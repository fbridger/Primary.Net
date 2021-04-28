namespace Primary.WinFormsApp
{
    partial class FrmSettlementTermTrade
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
            this.grpOwnedVenta = new System.Windows.Forms.GroupBox();
            this.VentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            this.lblVentaImporte = new System.Windows.Forms.Label();
            this.lblVentaComision = new System.Windows.Forms.Label();
            this.numVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            this.CompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            this.lblCompraImporte = new System.Windows.Forms.Label();
            this.numCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numDolar = new System.Windows.Forms.NumericUpDown();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProfitPesos = new System.Windows.Forms.Label();
            this.lnkArbitration = new System.Windows.Forms.LinkLabel();
            this.lblCompraComision = new System.Windows.Forms.Label();
            this.grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).BeginInit();
            this.grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            this.grpOwnedVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOwnedVenta.Controls.Add(this.VentaBidsOffers);
            this.grpOwnedVenta.Controls.Add(this.txtOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.lblVentaImporte);
            this.grpOwnedVenta.Controls.Add(this.lblVentaComision);
            this.grpOwnedVenta.Controls.Add(this.numVentaPrice);
            this.grpOwnedVenta.Controls.Add(this.label2);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaSize);
            this.grpOwnedVenta.Controls.Add(this.label1);
            this.grpOwnedVenta.Location = new System.Drawing.Point(11, 119);
            this.grpOwnedVenta.Margin = new System.Windows.Forms.Padding(4);
            this.grpOwnedVenta.Name = "grpOwnedVenta";
            this.grpOwnedVenta.Padding = new System.Windows.Forms.Padding(4);
            this.grpOwnedVenta.Size = new System.Drawing.Size(727, 240);
            this.grpOwnedVenta.TabIndex = 1;
            this.grpOwnedVenta.TabStop = false;
            this.grpOwnedVenta.Text = "1. Venta de Bono en Cartera";
            // 
            // VentaBidsOffers
            // 
            this.VentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.VentaBidsOffers.IsPesos = true;
            this.VentaBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.VentaBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VentaBidsOffers.Name = "VentaBidsOffers";
            this.VentaBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.VentaBidsOffers.TabIndex = 11;
            // 
            // txtOwnedVenta
            // 
            this.txtOwnedVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnedVenta.Location = new System.Drawing.Point(8, 207);
            this.txtOwnedVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOwnedVenta.Name = "txtOwnedVenta";
            this.txtOwnedVenta.Size = new System.Drawing.Size(698, 30);
            this.txtOwnedVenta.TabIndex = 10;
            this.txtOwnedVenta.TabStop = true;
            this.txtOwnedVenta.Text = "Copiar";
            this.txtOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOwnedVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtOwnedVenta_LinkClicked);
            // 
            // lblVentaImporte
            // 
            this.lblVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaImporte.Location = new System.Drawing.Point(11, 98);
            this.lblVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentaImporte.Name = "lblVentaImporte";
            this.lblVentaImporte.Size = new System.Drawing.Size(245, 22);
            this.lblVentaImporte.TabIndex = 6;
            this.lblVentaImporte.Text = "Importe";
            this.lblVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwnedComision
            // 
            this.lblVentaComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaComision.Location = new System.Drawing.Point(11, 121);
            this.lblVentaComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentaComision.Name = "lblOwnedComision";
            this.lblVentaComision.Size = new System.Drawing.Size(245, 22);
            this.lblVentaComision.TabIndex = 5;
            this.lblVentaComision.Text = "Comisión";
            this.lblVentaComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numVentaPrice
            // 
            this.numVentaPrice.DecimalPlaces = 2;
            this.numVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numVentaPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVentaPrice.Location = new System.Drawing.Point(149, 55);
            this.numVentaPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numVentaPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVentaPrice.Name = "numVentaPrice";
            this.numVentaPrice.Size = new System.Drawing.Size(107, 22);
            this.numVentaPrice.TabIndex = 1;
            this.numVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVentaPrice.ValueChanged += new System.EventHandler(this.numOwnedVentaPrice_ValueChanged);
            this.numVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "a:";
            // 
            // numOwnedVentaSize
            // 
            this.numOwnedVentaSize.Location = new System.Drawing.Point(149, 23);
            this.numOwnedVentaSize.Margin = new System.Windows.Forms.Padding(4);
            this.numOwnedVentaSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numOwnedVentaSize.Name = "numOwnedVentaSize";
            this.numOwnedVentaSize.Size = new System.Drawing.Size(107, 22);
            this.numOwnedVentaSize.TabIndex = 0;
            this.numOwnedVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedVentaSize.ValueChanged += new System.EventHandler(this.numOwnedVentaSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. de nominales:";
            // 
            // grpArbitrationCompra
            // 
            this.grpArbitrationCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpArbitrationCompra.Controls.Add(this.lblCompraComision);
            this.grpArbitrationCompra.Controls.Add(this.CompraBidsOffers);
            this.grpArbitrationCompra.Controls.Add(this.txtArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblCompraImporte);
            this.grpArbitrationCompra.Controls.Add(this.numCompraPrice);
            this.grpArbitrationCompra.Controls.Add(this.label6);
            this.grpArbitrationCompra.Controls.Add(this.numCompraSize);
            this.grpArbitrationCompra.Controls.Add(this.label7);
            this.grpArbitrationCompra.Location = new System.Drawing.Point(767, 119);
            this.grpArbitrationCompra.Margin = new System.Windows.Forms.Padding(4);
            this.grpArbitrationCompra.Name = "grpArbitrationCompra";
            this.grpArbitrationCompra.Padding = new System.Windows.Forms.Padding(4);
            this.grpArbitrationCompra.Size = new System.Drawing.Size(748, 240);
            this.grpArbitrationCompra.TabIndex = 8;
            this.grpArbitrationCompra.TabStop = false;
            this.grpArbitrationCompra.Text = "2. Compra de Bono a Arbitrar";
            // 
            // CompraBidsOffers
            // 
            this.CompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.CompraBidsOffers.IsPesos = true;
            this.CompraBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.CompraBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompraBidsOffers.Name = "CompraBidsOffers";
            this.CompraBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.CompraBidsOffers.TabIndex = 13;
            // 
            // txtArbitrationCompra
            // 
            this.txtArbitrationCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbitrationCompra.Location = new System.Drawing.Point(8, 207);
            this.txtArbitrationCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtArbitrationCompra.Name = "txtArbitrationCompra";
            this.txtArbitrationCompra.Size = new System.Drawing.Size(719, 30);
            this.txtArbitrationCompra.TabIndex = 12;
            this.txtArbitrationCompra.TabStop = true;
            this.txtArbitrationCompra.Text = "Copiar";
            this.txtArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArbitrationCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArbitrationCompra_LinkClicked);
            // 
            // lblCompraImporte
            // 
            this.lblCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraImporte.Location = new System.Drawing.Point(11, 98);
            this.lblCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraImporte.Name = "lblCompraImporte";
            this.lblCompraImporte.Size = new System.Drawing.Size(245, 22);
            this.lblCompraImporte.TabIndex = 6;
            this.lblCompraImporte.Text = "Importe";
            this.lblCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCompraPrice
            // 
            this.numCompraPrice.DecimalPlaces = 2;
            this.numCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numCompraPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCompraPrice.Location = new System.Drawing.Point(149, 55);
            this.numCompraPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numCompraPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCompraPrice.Name = "numCompraPrice";
            this.numCompraPrice.Size = new System.Drawing.Size(107, 22);
            this.numCompraPrice.TabIndex = 1;
            this.numCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCompraPrice.ValueChanged += new System.EventHandler(this.numCompraPrice_ValueChanged);
            this.numCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationCompraPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "a:";
            // 
            // numCompraSize
            // 
            this.numCompraSize.Location = new System.Drawing.Point(149, 23);
            this.numCompraSize.Margin = new System.Windows.Forms.Padding(4);
            this.numCompraSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCompraSize.Name = "numCompraSize";
            this.numCompraSize.Size = new System.Drawing.Size(107, 22);
            this.numCompraSize.TabIndex = 0;
            this.numCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCompraSize.ValueChanged += new System.EventHandler(this.numCompraSize_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cant. de nominales:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numComision
            // 
            this.numComision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numComision.DecimalPlaces = 2;
            this.numComision.Location = new System.Drawing.Point(1404, 81);
            this.numComision.Margin = new System.Windows.Forms.Padding(4);
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(107, 22);
            this.numComision.TabIndex = 0;
            this.numComision.Value = new decimal(new int[] {
            27,
            0,
            0,
            131072});
            this.numComision.ValueChanged += new System.EventHandler(this.numComision_ValueChanged);
            // 
            // lblProfit
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblProfit";
            this.lblHeader.Size = new System.Drawing.Size(1527, 66);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Profit: $ / %";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(1285, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Comisión %:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(1084, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dolar $:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDolar
            // 
            this.numDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numDolar.DecimalPlaces = 2;
            this.numDolar.Location = new System.Drawing.Point(1171, 81);
            this.numDolar.Margin = new System.Windows.Forms.Padding(4);
            this.numDolar.Name = "numDolar";
            this.numDolar.Size = new System.Drawing.Size(107, 22);
            this.numDolar.TabIndex = 19;
            this.numDolar.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.numDolar.ValueChanged += new System.EventHandler(this.numDolar_ValueChanged);
            // 
            // lblComisionTotal
            // 
            this.lblComisionTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionTotal.Location = new System.Drawing.Point(389, 387);
            this.lblComisionTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(244, 22);
            this.lblComisionTotal.TabIndex = 12;
            this.lblComisionTotal.Text = "Total Comisión:";
            this.lblComisionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalProfit
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(641, 387);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotalProfit";
            this.lblTotal.Size = new System.Drawing.Size(244, 22);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Ganancia:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitPesos
            // 
            this.lblProfitPesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPesos.Location = new System.Drawing.Point(893, 387);
            this.lblProfitPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfitPesos.Name = "lblProfitPesos";
            this.lblProfitPesos.Size = new System.Drawing.Size(244, 22);
            this.lblProfitPesos.TabIndex = 22;
            this.lblProfitPesos.Text = "Total Ganancia:";
            this.lblProfitPesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkArbitration
            // 
            this.lnkArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkArbitration.Location = new System.Drawing.Point(7, -156);
            this.lnkArbitration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkArbitration.Name = "lnkArbitration";
            this.lnkArbitration.Size = new System.Drawing.Size(453, 30);
            this.lnkArbitration.TabIndex = 14;
            this.lnkArbitration.TabStop = true;
            this.lnkArbitration.Text = "Copiar";
            this.lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArbitration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArbitration_LinkClicked);
            // 
            // lblCompraComision
            // 
            this.lblCompraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraComision.Location = new System.Drawing.Point(11, 121);
            this.lblCompraComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraComision.Name = "lblCompraComision";
            this.lblCompraComision.Size = new System.Drawing.Size(245, 22);
            this.lblCompraComision.TabIndex = 14;
            this.lblCompraComision.Text = "Comisión";
            this.lblCompraComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSettlementTermTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 418);
            this.Controls.Add(this.lnkArbitration);
            this.Controls.Add(this.lblProfitPesos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblComisionTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.grpArbitrationCompra);
            this.Controls.Add(this.grpOwnedVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSettlementTermTrade";
            this.Text = "Operación de Arbitraje";
            this.Load += new System.EventHandler(this.FrmArbitrationTrade_Load);
            this.grpOwnedVenta.ResumeLayout(false);
            this.grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).EndInit();
            this.grpArbitrationCompra.ResumeLayout(false);
            this.grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblVentaImporte;
        private System.Windows.Forms.Label lblVentaComision;
        private System.Windows.Forms.NumericUpDown numVentaPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblCompraImporte;
        private System.Windows.Forms.NumericUpDown numCompraPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDolar;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProfitPesos;
        private System.Windows.Forms.LinkLabel txtOwnedVenta;
        private System.Windows.Forms.LinkLabel txtArbitrationCompra;
        private BidsOffersControl VentaBidsOffers;
        private BidsOffersControl CompraBidsOffers;
        private System.Windows.Forms.LinkLabel lnkArbitration;
        private System.Windows.Forms.Label lblCompraComision;
    }
}