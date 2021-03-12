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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdArbitration = new System.Windows.Forms.DataGridView();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numMinProfit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMEP = new System.Windows.Forms.CheckBox();
            this.chkCCL = new System.Windows.Forms.CheckBox();
            this.chkDolarDC = new System.Windows.Forms.CheckBox();
            this.chkDolarCD = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).BeginInit();
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
            this.grdArbitration.Location = new System.Drawing.Point(4, 34);
            this.grdArbitration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdArbitration.Name = "grdArbitration";
            this.grdArbitration.ReadOnly = true;
            this.grdArbitration.RowHeadersVisible = false;
            this.grdArbitration.RowHeadersWidth = 51;
            this.grdArbitration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArbitration.ShowCellErrors = false;
            this.grdArbitration.ShowEditingIcon = false;
            this.grdArbitration.ShowRowErrors = false;
            this.grdArbitration.Size = new System.Drawing.Size(1747, 519);
            this.grdArbitration.TabIndex = 2;
            this.grdArbitration.DoubleClick += new System.EventHandler(this.grdArbitration_DoubleClick);
            // 
            // KeyOwnedVenta
            // 
            this.KeyOwnedVenta.DataPropertyName = "KeyOwnedVenta";
            this.KeyOwnedVenta.HeaderText = "1 Venta";
            this.KeyOwnedVenta.MinimumWidth = 6;
            this.KeyOwnedVenta.Name = "KeyOwnedVenta";
            this.KeyOwnedVenta.ReadOnly = true;
            // 
            // KeyArbitrationCompra
            // 
            this.KeyArbitrationCompra.DataPropertyName = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.HeaderText = "2 Compra";
            this.KeyArbitrationCompra.MinimumWidth = 6;
            this.KeyArbitrationCompra.Name = "KeyArbitrationCompra";
            this.KeyArbitrationCompra.ReadOnly = true;
            // 
            // KeyArbitrationVenta
            // 
            this.KeyArbitrationVenta.DataPropertyName = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.HeaderText = "3 Venta";
            this.KeyArbitrationVenta.MinimumWidth = 6;
            this.KeyArbitrationVenta.Name = "KeyArbitrationVenta";
            this.KeyArbitrationVenta.ReadOnly = true;
            // 
            // KeyOwnedCompra
            // 
            this.KeyOwnedCompra.DataPropertyName = "KeyOwnedCompra";
            this.KeyOwnedCompra.HeaderText = "4 Compra";
            this.KeyOwnedCompra.MinimumWidth = 6;
            this.KeyOwnedCompra.Name = "KeyOwnedCompra";
            this.KeyOwnedCompra.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle11.Format = "P";
            dataGridViewCellStyle11.NullValue = null;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle11;
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // ProfitLast
            // 
            this.ProfitLast.DataPropertyName = "ProfitLast";
            dataGridViewCellStyle12.Format = "P";
            this.ProfitLast.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProfitLast.HeaderText = "Profit Last";
            this.ProfitLast.MinimumWidth = 6;
            this.ProfitLast.Name = "ProfitLast";
            this.ProfitLast.ReadOnly = true;
            // 
            // OwnedVenta
            // 
            this.OwnedVenta.DataPropertyName = "OwnedVenta";
            dataGridViewCellStyle13.Format = "C2";
            this.OwnedVenta.DefaultCellStyle = dataGridViewCellStyle13;
            this.OwnedVenta.HeaderText = "Owned Venta";
            this.OwnedVenta.MinimumWidth = 6;
            this.OwnedVenta.Name = "OwnedVenta";
            this.OwnedVenta.ReadOnly = true;
            // 
            // ArbitrationCompra
            // 
            this.ArbitrationCompra.DataPropertyName = "ArbitrationCompra";
            dataGridViewCellStyle14.Format = "C2";
            this.ArbitrationCompra.DefaultCellStyle = dataGridViewCellStyle14;
            this.ArbitrationCompra.HeaderText = "Arbitration Compra";
            this.ArbitrationCompra.MinimumWidth = 6;
            this.ArbitrationCompra.Name = "ArbitrationCompra";
            this.ArbitrationCompra.ReadOnly = true;
            // 
            // ArbitrationVenta
            // 
            this.ArbitrationVenta.DataPropertyName = "ArbitrationVenta";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.ArbitrationVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.ArbitrationVenta.HeaderText = "Arbitration Venta";
            this.ArbitrationVenta.MinimumWidth = 6;
            this.ArbitrationVenta.Name = "ArbitrationVenta";
            this.ArbitrationVenta.ReadOnly = true;
            // 
            // OwnedCompra
            // 
            this.OwnedCompra.DataPropertyName = "OwnedCompra";
            dataGridViewCellStyle16.Format = "C2";
            this.OwnedCompra.DefaultCellStyle = dataGridViewCellStyle16;
            this.OwnedCompra.HeaderText = "Owned Compra";
            this.OwnedCompra.MinimumWidth = 6;
            this.OwnedCompra.Name = "OwnedCompra";
            this.OwnedCompra.ReadOnly = true;
            // 
            // DolarCompra
            // 
            this.DolarCompra.DataPropertyName = "DolarCompra";
            dataGridViewCellStyle17.Format = "C2";
            this.DolarCompra.DefaultCellStyle = dataGridViewCellStyle17;
            this.DolarCompra.HeaderText = "Compra";
            this.DolarCompra.MinimumWidth = 6;
            this.DolarCompra.Name = "DolarCompra";
            this.DolarCompra.ReadOnly = true;
            // 
            // DolarVenta
            // 
            this.DolarVenta.DataPropertyName = "DolarVenta";
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.DolarVenta.DefaultCellStyle = dataGridViewCellStyle18;
            this.DolarVenta.HeaderText = "Venta";
            this.DolarVenta.MinimumWidth = 6;
            this.DolarVenta.Name = "DolarVenta";
            this.DolarVenta.ReadOnly = true;
            // 
            // DolarCompraLast
            // 
            this.DolarCompraLast.DataPropertyName = "DolarCompraLast";
            dataGridViewCellStyle19.Format = "C2";
            this.DolarCompraLast.DefaultCellStyle = dataGridViewCellStyle19;
            this.DolarCompraLast.HeaderText = "Compra Last";
            this.DolarCompraLast.MinimumWidth = 6;
            this.DolarCompraLast.Name = "DolarCompraLast";
            this.DolarCompraLast.ReadOnly = true;
            // 
            // DolarVentaLast
            // 
            this.DolarVentaLast.DataPropertyName = "DolarVentaLast";
            dataGridViewCellStyle20.Format = "C2";
            this.DolarVentaLast.DefaultCellStyle = dataGridViewCellStyle20;
            this.DolarVentaLast.HeaderText = "Venta Last";
            this.DolarVentaLast.MinimumWidth = 6;
            this.DolarVentaLast.Name = "DolarVentaLast";
            this.DolarVentaLast.ReadOnly = true;
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
            this.numMinProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // chkMEP
            // 
            this.chkMEP.AutoSize = true;
            this.chkMEP.Checked = true;
            this.chkMEP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMEP.Location = new System.Drawing.Point(249, 3);
            this.chkMEP.Name = "chkMEP";
            this.chkMEP.Size = new System.Drawing.Size(167, 21);
            this.chkMEP.TabIndex = 5;
            this.chkMEP.Text = "Arbitrajes MEP ($ / D)";
            this.chkMEP.UseVisualStyleBackColor = true;
            // 
            // chkCCL
            // 
            this.chkCCL.AutoSize = true;
            this.chkCCL.Checked = true;
            this.chkCCL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCCL.Location = new System.Drawing.Point(416, 4);
            this.chkCCL.Name = "chkCCL";
            this.chkCCL.Size = new System.Drawing.Size(163, 21);
            this.chkCCL.TabIndex = 6;
            this.chkCCL.Text = "Arbitrajes CCL (C / $)";
            this.chkCCL.UseVisualStyleBackColor = true;
            // 
            // chkDolarDC
            // 
            this.chkDolarDC.AutoSize = true;
            this.chkDolarDC.Location = new System.Drawing.Point(590, 4);
            this.chkDolarDC.Name = "chkDolarDC";
            this.chkDolarDC.Size = new System.Drawing.Size(125, 21);
            this.chkDolarDC.TabIndex = 7;
            this.chkDolarDC.Text = "Arbitrajes D / C";
            this.chkDolarDC.UseVisualStyleBackColor = true;
            // 
            // chkDolarCD
            // 
            this.chkDolarCD.AutoSize = true;
            this.chkDolarCD.Location = new System.Drawing.Point(721, 3);
            this.chkDolarCD.Name = "chkDolarCD";
            this.chkDolarCD.Size = new System.Drawing.Size(125, 21);
            this.chkDolarCD.TabIndex = 8;
            this.chkDolarCD.Text = "Arbitrajes C / D";
            this.chkDolarCD.UseVisualStyleBackColor = true;
            // 
            // FrmArbitrationAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 554);
            this.Controls.Add(this.chkDolarCD);
            this.Controls.Add(this.chkDolarDC);
            this.Controls.Add(this.chkCCL);
            this.Controls.Add(this.chkMEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinProfit);
            this.Controls.Add(this.grdArbitration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmArbitrationAnalyzer";
            this.Text = "Scanner de arbitrajes";
            this.Load += new System.EventHandler(this.FrmArbitrationBestTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown numMinProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMEP;
        private System.Windows.Forms.CheckBox chkCCL;
        private System.Windows.Forms.CheckBox chkDolarDC;
        private System.Windows.Forms.CheckBox chkDolarCD;
    }
}