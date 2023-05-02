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
    public partial class teklifekranı : Form
    {
        public teklifekranı()
        {
            InitializeComponent();
            this.fiyattextbox.KeyPress += sadeceSayiGir;
        }
        private void sadeceSayiGir(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            { teklifresimbox.ImageLocation = openfiledialog.FileName; }
        }

		private void tamambtn_Click(object sender, EventArgs e)
		{

		}
	}
}
