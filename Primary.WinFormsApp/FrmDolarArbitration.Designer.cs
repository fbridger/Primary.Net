namespace Primary.WinFormsApp
{
    partial class FrmDolarArbitration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.Ticker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TickerPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TickerDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TickerCable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEPCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEPVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCLCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCLVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDolarCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDolarVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPesosCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPesosVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCableCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCableVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Ticker,
            this.TickerPesos,
            this.TickerDolar,
            this.TickerCable,
            this.BidSize,
            this.MEPCompra,
            this.MEPVenta,
            this.BidPrice,
            this.CCLCompra,
            this.CCLVenta,
            this.Pesos,
            this.Dolar,
            this.Cable,
            this.BookDolarCompra,
            this.BookDolarVenta,
            this.BookPesosCompra,
            this.BookPesosVenta,
            this.BookCableCompra,
            this.BookCableVenta});
            this.grdArbitration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArbitration.Location = new System.Drawing.Point(0, 0);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(800, 450);
            this.grdArbitration.TabIndex = 1;
            // 
            // Ticker
            // 
            this.Ticker.DataPropertyName = "Ticker";
            this.Ticker.HeaderText = "Ticker";
            this.Ticker.Name = "Ticker";
            this.Ticker.ReadOnly = true;
            // 
            // TickerPesos
            // 
            this.TickerPesos.DataPropertyName = "TickerPesos";
            this.TickerPesos.HeaderText = "TickerPesos";
            this.TickerPesos.Name = "TickerPesos";
            this.TickerPesos.ReadOnly = true;
            this.TickerPesos.Visible = false;
            // 
            // TickerDolar
            // 
            this.TickerDolar.DataPropertyName = "TickerDolar";
            this.TickerDolar.HeaderText = "TickerDolar";
            this.TickerDolar.Name = "TickerDolar";
            this.TickerDolar.ReadOnly = true;
            this.TickerDolar.Visible = false;
            // 
            // TickerCable
            // 
            this.TickerCable.DataPropertyName = "TickerCable";
            this.TickerCable.HeaderText = "TickerCable";
            this.TickerCable.Name = "TickerCable";
            this.TickerCable.ReadOnly = true;
            this.TickerCable.Visible = false;
            // 
            // BidSize
            // 
            this.BidSize.DataPropertyName = "MEP";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.BidSize.DefaultCellStyle = dataGridViewCellStyle1;
            this.BidSize.HeaderText = "MEP";
            this.BidSize.Name = "BidSize";
            this.BidSize.ReadOnly = true;
            // 
            // MEPCompra
            // 
            this.MEPCompra.DataPropertyName = "MEPCompra";
            dataGridViewCellStyle2.Format = "C2";
            this.MEPCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.MEPCompra.HeaderText = "MEP Compra";
            this.MEPCompra.Name = "MEPCompra";
            this.MEPCompra.ReadOnly = true;
            // 
            // MEPVenta
            // 
            this.MEPVenta.DataPropertyName = "MEPVenta";
            dataGridViewCellStyle3.Format = "C2";
            this.MEPVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.MEPVenta.HeaderText = "MEP Venta";
            this.MEPVenta.Name = "MEPVenta";
            this.MEPVenta.ReadOnly = true;
            // 
            // BidPrice
            // 
            this.BidPrice.DataPropertyName = "CCL";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.BidPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.BidPrice.HeaderText = "CCL";
            this.BidPrice.Name = "BidPrice";
            this.BidPrice.ReadOnly = true;
            // 
            // CCLCompra
            // 
            this.CCLCompra.DataPropertyName = "CCLCompra";
            dataGridViewCellStyle5.Format = "C2";
            this.CCLCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.CCLCompra.HeaderText = "CCL Compra";
            this.CCLCompra.Name = "CCLCompra";
            this.CCLCompra.ReadOnly = true;
            // 
            // CCLVenta
            // 
            this.CCLVenta.DataPropertyName = "CCLVenta";
            dataGridViewCellStyle6.Format = "C2";
            this.CCLVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.CCLVenta.HeaderText = "CCL Venta";
            this.CCLVenta.Name = "CCLVenta";
            this.CCLVenta.ReadOnly = true;
            // 
            // Pesos
            // 
            this.Pesos.DataPropertyName = "Pesos";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Pesos.DefaultCellStyle = dataGridViewCellStyle7;
            this.Pesos.HeaderText = "Pesos";
            this.Pesos.Name = "Pesos";
            this.Pesos.ReadOnly = true;
            // 
            // Dolar
            // 
            this.Dolar.DataPropertyName = "Dolar";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Dolar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Dolar.HeaderText = "Dolar";
            this.Dolar.Name = "Dolar";
            this.Dolar.ReadOnly = true;
            // 
            // Cable
            // 
            this.Cable.DataPropertyName = "Cable";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.Cable.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cable.HeaderText = "Cable";
            this.Cable.Name = "Cable";
            this.Cable.ReadOnly = true;
            // 
            // BookDolarCompra
            // 
            this.BookDolarCompra.DataPropertyName = "BookDolarCompra";
            dataGridViewCellStyle10.Format = "C2";
            this.BookDolarCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.BookDolarCompra.HeaderText = "BookDolarCompra";
            this.BookDolarCompra.Name = "BookDolarCompra";
            this.BookDolarCompra.ReadOnly = true;
            // 
            // BookDolarVenta
            // 
            this.BookDolarVenta.DataPropertyName = "BookDolarVenta";
            dataGridViewCellStyle11.Format = "C2";
            this.BookDolarVenta.DefaultCellStyle = dataGridViewCellStyle11;
            this.BookDolarVenta.HeaderText = "BookDolarVenta";
            this.BookDolarVenta.Name = "BookDolarVenta";
            this.BookDolarVenta.ReadOnly = true;
            // 
            // BookPesosCompra
            // 
            this.BookPesosCompra.DataPropertyName = "BookPesosCompra";
            dataGridViewCellStyle12.Format = "C2";
            this.BookPesosCompra.DefaultCellStyle = dataGridViewCellStyle12;
            this.BookPesosCompra.HeaderText = "BookPesosCompra";
            this.BookPesosCompra.Name = "BookPesosCompra";
            this.BookPesosCompra.ReadOnly = true;
            // 
            // BookPesosVenta
            // 
            this.BookPesosVenta.DataPropertyName = "BookPesosVenta";
            dataGridViewCellStyle13.Format = "C2";
            this.BookPesosVenta.DefaultCellStyle = dataGridViewCellStyle13;
            this.BookPesosVenta.HeaderText = "BookPesosVenta";
            this.BookPesosVenta.Name = "BookPesosVenta";
            this.BookPesosVenta.ReadOnly = true;
            // 
            // BookCableCompra
            // 
            this.BookCableCompra.DataPropertyName = "BookCableCompra";
            dataGridViewCellStyle14.Format = "C2";
            this.BookCableCompra.DefaultCellStyle = dataGridViewCellStyle14;
            this.BookCableCompra.HeaderText = "BookCableCompra";
            this.BookCableCompra.Name = "BookCableCompra";
            this.BookCableCompra.ReadOnly = true;
            // 
            // BookCableVenta
            // 
            this.BookCableVenta.DataPropertyName = "BookCableVenta";
            dataGridViewCellStyle15.Format = "C2";
            this.BookCableVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.BookCableVenta.HeaderText = "BookCableVenta";
            this.BookCableVenta.Name = "BookCableVenta";
            this.BookCableVenta.ReadOnly = true;
            // 
            // FrmDolarArbitration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdArbitration);
            this.Name = "FrmDolarArbitration";
            this.Text = "FrmDolarArbitration";
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticker;
        private System.Windows.Forms.DataGridViewTextBoxColumn TickerPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TickerDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TickerCable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEPCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEPVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCLCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCLVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDolarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDolarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPesosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPesosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCableCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCableVenta;
    }
}