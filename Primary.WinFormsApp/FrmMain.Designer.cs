namespace Primary.WinFormsApp
{
    partial class FrmMain
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorDeArbitrajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbInstruments = new System.Windows.Forms.ToolStripComboBox();
            this.dolarPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorArbitrajesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.historicDataToolStripMenuItem,
            this.buscadorDeArbitrajesToolStripMenuItem,
            this.marketDataToolStripMenuItem,
            this.dolarPricesToolStripMenuItem,
            this.refreshDataToolStripMenuItem,
            this.buscadorArbitrajesSimplesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // historicDataToolStripMenuItem
            // 
            this.historicDataToolStripMenuItem.Name = "historicDataToolStripMenuItem";
            this.historicDataToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.historicDataToolStripMenuItem.Text = "Historic Data";
            this.historicDataToolStripMenuItem.Click += new System.EventHandler(this.historicDataToolStripMenuItem_Click);
            // 
            // buscadorDeArbitrajesToolStripMenuItem
            // 
            this.buscadorDeArbitrajesToolStripMenuItem.Name = "buscadorDeArbitrajesToolStripMenuItem";
            this.buscadorDeArbitrajesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.buscadorDeArbitrajesToolStripMenuItem.Text = "Buscador de Arbitrajes";
            this.buscadorDeArbitrajesToolStripMenuItem.Click += new System.EventHandler(this.buscadorDeArbitrajesToolStripMenuItem_Click);
            // 
            // marketDataToolStripMenuItem
            // 
            this.marketDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbInstruments});
            this.marketDataToolStripMenuItem.Name = "marketDataToolStripMenuItem";
            this.marketDataToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.marketDataToolStripMenuItem.Text = "MarketData";
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(121, 28);
            this.cmbInstruments.SelectedIndexChanged += new System.EventHandler(this.cmbInstruments_SelectedIndexChanged);
            // 
            // dolarPricesToolStripMenuItem
            // 
            this.dolarPricesToolStripMenuItem.Name = "dolarPricesToolStripMenuItem";
            this.dolarPricesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.dolarPricesToolStripMenuItem.Text = "Dolar Prices";
            this.dolarPricesToolStripMenuItem.Click += new System.EventHandler(this.dolarPricesToolStripMenuItem_Click);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // buscadorArbitrajesSimplesToolStripMenuItem
            // 
            this.buscadorArbitrajesSimplesToolStripMenuItem.Name = "buscadorArbitrajesSimplesToolStripMenuItem";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.buscadorArbitrajesSimplesToolStripMenuItem.Text = "Buscador Arbitrajes Simples";
            this.buscadorArbitrajesSimplesToolStripMenuItem.Click += new System.EventHandler(this.buscadorArbitrajesSimplesToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Primary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorDeArbitrajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbInstruments;
        private System.Windows.Forms.ToolStripMenuItem dolarPricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorArbitrajesSimplesToolStripMenuItem;
    }
}

