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
    
	public partial class Form5 : Form
    {
        private int id;
        private string name;
        public Form5(int id, string name)
        {
            InitializeComponent();
            this.Location = new Point(550, 430);
            if (id == 0)
            {
                //MessageBox.Show("Base band cannot be deleted");
                
                text.Text = "Base band cannot be deleted";
                submitButton.Visible = false;
            }
            else
            {
                this.id = id;
                this.name = name;
                string txt = "Do you want to delete the band: ";
                txt += name.ToString();
                text.Text = txt;
            }
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Form1.bandsDB.removeBand(this.id);
            this.Close();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


//Do you want to delete the band:

