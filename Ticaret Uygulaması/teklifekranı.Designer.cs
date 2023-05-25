namespace Ticaret_Uygulaması
{
    partial class teklifekranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.teklifresimbox = new System.Windows.Forms.PictureBox();
			this.aciklamatxt = new System.Windows.Forms.Label();
			this.resimtxt = new System.Windows.Forms.Label();
			this.aciklamatextbox = new System.Windows.Forms.TextBox();
			this.fiyattxt = new System.Windows.Forms.Label();
			this.fiyattextbox = new System.Windows.Forms.TextBox();
			this.tamambtn = new System.Windows.Forms.Button();
			this.offerID = new System.Windows.Forms.Label();
			this.offerIDtext = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.teklifresimbox)).BeginInit();
			this.SuspendLayout();
			// 
			// teklifresimbox
			// 
			this.teklifresimbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.teklifresimbox.Location = new System.Drawing.Point(105, 15);
			this.teklifresimbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.teklifresimbox.Name = "teklifresimbox";
			this.teklifresimbox.Size = new System.Drawing.Size(277, 240);
			this.teklifresimbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.teklifresimbox.TabIndex = 0;
			this.teklifresimbox.TabStop = false;
			this.teklifresimbox.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// aciklamatxt
			// 
			this.aciklamatxt.AutoSize = true;
			this.aciklamatxt.Location = new System.Drawing.Point(5, 273);
			this.aciklamatxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.aciklamatxt.Name = "aciklamatxt";
			this.aciklamatxt.Size = new System.Drawing.Size(91, 16);
			this.aciklamatxt.TabIndex = 1;
			this.aciklamatxt.Text = "açıklama ekle";
			this.aciklamatxt.Click += new System.EventHandler(this.label1_Click);
			// 
			// resimtxt
			// 
			this.resimtxt.AutoSize = true;
			this.resimtxt.Location = new System.Drawing.Point(17, 15);
			this.resimtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resimtxt.Name = "resimtxt";
			this.resimtxt.Size = new System.Drawing.Size(69, 16);
			this.resimtxt.TabIndex = 2;
			this.resimtxt.Text = "resim ekle";
			// 
			// aciklamatextbox
			// 
			this.aciklamatextbox.Location = new System.Drawing.Point(105, 267);
			this.aciklamatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.aciklamatextbox.Name = "aciklamatextbox";
			this.aciklamatextbox.Size = new System.Drawing.Size(132, 22);
			this.aciklamatextbox.TabIndex = 3;
			// 
			// fiyattxt
			// 
			this.fiyattxt.AutoSize = true;
			this.fiyattxt.Location = new System.Drawing.Point(17, 316);
			this.fiyattxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fiyattxt.Name = "fiyattxt";
			this.fiyattxt.Size = new System.Drawing.Size(71, 16);
			this.fiyattxt.TabIndex = 4;
			this.fiyattxt.Text = "fiyat belirle";
			// 
			// fiyattextbox
			// 
			this.fiyattextbox.Location = new System.Drawing.Point(105, 316);
			this.fiyattextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.fiyattextbox.Name = "fiyattextbox";
			this.fiyattextbox.Size = new System.Drawing.Size(132, 22);
			this.fiyattextbox.TabIndex = 5;
			// 
			// tamambtn
			// 
			this.tamambtn.Location = new System.Drawing.Point(283, 310);
			this.tamambtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tamambtn.Name = "tamambtn";
			this.tamambtn.Size = new System.Drawing.Size(100, 28);
			this.tamambtn.TabIndex = 6;
			this.tamambtn.Text = "ekle(kaydet)";
			this.tamambtn.UseVisualStyleBackColor = true;
			this.tamambtn.Click += new System.EventHandler(this.tamambtn_Click);
			// 
			// offerID
			// 
			this.offerID.AutoSize = true;
			this.offerID.Location = new System.Drawing.Point(43, 358);
			this.offerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.offerID.Name = "offerID";
			this.offerID.Size = new System.Drawing.Size(20, 16);
			this.offerID.TabIndex = 8;
			this.offerID.Text = "ID";
			// 
			// offerIDtext
			// 
			this.offerIDtext.Location = new System.Drawing.Point(105, 358);
			this.offerIDtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.offerIDtext.Name = "offerIDtext";
			this.offerIDtext.Size = new System.Drawing.Size(132, 22);
			this.offerIDtext.TabIndex = 9;
			// 
			// teklifekranı
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 425);
			this.Controls.Add(this.offerIDtext);
			this.Controls.Add(this.offerID);
			this.Controls.Add(this.tamambtn);
			this.Controls.Add(this.fiyattextbox);
			this.Controls.Add(this.fiyattxt);
			this.Controls.Add(this.aciklamatextbox);
			this.Controls.Add(this.resimtxt);
			this.Controls.Add(this.aciklamatxt);
			this.Controls.Add(this.teklifresimbox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "teklifekranı";
			this.Text = "teklifekranı";
			((System.ComponentModel.ISupportInitialize)(this.teklifresimbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox teklifresimbox;
        public System.Windows.Forms.Label aciklamatxt;
        public System.Windows.Forms.Label resimtxt;
        public System.Windows.Forms.TextBox aciklamatextbox;
        public System.Windows.Forms.Label fiyattxt;
        public System.Windows.Forms.TextBox fiyattextbox;
        public System.Windows.Forms.Button tamambtn;
        private System.Windows.Forms.Label offerID;
        public System.Windows.Forms.TextBox offerIDtext;
    }
}