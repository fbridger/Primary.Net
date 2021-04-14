namespace Primary.WinFormsApp
{
    partial class FrmArbitrationTrade
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
            this.txtOwnedVenta = new System.Windows.Forms.LinkLabel();
            this.lblOwnedVentaImporte = new System.Windows.Forms.Label();
            this.lblOwnedComision = new System.Windows.Forms.Label();
            this.numOwnedVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            this.txtArbitrationCompra = new System.Windows.Forms.LinkLabel();
            this.lblArbitrationCompraImporte = new System.Windows.Forms.Label();
            this.numArbitrationCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numArbitrationCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpArbitrationVenta = new System.Windows.Forms.GroupBox();
            this.txtArbitrationVenta = new System.Windows.Forms.LinkLabel();
            this.lblArbitrationVentaImporte = new System.Windows.Forms.Label();
            this.lblArbitrationComision = new System.Windows.Forms.Label();
            this.numArbitrationVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numArbitrationVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grpOwnedCompra = new System.Windows.Forms.GroupBox();
            this.txtOwnedCompra = new System.Windows.Forms.LinkLabel();
            this.lblOwnedCompraImporte = new System.Windows.Forms.Label();
            this.numOwnedCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numOwnedCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.lblOwnedLast = new System.Windows.Forms.Label();
            this.lblArbitrationLast = new System.Windows.Forms.Label();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArbitrationDiff = new System.Windows.Forms.Label();
            this.lblDolarSell = new System.Windows.Forms.Label();
            this.lblDolarBuy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numDolar = new System.Windows.Forms.NumericUpDown();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblProfitPesos = new System.Windows.Forms.Label();
            this.chkComprarNominales = new System.Windows.Forms.CheckBox();
            this.lnkArbitration = new System.Windows.Forms.LinkLabel();
            this.OwnedCompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.ArbitrationVentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.ArbitrationCompraBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.OwnedVentaBidsOffers = new Primary.WinFormsApp.BidsOffersControl();
            this.grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).BeginInit();
            this.grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraSize)).BeginInit();
            this.grpArbitrationVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaSize)).BeginInit();
            this.grpOwnedCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            this.grpOwnedVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOwnedVenta.Controls.Add(this.OwnedVentaBidsOffers);
            this.grpOwnedVenta.Controls.Add(this.txtOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedVentaImporte);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedComision);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaPrice);
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
            // lblOwnedVentaImporte
            // 
            this.lblOwnedVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedVentaImporte.Location = new System.Drawing.Point(11, 98);
            this.lblOwnedVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnedVentaImporte.Name = "lblOwnedVentaImporte";
            this.lblOwnedVentaImporte.Size = new System.Drawing.Size(245, 22);
            this.lblOwnedVentaImporte.TabIndex = 6;
            this.lblOwnedVentaImporte.Text = "Importe";
            this.lblOwnedVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwnedComision
            // 
            this.lblOwnedComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedComision.Location = new System.Drawing.Point(11, 121);
            this.lblOwnedComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnedComision.Name = "lblOwnedComision";
            this.lblOwnedComision.Size = new System.Drawing.Size(245, 22);
            this.lblOwnedComision.TabIndex = 5;
            this.lblOwnedComision.Text = "Comisión";
            this.lblOwnedComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedVentaPrice
            // 
            this.numOwnedVentaPrice.DecimalPlaces = 2;
            this.numOwnedVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numOwnedVentaPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numOwnedVentaPrice.Location = new System.Drawing.Point(149, 55);
            this.numOwnedVentaPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numOwnedVentaPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numOwnedVentaPrice.Name = "numOwnedVentaPrice";
            this.numOwnedVentaPrice.Size = new System.Drawing.Size(107, 22);
            this.numOwnedVentaPrice.TabIndex = 1;
            this.numOwnedVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedVentaPrice.ValueChanged += new System.EventHandler(this.numOwnedVentaPrice_ValueChanged);
            this.numOwnedVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedVentaPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "a U$S:";
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
            this.grpArbitrationCompra.Controls.Add(this.ArbitrationCompraBidsOffers);
            this.grpArbitrationCompra.Controls.Add(this.txtArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblArbitrationCompraImporte);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraPrice);
            this.grpArbitrationCompra.Controls.Add(this.label6);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraSize);
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
            // lblArbitrationCompraImporte
            // 
            this.lblArbitrationCompraImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArbitrationCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationCompraImporte.Location = new System.Drawing.Point(11, 98);
            this.lblArbitrationCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbitrationCompraImporte.Name = "lblArbitrationCompraImporte";
            this.lblArbitrationCompraImporte.Size = new System.Drawing.Size(245, 22);
            this.lblArbitrationCompraImporte.TabIndex = 6;
            this.lblArbitrationCompraImporte.Text = "Importe";
            this.lblArbitrationCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationCompraPrice
            // 
            this.numArbitrationCompraPrice.DecimalPlaces = 2;
            this.numArbitrationCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numArbitrationCompraPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numArbitrationCompraPrice.Location = new System.Drawing.Point(149, 55);
            this.numArbitrationCompraPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numArbitrationCompraPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numArbitrationCompraPrice.Name = "numArbitrationCompraPrice";
            this.numArbitrationCompraPrice.Size = new System.Drawing.Size(107, 22);
            this.numArbitrationCompraPrice.TabIndex = 1;
            this.numArbitrationCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationCompraPrice.ValueChanged += new System.EventHandler(this.numArbitrationCompraPrice_ValueChanged);
            this.numArbitrationCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationCompraPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "a U$S:";
            // 
            // numArbitrationCompraSize
            // 
            this.numArbitrationCompraSize.Location = new System.Drawing.Point(149, 23);
            this.numArbitrationCompraSize.Margin = new System.Windows.Forms.Padding(4);
            this.numArbitrationCompraSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numArbitrationCompraSize.Name = "numArbitrationCompraSize";
            this.numArbitrationCompraSize.Size = new System.Drawing.Size(107, 22);
            this.numArbitrationCompraSize.TabIndex = 0;
            this.numArbitrationCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationCompraSize.ValueChanged += new System.EventHandler(this.numArbitrationCompraSize_ValueChanged);
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
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpArbitrationVenta
            // 
            this.grpArbitrationVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpArbitrationVenta.Controls.Add(this.ArbitrationVentaBidsOffers);
            this.grpArbitrationVenta.Controls.Add(this.txtArbitrationVenta);
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationVentaImporte);
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationComision);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaPrice);
            this.grpArbitrationVenta.Controls.Add(this.label11);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaSize);
            this.grpArbitrationVenta.Controls.Add(this.label12);
            this.grpArbitrationVenta.Location = new System.Drawing.Point(11, 379);
            this.grpArbitrationVenta.Margin = new System.Windows.Forms.Padding(4);
            this.grpArbitrationVenta.Name = "grpArbitrationVenta";
            this.grpArbitrationVenta.Padding = new System.Windows.Forms.Padding(4);
            this.grpArbitrationVenta.Size = new System.Drawing.Size(727, 240);
            this.grpArbitrationVenta.TabIndex = 12;
            this.grpArbitrationVenta.TabStop = false;
            this.grpArbitrationVenta.Text = "3. Venta de Bono a Arbitrar";
            // 
            // txtArbitrationVenta
            // 
            this.txtArbitrationVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbitrationVenta.Location = new System.Drawing.Point(8, 207);
            this.txtArbitrationVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtArbitrationVenta.Name = "txtArbitrationVenta";
            this.txtArbitrationVenta.Size = new System.Drawing.Size(698, 30);
            this.txtArbitrationVenta.TabIndex = 12;
            this.txtArbitrationVenta.TabStop = true;
            this.txtArbitrationVenta.Text = "Copiar";
            this.txtArbitrationVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArbitrationVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArbitrationVenta_LinkClicked);
            // 
            // lblArbitrationVentaImporte
            // 
            this.lblArbitrationVentaImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationVentaImporte.Location = new System.Drawing.Point(20, 96);
            this.lblArbitrationVentaImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbitrationVentaImporte.Name = "lblArbitrationVentaImporte";
            this.lblArbitrationVentaImporte.Size = new System.Drawing.Size(236, 22);
            this.lblArbitrationVentaImporte.TabIndex = 6;
            this.lblArbitrationVentaImporte.Text = "Importe";
            this.lblArbitrationVentaImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblArbitrationComision
            // 
            this.lblArbitrationComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationComision.Location = new System.Drawing.Point(12, 118);
            this.lblArbitrationComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbitrationComision.Name = "lblArbitrationComision";
            this.lblArbitrationComision.Size = new System.Drawing.Size(244, 22);
            this.lblArbitrationComision.TabIndex = 5;
            this.lblArbitrationComision.Text = "Comisión";
            this.lblArbitrationComision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numArbitrationVentaPrice
            // 
            this.numArbitrationVentaPrice.DecimalPlaces = 2;
            this.numArbitrationVentaPrice.ForeColor = System.Drawing.Color.Red;
            this.numArbitrationVentaPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArbitrationVentaPrice.Location = new System.Drawing.Point(149, 55);
            this.numArbitrationVentaPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numArbitrationVentaPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numArbitrationVentaPrice.Name = "numArbitrationVentaPrice";
            this.numArbitrationVentaPrice.Size = new System.Drawing.Size(107, 22);
            this.numArbitrationVentaPrice.TabIndex = 1;
            this.numArbitrationVentaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numArbitrationVentaPrice.ValueChanged += new System.EventHandler(this.numArbitrationVentaPrice_ValueChanged);
            this.numArbitrationVentaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numArbitrationVentaPrice_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "a $:";
            // 
            // numArbitrationVentaSize
            // 
            this.numArbitrationVentaSize.Enabled = false;
            this.numArbitrationVentaSize.Location = new System.Drawing.Point(149, 23);
            this.numArbitrationVentaSize.Margin = new System.Windows.Forms.Padding(4);
            this.numArbitrationVentaSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numArbitrationVentaSize.Name = "numArbitrationVentaSize";
            this.numArbitrationVentaSize.Size = new System.Drawing.Size(107, 22);
            this.numArbitrationVentaSize.TabIndex = 0;
            this.numArbitrationVentaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cant. de nominales:";
            // 
            // grpOwnedCompra
            // 
            this.grpOwnedCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOwnedCompra.Controls.Add(this.OwnedCompraBidsOffers);
            this.grpOwnedCompra.Controls.Add(this.txtOwnedCompra);
            this.grpOwnedCompra.Controls.Add(this.lblOwnedCompraImporte);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraPrice);
            this.grpOwnedCompra.Controls.Add(this.label16);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraSize);
            this.grpOwnedCompra.Controls.Add(this.label17);
            this.grpOwnedCompra.Location = new System.Drawing.Point(767, 379);
            this.grpOwnedCompra.Margin = new System.Windows.Forms.Padding(4);
            this.grpOwnedCompra.Name = "grpOwnedCompra";
            this.grpOwnedCompra.Padding = new System.Windows.Forms.Padding(4);
            this.grpOwnedCompra.Size = new System.Drawing.Size(748, 240);
            this.grpOwnedCompra.TabIndex = 9;
            this.grpOwnedCompra.TabStop = false;
            this.grpOwnedCompra.Text = "4. Compra de Bono en Cartera";
            // 
            // txtOwnedCompra
            // 
            this.txtOwnedCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnedCompra.Location = new System.Drawing.Point(11, 207);
            this.txtOwnedCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOwnedCompra.Name = "txtOwnedCompra";
            this.txtOwnedCompra.Size = new System.Drawing.Size(719, 30);
            this.txtOwnedCompra.TabIndex = 13;
            this.txtOwnedCompra.TabStop = true;
            this.txtOwnedCompra.Text = "Copiar";
            this.txtOwnedCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOwnedCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtOwnedCompra_LinkClicked);
            // 
            // lblOwnedCompraImporte
            // 
            this.lblOwnedCompraImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedCompraImporte.Location = new System.Drawing.Point(16, 96);
            this.lblOwnedCompraImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnedCompraImporte.Name = "lblOwnedCompraImporte";
            this.lblOwnedCompraImporte.Size = new System.Drawing.Size(240, 22);
            this.lblOwnedCompraImporte.TabIndex = 6;
            this.lblOwnedCompraImporte.Text = "Importe";
            this.lblOwnedCompraImporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numOwnedCompraPrice
            // 
            this.numOwnedCompraPrice.DecimalPlaces = 2;
            this.numOwnedCompraPrice.ForeColor = System.Drawing.Color.Red;
            this.numOwnedCompraPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOwnedCompraPrice.Location = new System.Drawing.Point(149, 58);
            this.numOwnedCompraPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numOwnedCompraPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOwnedCompraPrice.Name = "numOwnedCompraPrice";
            this.numOwnedCompraPrice.Size = new System.Drawing.Size(107, 22);
            this.numOwnedCompraPrice.TabIndex = 1;
            this.numOwnedCompraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOwnedCompraPrice.ValueChanged += new System.EventHandler(this.numOwnedCompraPrice_ValueChanged);
            this.numOwnedCompraPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOwnedCompraPrice_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "a $:";
            // 
            // numOwnedCompraSize
            // 
            this.numOwnedCompraSize.Enabled = false;
            this.numOwnedCompraSize.Location = new System.Drawing.Point(149, 26);
            this.numOwnedCompraSize.Margin = new System.Windows.Forms.Padding(4);
            this.numOwnedCompraSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numOwnedCompraSize.Name = "numOwnedCompraSize";
            this.numOwnedCompraSize.Size = new System.Drawing.Size(107, 22);
            this.numOwnedCompraSize.TabIndex = 0;
            this.numOwnedCompraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 28);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cant. de nominales:";
            // 
            // lblOwnedLast
            // 
            this.lblOwnedLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOwnedLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedLast.Location = new System.Drawing.Point(589, 82);
            this.lblOwnedLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnedLast.Name = "lblOwnedLast";
            this.lblOwnedLast.Size = new System.Drawing.Size(127, 22);
            this.lblOwnedLast.TabIndex = 9;
            this.lblOwnedLast.Text = "$ Last";
            this.lblOwnedLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArbitrationLast
            // 
            this.lblArbitrationLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArbitrationLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationLast.Location = new System.Drawing.Point(812, 80);
            this.lblArbitrationLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbitrationLast.Name = "lblArbitrationLast";
            this.lblArbitrationLast.Size = new System.Drawing.Size(123, 28);
            this.lblArbitrationLast.TabIndex = 13;
            this.lblArbitrationLast.Text = "$ Last";
            this.lblArbitrationLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblProfit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblProfit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(0, 0);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(1527, 66);
            this.lblProfit.TabIndex = 11;
            this.lblProfit.Text = "Profit: $ / %";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblArbitrationDiff
            // 
            this.lblArbitrationDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArbitrationDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbitrationDiff.Location = new System.Drawing.Point(724, 82);
            this.lblArbitrationDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbitrationDiff.Name = "lblArbitrationDiff";
            this.lblArbitrationDiff.Size = new System.Drawing.Size(80, 22);
            this.lblArbitrationDiff.TabIndex = 16;
            this.lblArbitrationDiff.Text = "%";
            this.lblArbitrationDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDolarSell
            // 
            this.lblDolarSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDolarSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarSell.Location = new System.Drawing.Point(436, 82);
            this.lblDolarSell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarSell.Name = "lblDolarSell";
            this.lblDolarSell.Size = new System.Drawing.Size(145, 22);
            this.lblDolarSell.TabIndex = 17;
            this.lblDolarSell.Text = "Dolar Compra";
            this.lblDolarSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDolarBuy
            // 
            this.lblDolarBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDolarBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarBuy.Location = new System.Drawing.Point(943, 82);
            this.lblDolarBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolarBuy.Name = "lblDolarBuy";
            this.lblDolarBuy.Size = new System.Drawing.Size(139, 22);
            this.lblDolarBuy.TabIndex = 18;
            this.lblDolarBuy.Text = "Dolar Venta";
            this.lblDolarBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionTotal.Location = new System.Drawing.Point(389, 623);
            this.lblComisionTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(244, 22);
            this.lblComisionTotal.TabIndex = 12;
            this.lblComisionTotal.Text = "Total Comisión:";
            this.lblComisionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(641, 623);
            this.lblTotalProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(244, 22);
            this.lblTotalProfit.TabIndex = 21;
            this.lblTotalProfit.Text = "Total Ganancia:";
            this.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitPesos
            // 
            this.lblProfitPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPesos.Location = new System.Drawing.Point(893, 623);
            this.lblProfitPesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfitPesos.Name = "lblProfitPesos";
            this.lblProfitPesos.Size = new System.Drawing.Size(244, 22);
            this.lblProfitPesos.TabIndex = 22;
            this.lblProfitPesos.Text = "Total Ganancia:";
            this.lblProfitPesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkComprarNominales
            // 
            this.chkComprarNominales.AutoSize = true;
            this.chkComprarNominales.Location = new System.Drawing.Point(1196, 623);
            this.chkComprarNominales.Margin = new System.Windows.Forms.Padding(4);
            this.chkComprarNominales.Name = "chkComprarNominales";
            this.chkComprarNominales.Size = new System.Drawing.Size(319, 21);
            this.chkComprarNominales.TabIndex = 23;
            this.chkComprarNominales.Text = "Utilizar ganancia para obtener más nominales";
            this.chkComprarNominales.UseVisualStyleBackColor = true;
            this.chkComprarNominales.CheckedChanged += new System.EventHandler(this.chkComprarNominales_CheckedChanged);
            // 
            // lnkArbitration
            // 
            this.lnkArbitration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkArbitration.Location = new System.Drawing.Point(7, 80);
            this.lnkArbitration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkArbitration.Name = "lnkArbitration";
            this.lnkArbitration.Size = new System.Drawing.Size(453, 30);
            this.lnkArbitration.TabIndex = 14;
            this.lnkArbitration.TabStop = true;
            this.lnkArbitration.Text = "Copiar";
            this.lnkArbitration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArbitration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArbitration_LinkClicked);
            // 
            // OwnedCompraBidsOffers
            // 
            this.OwnedCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.OwnedCompraBidsOffers.IsPesos = true;
            this.OwnedCompraBidsOffers.Location = new System.Drawing.Point(263, 22);
            this.OwnedCompraBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OwnedCompraBidsOffers.Name = "OwnedCompraBidsOffers";
            this.OwnedCompraBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.OwnedCompraBidsOffers.TabIndex = 14;
            // 
            // ArbitrationVentaBidsOffers
            // 
            this.ArbitrationVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.ArbitrationVentaBidsOffers.IsPesos = true;
            this.ArbitrationVentaBidsOffers.Location = new System.Drawing.Point(263, 22);
            this.ArbitrationVentaBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArbitrationVentaBidsOffers.Name = "ArbitrationVentaBidsOffers";
            this.ArbitrationVentaBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.ArbitrationVentaBidsOffers.TabIndex = 13;
            // 
            // ArbitrationCompraBidsOffers
            // 
            this.ArbitrationCompraBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.ArbitrationCompraBidsOffers.IsPesos = true;
            this.ArbitrationCompraBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.ArbitrationCompraBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArbitrationCompraBidsOffers.Name = "ArbitrationCompraBidsOffers";
            this.ArbitrationCompraBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.ArbitrationCompraBidsOffers.TabIndex = 13;
            // 
            // OwnedVentaBidsOffers
            // 
            this.OwnedVentaBidsOffers.BackColor = System.Drawing.Color.Azure;
            this.OwnedVentaBidsOffers.IsPesos = true;
            this.OwnedVentaBidsOffers.Location = new System.Drawing.Point(263, 20);
            this.OwnedVentaBidsOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OwnedVentaBidsOffers.Name = "OwnedVentaBidsOffers";
            this.OwnedVentaBidsOffers.Size = new System.Drawing.Size(443, 180);
            this.OwnedVentaBidsOffers.TabIndex = 11;
            // 
            // FrmArbitrationTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 654);
            this.Controls.Add(this.lnkArbitration);
            this.Controls.Add(this.chkComprarNominales);
            this.Controls.Add(this.lblProfitPesos);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblComisionTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numDolar);
            this.Controls.Add(this.lblDolarBuy);
            this.Controls.Add(this.lblDolarSell);
            this.Controls.Add(this.lblArbitrationDiff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.lblArbitrationLast);
            this.Controls.Add(this.lblOwnedLast);
            this.Controls.Add(this.grpOwnedCompra);
            this.Controls.Add(this.grpArbitrationVenta);
            this.Controls.Add(this.grpArbitrationCompra);
            this.Controls.Add(this.grpOwnedVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArbitrationTrade";
            this.Text = "Operación de Arbitraje";
            this.Load += new System.EventHandler(this.FrmArbitrationTrade_Load);
            this.grpOwnedVenta.ResumeLayout(false);
            this.grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).EndInit();
            this.grpArbitrationCompra.ResumeLayout(false);
            this.grpArbitrationCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraSize)).EndInit();
            this.grpArbitrationVenta.ResumeLayout(false);
            this.grpArbitrationVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaSize)).EndInit();
            this.grpOwnedCompra.ResumeLayout(false);
            this.grpOwnedCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblOwnedVentaImporte;
        private System.Windows.Forms.Label lblOwnedComision;
        private System.Windows.Forms.NumericUpDown numOwnedVentaPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblArbitrationCompraImporte;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpArbitrationVenta;
        private System.Windows.Forms.Label lblArbitrationVentaImporte;
        private System.Windows.Forms.Label lblArbitrationComision;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpOwnedCompra;
        private System.Windows.Forms.Label lblOwnedCompraImporte;
        private System.Windows.Forms.NumericUpDown numOwnedCompraPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numOwnedCompraSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOwnedLast;
        private System.Windows.Forms.Label lblArbitrationLast;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArbitrationDiff;
        private System.Windows.Forms.Label lblDolarSell;
        private System.Windows.Forms.Label lblDolarBuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDolar;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblProfitPesos;
        private System.Windows.Forms.CheckBox chkComprarNominales;
        private System.Windows.Forms.LinkLabel txtOwnedVenta;
        private System.Windows.Forms.LinkLabel txtArbitrationCompra;
        private System.Windows.Forms.LinkLabel txtArbitrationVenta;
        private System.Windows.Forms.LinkLabel txtOwnedCompra;
        private BidsOffersControl OwnedVentaBidsOffers;
        private BidsOffersControl ArbitrationCompraBidsOffers;
        private BidsOffersControl ArbitrationVentaBidsOffers;
        private BidsOffersControl OwnedCompraBidsOffers;
        private System.Windows.Forms.LinkLabel lnkArbitration;
    }
}