using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cringe
{
    public partial class Form3
    {
        ////////////////////////////////////////////////////////////////////////
        // Background Worker
        ////////////////////////////////////////////////////////////////////////
        Tuple<double, double> peak;

        private void backgroundWorkerAdvanced_DoWork(object sender, DoWorkEventArgs e)
        {
            

            BackgroundWorker worker = sender as BackgroundWorker;
            int scanCount = 0;

            
            while (!worker.CancellationPending)
            {
                Array.Copy(spectrum, fftConstSpectrum, spectrum.Length);

                peak = form1.doFFT(max, min, fftConstSpectrum, null);
                logger.display("int: {0}, peakstuff: {1}, {2}", (int) interval, peak.Item1, peak.Item2);

                // trigger graph update in GUI thread
                
                worker.ReportProgress(scanCount++);
              
                // necessary to ensure the GUI stays responsive
                
                Thread.Sleep((int) interval * 1000);

                
            }
            logger.log("[Acquisition] done");
        }

        private void backgroundWorkerAdvanced_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateGraphs(peak.Item1 , peak.Item2);
        }

        private void backgroundWorkerAdvanced_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            logger.log("[AcquistionComplete] worker cleanup");
            if (form1.closePending)
            {
                if (backgroundWorkerAdvanced.IsBusy)
                {
                    backgroundWorkerAdvanced.CancelAsync();
                }

                logger.log("[CleanShutdown] shutdown initiated");

                // block further user input
                this.Enabled = false;
            }
        }

    }
}
