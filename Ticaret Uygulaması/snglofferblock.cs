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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ticaret_Uygulaması
{
    public partial class snglofferblock : UserControl
    {
        public  FirebaseClient firebaseclient;
        public Kullanıcıbilgileri kullanıcıbilgileri;
        public snglofferblock(Kullanıcıbilgileri kullanıcıbilgileri,FirebaseClient firebaseclient)
        {            
            InitializeComponent();
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.FromArgb(128, 255, 255, 255);
            this.kullanıcıbilgileri = kullanıcıbilgileri;
            this.firebaseclient = firebaseclient;
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
            satinal.Enabled = false;

            var data = await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("Money").OnceAsJsonAsync();
            string dataAsClass = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(data);
            
            if (Int32.Parse(dataAsClass) <= 0)
            {
                MessageBox.Show("para yetersiz");
            }
            else
            {
                dataAsClass = (Int32.Parse(dataAsClass) - Int32.Parse(sngltextbox2.Text)).ToString();
                await firebaseclient.Child("Users").Child(kullanıcıbilgileri.UID).Child("Money").PutAsync(dataAsClass);
            }
            satinal.Enabled = true;


        }
    }
}
