using Primary.Data;

namespace Primary.WinFormsApp
{
    public class InstrumentWithData
    {
        public Instrument Instrument { get; set; }
        public Entries Data { get; set; }

        public void RefreshData()
        {
            Data = Argentina.Data.GetLatestOrNull(Instrument.Symbol);
        }
        public bool UpdateData(string symbol, Entries data)
        {
            if (Instrument.Symbol == symbol)
            {
                Data = data;
                return true;
            }

            return false;
        }

        public InstrumentWithData(Instrument instrument)
        {
            Instrument = instrument;
        }

        public InstrumentWithData(Instrument instrument, Entries data)
        {
            Instrument = instrument;
            Data = data;
        }

        public override string ToString()
        {
            return Instrument.SymbolWithoutPrefix();
        }
    }
}
