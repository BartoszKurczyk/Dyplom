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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            foreach(var instrument in Form1.instrumentsDB.instruments)
            {
                instrumentsList.Items.Add(instrument.getName());
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.instrumentsDB.removeInstrument(Form1.instrumentsDB.instruments.Find(x => x.getName().Equals(instrumentsList.SelectedItem.ToString())).getId());
                
                this.Close();
            }
            catch(NullReferenceException w)
            {
                MessageBox.Show("Select instrument");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
