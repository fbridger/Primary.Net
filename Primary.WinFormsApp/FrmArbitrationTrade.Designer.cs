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
            this.label1 = new System.Windows.Forms.Label();
            this.numOwnedVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numOwnedVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.lblOwnedComision = new System.Windows.Forms.Label();
            this.lblOwnedVentaTotal = new System.Windows.Forms.Label();
            this.lblBookOwnedVenta = new System.Windows.Forms.Label();
            this.grpArbitrationCompra = new System.Windows.Forms.GroupBox();
            this.lblBookArbitrationCompra = new System.Windows.Forms.Label();
            this.lblArbitrationCompraTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numArbitrationCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numArbitrationCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpArbitrationVenta = new System.Windows.Forms.GroupBox();
            this.lblBookArbitrationVenta = new System.Windows.Forms.Label();
            this.lblArbitrationVentaTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numArbitrationVentaPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numArbitrationVentaSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grpOwnedCompra = new System.Windows.Forms.GroupBox();
            this.lblBookOwnedCompra = new System.Windows.Forms.Label();
            this.lblOwnedCompraTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numOwnedCompraPrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numOwnedCompraSize = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.lblOwnedVentaLast = new System.Windows.Forms.Label();
            this.lblArbitrationCompraLast = new System.Windows.Forms.Label();
            this.lblArbitrationVentaLast = new System.Windows.Forms.Label();
            this.lblOwnedCompraLast = new System.Windows.Forms.Label();
            this.lblOwnedLast = new System.Windows.Forms.Label();
            this.lblArbitrationLast = new System.Windows.Forms.Label();
            this.grpOwnedVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).BeginInit();
            this.grpArbitrationCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationCompraSize)).BeginInit();
            this.grpArbitrationVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArbitrationVentaSize)).BeginInit();
            this.grpOwnedCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedCompraSize)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOwnedVenta
            // 
            this.grpOwnedVenta.Controls.Add(this.lblOwnedVentaLast);
            this.grpOwnedVenta.Controls.Add(this.lblBookOwnedVenta);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedVentaTotal);
            this.grpOwnedVenta.Controls.Add(this.lblOwnedComision);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaPrice);
            this.grpOwnedVenta.Controls.Add(this.label2);
            this.grpOwnedVenta.Controls.Add(this.numOwnedVentaSize);
            this.grpOwnedVenta.Controls.Add(this.label1);
            this.grpOwnedVenta.Location = new System.Drawing.Point(12, 12);
            this.grpOwnedVenta.Name = "grpOwnedVenta";
            this.grpOwnedVenta.Size = new System.Drawing.Size(631, 72);
            this.grpOwnedVenta.TabIndex = 1;
            this.grpOwnedVenta.TabStop = false;
            this.grpOwnedVenta.Text = "Venta de Bono en Cartera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. de nominales a vender:";
            // 
            // numOwnedVentaSize
            // 
            this.numOwnedVentaSize.Location = new System.Drawing.Point(162, 19);
            this.numOwnedVentaSize.Name = "numOwnedVentaSize";
            this.numOwnedVentaSize.Size = new System.Drawing.Size(80, 20);
            this.numOwnedVentaSize.TabIndex = 2;
            this.numOwnedVentaSize.ValueChanged += new System.EventHandler(this.numOwnedVentaSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a U$S:";
            // 
            // numOwnedVentaPrice
            // 
            this.numOwnedVentaPrice.DecimalPlaces = 2;
            this.numOwnedVentaPrice.Location = new System.Drawing.Point(294, 19);
            this.numOwnedVentaPrice.Name = "numOwnedVentaPrice";
            this.numOwnedVentaPrice.Size = new System.Drawing.Size(80, 20);
            this.numOwnedVentaPrice.TabIndex = 4;
            this.numOwnedVentaPrice.ValueChanged += new System.EventHandler(this.numOwnedVentaPrice_ValueChanged);
            // 
            // lblOwnedComision
            // 
            this.lblOwnedComision.Location = new System.Drawing.Point(6, 42);
            this.lblOwnedComision.Name = "lblOwnedComision";
            this.lblOwnedComision.Size = new System.Drawing.Size(106, 18);
            this.lblOwnedComision.TabIndex = 5;
            this.lblOwnedComision.Text = "Comisión";
            // 
            // lblOwnedVentaTotal
            // 
            this.lblOwnedVentaTotal.Location = new System.Drawing.Point(162, 42);
            this.lblOwnedVentaTotal.Name = "lblOwnedVentaTotal";
            this.lblOwnedVentaTotal.Size = new System.Drawing.Size(106, 18);
            this.lblOwnedVentaTotal.TabIndex = 6;
            this.lblOwnedVentaTotal.Text = "Total";
            // 
            // lblBookOwnedVenta
            // 
            this.lblBookOwnedVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookOwnedVenta.BackColor = System.Drawing.SystemColors.Info;
            this.lblBookOwnedVenta.Location = new System.Drawing.Point(386, 19);
            this.lblBookOwnedVenta.Name = "lblBookOwnedVenta";
            this.lblBookOwnedVenta.Size = new System.Drawing.Size(239, 41);
            this.lblBookOwnedVenta.TabIndex = 7;
            this.lblBookOwnedVenta.Text = "Book Size";
            this.lblBookOwnedVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpArbitrationCompra
            // 
            this.grpArbitrationCompra.Controls.Add(this.lblArbitrationCompraLast);
            this.grpArbitrationCompra.Controls.Add(this.lblBookArbitrationCompra);
            this.grpArbitrationCompra.Controls.Add(this.lblArbitrationCompraTotal);
            this.grpArbitrationCompra.Controls.Add(this.label5);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraPrice);
            this.grpArbitrationCompra.Controls.Add(this.label6);
            this.grpArbitrationCompra.Controls.Add(this.numArbitrationCompraSize);
            this.grpArbitrationCompra.Controls.Add(this.label7);
            this.grpArbitrationCompra.Location = new System.Drawing.Point(12, 90);
            this.grpArbitrationCompra.Name = "grpArbitrationCompra";
            this.grpArbitrationCompra.Size = new System.Drawing.Size(631, 72);
            this.grpArbitrationCompra.TabIndex = 8;
            this.grpArbitrationCompra.TabStop = false;
            this.grpArbitrationCompra.Text = "Compra de Bono a Arbitrar";
            // 
            // lblBookArbitrationCompra
            // 
            this.lblBookArbitrationCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookArbitrationCompra.BackColor = System.Drawing.SystemColors.Info;
            this.lblBookArbitrationCompra.Location = new System.Drawing.Point(386, 19);
            this.lblBookArbitrationCompra.Name = "lblBookArbitrationCompra";
            this.lblBookArbitrationCompra.Size = new System.Drawing.Size(239, 41);
            this.lblBookArbitrationCompra.TabIndex = 7;
            this.lblBookArbitrationCompra.Text = "Book Size";
            this.lblBookArbitrationCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArbitrationCompraTotal
            // 
            this.lblArbitrationCompraTotal.Location = new System.Drawing.Point(159, 42);
            this.lblArbitrationCompraTotal.Name = "lblArbitrationCompraTotal";
            this.lblArbitrationCompraTotal.Size = new System.Drawing.Size(106, 18);
            this.lblArbitrationCompraTotal.TabIndex = 6;
            this.lblArbitrationCompraTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comisión";
            // 
            // numArbitrationCompraPrice
            // 
            this.numArbitrationCompraPrice.DecimalPlaces = 2;
            this.numArbitrationCompraPrice.Location = new System.Drawing.Point(294, 19);
            this.numArbitrationCompraPrice.Name = "numArbitrationCompraPrice";
            this.numArbitrationCompraPrice.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationCompraPrice.TabIndex = 4;
            this.numArbitrationCompraPrice.ValueChanged += new System.EventHandler(this.numArbitrationCompraPrice_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "a U$S:";
            // 
            // numArbitrationCompraSize
            // 
            this.numArbitrationCompraSize.Location = new System.Drawing.Point(162, 19);
            this.numArbitrationCompraSize.Name = "numArbitrationCompraSize";
            this.numArbitrationCompraSize.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationCompraSize.TabIndex = 2;
            this.numArbitrationCompraSize.ValueChanged += new System.EventHandler(this.numArbitrationCompraSize_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cant. de nominales a vender:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpArbitrationVenta
            // 
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationVentaLast);
            this.grpArbitrationVenta.Controls.Add(this.lblBookArbitrationVenta);
            this.grpArbitrationVenta.Controls.Add(this.lblArbitrationVentaTotal);
            this.grpArbitrationVenta.Controls.Add(this.label10);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaPrice);
            this.grpArbitrationVenta.Controls.Add(this.label11);
            this.grpArbitrationVenta.Controls.Add(this.numArbitrationVentaSize);
            this.grpArbitrationVenta.Controls.Add(this.label12);
            this.grpArbitrationVenta.Location = new System.Drawing.Point(12, 168);
            this.grpArbitrationVenta.Name = "grpArbitrationVenta";
            this.grpArbitrationVenta.Size = new System.Drawing.Size(631, 72);
            this.grpArbitrationVenta.TabIndex = 12;
            this.grpArbitrationVenta.TabStop = false;
            this.grpArbitrationVenta.Text = "Venta de Bono a Arbitrar";
            // 
            // lblBookArbitrationVenta
            // 
            this.lblBookArbitrationVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookArbitrationVenta.BackColor = System.Drawing.SystemColors.Info;
            this.lblBookArbitrationVenta.Location = new System.Drawing.Point(386, 19);
            this.lblBookArbitrationVenta.Name = "lblBookArbitrationVenta";
            this.lblBookArbitrationVenta.Size = new System.Drawing.Size(239, 41);
            this.lblBookArbitrationVenta.TabIndex = 7;
            this.lblBookArbitrationVenta.Text = "Book Size";
            this.lblBookArbitrationVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArbitrationVentaTotal
            // 
            this.lblArbitrationVentaTotal.Location = new System.Drawing.Point(159, 42);
            this.lblArbitrationVentaTotal.Name = "lblArbitrationVentaTotal";
            this.lblArbitrationVentaTotal.Size = new System.Drawing.Size(106, 18);
            this.lblArbitrationVentaTotal.TabIndex = 6;
            this.lblArbitrationVentaTotal.Text = "Total";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Comisión";
            // 
            // numArbitrationVentaPrice
            // 
            this.numArbitrationVentaPrice.DecimalPlaces = 2;
            this.numArbitrationVentaPrice.Location = new System.Drawing.Point(294, 19);
            this.numArbitrationVentaPrice.Name = "numArbitrationVentaPrice";
            this.numArbitrationVentaPrice.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationVentaPrice.TabIndex = 4;
            this.numArbitrationVentaPrice.ValueChanged += new System.EventHandler(this.numArbitrationVentaPrice_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "a U$S:";
            // 
            // numArbitrationVentaSize
            // 
            this.numArbitrationVentaSize.Location = new System.Drawing.Point(162, 19);
            this.numArbitrationVentaSize.Name = "numArbitrationVentaSize";
            this.numArbitrationVentaSize.Size = new System.Drawing.Size(80, 20);
            this.numArbitrationVentaSize.TabIndex = 2;
            this.numArbitrationVentaSize.ValueChanged += new System.EventHandler(this.numArbitrationVentaSize_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cant. de nominales a vender:";
            // 
            // grpOwnedCompra
            // 
            this.grpOwnedCompra.Controls.Add(this.lblOwnedCompraLast);
            this.grpOwnedCompra.Controls.Add(this.lblBookOwnedCompra);
            this.grpOwnedCompra.Controls.Add(this.lblOwnedCompraTotal);
            this.grpOwnedCompra.Controls.Add(this.label15);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraPrice);
            this.grpOwnedCompra.Controls.Add(this.label16);
            this.grpOwnedCompra.Controls.Add(this.numOwnedCompraSize);
            this.grpOwnedCompra.Controls.Add(this.label17);
            this.grpOwnedCompra.Location = new System.Drawing.Point(12, 246);
            this.grpOwnedCompra.Name = "grpOwnedCompra";
            this.grpOwnedCompra.Size = new System.Drawing.Size(631, 72);
            this.grpOwnedCompra.TabIndex = 9;
            this.grpOwnedCompra.TabStop = false;
            this.grpOwnedCompra.Text = "Compra de Bono en Cartera";
            // 
            // lblBookOwnedCompra
            // 
            this.lblBookOwnedCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookOwnedCompra.BackColor = System.Drawing.SystemColors.Info;
            this.lblBookOwnedCompra.Location = new System.Drawing.Point(386, 19);
            this.lblBookOwnedCompra.Name = "lblBookOwnedCompra";
            this.lblBookOwnedCompra.Size = new System.Drawing.Size(239, 41);
            this.lblBookOwnedCompra.TabIndex = 7;
            this.lblBookOwnedCompra.Text = "Book Size";
            this.lblBookOwnedCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOwnedCompraTotal
            // 
            this.lblOwnedCompraTotal.Location = new System.Drawing.Point(159, 42);
            this.lblOwnedCompraTotal.Name = "lblOwnedCompraTotal";
            this.lblOwnedCompraTotal.Size = new System.Drawing.Size(106, 18);
            this.lblOwnedCompraTotal.TabIndex = 6;
            this.lblOwnedCompraTotal.Text = "Total";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Comisión";
            // 
            // numOwnedCompraPrice
            // 
            this.numOwnedCompraPrice.DecimalPlaces = 2;
            this.numOwnedCompraPrice.Location = new System.Drawing.Point(294, 19);
            this.numOwnedCompraPrice.Name = "numOwnedCompraPrice";
            this.numOwnedCompraPrice.Size = new System.Drawing.Size(80, 20);
            this.numOwnedCompraPrice.TabIndex = 4;
            this.numOwnedCompraPrice.ValueChanged += new System.EventHandler(this.numOwnedCompraPrice_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "a U$S:";
            // 
            // numOwnedCompraSize
            // 
            this.numOwnedCompraSize.Location = new System.Drawing.Point(162, 19);
            this.numOwnedCompraSize.Name = "numOwnedCompraSize";
            this.numOwnedCompraSize.Size = new System.Drawing.Size(80, 20);
            this.numOwnedCompraSize.TabIndex = 2;
            this.numOwnedCompraSize.ValueChanged += new System.EventHandler(this.numOwnedCompraSize_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cant. de nominales a vender:";
            // 
            // lblOwnedVentaLast
            // 
            this.lblOwnedVentaLast.Location = new System.Drawing.Point(291, 42);
            this.lblOwnedVentaLast.Name = "lblOwnedVentaLast";
            this.lblOwnedVentaLast.Size = new System.Drawing.Size(83, 18);
            this.lblOwnedVentaLast.TabIndex = 8;
            this.lblOwnedVentaLast.Text = "$ Last";
            // 
            // lblArbitrationCompraLast
            // 
            this.lblArbitrationCompraLast.Location = new System.Drawing.Point(291, 42);
            this.lblArbitrationCompraLast.Name = "lblArbitrationCompraLast";
            this.lblArbitrationCompraLast.Size = new System.Drawing.Size(83, 18);
            this.lblArbitrationCompraLast.TabIndex = 10;
            this.lblArbitrationCompraLast.Text = "$ Last";
            // 
            // lblArbitrationVentaLast
            // 
            this.lblArbitrationVentaLast.Location = new System.Drawing.Point(291, 42);
            this.lblArbitrationVentaLast.Name = "lblArbitrationVentaLast";
            this.lblArbitrationVentaLast.Size = new System.Drawing.Size(83, 18);
            this.lblArbitrationVentaLast.TabIndex = 10;
            this.lblArbitrationVentaLast.Text = "$ Last";
            // 
            // lblOwnedCompraLast
            // 
            this.lblOwnedCompraLast.Location = new System.Drawing.Point(291, 42);
            this.lblOwnedCompraLast.Name = "lblOwnedCompraLast";
            this.lblOwnedCompraLast.Size = new System.Drawing.Size(83, 18);
            this.lblOwnedCompraLast.TabIndex = 11;
            this.lblOwnedCompraLast.Text = "$ Last";
            // 
            // lblOwnedLast
            // 
            this.lblOwnedLast.Location = new System.Drawing.Point(145, 321);
            this.lblOwnedLast.Name = "lblOwnedLast";
            this.lblOwnedLast.Size = new System.Drawing.Size(83, 18);
            this.lblOwnedLast.TabIndex = 9;
            this.lblOwnedLast.Text = "$ Last";
            // 
            // lblArbitrationLast
            // 
            this.lblArbitrationLast.Location = new System.Drawing.Point(417, 321);
            this.lblArbitrationLast.Name = "lblArbitrationLast";
            this.lblArbitrationLast.Size = new System.Drawing.Size(83, 18);
            this.lblArbitrationLast.TabIndex = 13;
            this.lblArbitrationLast.Text = "$ Last";
            // 
            // FrmArbitrationTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArbitrationLast);
            this.Controls.Add(this.lblOwnedLast);
            this.Controls.Add(this.grpOwnedCompra);
            this.Controls.Add(this.grpArbitrationVenta);
            this.Controls.Add(this.grpArbitrationCompra);
            this.Controls.Add(this.grpOwnedVenta);
            this.Name = "FrmArbitrationTrade";
            this.Text = "FrmArbitrationTrade";
            this.Load += new System.EventHandler(this.FrmArbitrationTrade_Load);
            this.grpOwnedVenta.ResumeLayout(false);
            this.grpOwnedVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOwnedVentaPrice)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnedVenta;
        private System.Windows.Forms.Label lblBookOwnedVenta;
        private System.Windows.Forms.Label lblOwnedVentaTotal;
        private System.Windows.Forms.Label lblOwnedComision;
        private System.Windows.Forms.NumericUpDown numOwnedVentaPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOwnedVentaSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArbitrationCompra;
        private System.Windows.Forms.Label lblBookArbitrationCompra;
        private System.Windows.Forms.Label lblArbitrationCompraTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numArbitrationCompraSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOwnedVentaLast;
        private System.Windows.Forms.Label lblArbitrationCompraLast;
        private System.Windows.Forms.GroupBox grpArbitrationVenta;
        private System.Windows.Forms.Label lblArbitrationVentaLast;
        private System.Windows.Forms.Label lblBookArbitrationVenta;
        private System.Windows.Forms.Label lblArbitrationVentaTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numArbitrationVentaSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpOwnedCompra;
        private System.Windows.Forms.Label lblOwnedCompraLast;
        private System.Windows.Forms.Label lblBookOwnedCompra;
        private System.Windows.Forms.Label lblOwnedCompraTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numOwnedCompraPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numOwnedCompraSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOwnedLast;
        private System.Windows.Forms.Label lblArbitrationLast;
    }
}