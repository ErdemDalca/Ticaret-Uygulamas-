namespace Ticaret_Uygulaması
{
    partial class Envanter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envanter));
            this.EnvanterTxt = new System.Windows.Forms.Label();
            this.Acilcikis = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // EnvanterTxt
            // 
            resources.ApplyResources(this.EnvanterTxt, "EnvanterTxt");
            this.EnvanterTxt.BackColor = System.Drawing.Color.Transparent;
            this.EnvanterTxt.Name = "EnvanterTxt";
            // 
            // Acilcikis
            // 
            this.Acilcikis.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Acilcikis, "Acilcikis");
            this.Acilcikis.ForeColor = System.Drawing.Color.DarkGray;
            this.Acilcikis.Name = "Acilcikis";
            this.Acilcikis.UseVisualStyleBackColor = false;
            this.Acilcikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Envanter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Acilcikis);
            this.Controls.Add(this.EnvanterTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Envanter";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label EnvanterTxt;
        public System.Windows.Forms.Button Acilcikis;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}