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
    public partial class snglofferblock : UserControl
    {
        public snglofferblock()
        {
            InitializeComponent();
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.FromArgb(128, 255, 255, 255);
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
