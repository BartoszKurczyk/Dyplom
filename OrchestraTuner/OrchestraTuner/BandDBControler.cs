using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrchestraTuner
{
    
	public class BandDBControler
    {
        string filename = "bands.xml";
        Band temp_band;
        public List<Band> bands;
        int biggest_id;


        public void getBands()
        {
            XElement xdoc = XElement.Load(filename);

            var x = (from el in xdoc.Elements("bands").Elements("band") select el);

            foreach (var band in x)
            {

                temp_band = new Band();
                temp_band.setId(Int32.Parse(band.Attribute("id").Value));
                temp_band.setName(band.Element("name").Value);

                var z = (from el in band.Elements("instrument") select el);
                foreach (var inst in z)
                {
                    temp_band.addInstruments(Form1.instrumentsDB.instruments.Find(k => k.getId().Equals(Int32.Parse(inst.Value))));
                }
                bands.Add(temp_band);
            }
        }

        public void addBand(string new_name, List<Instrument> new_instruments)
        {
            var add_band = new Band();
            add_band.setId(biggest_id);
            add_band.setName(new_name);
            Band found_band = bands.Find(x => x.getName().Equals(add_band.getName()));
            if (found_band == null)
            {
                XElement dane = new XElement(filename);
                dane = XElement.Load(filename);

                var new_band = new XElement("band", new XAttribute("id", biggest_id), new XElement("name", add_band.getName()));
                foreach (var instr in new_instruments)
                {
                    new_band.Add(new XElement("instrument", instr.getId().ToString()));
                }
                dane.Element("bands").Add(new_band);
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

        public void updateBand(string name,string new_name, List<Instrument> new_instruments)
        {

            
            var found_band = Form1.bandsDB.bands.Find(x => x.getName().Equals(name));
            var id = found_band.getId();

            XElement dane = new XElement(filename);
            dane = XElement.Load(filename);

            var new_band = new XElement("band", new XAttribute("id", id), new XElement("name", new_name));
            foreach (var instr in new_instruments)
            {
                new_band.Add(new XElement("instrument", instr.getId().ToString()));
            }
            dane.Elements("bands").Elements("band").Single(x => x.Attribute("id").Value == id.ToString()).ReplaceWith(new_band);

            dane.Save(filename);
            synchronize();

        }

        public void removeInstrumentfromBands(int instrument_id)
        {
            XElement xdoc = XElement.Load(filename);
            //Selecting XML Node to delete
            var x = (from elemet in xdoc.Elements("bands").Elements("band").Elements("instrument")
                     where elemet.Value == instrument_id.ToString()
                     select elemet);

            //Removing XML Node
            x.Remove();
            xdoc.Save(filename);
            synchronize();
        }

        public void removeBand(int id)
        {
            XElement xdoc = XElement.Load(filename);
            //Selecting XML Node to delete
            var x = (from elemet in xdoc.Elements("bands").Elements("band")
                     where elemet.Attribute("id").Value == id.ToString()
                     select elemet);

            //Removing XML Node
            x.Remove();
            xdoc.Save(filename);
            synchronize();
        }
        public void initializeDB()
        {
            bands = new System.Collections.Generic.List<Band>();
            getBands();
            biggest_id = bands.Last().getId() + 1;

        }

        public void synchronize()
        {
            bands.Clear();
            getBands();

        }
    }
}


