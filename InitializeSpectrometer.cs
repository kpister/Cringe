using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;



namespace Cringe
{
    
    public partial class Form1
    {
        
        public void initializeSpectrometer()
        {
            initializeFFTSeries();
            initializeSeries();
            /* assume initialization will fail */
            disableButtons();

            /* if it is running, stop it */
            if (spectrometer != null)
            {
                spectrometer.close();
                spectrometer = null;
            }

            /* open spectrometer */
            if ((spectrometer == null || !spectrometer.isOk()))
            {
                /* initialize logger */

                logger.setTextBox(textBoxEventLog);
                logger.display("Initializing spectrometer...");
                spectrometer = new SeaBreezeSpectrometer();

                spectrometer.setLogger(logger);
                spectrometer.open();

                /* make sure the spectrometer opens correctly, then set up values */
                if (spectrometer.isOk())
                {
                    spectrometerType = spectrometer.getSpectrometerType();
                    pixels = spectrometer.getPixelCount();

                    /* set wavelengths */
                    spectrum[0] = spectrometer.getWavelengths();

                    /* initialize the size of each spectrum */
                    for (int i = 1; i < numSpectrum; i++)
                    {
                        spectrum[i] = new double[pixels];
                    }
                    advancedSpectrum = new double[pixels];

                    logger.display("Successfully claimed {0} with {1} pixels", spectrometerType, pixels);
                    groupBoxInfo.Text = "Spectrometer: " + spectrometerType;
                    labelPixels.Text = String.Format("{0}", pixels);
                    domainUpDownAir.SelectedIndex = 0;
                    domainUpDownLiquid.SelectedIndex = 0;
                    
                    //buttonMirror.Enabled = true;
                    buttonAdvanced.Enabled = true;

                    updateSpectrometerFromGUI();

                    if (!backgroundWorkerAcquisition.IsBusy)
                        backgroundWorkerAcquisition.RunWorkerAsync();

                    series[0].Points.AddXY(0, 0);
                    Refresh();
                }
                else
                {
                    logger.display("Failed to initialize spectrometer");
                    DialogResult result = MessageBox.Show(
                        "No usable spectrometer available\nWould you like to try again?",
                        "SeaBreeze",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly,
                        false);

                    if (result == DialogResult.Yes)
                    {

                        spectrometer.close();
                        spectrometer = null; 
                        initializeSpectrometer();
                    }
                    
                }
            }
            else
            {
                logger.log("Spectrometer already initialized");
            }
        }

        /* initialize all the fft series */
        private void initializeFFTSeries()
        {
            fftSeries[0] = chartFFT.Series.FindByName("airFFT");
            fftSeries[1] = chartFFT.Series.FindByName("liquidFFT");
            fftSeries[2] = chartFFT.Series.FindByName("otherFFT");
        }

        /* initialize all the series */
        private void initializeSeries()
        {
            series[0] = chartSpectrum.Series.FindByName("mirrorSpectrum");
            series[1] = chartSpectrum.Series.FindByName("working");
            series[2] = chartSpectrum.Series.FindByName("airSpectrum");
            series[3] = chartSpectrum.Series.FindByName("liquidSpectrum");
            series[4] = chartSpectrum.Series.FindByName("otherSpectrum");
                        
        }

    }
}
