﻿using Firebase.Auth;
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
using System.Xml.XPath;
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
        Bitmap profilfoto;
        Envanter Envanterekranı;
        public Profilekranı(Bitmap profilfoto,Kullanıcıbilgileri kullanıcıbilgileri,UserCredential userCredential, FirebaseClient firebaseClient, Ayarlar ayarlar)
        {
            InitializeComponent();

            this.ayarlar = ayarlar; 
            kullaciB = new kullaniciBilgileriUC(userCredential);
            panel1.Controls.Add(kullaciB);

			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Green);
			kullaciB.BackColor = Color.FromArgb(128, Color.Green);
            profildüzenlemebutonu.BackColor = Color.FromArgb(128, Color.Green);
			Envanterbutton.BackColor = Color.FromArgb(200, Color.Chocolate);

			kullaciB.Parent.Size = panel1.Size;
            this.kullanıcıbilgileri = kullanıcıbilgileri;
            this.userCredential = userCredential;
            this.firebaseClient = firebaseClient;
            this.profilfoto = profilfoto;
            try
            {
                task = new FirebaseStorage(ayarlar.FSDomain, new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync(),
                    ThrowOnCancel = true,
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            kullaciB.kullaniciAdiLbl.Text = kullanıcıbilgileri.Name;
            
            kullaciB.EmailLbl.Text = userCredential.User.Info.Email;
            kullaciB.aciklamaLbl.Text = kullanıcıbilgileri.Description;
            kullaciB.Refresh();

        }
        private void Envanterbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Envanterekranı = new Envanter(userCredential,ayarlar,kullanıcıbilgileri,firebaseClient);
            Envanterekranı.Show();
            Envanterekranı.Acilcikis.Click += Acilcikis_Click;

        }
        private async void Tamambtn_Click(object sender, EventArgs e)
        {
            teklif.tamambtn.Enabled = false;
            teklif.Visible = false;
			if (kullanıcıbilgileri._offerList.Count() < 5)
            {
                if (teklif.teklifresimbox.Image == null || teklif.fiyattextbox.Text == "" || teklif.aciklamatextbox.Text == "")
                    MessageBox.Show("Boş Alan Bıraktın!!!");
                else
                {
					string uniqueName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
					var stream = File.Open(teklif.teklifresimbox.ImageLocation, FileMode.Open);

                    await task.Child(kullanıcıbilgileri.UID).Child("Offer Pictures").Child((uniqueName).ToString()).PutAsync(stream);
                    string resim_url = await task.Child(kullanıcıbilgileri.UID)
                                                             .Child("Offer Pictures")
                                                             .Child(uniqueName).GetDownloadUrlAsync();


					string açıklama = teklif.aciklamatextbox.Text.Trim();
                    string fiyat = teklif.fiyattextbox.Text.Trim();
                    string ID = uniqueName;
                    kullanıcıbilgileri.OfferList.Add(new Offer(açıklama, fiyat, ID, resim_url));
                    await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);


                    flowLayoutPanel1.Controls.Clear();
                    Profilekranı_Load(this, new EventArgs());
                    teklif.Close();
                }
            }
            else
            {
                MessageBox.Show("En fazla 5 teklif verebilirsiniz!");
            }
        }

        private async void Profilekranı_Load(object sender, EventArgs e)
        {
            var yüklemeEkranı = new YüklemeEkranı();
            yüklemeEkranı.Location = Location;
            yüklemeEkranı.pictureBox1.Visible = false;
            yüklemeEkranı.Show();
            var list = kullanıcıbilgileri._offerList;
            this.paramik.Text = kullanıcıbilgileri.Money;
            ProfilfotoğrafıAslı.BackgroundImage = profilfoto;
            for (int i = 0; i < kullanıcıbilgileri._offerList.Count;i++)
            {
                var offerblock = new snglofferblock(userCredential, ayarlar,kullanıcıbilgileri, firebaseClient,flowLayoutPanel1,"", list[i].offerId);
                offerblock.SilBtn.Visible = true;
				offerblock.SilBtn.Click += SilBtn_Resize;
                offerblock.sngltextbox1.Text = list[i].açıklama;
                offerblock.sngltextbox2.Text = list[i].fiyat;

				try
				{
					string resim_url = list[i].resimUrl;

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
            yüklemeEkranı.Close();
        }

		private void SilBtn_Resize(object sender, EventArgs e)
		{
      
			    //Profilekranı_Load(this, new EventArgs()); 
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
			profildüzenlemebutonu.Enabled = false;
			profildüzenlemeekranı = new Profildüzenlemeekranı(kullanıcıbilgileri,userCredential,firebaseClient);
            profildüzenlemeekranı.Düzenlebutton.Click += Düzenlebutton_Click;
            profildüzenlemeekranı.Show();
			
		}
        
        private void Acilcikis_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private async void Düzenlebutton_Click(object sender, EventArgs e)
        {
            profildüzenlemeekranı.Enabled = false;
            kullanıcıbilgileri.Description = profildüzenlemeekranı.aciklamadegistirtxt.Text;
            kullanıcıbilgileri.Name =  profildüzenlemeekranı.NameChangeTxt.Text;
            kullanıcıbilgileri.Lastname = profildüzenlemeekranı.SurnameChangeTxt.Text;
            //MessageBox.Show(profildüzenlemeekranı.NameChangeTxt.Text+ profildüzenlemeekranı.aciklamadegistirtxt.Text);
            await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);
         
            ProfilfotoğrafıAslı.BackgroundImage = profildüzenlemeekranı.Profilfotoğrafıpictureboxı.Image;
            kullaciB.kullaniciAdiLbl.Text = profildüzenlemeekranı.NameChangeTxt.Text;
            kullaciB.aciklamaLbl.Text   = profildüzenlemeekranı.aciklamadegistirtxt.Text;
            kullaciB.Refresh();

            var stream = File.Open(profildüzenlemeekranı.Profilfotoğrafıpictureboxı.ImageLocation, FileMode.Open);

            await task.Child(kullanıcıbilgileri.UID).Child("Profil fotoğrafı").PutAsync(stream);
			profildüzenlemebutonu.Enabled = true;
			profildüzenlemeekranı.Close();
        }

        private void paraeklebtn_Click(object sender, EventArgs e)
        {
            var smenusu = new satinalmamenusu();
            smenusu.Location = Location;
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
