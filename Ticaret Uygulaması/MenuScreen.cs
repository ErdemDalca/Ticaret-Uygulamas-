using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ticaret_Uygulaması.Sınıflar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ticaret_Uygulaması
{    
    public partial class MenuScreen : Form
    {
        private UserCredential userCredential;
        private FirebaseClient firebaseclient;
        public Kullanıcıbilgileri kullanıcıbilgileri;
        public Ayarlar ayarlar;

         public MenuScreen(UserCredential userCredential, Ayarlar ayarlar)
        {   
            
            InitializeComponent();
            this.ayarlar = ayarlar;
            this.userCredential = userCredential;
			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Gray);
            button1.BackColor = Color.FromArgb(10, Color.Gray);
            yenilemeBtn.BackColor = Color.FromArgb(10, Color.Gray);
            try
            {
                this.firebaseclient = new FirebaseClient(ayarlar.FDDomain + " ",
                        new FirebaseOptions
                        {
                            AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync()
                        });

                //MessageBox.Show("database istemcisi oluşturuldu" , "pass", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch(Exception exc)
            {
                MessageBox.Show("dikkat"+exc.Message,"problem",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

			string uid = userCredential.User.Uid;
			string name = "none";
			string lastname = "none";
			string description = "açıklama";

            this.kullanıcıbilgileri = new Kullanıcıbilgileri(uid, name, description, lastname);

		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new snglofferblock());
        }

		private void filtre_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.White, e.Bounds);
			e.Graphics.DrawString(filtre.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
		}

		private async void profileBtn_Click(object sender, EventArgs e)
		{
            
            var data = await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).OnceAsJsonAsync();
		
			Kullanıcıbilgileri dataAsClass = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanıcıbilgileri>(data);
            if (dataAsClass == null)
                kayıt(kullanıcıbilgileri);
            else
            {
                kullanıcıbilgileri = dataAsClass;
				kayıt(kullanıcıbilgileri);
			}
			var Profil = new Profilekranı(kullanıcıbilgileri, userCredential, firebaseclient);
			Profil.Show();
            this.Hide();
            Profil.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


		private async void MenuScreen_Load(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			var dataUsers = await firebaseclient.Child("Users").OrderByKey().OnceAsync<Kullanıcıbilgileri>();

			foreach (var kullanıcı in dataUsers)
			{
                foreach (var offer in kullanıcı.Object._offerList)
                {
                    var sngloffer = new snglofferblock();
                    sngloffer.sngltextbox1.Text = offer.açıklama;
                    sngloffer.sngltextbox2.Text = offer.fiyat;
                    flowLayoutPanel1.Controls.Add(sngloffer);
                }
                
			}
			//Kullanıcıbilgileri dataAsClass = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanıcıbilgileri>(data);
		}

        private async void kayıt(Kullanıcıbilgileri kullanıcıbilgileri)
        {
			await firebaseclient.Child("Users")
								.Child(userCredential.User.Uid)
								.PutAsync(kullanıcıbilgileri);
		}

		private void yenilemeBtn_Click(object sender, EventArgs e)
		{
			MenuScreen_Load(this, new EventArgs());
		}
	}
}
