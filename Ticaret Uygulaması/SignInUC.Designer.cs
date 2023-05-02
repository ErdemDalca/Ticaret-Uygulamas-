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
            this.soyisimtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isimtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gösterCb
            // 
            this.gösterCb.AutoSize = true;
            this.gösterCb.BackColor = System.Drawing.Color.Transparent;
            this.gösterCb.Location = new System.Drawing.Point(214, 120);
            this.gösterCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gösterCb.Name = "gösterCb";
            this.gösterCb.Size = new System.Drawing.Size(15, 14);
            this.gösterCb.TabIndex = 9;
            this.gösterCb.UseVisualStyleBackColor = false;
            this.gösterCb.CheckedChanged += new System.EventHandler(this.gösterCb_CheckedChanged);
            // 
            // signinBtn
            // 
            this.signinBtn.Location = new System.Drawing.Point(58, 140);
            this.signinBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(152, 19);
            this.signinBtn.TabIndex = 8;
            this.signinBtn.Text = "Kayıt Ol";
            this.signinBtn.UseVisualStyleBackColor = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLbl.Location = new System.Drawing.Point(29, 119);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(26, 13);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "şifre";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLbl.Location = new System.Drawing.Point(23, 96);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(31, 13);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "email";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.Location = new System.Drawing.Point(58, 116);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(152, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Location = new System.Drawing.Point(58, 93);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(152, 20);
            this.emailTxt.TabIndex = 5;
            // 
            // soyisimtextbox
            // 
            this.soyisimtextbox.Location = new System.Drawing.Point(58, 71);
            this.soyisimtextbox.Name = "soyisimtextbox";
            this.soyisimtextbox.Size = new System.Drawing.Size(152, 20);
            this.soyisimtextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "soyisim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isimtextbox
            // 
            this.isimtextbox.Location = new System.Drawing.Point(58, 48);
            this.isimtextbox.Name = "isimtextbox";
            this.isimtextbox.Size = new System.Drawing.Size(152, 20);
            this.isimtextbox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "isim";
            // 
            // SignInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isimtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyisimtextbox);
            this.Controls.Add(this.gösterCb);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignInUC";
            this.Size = new System.Drawing.Size(252, 273);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox soyisimtextbox;
        public System.Windows.Forms.TextBox isimtextbox;
    }
}
