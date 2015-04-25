namespace AdoConnectedDisconnected
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ödevlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanEklemeGuncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerDisconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödevlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ödevlerToolStripMenuItem
            // 
            this.ödevlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calisanEklemeGuncellemeToolStripMenuItem,
            this.urunlerDisconnectedToolStripMenuItem,
            this.siparisDetayToolStripMenuItem});
            this.ödevlerToolStripMenuItem.Name = "ödevlerToolStripMenuItem";
            this.ödevlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ödevlerToolStripMenuItem.Text = "Ödevler";
            // 
            // calisanEklemeGuncellemeToolStripMenuItem
            // 
            this.calisanEklemeGuncellemeToolStripMenuItem.Name = "calisanEklemeGuncellemeToolStripMenuItem";
            this.calisanEklemeGuncellemeToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.calisanEklemeGuncellemeToolStripMenuItem.Text = "Çalışan Ekleme-Güncelleme (Connected)";
            this.calisanEklemeGuncellemeToolStripMenuItem.Click += new System.EventHandler(this.calisanEklemeGuncellemeToolStripMenuItem_Click);
            // 
            // urunlerDisconnectedToolStripMenuItem
            // 
            this.urunlerDisconnectedToolStripMenuItem.Name = "urunlerDisconnectedToolStripMenuItem";
            this.urunlerDisconnectedToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.urunlerDisconnectedToolStripMenuItem.Text = "Ürünler (Disconnected)";
            this.urunlerDisconnectedToolStripMenuItem.Click += new System.EventHandler(this.urunlerDisconnectedToolStripMenuItem_Click);
            // 
            // siparisDetayToolStripMenuItem
            // 
            this.siparisDetayToolStripMenuItem.Name = "siparisDetayToolStripMenuItem";
            this.siparisDetayToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.siparisDetayToolStripMenuItem.Text = "Sirapiş Detayları (Disconnected)";
            this.siparisDetayToolStripMenuItem.Click += new System.EventHandler(this.siparisDetayToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 370);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ödevlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanEklemeGuncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerDisconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisDetayToolStripMenuItem;
    }
}

