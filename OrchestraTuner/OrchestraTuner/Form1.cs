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
        double instrument_base_freq = 440.0;
        double double_freq;
        Bitmap scale, dot, hand;
        float angle;
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
            scale = new Bitmap(@"res\face.png");
            scaleBox.Image = scale;
            hand = new Bitmap(@"res\hand.png");
            dot = new Bitmap(@"res\green_dot.png");
            scaleBox.Controls.Add(handBox);
            handBox.Image = hand;
            handBox.Location = new Point(0, 0);
            handBox.BackColor = Color.Transparent;
            handBox.Controls.Add(dotBox);
            dotBox.Image = dot;
            dotBox.Location = new Point(0, 0);
            dotBox.BackColor = Color.Transparent;

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

        private void handBox_Click(object sender, EventArgs e)
        {

        }

        public void inTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            double_freq=detector.getFundamentalFreq();
            _freq = double_freq.ToString();
            changeTextInTimer();
            animateGUI();
            //Console.WriteLine(_freq);
        }
        public void animateGUI()
        {
            float angle;
            var temp_var = double_freq - instrument_base_freq;
            if (temp_var < 0.0)
            {
                angle = 360.0F + (float)temp_var;
            }
            else
                angle = (float)temp_var;

            if (temp_var > 60.0F)
            {
                angle = 60.0F;
            }
            else if (temp_var < -60.0F)
                angle = -60.0F;

            if ((temp_var > 1.0F && temp_var <= 30.0F) || (temp_var < -1.0F && temp_var >= -30.0F))
            {
                dot = new Bitmap(@"res\yellow_dot.png");
                dotBox.Image = dot;
            }
            else if (temp_var > 30.0F || temp_var < -30.0F) 
            {
                dot = new Bitmap(@"res\red_dot.png");
                dotBox.Image = dot;
            }
            else
            {
                dot = new Bitmap(@"res\green_dot.png");
                dotBox.Image = dot;
            }


            Console.WriteLine(angle);
            Bitmap temp_hand = rotateImage(hand, angle);
            handBox.Image = temp_hand;
            
        }
        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }

            return rotatedImage;
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
            timer.Interval = 500;
            timer.Elapsed += inTimer;
            timer.Start();

        }
        
    }
}
