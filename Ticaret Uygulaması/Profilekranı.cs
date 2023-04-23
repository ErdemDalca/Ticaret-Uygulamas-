using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticaret_Uygulaması
{
    public partial class Profilekranı : Form
    {
        teklifekranı teklif;
        public Profilekranı()
        {
            InitializeComponent();
            var kullaciB = new kullaniciBilgileriUC();
            panel1.Controls.Add(kullaciB);

			flowLayoutPanel1.BackColor = Color.FromArgb(128, Color.Green);
			kullaciB.BackColor = Color.FromArgb(128, Color.Green);

            kullaciB.Parent.Size = panel1.Size;
		}

        private void Tamambtn_Click(object sender, EventArgs e)

        {

            var offerblock = new snglofferblock();
            offerblock.snglpicturebox.Image = teklif.teklifresimbox.Image;
            offerblock.sngltextbox1.Text= teklif.aciklamatextbox.Text;
            offerblock.sngltextbox2.Text= teklif.fiyattextbox.Text;
            offerblock.snglpicturebox.Enabled = false;
            if (teklif.teklifresimbox.Image ==null || teklif.fiyattextbox.Text=="")
                MessageBox.Show("resim ekleyin,fiyat  eklemeden teklif olusturamazsınız");
            else 
            {
                flowLayoutPanel1.Controls.Add(offerblock);
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
