using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmSettlementTermsAnalyzer : Form
    {
        private SettlementTermArbitrationProcessor _processor;
        private DataTable _dataTable;

        public FrmSettlementTermsAnalyzer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _processor.RefreshData();
                var minProfit = numMinProfit.Value / 100;
                var trades = _processor.GetSettlementTermTrades(minProfit);

                var processedRows = new List<DataRow>();

                foreach (var bestTrade in trades)
                {
                    var ownedVenta = bestTrade.Sell.Instrument.SymbolWithoutPrefix();
                    var arbitrationCompra = bestTrade.Buy.Instrument.SymbolWithoutPrefix();

                    DataRow row;
                    var existingRow = _dataTable.Rows.Find(new[] { ownedVenta, arbitrationCompra});

                    if (existingRow != null)
                    {
                        row = existingRow;
                    }
                    else
                    {
                        row = _dataTable.NewRow();

                        row["KeyVenta"] = ownedVenta;
                        row["KeyCompra"] = arbitrationCompra;
                    }

                    row["Profit"] = bestTrade.Profit;
                    row["ProfitLast"] = bestTrade.ProfitLast;

                    decimal sellTotal = bestTrade.SellPrice * numBuySellSize.Value / 100m;
                    row["SellTotal"] = sellTotal;
                    decimal buyTotal = bestTrade.BuyPrice * numBuySellSize.Value / 100m;
                    row["BuyTotal"] = buyTotal;
                    decimal comision = bestTrade.SellPrice * numBuySellSize.Value / 100m * numComision.Value / 100m;
                    row["Comision"] = comision;
                    decimal interes = buyTotal * (numTasa.Value / 100m * numDiasCaucion.Value / 365m);
                    decimal caucion = buyTotal * (numComisionCaucion.Value / 100m * numDiasCaucion.Value / 365m) * 1.21m; // +IVA
                    row["Caucion"] = caucion + interes;
                    row["ProfitCaucion"] = sellTotal - buyTotal - comision - caucion - interes;

                    row["Venta"] = bestTrade.Sell.Data.HasBids() ? (object)bestTrade.Sell.Data.Bids[0].Price : DBNull.Value;
                    row["Compra"] = bestTrade.Buy.Data.HasOffers() ? (object)bestTrade.Buy.Data.Offers[0].Price : DBNull.Value;
                    row["VentaLast"] = bestTrade.Sell.Data.HasLastPrice() ? (object)bestTrade.Sell.Data.Last.Price.Value : DBNull.Value;
                    row["CompraLast"] = bestTrade.Buy.Data.HasLastPrice() ? (object)bestTrade.Buy.Data.Last.Price.Value : DBNull.Value;

                    row["Trade"] = bestTrade;

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
            _processor = new SettlementTermArbitrationProcessor();

            _processor.Init();

            _dataTable = new DataTable();
            var ownedVentaColumn = _dataTable.Columns.Add("KeyVenta", typeof(string));
            var arbitrationCompraColumn = _dataTable.Columns.Add("KeyCompra", typeof(string));

            _dataTable.PrimaryKey = new DataColumn[] { ownedVentaColumn, arbitrationCompraColumn };

            _dataTable.Columns.Add("Profit", typeof(decimal));
            _dataTable.Columns.Add("ProfitLast", typeof(decimal));

            _dataTable.Columns.Add("SellTotal", typeof(decimal));
            _dataTable.Columns.Add("BuyTotal", typeof(decimal));
            _dataTable.Columns.Add("Comision", typeof(decimal));
            _dataTable.Columns.Add("Caucion", typeof(decimal));
            _dataTable.Columns.Add("ProfitCaucion", typeof(decimal));

            _dataTable.Columns.Add("Venta", typeof(decimal));
            _dataTable.Columns.Add("Compra", typeof(decimal));

            
            _dataTable.Columns.Add("CompraLast", typeof(decimal));
            _dataTable.Columns.Add("VentaLast", typeof(decimal));

            _dataTable.Columns.Add("Trade", typeof(SettlementTermTrade));

            grdArbitration.MultiSelect = false;
            grdArbitration.AutoGenerateColumns = false;
            grdArbitration.DataSource = _dataTable;

            numMinProfit.Increment = 0.25m;
            numMinProfit.Minimum = -10m;
        }

        private void grdArbitration_DoubleClick(object sender, EventArgs e)
        {
            /*var frm = new FrmArbitrationTrade();
            var trade = ((DataRowView)grdArbitration.SelectedRows[0].DataBoundItem).Row["DolarArbitrationTrade"] as DolarArbitrationTrade;
            frm.Init(trade);
            frm.MdiParent = MdiParent;
            frm.Show();*/
        }
    }
}
