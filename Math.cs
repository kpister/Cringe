using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;


namespace Cringe
{
    public partial class Form1
    {
        /* the fft algorithm */
        public Tuple<double, double> doFFT(int max, int min, double[] mSpectrum, Series mSeries)
        {
            Tuple<double, double> peakPoint = new Tuple<double, double>(0, 0);
            
            int dataPoints = max - min;
            double[] invertedXAxis = new double[dataPoints];
            double[] tempFFT = new double[dataPoints];
            double[] finalData = new double[dataPoints];
            double[] intensities = new double[dataPoints];
            Complex[] tempFFTComplex = new Complex[dataPoints];

            Array.Copy(mSpectrum, min, intensities, 0, dataPoints);

            for (int i = 0; i < dataPoints; i++)
            {
                invertedXAxis[i] = 1 / spectrum[wavelengthIndex][i + min];
            }

            Array.Reverse(invertedXAxis);
            Array.Reverse(intensities);

            CubicSpline spline = new CubicSpline();
            double step = (invertedXAxis[dataPoints - 1] - invertedXAxis[0]) / (dataPoints - 1);
            double[] newx = new double[dataPoints];

            for (int i = 0; i < dataPoints; i++)
            {
                newx[i] = invertedXAxis[0] + i * step;
            }
            float[] floatedX = Array.ConvertAll(invertedXAxis, x => (float)x);
            float[] floatedY = Array.ConvertAll(intensities, x => (float)x);
            float[] floatedNewX = Array.ConvertAll(newx, x => (float)x);


            float[] newy = spline.FitAndEval(floatedX, floatedY, floatedNewX, float.NaN, float.NaN, false);

            double diff = 1 / (floatedNewX[11] - floatedNewX[10]);
            diff /= dataPoints;


            double[] hannWindow = Window.Hann(dataPoints);

            for (int i = 0; i < hannWindow.Length; i++)
            {
                tempFFT[i] = hannWindow[i] * newy[i];
            }

            for (int i = 0; i < tempFFT.Length; i++)
            {
                tempFFTComplex[i] = new Complex(tempFFT[i], 0);
            }

            Fourier.Forward(tempFFTComplex);

            for (int i = 0; i < dataPoints; i++)
            {
                finalData[i] = Math.Sqrt(Math.Pow(tempFFTComplex[i].Real, 2) + Math.Pow(tempFFTComplex[i].Imaginary, 2));
            }

            if (mSeries != null)
            {
                mSeries.Points.Clear();
            }

            double peak = 0;
            double peakIntensity = 0;

            for (int i = 0; i < dataPoints; i++)
            {

                if (peakIntensity < finalData[i])
                {
                    if (i * diff < 180000 && i * diff > 8000) { 
                        peak = i * diff;
                        peakIntensity = finalData[i];
                    }
                }
                if (mSeries != null)
                {
                    mSeries.Points.AddXY(i * diff, finalData[i]);
                }
            }

            if (peakIntensity * 2 > chartFFT.ChartAreas[0].AxisY.Maximum)
            {
                chartFFT.ChartAreas[0].AxisY.Maximum = peakIntensity * 2; 
            }

            peakPoint = new Tuple<double,double>(peak, peakIntensity);
            return peakPoint;
        }

        /* EOT(fill) = 2L[P*nFill^(2/3)+(1-P)*nPSi^(2/3)]^(3/2) */

        public void doLooyenga()
        {
            
            double twoNLAir = Double.Parse(text2nLair.Text);
            double twoNLLiquid = Double.Parse(text2nLliquid.Text);
            double twoNLOther = Double.Parse(text2nLOther.Text);
            double skeletonIndex = Double.Parse(textSkeleton.Text);

            doSimpleLooyenga(twoNLAir, twoNLLiquid, skeletonIndex);

            /*Cannot perform complicated looyenga at this point
            if (twoNLOther == 0.0 && twoNLAir != 0.0 && twoNLLiquid != 0.0)
            {
                double skeletonIndex = Double.Parse(textSkeleton.Text);
                doSimpleLooyenga(twoNLAir, twoNLLiquid, skeletonIndex);
            }
            else if (twoNLOther != 0.0 && twoNLAir != 0.0 && twoNLLiquid != 0.0)
            {
                doComplicatedLooyenga(twoNLAir, twoNLLiquid, twoNLOther);
            }
            else
                logger.display("Cannot perform Looyenga without 2 or 3 nL values");
             */

        }

