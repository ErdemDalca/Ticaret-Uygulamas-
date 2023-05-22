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
            this.Sıralamafiltresi = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.yenilemeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(810, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 49);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sıralamafiltresi
            // 
            this.Sıralamafiltresi.BackColor = System.Drawing.Color.White;
            this.Sıralamafiltresi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sıralamafiltresi.ForeColor = System.Drawing.Color.Black;
            this.Sıralamafiltresi.FormattingEnabled = true;
            this.Sıralamafiltresi.Items.AddRange(new object[] {
            "azalan",
            "artan"});
            this.Sıralamafiltresi.Location = new System.Drawing.Point(385, 58);
            this.Sıralamafiltresi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sıralamafiltresi.Name = "Sıralamafiltresi";
            this.Sıralamafiltresi.Size = new System.Drawing.Size(152, 21);
            this.Sıralamafiltresi.TabIndex = 1;
            this.Sıralamafiltresi.Text = "seç(sıralama kriterleri)";
            this.Sıralamafiltresi.SelectedIndexChanged += new System.EventHandler(this.filtre_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 510);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Transparent;
            this.profileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileBtn.BackgroundImage")));
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.ForeColor = System.Drawing.Color.Transparent;
            this.profileBtn.Location = new System.Drawing.Point(9, 11);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(45, 49);
            this.profileBtn.TabIndex = 4;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // yenilemeBtn
            // 
            this.yenilemeBtn.BackColor = System.Drawing.Color.Transparent;
            this.yenilemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenilemeBtn.ForeColor = System.Drawing.Color.Black;
            this.yenilemeBtn.Location = new System.Drawing.Point(548, 41);
            this.yenilemeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yenilemeBtn.Name = "yenilemeBtn";
            this.yenilemeBtn.Size = new System.Drawing.Size(38, 41);
            this.yenilemeBtn.TabIndex = 5;
            this.yenilemeBtn.Text = "⭮";
            this.yenilemeBtn.UseVisualStyleBackColor = false;
            this.yenilemeBtn.Click += new System.EventHandler(this.yenilemeBtn_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 602);
            this.Controls.Add(this.yenilemeBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Sıralamafiltresi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button profileBtn;
		private System.Windows.Forms.Button yenilemeBtn;
        public System.Windows.Forms.ComboBox Sıralamafiltresi;
    }
}