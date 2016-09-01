using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cringe
{
    public partial class Form1
    {
        /* set all the buttons to false so that you can't click them on start */
        public void disableButtons()
        {
            buttonReflectance.Enabled = false;
            buttonMirror.Enabled = false;
            buttonSwapGraphs.Enabled = false;
            buttonAdvanced.Enabled = false;
        }

        /* All the buttons! */

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            advanced = new Form3(this, pixels, details);
            advancedFormOpen = true;
            advanced.Show();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.Show();
        }
       

        private void buttonLooyenga_Click(object sender, EventArgs e)
        {
            doLooyenga(); 
        }

        /* set the mirror series */
        private void buttonMirror_Click(object sender, EventArgs e)
        {
            mirror = true;
            buttonReflectance.Enabled = true;
            logger.display("Mirror saved");
        }
        /* move on to the next spectrum */
        

        /* perform the fft */
        private void buttonPerform_Click(object sender, EventArgs e)
        {
            buttonSwapGraphs.Enabled = true;
            clearFFTSeries();

            chartFFT.Visible = true;
            chartSpectrum.Visible = false;

            chartFFT.ChartAreas[0].AxisY.Maximum = 500;

            int min = 0;
            int max = 0;
            for (int i = 0; i < pixels; i++)
            {
                if (spectrum[wavelengthIndex][i] >= Double.Parse(textMinWavVal.Text) - .25 &&
                    spectrum[wavelengthIndex][i] <= Double.Parse(textMinWavVal.Text) + .25)
                {
                    min = i;
                }
                if (spectrum[wavelengthIndex][i] >= Double.Parse(textMaxWavVal.Text) - .25 &&
                    spectrum[wavelengthIndex][i] <= Double.Parse(textMaxWavVal.Text) + .25)
                {
                    max = i;
                }
            }


            if (checkBoxAir.Checked)
            {
                Tuple<double, double> peak = doFFT(max, min, spectrum[airIndex], fftSeries[airIndex - airIndex]);
                peaks[0] = peak.Item1;
            }
            if (checkBoxLiquid.Checked)
            {
                peaks[1] = doFFT(max, min, spectrum[liquidIndex], fftSeries[liquidIndex - airIndex]).Item1;
            }
            if (checkBoxOther.Checked)
            {
                peaks[2] = doFFT(max, min, spectrum[otherIndex], fftSeries[otherIndex - airIndex]).Item1;
            }

            text2nLair.Text = (peaks[0] + "        ").Substring(0,8);
            text2nLliquid.Text = (peaks[1] + "        ").Substring(0, 8);
            text2nLOther.Text = (peaks[2] + "        ").Substring(0, 8);
            
            Refresh();
        }

        /* calculate the reflectance, only available after mirror is active */
        private void buttonReflectance_Click(object sender, EventArgs e)
        {
            if (reflectance)
            {
                chartSpectrum.ChartAreas[0].AxisY.Maximum = yAxisMax;
                chartSpectrum.ChartAreas[0].AxisY.Minimum = 1000;
                reflectance = false;
                unreflectSpectra();
                logger.display("Reflectance off");
                buttonMirror.Enabled = true;
            }
            else
            {
                chartSpectrum.ChartAreas[0].AxisY.Maximum = 1;
                chartSpectrum.ChartAreas[0].AxisY.Minimum = 0;
                reflectance = true;
                reflectSpectra();
                logger.display("Reflectance on");
                buttonMirror.Enabled = false;
            }
        }

        /* reset the program back to the beginning state */
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //if (backgroundWorkerAcquisition.IsBusy)
            //    backgroundWorkerAcquisition.CancelAsync();
            if (advanced != null)
            {
                advanced.Close();
            }
            Refresh();
            
            numericUpDownIntegrationTimeMillisec.Value = initialIntegrationTime;

            initializeSpectrometer();
            Refresh();

            clearSeries();
            clearFFTSeries();

            textMaxWavVal.Text = initialMaxWav + "";
            textMinWavVal.Text = initialMinWav + "";
            chartSpectrum.ChartAreas[0].AxisY.Maximum = initialYAxisMax;
            yAxisMax = initialYAxisMax;

            textSkeleton.Text = "3.1";
            text2nLliquid.Text = "0.0";
            text2nLair.Text = "0.0";
            text2nLOther.Text = "0.0";
            textLiquidIndex.Text = "0.0";
            domainUpDownLiquid.Text = "Liquid";
            textOtherIndex.Text = "0.0";
            domainUpDownOther.Text = "Liquid";
            textPorosity.Text = "0.0";
            textThickness.Text = "0.0";

            domainUpDownAir.SelectedIndex = 0;
            domainUpDownLiquid.SelectedIndex = 0;
            series[0].Points.AddXY(0, 0);

            series[1].Points.Clear();
            series[2].Points.Clear();
            series[3].Points.Clear();
            series[4].Points.Clear();

            spectralMaxes[0] = initialYAxisMax;
            spectralMaxes[1] = initialYAxisMax;
            spectralMaxes[2] = initialYAxisMax;
            spectralMaxes[3] = initialYAxisMax;
            spectralMaxes[4] = initialYAxisMax;

            checkBoxAir.Checked = false;
            checkBoxLiquid.Checked = false;
            checkBoxOther.Checked = false;

            reflectance = false;
            mirror = false;
            saveAir = false;
            saveLiquid = false;
            saveOther = false;

        }

      
        /* set the minimum wavelength for the fft */
        private void buttonSetMinWav_Click(object sender, EventArgs e)
        {
            textMinWavVal.Text = xPos.ToString();
        }

        /* set the maximum wavelength for the fft */
        private void buttonSetMaxWav_Click(object sender, EventArgs e)
        {
            textMaxWavVal.Text = xPos.ToString();
        }

        /* switch between the chart and the fft */
        private void buttonSwapGraphs_Click(object sender, EventArgs e)
        {
            swapGraphs();
        }

        /* the change integrationtime button */
        private void numericUpDownIntegrationTimeMillisec_ValueChanged(object sender, EventArgs e)
        {
            updateSpectrometerFromGUI();
        }

        /* select the liquid you used, and set the refractive index accordingly */
        private void domainUpDownLiquid_SelectedItemChanged(object sender, EventArgs e)
        {
            textLiquidIndex.Text = refractiveIndices[1, domainUpDownLiquid.SelectedIndex+1];
        }

        private void domainUpDownOther_SelectedItemChanged(object sender, EventArgs e)
        {
            textOtherIndex.Text = refractiveIndices[1, domainUpDownOther.SelectedIndex+1];
        }

        private void domainUpDownAir_SelectedItemChanged(object sender, EventArgs e)
        {
            textAirIndex.Text = refractiveIndices[1, domainUpDownAir.SelectedIndex];
        }

        /* when you click the chart, set the x and y coords */
        private void chartSpectrum_Click(object sender, EventArgs e)
        {
            xPos = chartSpectrum.ChartAreas[0].CursorX.Position;
            yPos = chartSpectrum.ChartAreas[0].CursorY.Position;
            labelXAxis.Text = "x: " + xPos.ToString();
            labelYAxis.Text = "y: " + yPos.ToString();
        }

        private void mouseScroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && chartSpectrum.ChartAreas[0].AxisY.Maximum > 1500)
            {
                chartSpectrum.ChartAreas[0].AxisY.Maximum -= chartSpectrum.ChartAreas[0].AxisY.Maximum * .2;

            }
            if (e.Delta < 0 && chartSpectrum.ChartAreas[0].AxisY.Maximum < 100000)
            {
                chartSpectrum.ChartAreas[0].AxisY.Maximum += chartSpectrum.ChartAreas[0].AxisY.Maximum * .2;
            }
        }

        private void buttonSaveAir_Click(object sender, EventArgs e)
        {
            saveAir = true;
            checkBoxAir.Checked = true;
            updateGraph();
            save(airIndex);
        }

        private void buttonSaveLiquid_Click(object sender, EventArgs e)
        {
            saveLiquid = true;
            checkBoxLiquid.Checked = true;
            updateGraph();
            save(liquidIndex);
        }

        private void buttonSaveOther_Click(object sender, EventArgs e)
        {
            saveOther = true;
            checkBoxOther.Checked = true;
            updateGraph();
            save(otherIndex);
        }

        private void buttonLoadAir_Click(object sender, EventArgs e)
        {
            load(airIndex);
            checkBoxAir.Checked = true;

        }

        private void buttonLoadLiquid_Click(object sender, EventArgs e)
        {
            load(liquidIndex);
            checkBoxLiquid.Checked = true;

        }

        private void buttonLoadOther_Click(object sender, EventArgs e)
        {
            load(otherIndex);
            checkBoxOther.Checked = true;

        }
    }
}
