using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;


namespace Cringe
{
 
    
    public partial class Form1 : Form
    {
        #region Variables

        ////////////////////////////////////////////////////////////////////////
        // Initialize Variables 
        ////////////////////////////////////////////////////////////////////////
        Spectrometer spectrometer = null; /* The spectrometer object */

        int pixels = 0; /* number of data points */
        int details = 20; /* pixels/details = the number of data points draw on the graph */
        int expandedSize = (int)Math.Pow(2, 12);
        int spectralOffset = 1; /* skip over wavelength, workingSpectrum, mirror */
        int numSpectrum = 6; /* in order: wavelength, workingSpectrum, mirror, airSpectrum, liquidSpectrum, other */
        int numSeries = 5; /* There are 3 potential series, air, liquid, other */

        const int otherIndex = 5;
        const int liquidIndex = 4;
        const int airIndex = 3;
        const int workingIndex = 2;
        const int mirrorIndex = 1;
        const int wavelengthIndex = 0;

        int yAxisMax = 2000; /* lowbar y axis max so that it will adjust when drawing */

        /* some initial values so that reset works */
        int initialYAxisMax = 2000;
        int initialIntegrationTime = 100;
        double initialMinWav = 600;
        double initialMaxWav = 1000;

        /* used when processing a click on the chart, later when updating fft min/max */
        double xPos = 0;
        double yPos = 0;

        double Porosity;
        double Thickness;

        double[] peaks = new double[3];
        double[] spectralMaxes = new double[5];

        /* array of double arrays, of all those spectrums from above */
        double[] workingSpectrum;
        double[][] spectrum = new double[6][];
        double[][] fftSpectra = new double[3][];
        double[] advancedSpectrum;
        System.Numerics.Complex[] enterFFT = new System.Numerics.Complex[4096];

        /* 2D array of the common liquids and their refractive indices */
        String[,] refractiveIndices = new String[2, 7]{ {"Air", "Methanol", "Ethanol", "Dichloromethane", "Toluene", "Water", "Other"}, 
                                                        {"1.000", "1.328",    "1.361",   "1.424",           "1.497",   "1.333", "0"} };
        String[] spectralNames = { "the Air", "the Liquid", "the Other"};

        bool scanning = false; /* loop variable for reading values */
        bool mirror = false; /* used to find the mirror */
        bool reflectance = false; /* if true, we use the reflectance algorithm */
        bool saveAir = false;
        bool saveLiquid = false;
        bool saveOther = false;

        int integrationTimeMillisec = 100; /* initial integration time */
        string spectrometerType; /* for a text box or two */
        string saveFileName;
        private Logger logger = new Logger(); /* prints to the event box at the bottom of the screen */
        public bool closePending = false; /* used when closing the window */
        bool advancedFormOpen = false;

        /* in order: mirror, airSeries, liquidSeries, other, another, really */
        Series[] series = new Series[5]; /* all the series (the lines on the graph) */
        Series[] fftSeries = new Series[3]; /* all the series on the fft graph */

        Form3 advanced;

        #endregion

        public Form1()
        {
            /* set up the window, with all the buttons and things */
            InitializeComponent();

            /* sets up the spectrometer, series, buttons and the works */
            initializeSpectrometer();
        }

        /* make sure the spectrometer has closed when the window closes */
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorkerAcquisition.IsBusy)
                backgroundWorkerAcquisition.CancelAsync();
            if (spectrometer != null)
            {
                spectrometer.close();
                spectrometer = null;
            }
        }

             
    }
}
