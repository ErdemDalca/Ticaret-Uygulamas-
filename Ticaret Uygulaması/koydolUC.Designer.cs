namespace Ticaret_Uygulaması
{
	partial class koydolUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(koydolUC));
			this.gösterChcBx = new System.Windows.Forms.CheckBox();
			this.kaydolBtn = new System.Windows.Forms.Button();
			this.passwordText = new System.Windows.Forms.Label();
			this.emailText = new System.Windows.Forms.Label();
			this.passwordLogin = new System.Windows.Forms.TextBox();
			this.emailLogin = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// gösterChcBx
			// 
			this.gösterChcBx.AutoSize = true;
			this.gösterChcBx.BackColor = System.Drawing.Color.Maroon;
			this.gösterChcBx.Location = new System.Drawing.Point(279, 141);
			this.gösterChcBx.Name = "gösterChcBx";
			this.gösterChcBx.Size = new System.Drawing.Size(18, 17);
			this.gösterChcBx.TabIndex = 10;
			this.gösterChcBx.UseVisualStyleBackColor = false;
			this.gösterChcBx.CheckedChanged += new System.EventHandler(this.gösterChcBx_CheckedChanged);
			// 
			// kaydolBtn
			// 
			this.kaydolBtn.Location = new System.Drawing.Point(80, 167);
			this.kaydolBtn.Name = "kaydolBtn";
			this.kaydolBtn.Size = new System.Drawing.Size(193, 37);
			this.kaydolBtn.TabIndex = 9;
			this.kaydolBtn.Text = "Giriş Yap";
			this.kaydolBtn.UseVisualStyleBackColor = true;
			// 
			// passwordText
			// 
			this.passwordText.AutoSize = true;
			this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
			this.passwordText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.passwordText.Location = new System.Drawing.Point(40, 141);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(34, 16);
			this.passwordText.TabIndex = 7;
			this.passwordText.Text = "Şifre";
			// 
			// emailText
			// 
			this.emailText.AutoSize = true;
			this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
			this.emailText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.emailText.Location = new System.Drawing.Point(33, 111);
			this.emailText.Name = "emailText";
			this.emailText.Size = new System.Drawing.Size(41, 16);
			this.emailText.TabIndex = 8;
			this.emailText.Text = "Email";
			// 
			// passwordLogin
			// 
			this.passwordLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordLogin.Location = new System.Drawing.Point(80, 139);
			this.passwordLogin.Name = "passwordLogin";
			this.passwordLogin.PasswordChar = '*';
			this.passwordLogin.Size = new System.Drawing.Size(193, 22);
			this.passwordLogin.TabIndex = 6;
			// 
			// emailLogin
			// 
			this.emailLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailLogin.Location = new System.Drawing.Point(80, 108);
			this.emailLogin.Name = "emailLogin";
			this.emailLogin.Size = new System.Drawing.Size(193, 22);
			this.emailLogin.TabIndex = 5;
			// 
			// koydolUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gösterChcBx);
			this.Controls.Add(this.kaydolBtn);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.emailText);
			this.Controls.Add(this.passwordLogin);
			this.Controls.Add(this.emailLogin);
			this.DoubleBuffered = true;
			this.Name = "koydolUC";
			this.Size = new System.Drawing.Size(336, 336);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckBox gösterChcBx;
		public System.Windows.Forms.Button kaydolBtn;
		public System.Windows.Forms.Label passwordText;
		public System.Windows.Forms.Label emailText;
		public System.Windows.Forms.TextBox passwordLogin;
		public System.Windows.Forms.TextBox emailLogin;
	}
}
