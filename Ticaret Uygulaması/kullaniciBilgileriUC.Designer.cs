namespace Ticaret_Uygulaması
{
	partial class kullaniciBilgileriUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciBilgileriUC));
			this.kullaniciAditxt = new System.Windows.Forms.Label();
			this.aciklamaTxt = new System.Windows.Forms.Label();
			this.kullaniciAdiLbl = new System.Windows.Forms.Label();
			this.aciklamaLbl = new System.Windows.Forms.Label();
			this.mailTxt = new System.Windows.Forms.Label();
			this.EmailLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// kullaniciAditxt
			// 
			this.kullaniciAditxt.AutoSize = true;
			this.kullaniciAditxt.BackColor = System.Drawing.Color.Transparent;
			this.kullaniciAditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kullaniciAditxt.Location = new System.Drawing.Point(49, 21);
			this.kullaniciAditxt.Name = "kullaniciAditxt";
			this.kullaniciAditxt.Size = new System.Drawing.Size(120, 20);
			this.kullaniciAditxt.TabIndex = 0;
			this.kullaniciAditxt.Text = "Kullanıcı Adı:";
			// 
			// aciklamaTxt
			// 
			this.aciklamaTxt.AutoSize = true;
			this.aciklamaTxt.BackColor = System.Drawing.Color.Transparent;
			this.aciklamaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.aciklamaTxt.Location = new System.Drawing.Point(78, 129);
			this.aciklamaTxt.Name = "aciklamaTxt";
			this.aciklamaTxt.Size = new System.Drawing.Size(91, 20);
			this.aciklamaTxt.TabIndex = 0;
			this.aciklamaTxt.Text = "Açıklama:";
			// 
			// kullaniciAdiLbl
			// 
			this.kullaniciAdiLbl.AutoSize = true;
			this.kullaniciAdiLbl.BackColor = System.Drawing.Color.Transparent;
			this.kullaniciAdiLbl.Location = new System.Drawing.Point(190, 25);
			this.kullaniciAdiLbl.Name = "kullaniciAdiLbl";
			this.kullaniciAdiLbl.Size = new System.Drawing.Size(55, 16);
			this.kullaniciAdiLbl.TabIndex = 1;
			this.kullaniciAdiLbl.Text = "kullanici";
			// 
			// aciklamaLbl
			// 
			this.aciklamaLbl.AutoSize = true;
			this.aciklamaLbl.BackColor = System.Drawing.Color.Transparent;
			this.aciklamaLbl.Location = new System.Drawing.Point(190, 129);
			this.aciklamaLbl.Name = "aciklamaLbl";
			this.aciklamaLbl.Size = new System.Drawing.Size(113, 16);
			this.aciklamaLbl.TabIndex = 1;
			this.aciklamaLbl.Text = "kullanıcı açıklama";
			// 
			// mailTxt
			// 
			this.mailTxt.AutoSize = true;
			this.mailTxt.BackColor = System.Drawing.Color.Transparent;
			this.mailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mailTxt.Location = new System.Drawing.Point(107, 74);
			this.mailTxt.Name = "mailTxt";
			this.mailTxt.Size = new System.Drawing.Size(62, 20);
			this.mailTxt.TabIndex = 0;
			this.mailTxt.Text = "Email:";
			// 
			// EmailLbl
			// 
			this.EmailLbl.AutoSize = true;
			this.EmailLbl.BackColor = System.Drawing.Color.Transparent;
			this.EmailLbl.Location = new System.Drawing.Point(190, 78);
			this.EmailLbl.Name = "EmailLbl";
			this.EmailLbl.Size = new System.Drawing.Size(40, 16);
			this.EmailLbl.TabIndex = 1;
			this.EmailLbl.Text = "email";
			// 
			// kullaniciBilgileriUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.aciklamaLbl);
			this.Controls.Add(this.EmailLbl);
			this.Controls.Add(this.kullaniciAdiLbl);
			this.Controls.Add(this.aciklamaTxt);
			this.Controls.Add(this.mailTxt);
			this.Controls.Add(this.kullaniciAditxt);
			this.Name = "kullaniciBilgileriUC";
			this.Size = new System.Drawing.Size(345, 185);
			this.Load += new System.EventHandler(this.kullaniciBilgileriUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label kullaniciAditxt;
		private System.Windows.Forms.Label aciklamaTxt;
		private System.Windows.Forms.Label kullaniciAdiLbl;
		private System.Windows.Forms.Label aciklamaLbl;
		private System.Windows.Forms.Label mailTxt;
		private System.Windows.Forms.Label EmailLbl;
	}
}
