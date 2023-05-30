﻿using Firebase.Auth;
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

namespace Ticaret_Uygulaması
{
    public partial class teklifekranı : Form
    {
        public teklifekranı(FirebaseClient firebaseClient, UserCredential userCredential)
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
            resimtxt.Visible = false;
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            { teklifresimbox.ImageLocation = openfiledialog.FileName; }
            else
            {
                if(teklifresimbox.Image == null)
				    resimtxt.Visible = true;
			}
        }

		private void tamambtn_Click(object sender, EventArgs e)
		{

		}
	}
}
