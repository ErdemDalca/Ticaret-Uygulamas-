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
		public LogInUC logIn;
		public SignInUC signIn;

		public BackSpace()
		{
			InitializeComponent();
			logIn = new LogInUC();
			signIn = new SignInUC();

			lb_Click(this, new EventArgs());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lb_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(logIn);
		}

		private void kb_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(signIn);
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
