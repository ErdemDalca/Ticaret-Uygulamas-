using Firebase.Auth;
using Firebase.Database;
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
    public partial class Profildüzenlemeekranı : Form
    {
        public Profildüzenlemeekranı(Kullanıcıbilgileri kullanıcıbilgileri, UserCredential userCredential, FirebaseClient firebaseClient)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Düzenlebutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(profildüzenlemeekranı.kullaniciadidegistxt.Text + profildüzenlemeekranı.aciklamadegistirtxt.Text);
            
        }
    }
}
