using Primary.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class FrmDolarArbitration : Form
    {
        private ConcurrentDictionary<string, Entries> instrumentsData = new ConcurrentDictionary<string, Entries>();
        private DataTable dataTable;

        public FrmDolarArbitration()
        {
            InitializeComponent();
        }

        public void OnMarketData(Instrument instrument, Entries data)
        {
            try
            {
                instrumentsData.AddOrUpdate(instrument.Symbol, data, (key, oldEntries) => data);

                lock (dataTable)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        bool updateMEP = false;
                        bool updateCCL = false;

                        bool updateMEPBook = false;
                        bool updateCCLBook = false;

                        if (data.Last != null)
                        {
                            if (instrument.Symbol.Equals(row["TickerPesos"]))
                            {
                                if (!data.Last.Price.Value.Equals(row["Pesos"]))
                                {
                                    row["Pesos"] = data.Last.Price.Value;
                                    updateMEP = updateCCL = true;
                                }

                                var bookPesos = GetBookString(data);

                                if (!bookPesos.Equals(row["BookPesos"]))
                                {
                                    row["BookPesos"] = bookPesos;
                                    updateMEPBook = updateCCLBook = true;
                                    if (data.HasOffers())
                                    {
                                        row["BookPesosVenta"] = data.Offers[0].Price;
                                    }
                                    if (data.HasBids())
                                    {
                                        row["BookPesosCompra"] = data.Bids[0].Price;
                                    }
                                }
                            }
                            else if (instrument.Symbol.Equals(row["TickerDolar"]))
                            {
                                if (!data.Last.Price.Value.Equals(row["Dolar"]))
                                {
                                    row["Dolar"] = data.Last.Price.Value;
                                    updateMEP = true;
                                }

                                var bookDolar = GetBookString(data);

                                if (!bookDolar.Equals(row["BookDolar"]))
                                {
                                    row["BookDolar"] = bookDolar;
                                    updateMEPBook = true;
                                    if (data.HasOffers())
                                    {
                                        row["BookDolarVenta"] = data.Offers[0].Price;
                                    }
                                    if (data.HasBids())
                                    {
                                        row["BookDolarCompra"] = data.Bids[0].Price;
                                    }
                                }
                            }
                            else if (instrument.Symbol.Equals(row["TickerCable"]))
                            {
                                if (!data.Last.Price.Value.Equals(row["Cable"]))
                                {
                                    row["Cable"] = data.Last.Price.Value;
                                    updateCCL = true;
                                }

                                var bookCable = GetBookString(data);

                                if (!bookCable.Equals(row["BookCable"]))
                                {
                                    row["BookCable"] = bookCable;
                                    updateCCLBook = true;
                                    if (data.HasOffers())
                                    {
                                        row["BookCableVenta"] = data.Offers[0].Price;
                                    }
                                    if (data.HasBids())
                                    {
                                        row["BookCableCompra"] = data.Bids[0].Price;
                                    }
                                }
                            }

                            if ((updateMEP || updateCCL) && row["Pesos"] is decimal pesos)
                            {
                                if (updateMEP && row["Dolar"] is decimal dolar)
                                {
                                    row["MEP"] = pesos / dolar;
                                }

                                if (updateCCL && row["Cable"] is decimal cable)
                                {
                                    row["CCL"] = pesos / cable;
                                }
                            }

                            if (updateMEPBook)
                            {
                                if (row["BookPesosCompra"] is decimal pesosCompra && row["BookDolarVenta"] is decimal dolarVenta)
                                {
                                    row["MEPCompra"] = pesosCompra / dolarVenta;
                                }

                                if (row["BookPesosVenta"] is decimal pesosVenta && row["BookDolarCompra"] is decimal dolarCompra)
                                {
                                    row["MEPVenta"] = pesosVenta / dolarCompra;
                                }
                            }

                            if (updateCCLBook)
                            {
                                if (row["BookPesosCompra"] is decimal pesosCompra && row["BookCableVenta"] is decimal dolarVenta)
                                {
                                    row["CCLCompra"] = pesosCompra / dolarVenta;
                                }

                                if (row["BookPesosVenta"] is decimal pesosVenta && row["BookCableCompra"] is decimal dolarCompra)
                                {
                                    row["CCLVenta"] = pesosVenta / dolarCompra;
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetBookString(Entries data)
        {
            var bid = "";

            if (data.Bids != null && data.Bids.Length > 0)
            {
                bid = $"{data.Bids[0].Size} {data.Bids[0].Price:C2}";
            }

            var offer = "";

            if (data.Offers != null && data.Offers.Length > 0)
            {
                offer = $"{data.Offers[0].Size} {data.Offers[0].Price:C2}";
            }

            return bid + " / " + offer;
        }

        internal void InitData()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Ticker", typeof(string));
            dataTable.Columns.Add("TickerPesos", typeof(string));
            dataTable.Columns.Add("TickerDolar", typeof(string));
            dataTable.Columns.Add("TickerCable", typeof(string));
            
            dataTable.Columns.Add("Pesos", typeof(decimal));
            dataTable.Columns.Add("Dolar", typeof(decimal));
            dataTable.Columns.Add("Cable", typeof(decimal));

            dataTable.Columns.Add("MEP", typeof(decimal));
            dataTable.Columns.Add("CCL", typeof(decimal));

            dataTable.Columns.Add("MEPCompra", typeof(decimal));
            dataTable.Columns.Add("MEPVenta", typeof(decimal));
            dataTable.Columns.Add("CCLCompra", typeof(decimal));
            dataTable.Columns.Add("CCLVenta", typeof(decimal));


            dataTable.Columns.Add("BookPesos", typeof(string));
            dataTable.Columns.Add("BookDolar", typeof(string));
            dataTable.Columns.Add("BookCable", typeof(string));



            dataTable.Columns.Add("BookPesosCompra", typeof(decimal));
            dataTable.Columns.Add("BookDolarCompra", typeof(decimal));
            dataTable.Columns.Add("BookCableCompra", typeof(decimal));

            dataTable.Columns.Add("BookPesosVenta", typeof(decimal));
            dataTable.Columns.Add("BookDolarVenta", typeof(decimal));
            dataTable.Columns.Add("BookCableVenta", typeof(decimal));

            foreach (var symbol in Properties.Settings.Default.ArbitrationTickers)
            {
                for (int i = 0; i < StringExtensions.AllSettlements.Length; i++)
                {
                    var settlementI = StringExtensions.AllSettlements[i];

                    for (int j = 0; j < StringExtensions.AllSettlements.Length; j++)
                    {
                        var settlementJ = StringExtensions.AllSettlements[j];

                        var row = dataTable.NewRow();

                        row["Ticker"] = $"{symbol} {settlementI} / {settlementJ}";
                        row["TickerPesos"] = symbol.ToMervalSymbol(settlementJ);
                        row["TickerDolar"] = symbol.AddDolarSuffix().ToMervalSymbol(settlementI);
                        row["TickerCable"] = symbol.AddCableSuffix().ToMervalSymbol(settlementI);

                        dataTable.Rows.Add(row);

                    }
                }
            }

            grdArbitration.DataSource = dataTable;
        }
    }
}
