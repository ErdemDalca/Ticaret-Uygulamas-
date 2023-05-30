namespace Ticaret_Uygulaması
{
    partial class Profildüzenlemeekranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciadidegistxt = new System.Windows.Forms.TextBox();
            this.aciklamadegistirtxt = new System.Windows.Forms.TextBox();
            this.Emaildüzen = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Düzenlebutton = new System.Windows.Forms.Button();
            this.Profilfotoğrafı = new System.Windows.Forms.Label();
            this.Profilfotoğrafıpictureboxı = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Profilfotoğrafıpictureboxı)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim/soyisim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // kullaniciadidegistxt
            // 
            this.kullaniciadidegistxt.Location = new System.Drawing.Point(203, 180);
            this.kullaniciadidegistxt.Name = "kullaniciadidegistxt";
            this.kullaniciadidegistxt.Size = new System.Drawing.Size(184, 20);
            this.kullaniciadidegistxt.TabIndex = 3;
            // 
            // aciklamadegistirtxt
            // 
            this.aciklamadegistirtxt.Location = new System.Drawing.Point(203, 317);
            this.aciklamadegistirtxt.Name = "aciklamadegistirtxt";
            this.aciklamadegistirtxt.Size = new System.Drawing.Size(184, 20);
            this.aciklamadegistirtxt.TabIndex = 5;
            this.aciklamadegistirtxt.TextChanged += new System.EventHandler(this.aciklamadegistirtxt_TextChanged);
            // 
            // Emaildüzen
            // 
            this.Emaildüzen.AutoSize = true;
            this.Emaildüzen.Location = new System.Drawing.Point(200, 250);
            this.Emaildüzen.Name = "Emaildüzen";
            this.Emaildüzen.Size = new System.Drawing.Size(85, 13);
            this.Emaildüzen.TabIndex = 6;
            this.Emaildüzen.Text = "Şu anki emailiniz";
            this.Emaildüzen.Click += new System.EventHandler(this.label4_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Açıklama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Düzenlebutton
            // 
            this.Düzenlebutton.Location = new System.Drawing.Point(417, 342);
            this.Düzenlebutton.Name = "Düzenlebutton";
            this.Düzenlebutton.Size = new System.Drawing.Size(75, 23);
            this.Düzenlebutton.TabIndex = 8;
            this.Düzenlebutton.Text = "Düzenle";
            this.Düzenlebutton.UseVisualStyleBackColor = true;
            this.Düzenlebutton.Click += new System.EventHandler(this.Düzenlebutton_Click);
            // 
            // Profilfotoğrafı
            // 
            this.Profilfotoğrafı.AutoSize = true;
            this.Profilfotoğrafı.Location = new System.Drawing.Point(48, 37);
            this.Profilfotoğrafı.Name = "Profilfotoğrafı";
            this.Profilfotoğrafı.Size = new System.Drawing.Size(71, 13);
            this.Profilfotoğrafı.TabIndex = 10;
            this.Profilfotoğrafı.Text = "Profil fotoğrafı";
            // 
            // Profilfotoğrafıpictureboxı
            // 
            this.Profilfotoğrafıpictureboxı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Profilfotoğrafıpictureboxı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Profilfotoğrafıpictureboxı.Location = new System.Drawing.Point(203, 12);
            this.Profilfotoğrafıpictureboxı.Name = "Profilfotoğrafıpictureboxı";
            this.Profilfotoğrafıpictureboxı.Size = new System.Drawing.Size(153, 141);
            this.Profilfotoğrafıpictureboxı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profilfotoğrafıpictureboxı.TabIndex = 11;
            this.Profilfotoğrafıpictureboxı.TabStop = false;
            this.Profilfotoğrafıpictureboxı.Click += new System.EventHandler(this.Profilfotoğrafıpictureboxı_Click);
            // 
            // Profildüzenlemeekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.Profilfotoğrafıpictureboxı);
            this.Controls.Add(this.Profilfotoğrafı);
            this.Controls.Add(this.Düzenlebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emaildüzen);
            this.Controls.Add(this.aciklamadegistirtxt);
            this.Controls.Add(this.kullaniciadidegistxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profildüzenlemeekranı";
            this.Text = "Profildüzenlemeekranı";
            ((System.ComponentModel.ISupportInitialize)(this.Profilfotoğrafıpictureboxı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.Button Düzenlebutton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox kullaniciadidegistxt;
        public System.Windows.Forms.TextBox aciklamadegistirtxt;
        public System.Windows.Forms.Label Emaildüzen;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Profilfotoğrafı;
        public System.Windows.Forms.PictureBox Profilfotoğrafıpictureboxı;
    }
}