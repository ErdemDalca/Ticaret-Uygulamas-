using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticaret_Uygulaması.Controls;
using Ticaret_Uygulaması.Sınıflar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Ticaret_Uygulaması
{
    public partial class snglofferblock : UserControl
    {

        public string offerID;
        public  FirebaseClient firebaseclient;
        public Kullanıcıbilgileri kullanıcıbilgileri;
        public FirebaseStorage firebaseStorage;
        public FlowLayoutPanel panel;
		public string Uıd;
		public Offer offer;
		
		public snglofferblock(UserCredential userCredential, Ayarlar ayarlar, Kullanıcıbilgileri kullanıcıbilgileri, FirebaseClient firebaseclient, FlowLayoutPanel panel, string Uıd = "", string offerID = "",Offer offer = null)
        {            
            InitializeComponent();
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.FromArgb(128, 255, 255, 255);
            this.kullanıcıbilgileri = kullanıcıbilgileri;
            this.firebaseclient = firebaseclient;
            this.offerID = offerID;
            this.panel = panel;
			this.Uıd = Uıd;
			this.offer = offer;

			try
			{
				firebaseStorage = new FirebaseStorage(ayarlar.FSDomain, new FirebaseStorageOptions
				{
					AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync(),
					ThrowOnCancel = true,
				});

				//MessageBox.Show("database istemcisi oluşturuldu" , "pass", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			catch (Exception exc)
			{
				MessageBox.Show("dikkat" + exc.Message, "problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            { snglpicturebox.ImageLocation=openfiledialog.FileName; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
		private async void  satinal_Click(object sender, EventArgs e)
        {
			panel.Enabled = false;

			var data = await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("Money").OnceAsJsonAsync();
            string dataAsClass = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(data);
			var data2 = await firebaseclient.Child("Users").Child(Uıd).Child("Money").OnceAsJsonAsync();
			string dataAsClass2 = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(data2);
			var envanterData = await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("_envanter").OnceAsJsonAsync();
			List<Offer> envanter = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Offer>>(envanterData);
			if (dataAsClass == null)
				dataAsClass = "0";
			if (dataAsClass2 == null)
				dataAsClass2 = "0";
			if ((Int32.Parse(dataAsClass) - Int32.Parse(sngltextbox2.Text)) <= 0)
            {
                MessageBox.Show("para yetersiz");
            }
            else
            {
                dataAsClass = (Int32.Parse(dataAsClass) - Int32.Parse(sngltextbox2.Text)).ToString();
                dataAsClass2 = (Int32.Parse(dataAsClass2) + Int32.Parse(sngltextbox2.Text)).ToString();
                await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("Money").PutAsync(dataAsClass);
				kullanıcıbilgileri._envanter = envanter;
				kullanıcıbilgileri._envanter.Add(offer);
                await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("_envanter").PutAsync(kullanıcıbilgileri._envanter);
                await firebaseclient.Child("Users").Child(Uıd).Child("Money").PutAsync(dataAsClass2);
            }
			panel.Enabled = true;
		}

		private async void SilBtn_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Teklifi silmek istiyormusunuz?", "Silme ekranı", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					SilBtn.Enabled = false;

					await firebaseStorage.Child(kullanıcıbilgileri.UID).Child("Offer Pictures").Child(offerID).DeleteAsync();
					kullanıcıbilgileri._offerList.RemoveAll(x => x.offerId == offerID);

					kullanıcıbilgileri.OfferList = kullanıcıbilgileri._offerList;
					await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("_offerList").PutAsync(kullanıcıbilgileri._offerList);
					await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("OfferList").PutAsync(kullanıcıbilgileri._offerList);

				}
				catch (Exception ex) { MessageBox.Show(ex.ToString()); }
				finally
				{
					panel.Controls.Remove(this);
					SilBtn.Enabled = true;
				}
			}
			else if (dialogResult == DialogResult.No)
			{
				//do something else
			}
			
			
		}

		private void SilBtn_Resize(object sender, EventArgs e)
		{
			
		}
	}
}
