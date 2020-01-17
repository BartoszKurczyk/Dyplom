using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraTuner
{
    public class Band
    {
        private int id;
        private string name;
        private List<Instrument> instruments_in_band = new List<Instrument>();
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void addInstruments(Instrument instrument)
        {
            this.instruments_in_band.Add(instrument);
        }
        public string getName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
        public List<Instrument> GetInstruments()
        {
            return instruments_in_band;
        }
    }
}
