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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.historicDataToolStripMenuItem,
            this.buscadorDeArbitrajesToolStripMenuItem,
            this.marketDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // historicDataToolStripMenuItem
            // 
            this.historicDataToolStripMenuItem.Name = "historicDataToolStripMenuItem";
            this.historicDataToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.historicDataToolStripMenuItem.Text = "Historic Data";
            this.historicDataToolStripMenuItem.Click += new System.EventHandler(this.historicDataToolStripMenuItem_Click);
            // 
            // buscadorDeArbitrajesToolStripMenuItem
            // 
            this.buscadorDeArbitrajesToolStripMenuItem.Name = "buscadorDeArbitrajesToolStripMenuItem";
            this.buscadorDeArbitrajesToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.buscadorDeArbitrajesToolStripMenuItem.Text = "Buscador de Arbitrajes";
            this.buscadorDeArbitrajesToolStripMenuItem.Click += new System.EventHandler(this.buscadorDeArbitrajesToolStripMenuItem_Click);
            // 
            // marketDataToolStripMenuItem
            // 
            this.marketDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbInstruments});
            this.marketDataToolStripMenuItem.Name = "marketDataToolStripMenuItem";
            this.marketDataToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.marketDataToolStripMenuItem.Text = "MarketData";
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(121, 23);
            this.cmbInstruments.SelectedIndexChanged += new System.EventHandler(this.cmbInstruments_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}

