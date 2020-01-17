using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraTuner
{
    public class InstrumentsDBControler
    {
        string filename = "baza.xml";
        Instrument temp_instrument;
        public List<Instrument> instruments;
        int biggest_id;

        public void getInstruments()
        {
            XElement xdoc = XElement.Load(filename);

            var x = (from el in xdoc.Elements("instruments").Elements("instrument") select el);

            temp_instrument = new Instrument();
            foreach (var ids in x)
            {
                temp_instrument.setId(Int32.Parse(ids.Attribute("id").Value));
                temp_instrument.setName(ids.Element("name").Value);
                temp_instrument.setFreq(Double.Parse(ids.Element("freq").Value.Replace('.', ',')));
                instruments.Add(temp_instrument);
                temp_instrument = new Instrument();


            }
        }



        public void addInstrument(string new_name, double new_freq)
        {
            var add_instrument = new Instrument(new_name, new_freq, biggest_id);
            Instrument found_instrument = instruments.Find(x => x.getName().Equals(add_instrument.getName()));
            if (found_instrument == null)
            {
                XElement dane = new XElement(filename);
                dane = XElement.Load(filename);

                var new_instrument = new XElement("instrument", new XAttribute("id", biggest_id), new XElement("name", add_instrument.getName()), new XElement("freq", add_instrument.getFreq().ToString().Replace(',', '.')));

                dane.Element("instruments").Add(new_instrument);
                dane.Save(filename);
                synchronize();
            }
            else
            {
                Console.WriteLine("Taki element już istnieje");
                System.Exception alreadyExist = new System.Exception("Taki instrument juz istnieje");
                throw alreadyExist;
            }

            biggest_id++;
        }

        public void updateInstrument(string name,string new_name, double new_freq)
        {

            
            var found_instrument = Form1.instrumentsDB.instruments.Find(x => x.getName().Equals(name));
            var id = found_instrument.getId();
            

            XElement dane = new XElement(filename);
            dane = XElement.Load(filename);

            var new_instrument = new XElement("instrument", new XAttribute("id", id), new XElement("name", new_name), new XElement("freq", new_freq.ToString().Replace(',', '.')));

            dane.Elements("instruments").Elements("instrument").Single(x => x.Attribute("id").Value == id.ToString()).ReplaceWith(new_instrument);

            dane.Save(filename);
            synchronize();

        }

        public void removeInstrument(int id)
        {
            XElement xdoc = XElement.Load(filename);
            //Selecting XML Node to delete
            var x = (from elemet in xdoc.Elements("instruments").Elements("instrument")
                     where elemet.Attribute("id").Value == id.ToString()
                     select elemet);

            //Removing XML Node
            x.Remove();
            xdoc.Save(filename);
            Form1.bandsDB.removeInstrumentfromBands(id);
            synchronize();
        }

        public void initializeDB()
        {
            instruments = new System.Collections.Generic.List<Instrument>();
            getInstruments();
            biggest_id = instruments.Last().getId() + 1;

        }

        public void synchronize()
        {
            instruments.Clear();
            getInstruments();
        }
    }
}

