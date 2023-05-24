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
			this.cpb = new CircularProgressBar.CircularProgressBar();
			this.yüklemePanel = new System.Windows.Forms.Panel();
			this.yükleniyorLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.yüklemePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(343, 192);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 335);
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
			this.lb.Location = new System.Drawing.Point(343, 532);
			this.lb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(89, 73);
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
			this.kb.Location = new System.Drawing.Point(437, 532);
			this.kb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kb.Name = "kb";
			this.kb.Size = new System.Drawing.Size(139, 73);
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
			this.ÇIKIŞ.Location = new System.Drawing.Point(583, 532);
			this.ÇIKIŞ.Margin = new System.Windows.Forms.Padding(4);
			this.ÇIKIŞ.Name = "ÇIKIŞ";
			this.ÇIKIŞ.Size = new System.Drawing.Size(96, 70);
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
			// cpb
			// 
			this.cpb.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.cpb.AnimationSpeed = 500;
			this.cpb.BackColor = System.Drawing.Color.Transparent;
			this.cpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
			this.cpb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cpb.InnerColor = System.Drawing.Color.Transparent;
			this.cpb.InnerMargin = 2;
			this.cpb.InnerWidth = -1;
			this.cpb.Location = new System.Drawing.Point(99, 3);
			this.cpb.MarqueeAnimationSpeed = 2000;
			this.cpb.Name = "cpb";
			this.cpb.OuterColor = System.Drawing.Color.White;
			this.cpb.OuterMargin = -25;
			this.cpb.OuterWidth = 26;
			this.cpb.ProgressColor = System.Drawing.Color.Cyan;
			this.cpb.ProgressWidth = 25;
			this.cpb.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.cpb.Size = new System.Drawing.Size(50, 50);
			this.cpb.StartAngle = 270;
			this.cpb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.cpb.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cpb.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cpb.SubscriptText = ".23";
			this.cpb.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.cpb.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cpb.SuperscriptText = "°C";
			this.cpb.TabIndex = 4;
			this.cpb.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cpb.Value = 68;
			// 
			// yüklemePanel
			// 
			this.yüklemePanel.Controls.Add(this.yükleniyorLbl);
			this.yüklemePanel.Controls.Add(this.cpb);
			this.yüklemePanel.Location = new System.Drawing.Point(860, 698);
			this.yüklemePanel.Name = "yüklemePanel";
			this.yüklemePanel.Size = new System.Drawing.Size(152, 58);
			this.yüklemePanel.TabIndex = 5;
			this.yüklemePanel.Visible = false;
			// 
			// yükleniyorLbl
			// 
			this.yükleniyorLbl.AutoSize = true;
			this.yükleniyorLbl.BackColor = System.Drawing.Color.Transparent;
			this.yükleniyorLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.yükleniyorLbl.Location = new System.Drawing.Point(20, 19);
			this.yükleniyorLbl.Name = "yükleniyorLbl";
			this.yükleniyorLbl.Size = new System.Drawing.Size(73, 16);
			this.yükleniyorLbl.TabIndex = 5;
			this.yükleniyorLbl.Text = "Yükleniyor:";
			// 
			// BackSpace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.yüklemePanel);
			this.Controls.Add(this.ÇIKIŞ);
			this.Controls.Add(this.kb);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BackSpace";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.Load += new System.EventHandler(this.BackSpace_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.yüklemePanel.ResumeLayout(false);
			this.yüklemePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button lb;
		private System.Windows.Forms.Button kb;
        private System.Windows.Forms.Button ÇIKIŞ;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
		private CircularProgressBar.CircularProgressBar cpb;
		private System.Windows.Forms.Panel yüklemePanel;
		private System.Windows.Forms.Label yükleniyorLbl;
	}
}

