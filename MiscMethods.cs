using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cringe
{
    public partial class Form1
    {        
        /* self written methods */
        
        /* when reflectance is true, adjust the spectrum as it is being gathered */
        private void adjustReflectance()
        {
            if (series[mirrorIndex - spectralOffset] != null)
            {   
                for (int i = 0; i < pixels; i++)
                {
                    spectrum[workingIndex][i] = spectrum[workingIndex][i] / spectrum[mirrorIndex][i];
                }
            }
        }


        /* clear all the series */
        private void clearSeries()
        {
            for (int i = 0; i < series.Length; i++)
            {
                series[i].Points.Clear();
            }

            checkBoxAir.Checked = false;
            checkBoxLiquid.Checked = false;
            checkBoxOther.Checked = false;
        }

        private void clearFFTSeries()
        {
            for (int i = 0; i < fftSeries.Length; i++)
            {
                fftSeries[i].Points.Clear();
            }

            chartSpectrum.Visible = true;
            chartFFT.Visible = false;
        }

        /* draw the current series */
        private void drawGraph(int points, int index)
        {
            double max = 0;
            for (int i = 0; i < points; i++)
            {
                if (i % details == 0)
                {
                    if (!reflectance)
                    {
                        if (max < spectrum[index + spectralOffset][i])
                        {
                            max = spectrum[index + spectralOffset][i];
                        }
                        series[index].Points.AddXY(spectrum[wavelengthIndex][i], spectrum[index + spectralOffset][i]);
                    }
                    else
                    {
                        series[index].Points.AddXY(spectrum[wavelengthIndex][i], spectrum[index + spectralOffset][i]/spectrum[mirrorIndex][i]);
                    }
                }
            }
            spectralMaxes[index] = max;
            for (int i = 0; i < numSeries; i++ )
            {
                if (max < spectralMaxes[i])
                {
                    max = spectralMaxes[i];
                }
            }
            if (!reflectance)
            {
                yAxisMax = (int)max + 1500;
                yAxisMax /= 1000;
                yAxisMax *= 1000;
                chartSpectrum.ChartAreas[0].AxisY.Maximum = (double)yAxisMax;
            }
        }
        
        /* calculate the reflectance of the non-active spectra */
        private void reflectSpectra()
        {
            for (int i = 0; i < numSeries; i++)
            {
                if (series[i] != null && series[i].Points.Count > 0)
                {
                    series[i].Points.Clear();
                    for (int j = 0; j < pixels; j++)
                    {
                        spectrum[i + spectralOffset][j] = spectrum[i + spectralOffset][j] / spectrum[mirrorIndex][j];
                        if (j % details == 0)
                        {
                            series[i].Points.AddXY(spectrum[wavelengthIndex][j], spectrum[i + spectralOffset][j]);
                        }
                    }
                    Refresh();
                }
            }
        }

        /* swap between the chart and the fft */
        private void swapGraphs()
        {
            if (chartSpectrum.Visible)
            {
                chartSpectrum.Visible = false;
                chartFFT.Visible = true;
            }
            else
            {
                chartSpectrum.Visible = true;
                chartFFT.Visible = false;
            }
        }

        private void unreflectSpectra()
        {
            for (int i = 0; i < numSeries; i++)
            {
                if (series[i] != null && series[i].Points.Count > 0)
                {
                    series[i].Points.Clear();
                    for (int j = 0; j < pixels; j++)
                    {
                        spectrum[i + spectralOffset][j] = spectrum[i + spectralOffset][j] * spectrum[mirrorIndex][j];
                        if (j % details == 0)
                            series[i].Points.AddXY(spectrum[wavelengthIndex][j], spectrum[i + spectralOffset][j]);
                    }
                    Refresh();
                }
            }
        }

        /* redraw the current series */
        private void updateGraph()
        {
            if (workingSpectrum[500] == 0)
            {
                return;
            }
           
            /* clear the current series, copy the data into current spectrum, graph spectrum */
            try
            {
                if (mirror)
                {
                    series[mirrorIndex - spectralOffset].Points.Clear();
                    Array.Copy(workingSpectrum, spectrum[mirrorIndex], pixels);
                    drawGraph(pixels, mirrorIndex - spectralOffset);
                    if (spectrum[mirrorIndex][500] != 0)
                    {
                        mirror = false;
                    }
                }
                else if (saveAir)
                {
                    series[airIndex - spectralOffset].Points.Clear();
                    Array.Copy(workingSpectrum, spectrum[airIndex], pixels);
                    drawGraph(pixels, airIndex - spectralOffset);

                    if (spectrum[airIndex][500] != 0)
                    {
                        saveAir = false;
                    }

                }
                else if (saveLiquid)
                {
                    series[liquidIndex - spectralOffset].Points.Clear();
                    Array.Copy(workingSpectrum, spectrum[liquidIndex], pixels);
                    drawGraph(pixels, liquidIndex - spectralOffset);
                    if (spectrum[liquidIndex][500] != 0)
                    {
                        saveLiquid = false;
                    }

                }
                else if (saveOther)
                {
                    series[otherIndex - spectralOffset].Points.Clear();
                    Array.Copy(workingSpectrum, spectrum[otherIndex], pixels);
                    drawGraph(pixels, otherIndex - spectralOffset);
                    if (spectrum[otherIndex][500] != 0)
                    {
                        saveOther = false;
                    }

                }
                else if (advancedFormOpen)
                {
                    advanced.updateSeries(workingSpectrum);
                    return;
                }
                else
                {
                    series[workingIndex - spectralOffset].Points.Clear();
                    Array.Copy(workingSpectrum, spectrum[workingIndex], pixels);
                    drawGraph(pixels, workingIndex - spectralOffset);
                }
                
            }
            catch (NullReferenceException e)
            {

            }            
            //Refresh();
        }

        /* updates the integration time, called on start, reset and integration time change */
        private void updateSpectrometerFromGUI()
        {
            /* integration time */
            integrationTimeMillisec = (int)numericUpDownIntegrationTimeMillisec.Value;
            logger.display("Set integration time {0}", integrationTimeMillisec);

            /* make sure integration time doesn't reach below 5 microseconds for performance issues */
            if (integrationTimeMillisec < 5)
            {
                numericUpDownIntegrationTimeMillisec.Value = initialIntegrationTime;   
            }
            spectrometer.setIntegrationTimeMilliseconds(integrationTimeMillisec);

        }

        public void save(int index)
        {
            if (scanning)
            {
                backgroundWorkerAcquisition.CancelAsync();
            }

            saveFileDialogSpectra.Title = "Save " + spectralNames[index-3] +" spectrum as";
            saveFileDialogSpectra.AddExtension = true;
            saveFileDialogSpectra.DefaultExt = ".txt";
            
            if (saveFileName != "")
                saveFileDialogSpectra.FileName = saveFileName;

            if (saveFileDialogSpectra.ShowDialog() != DialogResult.OK)
                return;

            string pathname = saveFileDialogSpectra.FileName;
            using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(pathname))
            {
                outfile.WriteLine("wavelength,intensities");
                for (int i = 0; i < pixels; i++)
                    outfile.WriteLine("{0:f2},{1:f2}", spectrum[wavelengthIndex][i], spectrum[index][i]);
            }

            logger.display("Saved {0}", pathname);
            saveFileName = pathname;
        }

        public void closeAdvanced()
        {
            advancedFormOpen = false;
        }

        public double[] getAdvancedSpectrum()
        {
            return advancedSpectrum;
        }

        public double[] getWavelengths()
        {
            return spectrum[wavelengthIndex];
        }

        public void load(int index)
        {
            char[] comma = { ',' };
            String[] info;
            String fileName;

            if (backgroundWorkerAcquisition.IsBusy)
            {
                backgroundWorkerAcquisition.CancelAsync();
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = openFileDialog.FileName;

            if (fileName != null)
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
                {
                    String line = reader.ReadLine();
                    if (line != "wavelength,intensities")
                    {
                        logger.log("File was not created by Cringe");
                        return;
                    }
                    for (int i = 0; i < pixels; i++ )
                    {
                        line = reader.ReadLine();
                        info = line.Split(comma);

                        spectrum[0][i] = Double.Parse(info[0]);
                        spectrum[index][i] = Double.Parse(info[1]);

                    }
                    
                    drawGraph(pixels, index - 1);
                    
                    if (!backgroundWorkerAcquisition.IsBusy)
                    {
                        backgroundWorkerAcquisition.RunWorkerAsync();
                    }
                }
            }
        }
    }
}
