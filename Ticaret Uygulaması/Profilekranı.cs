using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Ticaret_Uygulaması.Sınıflar;

namespace Ticaret_Uygulaması
{
    public partial class Profilekranı : Form
    {
        UserCredential userCredential;
        FirebaseClient firebaseClient;
        Kullanıcıbilgileri kullanıcıbilgileri;
        teklifekranı teklif;
        Profildüzenlemeekranı profildüzenlemeekranı;
        kullaniciBilgileriUC kullaciB;
        Ayarlar ayarlar;
        FirebaseStorage task;

        public Profilekranı(Kullanıcıbilgileri kullanıcıbilgileri,UserCredential userCredential, FirebaseClient firebaseClient, Ayarlar ayarlar)
        {
            InitializeComponent();

            this.ayarlar = ayarlar; 
            kullaciB = new kullaniciBilgileriUC(userCredential);
            panel1.Controls.Add(kullaciB);

			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Green);
			kullaciB.BackColor = Color.FromArgb(128, Color.Green);

            kullaciB.Parent.Size = panel1.Size;
            this.kullanıcıbilgileri = kullanıcıbilgileri;
            this.userCredential = userCredential;
            this.firebaseClient = firebaseClient;

			task = new FirebaseStorage(ayarlar.FSDomain, new FirebaseStorageOptions
			{
				AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync(),
				ThrowOnCancel = true,
			});

            kullaciB.kullaniciAdiLbl.Text = kullanıcıbilgileri.Name;
            
            kullaciB.EmailLbl.Text = userCredential.User.Info.Email;
            kullaciB.aciklamaLbl.Text = kullanıcıbilgileri.Description;
            kullaciB.Refresh();

        }

        private async void Tamambtn_Click(object sender, EventArgs e)
        {
            if (teklif.teklifresimbox.Image ==null || teklif.fiyattextbox.Text=="" || teklif.aciklamatextbox.Text == "")
                MessageBox.Show("Boş Alan Bıraktın!!!");
            else 
            {
				var stream = File.Open(teklif.teklifresimbox.ImageLocation, FileMode.Open);

				await task.Child(kullanıcıbilgileri.UID).Child("Offer Pictures").Child((kullanıcıbilgileri.OfferList.Count).ToString()).PutAsync(stream);
				string resim_url = await task.Child(kullanıcıbilgileri.UID)
														 .Child("Offer Pictures")
														 .Child((kullanıcıbilgileri.OfferList.Count).ToString()).GetDownloadUrlAsync();


				string açıklama = teklif.aciklamatextbox.Text.Trim();
                string fiyat = teklif.fiyattextbox.Text.Trim();
                string ID = teklif.offerIDtext.Text.Trim();
                kullanıcıbilgileri.OfferList.Add(new Offer(açıklama, fiyat, ID,resim_url));
				await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);
				

				flowLayoutPanel1.Controls.Clear();
				Profilekranı_Load(this, new EventArgs());
				teklif.Close();
            }
        }

        private async void Profilekranı_Load(object sender, EventArgs e)
        {
            var list = kullanıcıbilgileri._offerList;

            for(int i = 0; i < kullanıcıbilgileri._offerList.Count;i++)
            {
                var offerblock = new snglofferblock(kullanıcıbilgileri,firebaseClient);
                offerblock.sngltextbox1.Text = list[i].açıklama;
                offerblock.sngltextbox2.Text = list[i].fiyat;

				try
				{
					string resim_url = await task.Child(kullanıcıbilgileri.UID)
                                                 .Child("Offer Pictures")
                                                 .Child((i).ToString()).GetDownloadUrlAsync();

					WebClient istemci = new WebClient();
					Stream raw_dosya = istemci.OpenRead(resim_url);
					Bitmap resim = new Bitmap(raw_dosya);

					offerblock.snglpicturebox.Image = resim;

					raw_dosya.Flush();
					raw_dosya.Close();
					istemci.Dispose();

				}
				catch (Exception ex) { }

				flowLayoutPanel1.Controls.Add(offerblock);
            }
            paramik.Enabled = false;
            this.paramik.Text = kullanıcıbilgileri.Money;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)

        {
           
            teklif = new teklifekranı(firebaseClient,userCredential);
            teklif.Show();
            teklif.tamambtn.Click += Tamambtn_Click;


        }

        private void profildüzenlemebutonu_Click(object sender, EventArgs e)
        {
            profildüzenlemeekranı = new Profildüzenlemeekranı(kullanıcıbilgileri,userCredential,firebaseClient);
            profildüzenlemeekranı.Düzenlebutton.Click += Düzenlebutton_Click;
            profildüzenlemeekranı.Show();
        }

        private async void Düzenlebutton_Click(object sender, EventArgs e)
        {
            kullanıcıbilgileri.Description = profildüzenlemeekranı.aciklamadegistirtxt.Text;
            kullanıcıbilgileri.Name =  profildüzenlemeekranı.kullaniciadidegistxt.Text;
            MessageBox.Show(profildüzenlemeekranı.kullaniciadidegistxt.Text+ profildüzenlemeekranı.aciklamadegistirtxt.Text);
            await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);
            
            kullaciB.kullaniciAdiLbl.Text = profildüzenlemeekranı.kullaniciadidegistxt.Text;
            kullaciB.aciklamaLbl.Text   = profildüzenlemeekranı.aciklamadegistirtxt.Text;
            kullaciB.Refresh();

            profildüzenlemeekranı.Close();

        }

        private void paraeklebtn_Click(object sender, EventArgs e)
        {
            var smenusu = new satinalmamenusu();
            smenusu.satinal.Click += Satinal_Click;
            smenusu.satinal2.Click += Satinal2_Click;
            smenusu.satinal3.Click += Satinal3_Click;
            smenusu.satinal4.Click += Satinal4_Click;
            smenusu.satinal5.Click += Satinal5_Click;
            smenusu.satinal6.Click += Satinal6_Click;
            smenusu.Show();

        }

        private void Satinal6_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 1500;
            paramik.Text = txt.ToString();
            MessageBox.Show("1500 * satın aldınız !");
            store();
        }

        private void Satinal5_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 1000;
            paramik.Text = txt.ToString();
            MessageBox.Show("1000 * satın aldınız !");
            store();
        }

        private void Satinal4_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 800;
            paramik.Text = txt.ToString();
            MessageBox.Show("800 * satın aldınız !");
            store();
        }

        private void Satinal3_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 500;
            paramik.Text = txt.ToString();
            MessageBox.Show("500 * satın aldınız !");
            store();
        }

        private void Satinal2_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 150;
            paramik.Text = txt.ToString();
            MessageBox.Show("150 * satın aldınız !");
            store();
        }

        private void Satinal_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt32(paramik.Text);
            txt += 50;
            paramik.Text = txt.ToString();
            MessageBox.Show("50 * satın aldınız !");
            store();
        }
        private async void store()
        {
            await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).Child("Money").PutAsync(paramik.Text);
        }
    }
}
