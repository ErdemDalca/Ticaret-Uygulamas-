namespace Ticaret_Uygulaması
{
	partial class LoginUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUC));
			this.emailLogin = new System.Windows.Forms.TextBox();
			this.passwordLogin = new System.Windows.Forms.TextBox();
			this.emailText = new System.Windows.Forms.Label();
			this.passwordText = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.gösterChcBx = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// emailLogin
			// 
			this.emailLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailLogin.Location = new System.Drawing.Point(80, 107);
			this.emailLogin.Name = "emailLogin";
			this.emailLogin.Size = new System.Drawing.Size(193, 22);
			this.emailLogin.TabIndex = 0;
			// 
			// passwordLogin
			// 
			this.passwordLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordLogin.Location = new System.Drawing.Point(80, 138);
			this.passwordLogin.Name = "passwordLogin";
			this.passwordLogin.PasswordChar = '*';
			this.passwordLogin.Size = new System.Drawing.Size(193, 22);
			this.passwordLogin.TabIndex = 1;
			// 
			// emailText
			// 
			this.emailText.AutoSize = true;
			this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
			this.emailText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.emailText.Location = new System.Drawing.Point(33, 110);
			this.emailText.Name = "emailText";
			this.emailText.Size = new System.Drawing.Size(41, 16);
			this.emailText.TabIndex = 2;
			this.emailText.Text = "Email";
			// 
			// passwordText
			// 
			this.passwordText.AutoSize = true;
			this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
			this.passwordText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.passwordText.Location = new System.Drawing.Point(40, 140);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(34, 16);
			this.passwordText.TabIndex = 2;
			this.passwordText.Text = "Şifre";
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(80, 166);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(193, 37);
			this.loginBtn.TabIndex = 3;
			this.loginBtn.Text = "Giriş Yap";
			this.loginBtn.UseVisualStyleBackColor = true;
			// 
			// gösterChcBx
			// 
			this.gösterChcBx.AutoSize = true;
			this.gösterChcBx.BackColor = System.Drawing.Color.Maroon;
			this.gösterChcBx.Location = new System.Drawing.Point(279, 140);
			this.gösterChcBx.Name = "gösterChcBx";
			this.gösterChcBx.Size = new System.Drawing.Size(18, 17);
			this.gösterChcBx.TabIndex = 4;
			this.gösterChcBx.UseVisualStyleBackColor = false;
			this.gösterChcBx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// LoginUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gösterChcBx);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.emailText);
			this.Controls.Add(this.passwordLogin);
			this.Controls.Add(this.emailLogin);
			this.DoubleBuffered = true;
			this.Name = "LoginUC";
			this.Size = new System.Drawing.Size(336, 336);
			this.Load += new System.EventHandler(this.LoginUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox emailLogin;
		public System.Windows.Forms.TextBox passwordLogin;
		public System.Windows.Forms.Label emailText;
		public System.Windows.Forms.Label passwordText;
		public System.Windows.Forms.Button loginBtn;
		public System.Windows.Forms.CheckBox gösterChcBx;
	}
}
