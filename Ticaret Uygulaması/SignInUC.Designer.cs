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
			this.signinBtn = new System.Windows.Forms.Button();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.emailLbl = new System.Windows.Forms.Label();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.emailTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// gösterCb
			// 
			this.gösterCb.AutoSize = true;
			this.gösterCb.BackColor = System.Drawing.Color.Transparent;
			this.gösterCb.Location = new System.Drawing.Point(285, 148);
			this.gösterCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gösterCb.Name = "gösterCb";
			this.gösterCb.Size = new System.Drawing.Size(18, 17);
			this.gösterCb.TabIndex = 9;
			this.gösterCb.UseVisualStyleBackColor = false;
			this.gösterCb.CheckedChanged += new System.EventHandler(this.gösterCb_CheckedChanged);
			// 
			// signinBtn
			// 
			this.signinBtn.Location = new System.Drawing.Point(77, 172);
			this.signinBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.signinBtn.Name = "signinBtn";
			this.signinBtn.Size = new System.Drawing.Size(203, 23);
			this.signinBtn.TabIndex = 8;
			this.signinBtn.Text = "Kayıt Ol";
			this.signinBtn.UseVisualStyleBackColor = true;
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
			this.passwordLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.passwordLbl.Location = new System.Drawing.Point(39, 146);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(32, 16);
			this.passwordLbl.TabIndex = 6;
			this.passwordLbl.Text = "şifre";
			// 
			// emailLbl
			// 
			this.emailLbl.AutoSize = true;
			this.emailLbl.BackColor = System.Drawing.Color.Transparent;
			this.emailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.emailLbl.Location = new System.Drawing.Point(31, 118);
			this.emailLbl.Name = "emailLbl";
			this.emailLbl.Size = new System.Drawing.Size(40, 16);
			this.emailLbl.TabIndex = 7;
			this.emailLbl.Text = "email";
			// 
			// passwordTxt
			// 
			this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTxt.Location = new System.Drawing.Point(77, 143);
			this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.PasswordChar = '*';
			this.passwordTxt.Size = new System.Drawing.Size(201, 22);
			this.passwordTxt.TabIndex = 4;
			// 
			// emailTxt
			// 
			this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTxt.Location = new System.Drawing.Point(77, 114);
			this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(201, 22);
			this.emailTxt.TabIndex = 5;
			// 
			// SignInUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gösterCb);
			this.Controls.Add(this.signinBtn);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.emailLbl);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.emailTxt);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SignInUC";
			this.Size = new System.Drawing.Size(336, 336);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckBox gösterCb;
		public System.Windows.Forms.Button signinBtn;
		public System.Windows.Forms.Label passwordLbl;
		public System.Windows.Forms.Label emailLbl;
		public System.Windows.Forms.TextBox passwordTxt;
		public System.Windows.Forms.TextBox emailTxt;
	}
}
