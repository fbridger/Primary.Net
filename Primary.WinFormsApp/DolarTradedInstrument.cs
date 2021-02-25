using Primary.Data;
using System.Collections.Generic;
using System.Linq;

namespace Primary.WinFormsApp
{
    /// <summary>
    /// Permite construir a partir de un Ticker en Pesos (ej. AL30) los diferentes plazos de liquidación y dolar (D y C) en los que se puede operar
    /// </summary>
    public class DolarTradedInstrument
    {
        public DolarTradedInstrument(string ticker)
        {
            Ticker = ticker;

            Pesos48 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbol48H()));
            Pesos24 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbol24H()));
            PesosCI = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.ToMervalSymbolCI()));

            Dolar48 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddDolarSuffix().ToMervalSymbol48H()));
            Dolar24 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddDolarSuffix().ToMervalSymbol24H()));
            DolarCI = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddDolarSuffix().ToMervalSymbolCI()));

            Cable48 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddCableSuffix().ToMervalSymbol48H()));
            Cable24 = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddCableSuffix().ToMervalSymbol24H()));
            CableCI = new InstrumentWithData(Argentina.Data.AllInstruments.Single(x => x.Symbol == ticker.AddCableSuffix().ToMervalSymbolCI()));

            RefreshData();
        }

        public override string ToString()
        {
            return Ticker + " " + base.ToString();
        }

        public string Ticker { get; private set; }

        public InstrumentWithData Pesos48 { get; set; }
        public InstrumentWithData Pesos24 { get; set; }
        public InstrumentWithData PesosCI { get; set; }
        public InstrumentWithData Dolar48 { get; set; }
        public InstrumentWithData Dolar24 { get; set; }
        public InstrumentWithData DolarCI { get; set; }
        public InstrumentWithData Cable48 { get; set; }
        public InstrumentWithData Cable24 { get; set; }
        public InstrumentWithData CableCI { get; set; }

        public IEnumerable<InstrumentWithData> GetAll()
        {
            yield return Pesos48;
            yield return Pesos24;
            yield return PesosCI;
            yield return Dolar48;
            yield return Dolar24;
            yield return DolarCI;
            yield return Cable48;
            yield return Cable24;
            yield return CableCI;
        }

        public bool ContainsSymbol(string symbol)
        {
            var isMatch =
                Pesos48.Instrument.Symbol == symbol ||
                Pesos24.Instrument.Symbol == symbol ||
                PesosCI.Instrument.Symbol == symbol ||
                Dolar48.Instrument.Symbol == symbol ||
                Dolar24.Instrument.Symbol == symbol ||
                DolarCI.Instrument.Symbol == symbol ||
                Cable48.Instrument.Symbol == symbol ||
                Cable24.Instrument.Symbol == symbol ||
                CableCI.Instrument.Symbol == symbol;

            return isMatch;
        }

        public void RefreshData()
        {
            Pesos48.RefreshData();
            Pesos24.RefreshData();
            PesosCI.RefreshData();

            Dolar48.RefreshData();
            Dolar24.RefreshData();
            DolarCI.RefreshData();

            Cable48.RefreshData();
            Cable24.RefreshData();
            CableCI.RefreshData();
        }

        public bool UpdateData(Instrument instrument, Entries data)
        {
            return UpdateData(instrument.Symbol, data);
        }

        public bool UpdateData(string symbol, Entries data)
        {
            return 
                Pesos48.UpdateData(symbol, data) ||
                Pesos24.UpdateData(symbol, data) ||
                PesosCI.UpdateData(symbol, data) ||
                Dolar48.UpdateData(symbol, data) ||
                Dolar24.UpdateData(symbol, data) ||
                DolarCI.UpdateData(symbol, data) ||
                Cable48.UpdateData(symbol, data) ||
                Cable24.UpdateData(symbol, data) ||
                CableCI.UpdateData(symbol, data);
        }

    }
}
