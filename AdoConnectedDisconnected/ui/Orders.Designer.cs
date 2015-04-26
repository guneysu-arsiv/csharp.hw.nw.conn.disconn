namespace AdoConnectedDisconnected.ui
{
    partial class Orders
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
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 17;
            this.lstEmployees.Location = new System.Drawing.Point(10, 40);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(10);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(189, 290);
            this.lstEmployees.TabIndex = 0;
            this.lstEmployees.SelectedValueChanged += new System.EventHandler(this.lstEmployees_SelectedValueChanged);
            // 
            // lstOrders
            // 
            this.lstOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 17;
            this.lstOrders.Location = new System.Drawing.Point(199, 40);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(10);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(154, 290);
            this.lstOrders.TabIndex = 1;
            this.lstOrders.SelectedValueChanged += new System.EventHandler(this.lstOrders_SelectedValueChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 17;
            this.lstProducts.Location = new System.Drawing.Point(353, 40);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(10);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(238, 290);
            this.lstProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışanlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Siparişler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(353, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürünler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Orders";
            this.Padding = new System.Windows.Forms.Padding(10, 40, 10, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}