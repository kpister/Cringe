using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cringe
{
    public partial class Form1
    {
        ////////////////////////////////////////////////////////////////////////
        // Background Worker
        ////////////////////////////////////////////////////////////////////////

        private void backgroundWorkerAcquisition_DoWork(object sender, DoWorkEventArgs e)
        {
            //logger.setTextBox(textBoxAquiLog);
            logger.log("[Acquisition] starting...");
            if (spectrometer == null || !spectrometer.isOk())
            {
                logger.log("Can't start acquisition (missing spectrometer or driver)");
                return;
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            int scanCount = 0;

            
            while (!worker.CancellationPending)
            {                
                workingSpectrum = new double[pixels];
                if (spectrometer != null)
                {
                    workingSpectrum = spectrometer.getSpectrum();
                }
                
                if (reflectance)
                {
                    adjustReflectance();
                }
                if (workingSpectrum == null || spectrum[workingIndex].Length != pixels)
                {
                    logger.log("Error taking acquisition");
                    break;
                }

                // trigger graph update in GUI thread
                worker.ReportProgress(scanCount++);

                // necessary to ensure the GUI stays responsive
                
                Thread.Sleep(integrationTimeMillisec);

                
            }
            logger.log("[Acquisition] done");
        }

        private void backgroundWorkerAcquisition_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateGraph();
        }

        private void backgroundWorkerAcquisition_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            logger.log("[AcquistionComplete] worker cleanup");
            if (closePending)
            {
                if (backgroundWorkerAcquisition.IsBusy)
                    backgroundWorkerAcquisition.CancelAsync();

                logger.log("[CleanShutdown] shutdown initiated");

                // block further user input
                this.Enabled = false;

                // shutdown spectrometer
                spectrometer.close();
                this.Close();
                
            }
        }

    }
}
