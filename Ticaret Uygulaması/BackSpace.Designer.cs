namespace Ticaret_Uygulaması
{
	partial class BackSpace
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

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackSpace));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb = new System.Windows.Forms.Button();
			this.kb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(343, 191);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 335);
			this.panel1.TabIndex = 0;
			// 
			// lb
			// 
			this.lb.Location = new System.Drawing.Point(343, 563);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(153, 52);
			this.lb.TabIndex = 1;
			this.lb.Text = "giriş yap";
			this.lb.UseVisualStyleBackColor = true;
			this.lb.Click += new System.EventHandler(this.lb_Click);
			// 
			// kb
			// 
			this.kb.Location = new System.Drawing.Point(541, 563);
			this.kb.Name = "kb";
			this.kb.Size = new System.Drawing.Size(138, 52);
			this.kb.TabIndex = 2;
			this.kb.Text = "kayıt ol";
			this.kb.UseVisualStyleBackColor = true;
			this.kb.Click += new System.EventHandler(this.kb_Click);
			// 
			// BackSpace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.kb);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BackSpace";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button lb;
		private System.Windows.Forms.Button kb;
	}
}

