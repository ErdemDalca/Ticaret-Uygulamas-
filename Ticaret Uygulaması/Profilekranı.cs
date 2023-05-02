using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
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

        public Profilekranı(Kullanıcıbilgileri kullanıcıbilgileri,UserCredential userCredential, FirebaseClient firebaseClient)
        {
            InitializeComponent();
            kullaciB = new kullaniciBilgileriUC(userCredential);
            panel1.Controls.Add(kullaciB);

			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Green);
			kullaciB.BackColor = Color.FromArgb(128, Color.Green);

            kullaciB.Parent.Size = panel1.Size;
            this.kullanıcıbilgileri = kullanıcıbilgileri;
            this.userCredential = userCredential;
            this.firebaseClient = firebaseClient;

            
		}

        private async void Tamambtn_Click(object sender, EventArgs e)

        {
            if (teklif.teklifresimbox.Image ==null || teklif.fiyattextbox.Text=="" || teklif.aciklamatextbox.Text == "")
                MessageBox.Show("Boş Alan Bıraktını!!!");
            else 
            {
                string açıklama = teklif.aciklamatextbox.Text.Trim();
                string fiyat = teklif.fiyattextbox.Text.Trim();
                kullanıcıbilgileri.OfferList.Add(new Offer(açıklama,fiyat));
				await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);
                flowLayoutPanel1.Controls.Clear();
				Profilekranı_Load(this, new EventArgs());
				teklif.Close();
            }
        }

        private void Profilekranı_Load(object sender, EventArgs e)
        {
            var list = kullanıcıbilgileri._offerList;

            for(int i = 0; i < kullanıcıbilgileri._offerList.Count;i++)
            {
                var offerblock = new snglofferblock();
                offerblock.sngltextbox1.Text = list[i].açıklama;
                offerblock.sngltextbox2.Text = list[i].fiyat;

                flowLayoutPanel1.Controls.Add(offerblock);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)

        {
           
            teklif = new teklifekranı();
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
    }
}
