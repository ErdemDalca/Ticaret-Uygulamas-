namespace Ticaret_Uygulaması
{
    partial class MenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
			this.button1 = new System.Windows.Forms.Button();
			this.filtre = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.profileBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(1080, 14);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 60);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// filtre
			// 
			this.filtre.BackColor = System.Drawing.Color.White;
			this.filtre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.filtre.ForeColor = System.Drawing.Color.Black;
			this.filtre.FormattingEnabled = true;
			this.filtre.Items.AddRange(new object[] {
            "fiyata göre sırala",
            "eklenme tarihine göre sırala"});
			this.filtre.Location = new System.Drawing.Point(580, 62);
			this.filtre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.filtre.Name = "filtre";
			this.filtre.Size = new System.Drawing.Size(201, 24);
			this.filtre.TabIndex = 1;
			this.filtre.Text = "seç(sıralama kriterleri)";
			this.filtre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 107);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 628);
			this.flowLayoutPanel1.TabIndex = 2;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// profileBtn
			// 
			this.profileBtn.BackColor = System.Drawing.Color.Transparent;
			this.profileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileBtn.BackgroundImage")));
			this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.profileBtn.ForeColor = System.Drawing.Color.Transparent;
			this.profileBtn.Location = new System.Drawing.Point(12, 14);
			this.profileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.profileBtn.Name = "profileBtn";
			this.profileBtn.Size = new System.Drawing.Size(60, 60);
			this.profileBtn.TabIndex = 4;
			this.profileBtn.UseVisualStyleBackColor = false;
			this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
			// 
			// MenuScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1153, 741);
			this.Controls.Add(this.profileBtn);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.filtre);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimizeBox = false;
			this.Name = "MenuScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yilgin bir hosgoru ile benimsenmisler";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Load += new System.EventHandler(this.MenuScreen_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox filtre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button profileBtn;
    }
}