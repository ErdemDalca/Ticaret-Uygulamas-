﻿using System;
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
	public partial class SignInUC : UserControl
	{
		public SignInUC()
		{
			InitializeComponent();
		}

		private void gösterCb_CheckedChanged(object sender, EventArgs e)
		{
			if(gösterCb.Checked)
			{
				passwordTxt.PasswordChar = '\0';
			}
			else
			{
				passwordTxt.PasswordChar = '*';
			}
		}

        private void signinBtn_Click(object sender, EventArgs e)
        {
			
			

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
