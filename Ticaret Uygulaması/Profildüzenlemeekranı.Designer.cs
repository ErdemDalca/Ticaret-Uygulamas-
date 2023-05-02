namespace Ticaret_Uygulaması
{
    partial class Profildüzenlemeekranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciadidegistxt = new System.Windows.Forms.TextBox();
            this.aciklamadegistirtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Düzenlebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim/soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // kullaniciadidegistxt
            // 
            this.kullaniciadidegistxt.Location = new System.Drawing.Point(271, 49);
            this.kullaniciadidegistxt.Name = "kullaniciadidegistxt";
            this.kullaniciadidegistxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciadidegistxt.TabIndex = 3;
            // 
            // aciklamadegistirtxt
            // 
            this.aciklamadegistirtxt.Location = new System.Drawing.Point(271, 158);
            this.aciklamadegistirtxt.Name = "aciklamadegistirtxt";
            this.aciklamadegistirtxt.Size = new System.Drawing.Size(100, 20);
            this.aciklamadegistirtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Açıklama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Düzenlebutton
            // 
            this.Düzenlebutton.Location = new System.Drawing.Point(296, 206);
            this.Düzenlebutton.Name = "Düzenlebutton";
            this.Düzenlebutton.Size = new System.Drawing.Size(75, 23);
            this.Düzenlebutton.TabIndex = 8;
            this.Düzenlebutton.Text = "Düzenle";
            this.Düzenlebutton.UseVisualStyleBackColor = true;
            this.Düzenlebutton.Click += new System.EventHandler(this.Düzenlebutton_Click);
            // 
            // Profildüzenlemeekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.Düzenlebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aciklamadegistirtxt);
            this.Controls.Add(this.kullaniciadidegistxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profildüzenlemeekranı";
            this.Text = "Profildüzenlemeekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.Button Düzenlebutton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox kullaniciadidegistxt;
        public System.Windows.Forms.TextBox aciklamadegistirtxt;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
    }
}