namespace Primary.WinFormsApp
{
    partial class FrmArbitrationAnalyzer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyOwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArbitration
            // 
            this.grdArbitration.AllowUserToAddRows = false;
            this.grdArbitration.AllowUserToDeleteRows = false;
            this.grdArbitration.AllowUserToOrderColumns = true;
            this.grdArbitration.AllowUserToResizeRows = false;
            this.grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArbitration.CausesValidation = false;
            this.grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyOwnedVenta,
            this.KeyArbitrationCompra,
            this.KeyArbitrationVenta,
            this.KeyOwnedCompra,
            this.Profit,
            this.ProfitLast,
            this.OwnedVenta,
            this.ArbitrationCompra,
            this.ArbitrationVenta,
            this.OwnedCompra,
            this.DolarCompra,
            this.DolarVenta,
            this.DolarCompraLast,
            this.DolarVentaLast});
            this.grdArbitration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArbitration.Location = new System.Drawing.Point(0, 0);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(1313, 450);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KeyOwnedVenta
            // 
            this.KeyOwnedVenta.DataPropertyName = "KeyOwnedVenta";
            this.KeyOwnedVenta.HeaderText = "1 Venta";
            this.KeyOwnedVenta.Name = "KeyOwnedVenta";
            this.KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            this.KeyArbitrationCompra.DataPropertyName = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.HeaderText = "2 Compra";
            this.KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.ReadOnly = true;
            // 
            // KeyArbitrationVenta
            // 
            this.KeyArbitrationVenta.DataPropertyName = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.HeaderText = "3 Venta";
            this.KeyArbitrationVenta.Name = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.ReadOnly = true;
            // 
            // KeyOwnedCompra
            // 
            this.KeyOwnedCompra.DataPropertyName = "KeyOwnedCompra";
            this.KeyOwnedCompra.HeaderText = "4 Compra";
            this.KeyOwnedCompra.Name = "KeyOwnedCompra";
            this.KeyOwnedCompra.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle1.Format = "P";
            dataGridViewCellStyle1.NullValue = null;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // ProfitLast
            // 
            this.ProfitLast.DataPropertyName = "ProfitLast";
            dataGridViewCellStyle2.Format = "P";
            this.ProfitLast.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProfitLast.HeaderText = "Profit Last";
            this.ProfitLast.Name = "ProfitLast";
            this.ProfitLast.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "OwnedVenta";
            dataGridViewCellStyle3.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.OwnedVenta.HeaderText = "Owned Venta";
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "ArbitrationCompra";
            dataGridViewCellStyle4.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle4;
            this.ArbitrationCompra.HeaderText = "Arbitration Compra";
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // ArbitrationVenta
            // 
            this.ArbitrationVenta.DataPropertyName = "ArbitrationVenta";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ArbitrationVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.ArbitrationVenta.HeaderText = "Arbitration Venta";
            this.ArbitrationVenta.Name = "ArbitrationVenta";
            this.ArbitrationVenta.ReadOnly = true;
            // 
            // OwnedCompra
            // 
            this.OwnedCompra.DataPropertyName = "OwnedCompra";
            dataGridViewCellStyle6.Format = "C2";
            this.OwnedCompra.DefaultCellStyle = dataGridViewCellStyle6;
            this.OwnedCompra.HeaderText = "Owned Compra";
            this.OwnedCompra.Name = "OwnedCompra";
            this.OwnedCompra.ReadOnly = true;
            // 
            // DolarCompra
            // 
            this.DolarCompra.DataPropertyName = "DolarCompra";
            dataGridViewCellStyle7.Format = "C2";
            this.DolarCompra.DefaultCellStyle = dataGridViewCellStyle7;
            this.DolarCompra.HeaderText = "Compra";
            this.DolarCompra.Name = "DolarCompra";
            this.DolarCompra.ReadOnly = true;
            // 
            // DolarVenta
            // 
            this.DolarVenta.DataPropertyName = "DolarVenta";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.DolarVenta.DefaultCellStyle = dataGridViewCellStyle8;
            this.DolarVenta.HeaderText = "Venta";
            this.DolarVenta.Name = "DolarVenta";
            this.DolarVenta.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "DolarCompraLast";
            dataGridViewCellStyle9.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle9;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "DolarVentaLast";
            dataGridViewCellStyle10.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle10;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
            // 
            // FrmArbitrationBestTrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.grdArbitration);
            this.Name = "FrmArbitrationBestTrades";
            this.Text = "FrmArbitrationBestTrades";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
    }
}