        public void doSimpleLooyenga(double twoNLAir, double twoNLLiquid, double skeletonIndex1)
        {
            double[][] myMatrix = new double[2][];
            myMatrix[0] = new double[3];
            myMatrix[1] = new double[3];

            double refractiveAir1 = Double.Parse(textAirIndex.Text);
            double refractiveLiquid1 = Double.Parse(textLiquidIndex.Text);

            double skeletonIndex = Math.Pow(skeletonIndex1, .66666667);
            double refractiveAir = Math.Pow(refractiveAir1, .66666667);
            double refractiveLiquid = Math.Pow(refractiveLiquid1, .66666667);

            myMatrix[0][0] = refractiveAir - skeletonIndex;
            myMatrix[1][0] = refractiveLiquid - skeletonIndex;
            myMatrix[0][1] = 0 - Math.Pow((twoNLAir / 2), .666666667);
            myMatrix[1][1] = 0 - Math.Pow((twoNLLiquid / 2), .66666667);
            myMatrix[0][2] = 0 - skeletonIndex;
            myMatrix[1][2] = 0 - skeletonIndex;

            double scale1 = myMatrix[1][0];
            double scale2 = myMatrix[0][0];

            myMatrix[0][0] *= scale1;
            myMatrix[0][1] *= scale1;
            myMatrix[0][2] *= scale1;

            myMatrix[1][0] *= scale2;
            myMatrix[1][1] *= scale2;
            myMatrix[1][2] *= scale2;

            myMatrix[1][0]  = 0;
            myMatrix[1][1] -= myMatrix[0][1];
            myMatrix[1][2] -= myMatrix[0][2];

            scale1 = myMatrix[1][1];
            scale2 = myMatrix[0][1];

            myMatrix[0][0] *= scale1;
            myMatrix[0][1] *= scale1;
            myMatrix[0][2] *= scale1;

            myMatrix[1][0] *= scale2;
            myMatrix[1][1] *= scale2;
            myMatrix[1][2] *= scale2;

            myMatrix[0][0] -= myMatrix[1][0];
            myMatrix[0][1]  = 0;
            myMatrix[0][2] -= myMatrix[1][2];

            Porosity = myMatrix[0][2] / myMatrix[0][0];
            logger.log("Porosity {0}", Porosity);
            double thickness1 = myMatrix[1][1] / myMatrix[1][2];
            Thickness = Math.Pow(thickness1, 1.5);
            logger.log("Thickness {0}", Thickness);


            double partOne = Porosity * Math.Pow(refractiveAir, .6666666667);
            double partTwo = (1 - Porosity) * Math.Pow(skeletonIndex, .66666666667);
            double partThree = twoNLAir / (2 * Thickness);
            partThree = Math.Pow(partThree, .66666666667);
            logger.display((partOne + partTwo -partThree) + "");

            double partOne1 = Porosity * Math.Pow(refractiveLiquid, .6666666667);
            double partTwo1 = (1 - Porosity) * Math.Pow(skeletonIndex, .66666666667);
            double partThree1 = twoNLLiquid / (2 * Thickness);
            partThree1 = Math.Pow(partThree1, .66666667);
            logger.display((partOne1 + partTwo1 - partThree1) + "");

            double orosity = Porosity * 100;
            String poro = orosity + "";
            String thick = Thickness + "";
            /* EOT(fill) = 2L[P*nFill^(2/3)+(1-P)*nPSi^(2/3)]^(3/2) */

            if (poro.Length > 6)
                textPorosity.Text = poro.Substring(0, 6) + "%";
            else
                textPorosity.Text = poro + "%";


            if (thick.Length > 8)
                textThickness.Text = thick.Substring(0, 8);
            else
                textThickness.Text = thick;
        }
        /*
        public void doComplicatedLooyenga(double twoNLAir, double twoNLLiquid, double twoNLOther)
        {
            double skeletonIndex = 1.5;
            double step = .001;
            double refractiveOther = Double.Parse(textOtherIndex.Text);

            while (skeletonIndex < 4)
            {
                doSimpleLooyenga(twoNLAir, twoNLLiquid, skeletonIndex);
                double partOne = Porosity * Math.Pow(refractiveOther, .6666666667);
                double partTwo = (1 - Porosity) * Math.Pow(skeletonIndex, .66666666667);
                double together = partOne + partTwo;
                together = Math.Pow(together, 1.5);
                //logger.display(partOne + "    " + partTwo + "   " + (2 * Thickness) + "    " + Porosity + "   " + together);

                if (twoNLOther >= (2 * Thickness * together - 2000) && twoNLOther <= (2 * Thickness * together + 2000))
                {
                    //logger.display(skeletonIndex + "    " +twoNLOther + "     " + (2 * Thickness * together));
                    //break;
                }

                skeletonIndex += step;
            }
            textSkeleton.Text = skeletonIndex + "";
        }
         */
    }
}
