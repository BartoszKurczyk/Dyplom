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
    public partial class Form2 : Form
    {
        bool valid_name = false, valid_freq=false;
        string name;
        double freq;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string name, double freq)
        {
            
            InitializeComponent();
            valid_name = true;
            valid_freq = true;
            submitButton.Click -= submitButton_Click;
            submitButton.Click += submitButton_ClickUpdate;
            this.name = name;
            this.freq = freq;
            nameTextBox.Text = name;
            freqTextBox.Text = freq.ToString();

        }

        private void freqTextBox_Validating(object sender, CancelEventArgs e)
        {
            double val;
            if (string.IsNullOrEmpty(freqTextBox.Text.ToString()) || !Double.TryParse(freqTextBox.Text.ToString(), out val))
            {
                valid_freq = false;
                if (string.IsNullOrEmpty(freqTextBox.Text.ToString()))
                {
                    label5.Text = "Field cannot be empty";
                }
                else if (!Double.TryParse(freqTextBox.Text.ToString(), out val))
                    label5.Text = "Use comma";
                //MessageBox.Show("Częstotliwość jest wymagana");
            }
            else
            {
                valid_freq = true;
                label5.Text = "";
            }
        }
        private void submitButton_ClickUpdate(object sender, EventArgs e)
        {
            if (valid_name && valid_freq)
            {
                //dodaj do bazy
                //Trzeba obsłużyć wyjątek, gdy chcemy zmienić na nazwe która już w bazie istnieje

                double toDouble = Convert.ToDouble(freqTextBox.Text.ToString());
                Form1.instrumentsDB.updateInstrument(name,nameTextBox.Text.ToString(), toDouble);
                this.Close();
                
                
            }
            else
            {
                MessageBox.Show("Fill out the form correctly");
            }
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if(valid_name && valid_freq)
            {
                //dodaj do bazy
                try
                {

                    double toDouble = Convert.ToDouble(freqTextBox.Text.ToString());
                    Form1.instrumentsDB.addInstrument(nameTextBox.Text.ToString(), toDouble);
                    this.Close();
                }
                catch (System.Exception wyjatek)
                {
                    MessageBox.Show("The same instument is in the base");
                }
            }
            else
            {
                MessageBox.Show("Fill out the form correctly");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(nameTextBox.Text.ToString()))
            {
                valid_name = false;
                //MessageBox.Show("Nazwa jest wymagana");
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
