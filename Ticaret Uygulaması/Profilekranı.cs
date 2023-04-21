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
    public partial class Profilekranı : Form
    {
        teklifekranı teklif;
        public Profilekranı()
        {
            InitializeComponent();
            

        }

        private void Tamambtn_Click(object sender, EventArgs e)

        {

            var offerblock = new snglofferblock();
            offerblock.snglpicturebox.Image = teklif.teklifresimbox.Image; 
            offerblock.sngltextbox1.Text= teklif.aciklamatextbox.Text;
            offerblock.sngltextbox2.Text= teklif.fiyattextbox.Text;
            flowLayoutPanel1.Controls.Add(offerblock);
            
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
