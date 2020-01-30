using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraTuner
{
    
	public class Instrument
    {
        private string name;
        private double freq;
        private int id;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public double getFreq()
        {
            return freq;
        }
        public void setFreq(double freq)
        {
            this.freq = freq;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }


        public Instrument() { }
        public Instrument(string name, double freq, int id)
        {
            this.name = name;
            this.freq = freq;
            this.id = id;
        }
    }
}


