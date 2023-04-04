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
	public partial class BackSpace : Form
	{
		private LoginUC login;
		private koydolUC signin;

		public BackSpace()
		{
			InitializeComponent();

			login = new LoginUC();
			signin = new koydolUC();
		}

		private void userLoginBtn_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(login);
		}

		private void newUserBtn_Click(object sender, EventArgs e)
		{
			LoginUC nesne = new LoginUC();

			panel1.Controls.Clear();
			panel1.Controls.Add(signin);
		}
	}
}
