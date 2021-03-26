namespace Primary.WinFormsApp
{
    partial class FrmSettlementTermsAnalyzer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdArbitration = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numMinProfit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSettlementTerms = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numComisionCaucion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBuySellSize = new System.Windows.Forms.NumericUpDown();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyOwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitCaucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbitrationCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarCompraLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolarVentaLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDiasCaucion = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionCaucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuySellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasCaucion)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArbitration
            // 
            this.grdArbitration.AllowUserToAddRows = false;
            this.grdArbitration.AllowUserToDeleteRows = false;
            this.grdArbitration.AllowUserToOrderColumns = true;
            this.grdArbitration.AllowUserToResizeRows = false;
            this.grdArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArbitration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArbitration.CausesValidation = false;
            this.grdArbitration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArbitration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyOwnedVenta,
            this.KeyArbitrationCompra,
            this.Profit,
            this.ProfitLast,
            this.SellTotal,
            this.BuyTotal,
            this.Comision,
            this.Caucion,
            this.ProfitCaucion,
            this.OwnedVenta,
            this.ArbitrationCompra,
            this.DolarCompraLast,
            this.DolarVentaLast});
            this.grdArbitration.Location = new System.Drawing.Point(4, 34);
            this.grdArbitration.Margin = new System.Windows.Forms.Padding(4);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.RowHeadersWidth = 51;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(2096, 621);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numMinProfit
            // 
            this.numMinProfit.DecimalPlaces = 2;
            this.numMinProfit.Location = new System.Drawing.Point(111, 2);
            this.numMinProfit.Margin = new System.Windows.Forms.Padding(4);
            this.numMinProfit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMinProfit.Name = "numMinProfit";
            this.numMinProfit.Size = new System.Drawing.Size(109, 22);
            this.numMinProfit.TabIndex = 3;
            this.numMinProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinProfit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min Profit %:";
            // 
            // chkSettlementTerms
            // 
            this.chkSettlementTerms.AutoSize = true;
            this.chkSettlementTerms.Checked = true;
            this.chkSettlementTerms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettlementTerms.Location = new System.Drawing.Point(249, 3);
            this.chkSettlementTerms.Name = "chkSettlementTerms";
            this.chkSettlementTerms.Size = new System.Drawing.Size(205, 21);
            this.chkSettlementTerms.TabIndex = 5;
            this.chkSettlementTerms.Text = "Arbitrajes Plazo Liquidacion";
            this.chkSettlementTerms.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comision Operación%:";
            // 
            // numComisionCaucion
            // 
            this.numComisionCaucion.DecimalPlaces = 3;
            this.numComisionCaucion.Location = new System.Drawing.Point(941, 3);
            this.numComisionCaucion.Margin = new System.Windows.Forms.Padding(4);
            this.numComisionCaucion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComisionCaucion.Name = "numComisionCaucion";
            this.numComisionCaucion.Size = new System.Drawing.Size(109, 22);
            this.numComisionCaucion.TabIndex = 6;
            this.numComisionCaucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComisionCaucion.Value = new decimal(new int[] {
            2865,
            0,
            0,
            196608});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1082, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sell/Buy Size: ";
            // 
            // numBuySellSize
            // 
            this.numBuySellSize.Location = new System.Drawing.Point(1212, 5);
            this.numBuySellSize.Margin = new System.Windows.Forms.Padding(4);
            this.numBuySellSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBuySellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBuySellSize.Name = "numBuySellSize";
            this.numBuySellSize.Size = new System.Drawing.Size(109, 22);
            this.numBuySellSize.TabIndex = 8;
            this.numBuySellSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBuySellSize.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numComision
            // 
            this.numComision.DecimalPlaces = 2;
            this.numComision.Location = new System.Drawing.Point(636, 5);
            this.numComision.Margin = new System.Windows.Forms.Padding(4);
            this.numComision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(109, 22);
            this.numComision.TabIndex = 10;
            this.numComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numComision.Value = new decimal(new int[] {
            27,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comision Caucion%:";
            // 
            // KeyOwnedVenta
            // 
            this.KeyOwnedVenta.DataPropertyName = "KeyVenta";
            this.KeyOwnedVenta.HeaderText = "1 Venta";
            this.KeyOwnedVenta.MinimumWidth = 6;
            this.KeyOwnedVenta.Name = "KeyOwnedVenta";
            this.KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            this.KeyArbitrationCompra.DataPropertyName = "KeyCompra";
            this.KeyArbitrationCompra.HeaderText = "2 Compra";
            this.KeyArbitrationCompra.MinimumWidth = 6;
            this.KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle12.Format = "P";
            dataGridViewCellStyle12.NullValue = null;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle12;
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // ProfitLast
            // 
            this.ProfitLast.DataPropertyName = "ProfitLast";
            dataGridViewCellStyle13.Format = "P";
            this.ProfitLast.DefaultCellStyle = dataGridViewCellStyle13;
            this.ProfitLast.HeaderText = "Profit Last";
            this.ProfitLast.MinimumWidth = 6;
            this.ProfitLast.Name = "ProfitLast";
            this.ProfitLast.ReadOnly = true;
            // 
            // SellTotal
            // 
            this.SellTotal.DataPropertyName = "SellTotal";
            dataGridViewCellStyle14.Format = "C0";
            this.SellTotal.DefaultCellStyle = dataGridViewCellStyle14;
            this.SellTotal.HeaderText = "SellTotal";
            this.SellTotal.MinimumWidth = 6;
            this.SellTotal.Name = "SellTotal";
            this.SellTotal.ReadOnly = true;
            // 
            // BuyTotal
            // 
            this.BuyTotal.DataPropertyName = "BuyTotal";
            dataGridViewCellStyle15.Format = "C0";
            this.BuyTotal.DefaultCellStyle = dataGridViewCellStyle15;
            this.BuyTotal.HeaderText = "BuyTotal";
            this.BuyTotal.MinimumWidth = 6;
            this.BuyTotal.Name = "BuyTotal";
            this.BuyTotal.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            dataGridViewCellStyle16.Format = "C0";
            this.Comision.DefaultCellStyle = dataGridViewCellStyle16;
            this.Comision.HeaderText = "Comision";
            this.Comision.MinimumWidth = 6;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Caucion
            // 
            this.Caucion.DataPropertyName = "Caucion";
            dataGridViewCellStyle17.Format = "C0";
            this.Caucion.DefaultCellStyle = dataGridViewCellStyle17;
            this.Caucion.HeaderText = "Caucion";
            this.Caucion.MinimumWidth = 6;
            this.Caucion.Name = "Caucion";
            this.Caucion.ReadOnly = true;
            // 
            // ProfitCaucion
            // 
            this.ProfitCaucion.DataPropertyName = "ProfitCaucion";
            dataGridViewCellStyle18.Format = "C0";
            dataGridViewCellStyle18.NullValue = null;
            this.ProfitCaucion.DefaultCellStyle = dataGridViewCellStyle18;
            this.ProfitCaucion.HeaderText = "P&L Caucion";
            this.ProfitCaucion.MinimumWidth = 6;
            this.ProfitCaucion.Name = "ProfitCaucion";
            this.ProfitCaucion.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "Venta";
            dataGridViewCellStyle19.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle19;
            this.OwnedVenta.HeaderText = "Venta";
            this.OwnedVenta.MinimumWidth = 6;
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "Compra";
            dataGridViewCellStyle20.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle20;
            this.ArbitrationCompra.HeaderText = "Compra";
            this.ArbitrationCompra.MinimumWidth = 6;
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "CompraLast";
            dataGridViewCellStyle21.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle21;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.MinimumWidth = 6;
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "VentaLast";
            dataGridViewCellStyle22.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle22;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.MinimumWidth = 6;
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
            // 
            // numDiasCaucion
            // 
            this.numDiasCaucion.Location = new System.Drawing.Point(1474, 6);
            this.numDiasCaucion.Margin = new System.Windows.Forms.Padding(4);
            this.numDiasCaucion.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDiasCaucion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDiasCaucion.Name = "numDiasCaucion";
            this.numDiasCaucion.Size = new System.Drawing.Size(109, 22);
            this.numDiasCaucion.TabIndex = 12;
            this.numDiasCaucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiasCaucion.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1342, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dias Caucion: ";
            // 
            // FrmSettlementTermsAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDiasCaucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numBuySellSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numComisionCaucion);
            this.Controls.Add(this.chkSettlementTerms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinProfit);
            this.Controls.Add(this.grdArbitration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSettlementTermsAnalyzer";
            this.Text = "Scanner de arbitrajes simples";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionCaucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuySellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasCaucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArbitration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numMinProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSettlementTerms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComisionCaucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBuySellSize;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyOwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitCaucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbitrationCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarCompraLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolarVentaLast;
        private System.Windows.Forms.NumericUpDown numDiasCaucion;
        private System.Windows.Forms.Label label5;
    }
}