using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Cringe
{
    public partial class Form3 : Form
    {
        public double interval = -1;
        public double duration = -1;
        public int intervalUnit = -1;
        public int durationUnit = -1;
        public double totalInterval = -1;
        public double totalDuration = -1;

        public double time = 0;

        int posMax = 500;
        int magMax = 10;
        

        double xPos = 0;
        Form1 form1;
        Series mainSeries;
        Series FFTMagTimeSeries;
        Series FFTPosTimeSeries;
        double[] spectrum;
        double[] fftConstSpectrum;
        double[] wavelengths;
        double[] fftPosSave;
        double[] fftMagSave;
        int details;
        int pixels;
        int yAxisMax = 1000;
        bool recording = false;
        int max;
        int min;
        int count = 0;
        double toggle = 0;

        Logger logger = new Logger();


        public Form3(Form1 f, int pixels, int details)
        {
            InitializeComponent();
            form1 = f;
            mainSeries = chartSpectrum.Series.FindByName("mainSpectrum");
            FFTMagTimeSeries = chartFFTMag.Series.FindByName("FFTMagTime");
            FFTPosTimeSeries = chartFFTPosition.Series.FindByName("FFTPosTime");
            spectrum = new double[pixels];
            fftConstSpectrum = new double[pixels];
            this.details = details;
            this.pixels = pixels;
            wavelengths = form1.getWavelengths();
            mainSeries.Points.AddXY(0, 0);
            FFTMagTimeSeries.Points.AddXY(0, 0);
            FFTPosTimeSeries.Points.AddXY(0, 0);


            domainUpDownInterval.SelectedIndex = 0;
            domainUpDownDuration.SelectedIndex = 0;
        }

        public void updateSeries(double[] newValues)
        {
            mainSeries.Points.Clear();
            Array.Copy(newValues, spectrum, spectrum.Length);
            drawGraph();
        }
        private void drawGraph()
        {
            double max = 0;
            for (int i = 0; i < pixels; i++)
            {
                if (i % details == 0)
                {
                    if (max < spectrum[i])
                    {
                        max = spectrum[i];
                    }
                    mainSeries.Points.AddXY(wavelengths[i], spectrum[i]);
                }
            }
            
            yAxisMax = (int)max + 1500;
            yAxisMax /= 1000;
            yAxisMax *= 1000;
            chartSpectrum.ChartAreas[0].AxisY.Maximum = (double)yAxisMax;
            
        }
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (!recording)
            {
                buttonRecord.Text = "Stop";
                recording = true;
            }
            else
            {
                buttonRecord.Text = "Record";
                recording = false;
                backgroundWorkerAdvanced.CancelAsync();
            }
            if (recording)
            {
                try
                {
                    duration = Convert.ToDouble(textBoxDuration.Text);
                    interval = Convert.ToDouble(textBoxInterval.Text);
                    durationUnit = domainUpDownDuration.SelectedIndex;
                    intervalUnit = domainUpDownInterval.SelectedIndex;

                    totalDuration = duration;
                    if (durationUnit > 0)
                    {
                        totalDuration *= 60;
                    }
                    if (durationUnit > 1)
                    {
                        totalDuration *= 60;
                    }
                    if (durationUnit > 2)
                    {
                        totalDuration *= 24;
                    }

                    totalInterval = interval;
                    if (intervalUnit > 0)
                    {
                        totalInterval *= 60;
                    }
                    if (intervalUnit > 1)
                    {
                        totalInterval *= 60;
                    }
                    if (intervalUnit > 2)
                    {
                        totalInterval *= 24;
                    }

                    logger.display("{0}", totalInterval);
                    min = 0;
                    max = 0;
                    for (int i = 0; i < pixels; i++)
                    {
                        if (wavelengths[i] >= Double.Parse(textBoxMinWavVal.Text) - .25 &&
                            wavelengths[i] <= Double.Parse(textBoxMinWavVal.Text) + .25)
                        {
                            min = i;
                        }
                        if (wavelengths[i] >= Double.Parse(textBoxMaxWavVal.Text) - .25 &&
                            wavelengths[i] <= Double.Parse(textBoxMaxWavVal.Text) + .25)
                        {
                            max = i;
                        }
                    }

                    if (duration > interval && interval > 0)
                    {
                        fftMagSave = new Double[(int)(duration / interval) + 1];
                        fftPosSave = new Double[(int)(duration / interval) + 1];


                        toggle = (duration / interval) / 100;

                        logger.display("{0}", toggle);

                        FFTMagTimeSeries.Points.Clear();
                        FFTPosTimeSeries.Points.Clear();
                        backgroundWorkerAdvanced.RunWorkerAsync();

                    }
                    else
                    {
                        buttonRecord.Text = "Record";
                        recording = false;
                    }
                }
                catch (FormatException ex)
                {
                    buttonRecord.Text = "Record";
                }
            }
        }

        private void updateGraphs(double pos, double mag)
        {
            if (time < duration)
            {
                fftPosSave[count] = pos;
                fftMagSave[count] = pos;
                count++;

                
                if (toggle < 1 || count % (int)toggle == 0)
                {
                    if ((int) mag > magMax)
                    {
                        magMax = (int) mag;
                        chartFFTMag.ChartAreas[0].AxisY.Maximum = magMax + ((int)magMax / 5);

                    }
                    if ((int)pos > posMax)
                    {
                        posMax = (int) pos;
                        chartFFTPosition.ChartAreas[0].AxisY.Maximum = posMax + ((int)posMax / 5);
                    }
                    FFTMagTimeSeries.Points.AddXY(count/toggle, mag);
                    FFTPosTimeSeries.Points.AddXY(count/toggle, pos);
                }

                time += interval;
            }
            else
            {
                buttonRecord.Text = "Record";
                recording = false;
                backgroundWorkerAdvanced.CancelAsync();
            }

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDuration.Text = "0";
            textBoxInterval.Text = "0";
            textBoxNumberSpectra.Text = "0";
            domainUpDownInterval.SelectedIndex = 0;
            domainUpDownDuration.SelectedIndex = 0;
            time = 0;
            toggle = 0;
            count = 0;

            FFTMagTimeSeries.Points.Clear();
            FFTPosTimeSeries.Points.Clear();

            FFTMagTimeSeries.Points.AddXY(0, 0);
            FFTPosTimeSeries.Points.AddXY(0, 0);

            buttonRecord.Text = "Record";
            recording = false;
            backgroundWorkerAdvanced.CancelAsync();
        }

        private void buttonSetMinWav_Click(object sender, EventArgs e)
        {
            textBoxMinWavVal.Text = xPos.ToString();
        }

        private void chartSpectrum_Click(object sender, EventArgs e)
        {
            xPos = chartSpectrum.ChartAreas[0].CursorX.Position;

        }

        private void buttonSetMaxWav_Click(object sender, EventArgs e)
        {
            textBoxMaxWavVal.Text = xPos.ToString();
        }

        public void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorkerAdvanced.CancelAsync();
            form1.closeAdvanced();
        }

    }
}
