using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Runtime.InteropServices;

namespace OrchestraTuner
{
    
    class Detector
    {
        private int RATE = 44100;
        private int BUFFERSIZE = 44100;
        
        public BufferedWaveProvider bwp;

        void AudioDataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void StartMicListening()
        {
            int audioDevNumber = 0;
            WaveInEvent wIN = new WaveInEvent();
            wIN.DeviceNumber = audioDevNumber;
            wIN.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
            wIN.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);
            wIN.DataAvailable += new EventHandler<WaveInEventArgs>(AudioDataAvailable);
            bwp = new BufferedWaveProvider(wIN.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;
            bwp.DiscardOnBufferOverflow = true;
            try
            {
                wIN.StartRecording();
            }
            catch
            {
                Console.WriteLine("Can't see device");
            }

            //Console.WriteLine("Recording");
        }

        public double getFundamentalFreq()
        {
            var audioBytes = new byte[BUFFERSIZE];
            bwp.Read(audioBytes, 0, BUFFERSIZE);
            int pointCount = audioBytes.Length / 2;
            double[] pcm = new double[pointCount];

            for (int i = 0; i < pointCount; i++)
            {
                // read the int16 from the two bytes
                Int16 val = BitConverter.ToInt16(audioBytes, i * 2);

                // store the value in Ys as a percent (+/- 100% = 200%)
                pcm[i] = (double)(val) / Math.Pow(2, 16) * 200.0;
            }
            double freq = (double)pitchDetect(pcm, pointCount);
            return freq;
        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct pyinc_pitch_range
        {
            public float* begin;
            public float* end;
        }

        [DllImport("\\LibPyin.dll")]
        static extern void pyinc_init(int sample_rate, int block_size, int step_size);

        [DllImport("\\LibPyin.dll")]
        unsafe static extern pyinc_pitch_range pyinc_feed(float* data, int size);

        [DllImport("\\LibPyin.dll")]
        unsafe static extern void pyinc_clear();
        unsafe public float pitchDetect(double[] pre_ptr, int sample_count)
        {
            int SAMPLE_RATE = RATE;
            int SAMPLE_COUNT = sample_count;
            int BLOCK_SIZE = 8192;
            int STEP_SIZE = 512;

            // Prepare objects
            pyinc_init(SAMPLE_RATE, BLOCK_SIZE, STEP_SIZE);

            float* ptr = stackalloc float[SAMPLE_COUNT];


            
            for (int i = 0; i < SAMPLE_COUNT; i++)
            {
                ptr[i] = (float)pre_ptr[i];
            }
            // Mine pitches
            pyinc_pitch_range pitches = pyinc_feed(ptr, SAMPLE_COUNT);

            // Go through and print the pitches
            float* res_ptr = pitches.begin;
            if (*res_ptr != -1)
            //Console.WriteLine(*res_ptr);
            /*while (res_ptr != pitches.end)
            {

                if (*res_ptr != -1)
                {
                    Console.WriteLine(*res_ptr);

                }
                res_ptr++;
            }
            res_ptr = pitches.begin;
            if (*res_ptr != -1)
                Console.WriteLine("------------------------------");*/
            // Release the data
            pyinc_clear();
            return *res_ptr;
        }
    }
}
