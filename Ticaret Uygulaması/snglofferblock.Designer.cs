namespace Ticaret_Uygulaması
{
    partial class snglofferblock
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sngltextbox1 = new System.Windows.Forms.TextBox();
            this.sngltextbox2 = new System.Windows.Forms.TextBox();
            this.snglpicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snglpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // sngltextbox1
            // 
            this.sngltextbox1.Location = new System.Drawing.Point(229, 17);
            this.sngltextbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sngltextbox1.Name = "sngltextbox1";
            this.sngltextbox1.ReadOnly = true;
            this.sngltextbox1.Size = new System.Drawing.Size(351, 22);
            this.sngltextbox1.TabIndex = 0;
            this.sngltextbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sngltextbox2
            // 
            this.sngltextbox2.Location = new System.Drawing.Point(613, 17);
            this.sngltextbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sngltextbox2.Name = "sngltextbox2";
            this.sngltextbox2.ReadOnly = true;
            this.sngltextbox2.Size = new System.Drawing.Size(97, 22);
            this.sngltextbox2.TabIndex = 3;
            this.sngltextbox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // snglpicturebox
            // 
            this.snglpicturebox.BackColor = System.Drawing.Color.White;
            this.snglpicturebox.Location = new System.Drawing.Point(3, 2);
            this.snglpicturebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snglpicturebox.Name = "snglpicturebox";
            this.snglpicturebox.Size = new System.Drawing.Size(220, 121);
            this.snglpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snglpicturebox.TabIndex = 1;
            this.snglpicturebox.TabStop = false;
            this.snglpicturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // snglofferblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sngltextbox2);
            this.Controls.Add(this.snglpicturebox);
            this.Controls.Add(this.sngltextbox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "snglofferblock";
            this.Size = new System.Drawing.Size(781, 126);
            ((System.ComponentModel.ISupportInitialize)(this.snglpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox snglpicturebox;
        public System.Windows.Forms.TextBox sngltextbox1;
        public System.Windows.Forms.TextBox sngltextbox2;
    }
}
