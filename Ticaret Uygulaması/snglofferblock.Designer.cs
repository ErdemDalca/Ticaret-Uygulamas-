using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snglofferblock));
            this.sngltextbox1 = new System.Windows.Forms.TextBox();
            this.sngltextbox2 = new System.Windows.Forms.TextBox();
            this.snglpicturebox = new System.Windows.Forms.PictureBox();
            this.satinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snglpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // sngltextbox1
            // 
            resources.ApplyResources(this.sngltextbox1, "sngltextbox1");
            this.sngltextbox1.Name = "sngltextbox1";
            this.sngltextbox1.ReadOnly = true;
            this.sngltextbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sngltextbox2
            // 
            resources.ApplyResources(this.sngltextbox2, "sngltextbox2");
            this.sngltextbox2.Name = "sngltextbox2";
            this.sngltextbox2.ReadOnly = true;
            this.sngltextbox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // snglpicturebox
            // 
            this.snglpicturebox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.snglpicturebox, "snglpicturebox");
            this.snglpicturebox.Name = "snglpicturebox";
            this.snglpicturebox.TabStop = false;
            this.snglpicturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // satinal
            // 
            resources.ApplyResources(this.satinal, "satinal");
            this.satinal.Name = "satinal";
            this.satinal.UseVisualStyleBackColor = true;
            this.satinal.Click += new System.EventHandler(this.satinal_Click);
            // 
            // snglofferblock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.satinal);
            this.Controls.Add(this.sngltextbox2);
            this.Controls.Add(this.snglpicturebox);
            this.Controls.Add(this.sngltextbox1);
            this.Name = "snglofferblock";
            ((System.ComponentModel.ISupportInitialize)(this.snglpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox snglpicturebox;
        public System.Windows.Forms.TextBox sngltextbox1;
        public System.Windows.Forms.TextBox sngltextbox2;
        public Button satinal;
    }
}
