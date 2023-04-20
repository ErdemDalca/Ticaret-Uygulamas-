namespace Ticaret_Uygulaması
{
    partial class Specialmessagebox
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
            this.kayitmesaji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kayitmesaji
            // 
            this.kayitmesaji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayitmesaji.AutoEllipsis = true;
            this.kayitmesaji.BackColor = System.Drawing.Color.Transparent;
            this.kayitmesaji.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitmesaji.Location = new System.Drawing.Point(30, 50);
            this.kayitmesaji.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kayitmesaji.Name = "kayitmesaji";
            this.kayitmesaji.Size = new System.Drawing.Size(218, 40);
            this.kayitmesaji.TabIndex = 0;
            this.kayitmesaji.Text = "Hesabınız oluşturuldu!";
            this.kayitmesaji.Click += new System.EventHandler(this.label1_Click);
            // 
            // Specialmessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ticaret_Uygulaması.Properties.Resources.minions;
            this.ClientSize = new System.Drawing.Size(273, 136);
            this.Controls.Add(this.kayitmesaji);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Specialmessagebox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Specialmessagebox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label kayitmesaji;
    }
}