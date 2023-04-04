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
	public partial class koydolUC : UserControl
	{
		public koydolUC()
		{
			InitializeComponent();
		}

		private void gösterChcBx_CheckedChanged(object sender, EventArgs e)
		{
			if (gösterChcBx.Checked)
			{
				passwordLogin.PasswordChar = '\0';
			}
			else
			{
				passwordLogin.PasswordChar = '*';
			}
		}
	}
}
