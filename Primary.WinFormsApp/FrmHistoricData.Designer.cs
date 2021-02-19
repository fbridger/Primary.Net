namespace Primary.WinFormsApp
{
    partial class FrmHistoricData
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
            this.grdHistoricData = new System.Windows.Forms.DataGridView();
            this.cmbInstruments = new System.Windows.Forms.ComboBox();
            this.btnGetHistoricData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHistoricData
            // 
            this.grdHistoricData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistoricData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdHistoricData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistoricData.Location = new System.Drawing.Point(12, 40);
            this.grdHistoricData.Name = "grdHistoricData";
            this.grdHistoricData.Size = new System.Drawing.Size(776, 398);
            this.grdHistoricData.TabIndex = 0;
            this.grdHistoricData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbInstruments
            // 
            this.cmbInstruments.FormattingEnabled = true;
            this.cmbInstruments.Location = new System.Drawing.Point(12, 12);
            this.cmbInstruments.Name = "cmbInstruments";
            this.cmbInstruments.Size = new System.Drawing.Size(408, 21);
            this.cmbInstruments.TabIndex = 1;
            this.cmbInstruments.SelectedValueChanged += new System.EventHandler(this.cmbInstruments_SelectedValueChanged);
            // 
            // btnGetHistoricData
            // 
            this.btnGetHistoricData.Location = new System.Drawing.Point(426, 10);
            this.btnGetHistoricData.Name = "btnGetHistoricData";
            this.btnGetHistoricData.Size = new System.Drawing.Size(173, 23);
            this.btnGetHistoricData.TabIndex = 2;
            this.btnGetHistoricData.Text = "Obtener Datos";
            this.btnGetHistoricData.UseVisualStyleBackColor = true;
            this.btnGetHistoricData.Click += new System.EventHandler(this.btnGetHistoricData_Click);
            // 
            // FrmHistoricData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetHistoricData);
            this.Controls.Add(this.cmbInstruments);
            this.Controls.Add(this.grdHistoricData);
            this.Name = "FrmHistoricData";
            this.Text = "FrmHistoricData";
            this.Load += new System.EventHandler(this.FrmHistoricData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistoricData;
        private System.Windows.Forms.ComboBox cmbInstruments;
        private System.Windows.Forms.Button btnGetHistoricData;
    }
}