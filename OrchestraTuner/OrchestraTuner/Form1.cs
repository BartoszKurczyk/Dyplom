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
        public static InstrumentsDBControler instrumentsDB = new InstrumentsDBControler();
        public static BandDBControler bandsDB = new BandDBControler();
        Detector detector = new Detector();
        string _freq="440";
        double instrument_base_freq = 440.0;
        double to_base_440 = 0.0;
        double base_freq = 0.0;
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


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /*private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }*/
        public void changeTextInTimer(/*object sender, System.Timers.ElapsedEventArgs e*/)
        {
            richTextBox1.Text = _freq;
        }


        public Form1()
        {
            
            
            InitializeComponent();
            
            instrumentsDB.initializeDB();
            bandsDB.initializeDB();
            
            bandSelect.Text = bandsDB.bands.First().getName();

            refreshInstruments();
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
            baseFreqTrackBar.Minimum = 400;
            baseFreqTrackBar.Maximum = 480;
            baseFreqTrackBar.Value = 440;
            base_freq = 440;
            
            baseFreqLabel.Text = base_freq.ToString()+" Hz";




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
            _freq = String.Format("{0:0.00}", double_freq);//double_freq.ToString();
            changeTextInTimer();
            animateGUI();
            //Console.WriteLine(_freq);
        }
        public void animateGUI()
        {
            float angle;
            var temp_var = double_freq - (instrument_base_freq);
            if (temp_var < 0.0)
            {
                angle = 360.0F + (float)temp_var;
            }
            else
                angle = (float)temp_var;

            if (temp_var > 60.0F)
            {
                angle = -65.0F;
            }
            else if (temp_var < -60.0F)
                angle = -65.0F;

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dotBox_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bandSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInstruments();
        }

        private void bandSelect_Enter(object sender, EventArgs e)
        {
            refreshBand();
        }
        public void refreshBand()
        {
            bandSelect.Items.Clear();
            foreach (var band in bandsDB.bands)
            {
                bandSelect.Items.Add(band.getName());
            }
        }
        public void refreshInstruments()
        {
            string bandName = bandSelect.Text.ToString();
            var instruments_to_display = bandsDB.bands.Find(x => x.getName().Equals(bandName)).GetInstruments();
            instrumentList.Items.Clear();
            foreach (var instrument in instruments_to_display)
            {
                instrumentList.Items.Add(instrument.getName());
            }
            instrumentList.SelectedIndex = 0;
            
            

        }

        private void instrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            instrument_base_freq = instrumentsDB.instruments.Find(x => x.getName().Equals(instrumentList.SelectedItem.ToString())).getFreq()+to_base_440;
            //changeBaseFreq();
            freqLabel.Text = instrument_base_freq.ToString()+" Hz";
            //changeBaseFreq();
        }

        private void addInstrumentButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void deleteInstrumentButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            //MessageBox.Show("coś dziwnego!!!1");
            
            refreshInstruments();
        }

        private void addBandButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void updateBand_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(bandSelect.Text.ToString(), bandsDB.bands.Find(x => x.getName().Equals(bandSelect.Text.ToString())).GetInstruments());
            f4.ShowDialog();
            bandSelect.Text = bandSelect.Text = bandsDB.bands.First().getName();
            refreshBand();
            refreshInstruments();
        }

        private void deleteBandButton_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(bandsDB.bands.Find(x => x.getName().Equals(bandSelect.Text.ToString())).getId(), bandSelect.Text.ToString());
            f5.ShowDialog();
            bandSelect.Text = bandSelect.Text = bandsDB.bands.First().getName();
            refreshBand();
        }

        private void updateInstrumentButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(instrumentList.SelectedItem.ToString(),instrumentsDB.instruments.Find(x => x.getName().Equals(instrumentList.SelectedItem.ToString())).getFreq());
            f2.ShowDialog();
            bandSelect.Text = bandSelect.Text = bandsDB.bands.First().getName();
            refreshBand();
            refreshInstruments();
        }

        private void baseFreqTrackBar_ValueChanged(object sender, EventArgs e)
        {
            base_freq = (double)baseFreqTrackBar.Value;
            baseFreqLabel.Text = base_freq.ToString();
            to_base_440 = base_freq - 440;
            freqLabel.Text = instrument_base_freq.ToString();
            
            Console.WriteLine(to_base_440);
            refreshInstruments();
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

