namespace Ticaret_Uygulaması
{
    partial class Profilekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilekranı));
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tekliflerTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.profildüzenlemebutonu = new System.Windows.Forms.Button();
            this.paraeklebtn = new System.Windows.Forms.Button();
            this.paramik = new System.Windows.Forms.TextBox();
            this.paraicon = new System.Windows.Forms.PictureBox();
            this.ProfilfotoğrafıAslı = new System.Windows.Forms.Button();
            this.Envanterbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paraicon)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(550, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(581, 511);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tekliflerTxt
            // 
            this.tekliflerTxt.AutoSize = true;
            this.tekliflerTxt.BackColor = System.Drawing.Color.Transparent;
            this.tekliflerTxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekliflerTxt.Location = new System.Drawing.Point(248, 31);
            this.tekliflerTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tekliflerTxt.Name = "tekliflerTxt";
            this.tekliflerTxt.Size = new System.Drawing.Size(99, 19);
            this.tekliflerTxt.TabIndex = 3;
            this.tekliflerTxt.Text = "TEKLİFLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(597, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 150);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profildüzenlemebutonu
            // 
            this.profildüzenlemebutonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profildüzenlemebutonu.Location = new System.Drawing.Point(754, 241);
            this.profildüzenlemebutonu.Name = "profildüzenlemebutonu";
            this.profildüzenlemebutonu.Size = new System.Drawing.Size(102, 23);
            this.profildüzenlemebutonu.TabIndex = 5;
            this.profildüzenlemebutonu.Text = "Profili düzenle";
            this.profildüzenlemebutonu.UseVisualStyleBackColor = true;
            this.profildüzenlemebutonu.Click += new System.EventHandler(this.profildüzenlemebutonu_Click);
            // 
            // paraeklebtn
            // 
            this.paraeklebtn.Location = new System.Drawing.Point(754, 63);
            this.paraeklebtn.Margin = new System.Windows.Forms.Padding(2);
            this.paraeklebtn.Name = "paraeklebtn";
            this.paraeklebtn.Size = new System.Drawing.Size(22, 19);
            this.paraeklebtn.TabIndex = 6;
            this.paraeklebtn.Text = "+";
            this.paraeklebtn.UseVisualStyleBackColor = true;
            this.paraeklebtn.Click += new System.EventHandler(this.paraeklebtn_Click);
            // 
            // paramik
            // 
            this.paramik.Enabled = false;
            this.paramik.Location = new System.Drawing.Point(633, 63);
            this.paramik.Margin = new System.Windows.Forms.Padding(2);
            this.paramik.Name = "paramik";
            this.paramik.Size = new System.Drawing.Size(117, 20);
            this.paramik.TabIndex = 7;
            this.paramik.Text = "0";
            this.paramik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paraicon
            // 
            this.paraicon.BackColor = System.Drawing.Color.Transparent;
            this.paraicon.Enabled = false;
            this.paraicon.Image = ((System.Drawing.Image)(resources.GetObject("paraicon.Image")));
            this.paraicon.Location = new System.Drawing.Point(606, 57);
            this.paraicon.Margin = new System.Windows.Forms.Padding(2);
            this.paraicon.Name = "paraicon";
            this.paraicon.Size = new System.Drawing.Size(24, 26);
            this.paraicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paraicon.TabIndex = 8;
            this.paraicon.TabStop = false;
            // 
            // ProfilfotoğrafıAslı
            // 
            this.ProfilfotoğrafıAslı.BackColor = System.Drawing.Color.Transparent;
            this.ProfilfotoğrafıAslı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilfotoğrafıAslı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilfotoğrafıAslı.Location = new System.Drawing.Point(781, 6);
            this.ProfilfotoğrafıAslı.Name = "ProfilfotoğrafıAslı";
            this.ProfilfotoğrafıAslı.Size = new System.Drawing.Size(75, 75);
            this.ProfilfotoğrafıAslı.TabIndex = 9;
            this.ProfilfotoğrafıAslı.UseVisualStyleBackColor = false;
            // 
            // Envanterbutton
            // 
            this.Envanterbutton.Location = new System.Drawing.Point(597, 533);
            this.Envanterbutton.Name = "Envanterbutton";
            this.Envanterbutton.Size = new System.Drawing.Size(259, 64);
            this.Envanterbutton.TabIndex = 10;
            this.Envanterbutton.Text = "ENVANTER";
            this.Envanterbutton.UseVisualStyleBackColor = true;
            this.Envanterbutton.Click += new System.EventHandler(this.Envanterbutton_Click);
            // 
            // Profilekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 602);
            this.Controls.Add(this.Envanterbutton);
            this.Controls.Add(this.ProfilfotoğrafıAslı);
            this.Controls.Add(this.paraicon);
            this.Controls.Add(this.paramik);
            this.Controls.Add(this.paraeklebtn);
            this.Controls.Add(this.profildüzenlemebutonu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tekliflerTxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profilekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilekranı";
            this.Load += new System.EventHandler(this.Profilekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paraicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label tekliflerTxt;
        public System.Windows.Forms.Button profildüzenlemebutonu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button paraeklebtn;
        private System.Windows.Forms.TextBox paramik;
        private System.Windows.Forms.PictureBox paraicon;
        public System.Windows.Forms.Button ProfilfotoğrafıAslı;
        public System.Windows.Forms.Button Envanterbutton;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}