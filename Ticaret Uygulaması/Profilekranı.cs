using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Profilekranı(Kullanıcıbilgileri kullanıcıbilgileri,UserCredential userCredential, FirebaseClient firebaseClient)
        {
            InitializeComponent();
            var kullaciB = new kullaniciBilgileriUC();
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

            var offerblock = new snglofferblock();
            offerblock.snglpicturebox.Image = teklif.teklifresimbox.Image;
            offerblock.sngltextbox1.Text= teklif.aciklamatextbox.Text;
            offerblock.sngltextbox2.Text= teklif.fiyattextbox.Text;
            offerblock.snglpicturebox.Enabled = false;
            if (teklif.teklifresimbox.Image ==null || teklif.fiyattextbox.Text=="" || teklif.aciklamatextbox.Text == "")
                MessageBox.Show("Boş Alan Bıraktını!!!");
            else 
            {
                kullanıcıbilgileri.OfferList.Add(new Offer());
                await firebaseClient.Child("Users").Child(kullanıcıbilgileri.UID).PutAsync(kullanıcıbilgileri);
				teklif.Close();
                
            }
        }

        private void Profilekranı_Load(object sender, EventArgs e)
        {

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
        

    }
}
