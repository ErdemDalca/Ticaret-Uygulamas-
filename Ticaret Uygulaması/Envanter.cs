using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticaret_Uygulaması.Sınıflar;

namespace Ticaret_Uygulaması
{   
    public partial class Envanter : Form
    {
        Kullanıcıbilgileri kullanıcıbilgileri;
		UserCredential userCredential;
		Ayarlar ayarlar;
		FirebaseClient firebaseClient;
		public Envanter(UserCredential userCredential,Ayarlar ayarlar,Kullanıcıbilgileri kullanıcıbilgileri, FirebaseClient firebaseClient)
        {
            InitializeComponent();

            this.kullanıcıbilgileri = kullanıcıbilgileri;
			this.userCredential = userCredential;
			this.firebaseClient = firebaseClient;
			this.ayarlar = ayarlar;

			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Chocolate);
			Acilcikis.BackColor = Color.FromArgb(128, Color.Chocolate);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnvanterFlowpanel_Paint(object sender, PaintEventArgs e)
        {

        }

		private void Envanter_Load(object sender, EventArgs e)
		{
			var yüklemeEkranı = new YüklemeEkranı();
			yüklemeEkranı.Location = Location;
			yüklemeEkranı.pictureBox1.Visible = false;
			yüklemeEkranı.Show();
			var list = kullanıcıbilgileri._envanter;

			for (int i = 0; i < kullanıcıbilgileri._envanter.Count; i++)
			{
				var offerblock = new snglofferblock(userCredential, ayarlar, kullanıcıbilgileri, firebaseClient, flowLayoutPanel1);
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
			yüklemeEkranı.Close();
		}
	}
}
