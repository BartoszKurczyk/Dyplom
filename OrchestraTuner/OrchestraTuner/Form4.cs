using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrchestraTuner
{
    public partial class Form4 : Form
    {
        List<Instrument> all_instruments = new List<Instrument>();
        List<Instrument> instruments_toBand = new List<Instrument>();
        string name;
        bool valid_instruments = false, valid_name=false;
        public Form4()
        {

            InitializeComponent();
            all_instruments = Form1.instrumentsDB.instruments;
            foreach (var instr in all_instruments)
            {
                instrumentsList.Items.Add(instr.getName());
            }
        }

        public Form4(string name, List<Instrument> instrument)
        {

            InitializeComponent();
            submitButton.Click -= submitButton_Click;
            submitButton.Click += submitButton_ClickUpdate;

            all_instruments = Form1.instrumentsDB.instruments;
            foreach (var instr in all_instruments)
            {
                instrumentsList.Items.Add(instr.getName());
            }
            int index = 0;
            List<int> list_of_ids = new List<int>();
            foreach (var item in instrumentsList.Items)
            {
                //index = 0;
                foreach (var it in instrument)
                {
                    if (item.ToString().Equals(it.getName()))
                    {
                        //checkedListBox1.SetItemChecked(index, true);
                        list_of_ids.Add(index);
                    }

                }
                index++;
            }

            foreach (var id in list_of_ids)
            {
                instrumentsList.SetItemChecked(id, true);
            }
            nameTextBox.Text = name;
            this.name = name;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (valid_name && valid_instruments)
            {
                foreach (var checkedInstruments in instrumentsList.CheckedItems)
                {
                    Instrument found_instrument = all_instruments.Find(x => x.getName().Equals(checkedInstruments.ToString()));
                    instruments_toBand.Add(found_instrument);

                }

                Form1.bandsDB.addBand(nameTextBox.Text.ToString(), instruments_toBand);
                instruments_toBand.Clear();
                this.Close();
            }
            else
            {
                if(!valid_instruments)
                {
                    label3.Text = "Select min. 1 instrument";
                }
                else
                {
                    label3.Text = "";
                }
                MessageBox.Show("Fill out the form correctly");
            }


        }
        private void submitButton_ClickUpdate(object sender, EventArgs e)
        {
            if (valid_name && valid_instruments)
            {
                foreach (var checkedInstruments in instrumentsList.CheckedItems)
                {
                    Instrument found_instrument = all_instruments.Find(x => x.getName().Equals(checkedInstruments.ToString()));
                    instruments_toBand.Add(found_instrument);

                }

                Form1.bandsDB.updateBand(name, nameTextBox.Text.ToString(), instruments_toBand); ;
                instruments_toBand.Clear();
                this.Close();
            }
            else
            {
                if (!valid_instruments)
                {
                    label3.Text = "Select min. 1 instrument";
                }
                else
                {
                    label3.Text = "";
                }
                MessageBox.Show("Fill out the form correctly");
            }
            //Console.WriteLine("Debug");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instrumentsList_Validating(object sender, CancelEventArgs e)
        {
            if (instrumentsList.CheckedItems.Count > 0)
            {
                valid_instruments = true;
                label3.Text = "";
            }
            else
            {
                label3.Text = "Select min. 1 instrument";
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(nameTextBox.Text.ToString()))
            {
                valid_name = false;
                label4.Text = "Field cannot be empty";
            }
            else
            {
                valid_name = true;
                label4.Text = "";
            }
        }
    }
}
