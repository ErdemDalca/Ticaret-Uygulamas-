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
            this.ÇIKIŞ = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(257, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 272);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb
            // 
            this.lb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb.BackgroundImage")));
            this.lb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb.Location = new System.Drawing.Point(257, 432);
            this.lb.Margin = new System.Windows.Forms.Padding(2);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(67, 59);
            this.lb.TabIndex = 1;
            this.lb.Text = "giriş yap";
            this.lb.UseVisualStyleBackColor = true;
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // kb
            // 
            this.kb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kb.BackgroundImage")));
            this.kb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kb.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kb.Location = new System.Drawing.Point(328, 432);
            this.kb.Margin = new System.Windows.Forms.Padding(2);
            this.kb.Name = "kb";
            this.kb.Size = new System.Drawing.Size(104, 59);
            this.kb.TabIndex = 2;
            this.kb.Text = "kayıt ol";
            this.kb.UseVisualStyleBackColor = true;
            this.kb.Click += new System.EventHandler(this.kb_Click);
            // 
            // ÇIKIŞ
            // 
            this.ÇIKIŞ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ÇIKIŞ.BackgroundImage = global::Ticaret_Uygulaması.Properties.Resources.mavi;
            this.ÇIKIŞ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ÇIKIŞ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÇIKIŞ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇIKIŞ.Location = new System.Drawing.Point(437, 432);
            this.ÇIKIŞ.Name = "ÇIKIŞ";
            this.ÇIKIŞ.Size = new System.Drawing.Size(72, 57);
            this.ÇIKIŞ.TabIndex = 3;
            this.ÇIKIŞ.Text = "ÇIKIŞ";
            this.ÇIKIŞ.UseVisualStyleBackColor = false;
            this.ÇIKIŞ.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BackSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 624);
            this.Controls.Add(this.ÇIKIŞ);
            this.Controls.Add(this.kb);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button lb;
		private System.Windows.Forms.Button kb;
        private System.Windows.Forms.Button ÇIKIŞ;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

