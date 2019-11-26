using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OrchestraTuner
{
    public partial class Form1 : Form
    {
        Detector detector = new Detector();
        string _freq="440";
        double double_freq;
        /*public string freq
        {
            get { return _freq; }
            set
            {
                _freq = value;
                changeText();
            }
        }*/
        public void changeTextInTimer(/*object sender, System.Timers.ElapsedEventArgs e*/)
        {
            richTextBox1.Text = _freq;
        }
        public Form1()
        {
            InitializeComponent();

        }
        /*public void changeText()
        {
            Thread.Sleep(1200);
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 500;
            timer1.Elapsed += changeTextInTimer;
            timer1.Start();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thr = new Thread(calculateInBackground);
            thr.Start();
            //Thread thr2 = new Thread(changeText);
            //thr2.Start();
            
        }
        public void inTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            double_freq=detector.getFundamentalFreq();
            _freq = double_freq.ToString();
            changeTextInTimer();
            //Console.WriteLine(_freq);
        }
        public void calculateInBackground()
        {
            
            detector.StartMicListening();
            /*while (true)
            {
                double_freq = detector.getFundamentalFreq();
                if(double_freq!=-1)
                    freq = double_freq.ToString();
            }*/
            /*var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);

            var timer = new System.Threading.Timer((e) =>
             {
                 inTimer();
             }, null, startTimeSpan, periodTimeSpan);
            Timer*/
            Thread.Sleep(1200);
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 600;
            timer.Elapsed += inTimer;
            timer.Start();

        }
        
    }
}
