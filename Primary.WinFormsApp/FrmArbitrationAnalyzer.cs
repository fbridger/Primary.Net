using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmArbitrationAnalyzer : Form
    {
        private DolarArbitrationProcessor _processor;
        private DataTable _dataTable;

        public FrmArbitrationAnalyzer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _processor.RefreshData();
                var trades = _processor.GetArbitrationTrades();

                var processedRows = new List<DataRow>();

                foreach (var bestTrade in trades)
                {
                    var ownedVenta = bestTrade.Owned.Dolar.Instrument.SymbolWithoutPrefix();
                    var arbitrationCompra = bestTrade.Arbitration.Dolar.Instrument.SymbolWithoutPrefix();
                    var arbitrationVenta = bestTrade.Arbitration.Pesos.Instrument.SymbolWithoutPrefix();
                    var ownedCompra = bestTrade.Owned.Pesos.Instrument.SymbolWithoutPrefix();

                    DataRow row;
                    var existingRow = _dataTable.Rows.Find(new[] { ownedVenta, arbitrationCompra, arbitrationVenta, ownedCompra });

                    if (existingRow != null)
                    {
                        row = existingRow;
                    }
                    else
                    {
                        row = _dataTable.NewRow();

                        row["KeyOwnedVenta"] = ownedVenta;
                        row["KeyArbitrationCompra"] = arbitrationCompra;
                        row["KeyArbitrationVenta"] = arbitrationVenta;
                        row["KeyOwnedCompra"] = ownedCompra;
                    }

                    row["Profit"] = bestTrade.Profit;
                    row["ProfitLast"] = bestTrade.ProfitLast;

                    row["OwnedVenta"] = bestTrade.Owned.Dolar.Data.HasBids() ? (object)bestTrade.Owned.Dolar.Data.Bids[0].Price : DBNull.Value;
                    row["ArbitrationCompra"] = bestTrade.Arbitration.Dolar.Data.HasOffers() ? (object)bestTrade.Arbitration.Dolar.Data.Offers[0].Price : DBNull.Value;
                    row["ArbitrationVenta"] = bestTrade.Arbitration.Pesos.Data.HasBids() ? (object)bestTrade.Arbitration.Pesos.Data.Bids[0].Price : DBNull.Value;
                    row["OwnedCompra"] = bestTrade.Owned.Pesos.Data.HasOffers() ? (object)bestTrade.Owned.Pesos.Data.Offers[0].Price : DBNull.Value;


                    row["DolarCompra"] = bestTrade.Owned.Compra;
                    row["DolarCompraLast"] = bestTrade.Owned.Last;
                    row["DolarVenta"] = bestTrade.Arbitration.Venta;
                    row["DolarVentaLast"] = bestTrade.Arbitration.Last;

                    row["DolarArbitrationTrade"] = bestTrade;

                    if (existingRow == null)
                    {
                        _dataTable.Rows.Add(row);
                    }
                    processedRows.Add(row);
                }

                var rowsToRemove = new List<DataRow>();
                foreach (DataRow dataRow in _dataTable.Rows)
                {
                    if (!processedRows.Contains(dataRow))
                    {
                        rowsToRemove.Add(dataRow);
                    }
                }
                foreach (var dataRow in rowsToRemove)
                {
                    _dataTable.Rows.Remove(dataRow);
                }


                //grdArbitration.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void FrmArbitrationBestTrades_Load(object sender, EventArgs e)
        {
            _processor = new DolarArbitrationProcessor();

            _processor.Init();

            _dataTable = new DataTable();
            var ownedVentaColumn = _dataTable.Columns.Add("KeyOwnedVenta", typeof(string));
            var arbitrationCompraColumn = _dataTable.Columns.Add("KeyArbitrationCompra", typeof(string));
            var arbitrationVentaColumn = _dataTable.Columns.Add("KeyArbitrationVenta", typeof(string));
            var ownedCompraColumn = _dataTable.Columns.Add("KeyOwnedCompra", typeof(string));

            _dataTable.PrimaryKey = new DataColumn[] { ownedVentaColumn, arbitrationCompraColumn, arbitrationVentaColumn, ownedCompraColumn };

            _dataTable.Columns.Add("Profit", typeof(decimal));
            _dataTable.Columns.Add("ProfitLast", typeof(decimal));

            _dataTable.Columns.Add("OwnedVenta", typeof(decimal));
            _dataTable.Columns.Add("ArbitrationCompra", typeof(decimal));
            _dataTable.Columns.Add("ArbitrationVenta", typeof(decimal));
            _dataTable.Columns.Add("OwnedCompra", typeof(decimal));

            _dataTable.Columns.Add("DolarCompra", typeof(decimal));
            _dataTable.Columns.Add("DolarCompraLast", typeof(decimal));
            _dataTable.Columns.Add("DolarVenta", typeof(decimal));
            _dataTable.Columns.Add("DolarVentaLast", typeof(decimal));

            _dataTable.Columns.Add("DolarArbitrationTrade", typeof(DolarArbitrationTrade));

            grdArbitration.MultiSelect = false;
            grdArbitration.AutoGenerateColumns = false;
            grdArbitration.DataSource = _dataTable;
        }

        private void grdArbitration_DoubleClick(object sender, EventArgs e)
        {
            var frm = new FrmArbitrationTrade();
            var trade = ((DataRowView)grdArbitration.SelectedRows[0].DataBoundItem).Row["DolarArbitrationTrade"] as DolarArbitrationTrade;
            frm.Init(trade);
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }
}
