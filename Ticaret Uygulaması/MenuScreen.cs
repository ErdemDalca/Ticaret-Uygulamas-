using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticaret_Uygulaması.Sınıflar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ticaret_Uygulaması
{    
    public partial class MenuScreen : Form
    {
        private UserCredential userCredential;
        private FirebaseClient firebaseclient;
         public MenuScreen(UserCredential userCredential)
        {   
            
            InitializeComponent();
            this.userCredential = userCredential;
			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Gray);
            button1.BackColor = Color.FromArgb(10, Color.Gray);
            try
            {
                this.firebaseclient = new FirebaseClient("https://ticaretuygulamasi-kutsanmis-default-rtdb.firebaseio.com/ ",
                        new FirebaseOptions
                        {
                            AuthTokenAsyncFactory = () => userCredential.User.GetIdTokenAsync()
                        });
                MessageBox.Show("database istemcisi oluşturuldu" , "pass", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch(Exception exc)
            {
                MessageBox.Show("dikkat"+exc.Message,"problem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



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

		private void profileBtn_Click(object sender, EventArgs e)
		{
            var Profil = new Profilekranı();
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

        public async void kayıt_Click(object sender, EventArgs e)
        {
            string uid = userCredential.User.Uid;
            string name = userCredential.User.Info.FirstName;
            string lastname = userCredential.User.Info.LastName;
            string description = "açıklama";

            await firebaseclient.Child("Users")
                                .Child(userCredential.User.Uid)
                                .PutAsync(new Kullanıcıbilgileri(uid,name,description,lastname));
        }
    }
}
