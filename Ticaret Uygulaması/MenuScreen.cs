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
        public IReadOnlyCollection<FirebaseObject<Kullanıcıbilgileri>> dataUsers;
        public List<Offer> dataofferlist;


		 public MenuScreen(UserCredential userCredential, Ayarlar ayarlar)
        {   
            
            InitializeComponent();
            dataofferlist = new List<Offer>();
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


        private void ekle_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new snglofferblock());
        }

		private void filtre_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.White, e.Bounds);
			e.Graphics.DrawString(Sıralamafiltresi.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
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
			var Profil = new Profilekranı(kullanıcıbilgileri, userCredential, firebaseclient,ayarlar);
			Profil.Show();
            this.Hide();
            Profil.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

		private async void MenuScreen_Load(object sender, EventArgs e)
		{
            dataofferlist.Clear();
			dataUsers = await firebaseclient.Child("Users").OrderByKey().OnceAsync<Kullanıcıbilgileri>();
            foreach(var user in dataUsers)
            {
                dataofferlist.AddRange(user.Object._offerList);

               
            }
            OfferListele();
			//Kullanıcıbilgileri dataAsClass = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanıcıbilgileri>(data);
		}

        private void OfferListele()
        {   
			flowLayoutPanel1.Controls.Clear();
			foreach (var offer in dataofferlist)
				{
					var sngloffer = new snglofferblock();
					sngloffer.sngltextbox1.Text = offer.açıklama;
					sngloffer.sngltextbox2.Text = offer.fiyat;
					flowLayoutPanel1.Controls.Add(sngloffer);
				}
					
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

        private void filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           if( Sıralamafiltresi.SelectedItem == "azalan")
            {
                dataofferlist = dataofferlist.OrderByDescending(u => decimal.Parse(u.fiyat)).ToList();
                


                //dataofferlist.Sort((x, y) => y.fiyat.CompareTo(x.fiyat));
                OfferListele();
                MessageBox.Show("azalacak şekilde sıralandı");
            }
            else
            {
                dataofferlist = dataofferlist.OrderBy(u => decimal.Parse(u.fiyat)).ToList();



                //dataofferlist.Sort((y, x) => y.fiyat.CompareTo(x.fiyat))
                OfferListele();
                MessageBox.Show("artacak şekilde sıralandı");
            }
        }
    }
}