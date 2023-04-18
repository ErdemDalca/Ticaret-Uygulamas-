namespace Ticaret_Uygulaması
{
	partial class SignInUC
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
			this.gösterCb = new System.Windows.Forms.CheckBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.emailLbl = new System.Windows.Forms.Label();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.emailTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// gösterCb
			// 
			this.gösterCb.AutoSize = true;
			this.gösterCb.Location = new System.Drawing.Point(283, 147);
			this.gösterCb.Name = "gösterCb";
			this.gösterCb.Size = new System.Drawing.Size(18, 17);
			this.gösterCb.TabIndex = 9;
			this.gösterCb.UseVisualStyleBackColor = true;
			this.gösterCb.CheckedChanged += new System.EventHandler(this.gösterCb_CheckedChanged);
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(75, 171);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(202, 23);
			this.loginBtn.TabIndex = 8;
			this.loginBtn.Text = "Giriş Yap";
			this.loginBtn.UseVisualStyleBackColor = true;
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.Location = new System.Drawing.Point(37, 145);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(32, 16);
			this.passwordLbl.TabIndex = 6;
			this.passwordLbl.Text = "şifre";
			// 
			// emailLbl
			// 
			this.emailLbl.AutoSize = true;
			this.emailLbl.Location = new System.Drawing.Point(29, 117);
			this.emailLbl.Name = "emailLbl";
			this.emailLbl.Size = new System.Drawing.Size(40, 16);
			this.emailLbl.TabIndex = 7;
			this.emailLbl.Text = "email";
			// 
			// passwordTxt
			// 
			this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTxt.Location = new System.Drawing.Point(75, 142);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.PasswordChar = '*';
			this.passwordTxt.Size = new System.Drawing.Size(202, 22);
			this.passwordTxt.TabIndex = 4;
			// 
			// emailTxt
			// 
			this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTxt.Location = new System.Drawing.Point(75, 114);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(202, 22);
			this.emailTxt.TabIndex = 5;
			// 
			// SignInUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gösterCb);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.emailLbl);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.emailTxt);
			this.Name = "SignInUC";
			this.Size = new System.Drawing.Size(336, 336);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox gösterCb;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label passwordLbl;
		private System.Windows.Forms.Label emailLbl;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.TextBox emailTxt;
	}
}
