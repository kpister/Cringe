namespace Cringe
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.domainUpDownInterval = new System.Windows.Forms.DomainUpDown();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.domainUpDownDuration = new System.Windows.Forms.DomainUpDown();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxNumberSpectra = new System.Windows.Forms.TextBox();
            this.labelSpectraNumber = new System.Windows.Forms.Label();
            this.labelOr = new System.Windows.Forms.Label();
            this.chartSpectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxFFT = new System.Windows.Forms.GroupBox();
            this.buttonSetMaxWav = new System.Windows.Forms.Button();
            this.buttonSetMinWav = new System.Windows.Forms.Button();
            this.textBoxMaxWavVal = new System.Windows.Forms.TextBox();
            this.textBoxMinWavVal = new System.Windows.Forms.TextBox();
            this.labelMaxWav = new System.Windows.Forms.Label();
            this.labelMinWav = new System.Windows.Forms.Label();
            this.chartFFTMag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFFTPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorkerAdvanced = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectrum)).BeginInit();
            this.groupBoxFFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFTMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFTPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Arial", 12F);
            this.labelInterval.Location = new System.Drawing.Point(6, 66);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(56, 18);
            this.labelInterval.TabIndex = 0;
            this.labelInterval.Text = "Interval";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.Location = new System.Drawing.Point(82, 66);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(50, 20);
            this.textBoxInterval.TabIndex = 1;
            this.textBoxInterval.Text = "0";
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // domainUpDownInterval
            // 
            this.domainUpDownInterval.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownInterval.Items.Add("Seconds");
            this.domainUpDownInterval.Items.Add("Minutes");
            this.domainUpDownInterval.Items.Add("Hours");
            this.domainUpDownInterval.Items.Add("Days");
            this.domainUpDownInterval.Location = new System.Drawing.Point(138, 66);
            this.domainUpDownInterval.Name = "domainUpDownInterval";
            this.domainUpDownInterval.Size = new System.Drawing.Size(68, 20);
            this.domainUpDownInterval.TabIndex = 2;
            this.domainUpDownInterval.Text = "Units";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDuration.Location = new System.Drawing.Point(6, 31);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(67, 18);
            this.labelDuration.TabIndex = 4;
            this.labelDuration.Text = "Duration";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuration.Location = new System.Drawing.Point(82, 31);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(50, 20);
            this.textBoxDuration.TabIndex = 5;
            this.textBoxDuration.Text = "0";
            this.textBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // domainUpDownDuration
            // 
            this.domainUpDownDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownDuration.Items.Add("Seconds");
            this.domainUpDownDuration.Items.Add("Minutes");
            this.domainUpDownDuration.Items.Add("Hours");
            this.domainUpDownDuration.Items.Add("Days");
            this.domainUpDownDuration.Location = new System.Drawing.Point(138, 31);
            this.domainUpDownDuration.Name = "domainUpDownDuration";
            this.domainUpDownDuration.Size = new System.Drawing.Size(68, 20);
            this.domainUpDownDuration.TabIndex = 6;
            this.domainUpDownDuration.Text = "Units";
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.Location = new System.Drawing.Point(245, 109);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(217, 113);
            this.buttonRecord.TabIndex = 7;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.textBoxNumberSpectra);
            this.groupBox1.Controls.Add(this.labelSpectraNumber);
            this.groupBox1.Controls.Add(this.labelOr);
            this.groupBox1.Controls.Add(this.labelDuration);
            this.groupBox1.Controls.Add(this.domainUpDownDuration);
            this.groupBox1.Controls.Add(this.domainUpDownInterval);
            this.groupBox1.Controls.Add(this.textBoxInterval);
            this.groupBox1.Controls.Add(this.textBoxDuration);
            this.groupBox1.Controls.Add(this.labelInterval);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Spectra Over Time";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(10, 159);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 41);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxNumberSpectra
            // 
            this.textBoxNumberSpectra.Enabled = false;
            this.textBoxNumberSpectra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberSpectra.Location = new System.Drawing.Point(145, 131);
            this.textBoxNumberSpectra.Name = "textBoxNumberSpectra";
            this.textBoxNumberSpectra.Size = new System.Drawing.Size(61, 20);
            this.textBoxNumberSpectra.TabIndex = 30;
            this.textBoxNumberSpectra.Text = "0";
            this.textBoxNumberSpectra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSpectraNumber
            // 
            this.labelSpectraNumber.AutoSize = true;
            this.labelSpectraNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.labelSpectraNumber.Location = new System.Drawing.Point(6, 131);
            this.labelSpectraNumber.Name = "labelSpectraNumber";
            this.labelSpectraNumber.Size = new System.Drawing.Size(139, 18);
            this.labelSpectraNumber.TabIndex = 29;
            this.labelSpectraNumber.Text = "Number of Spectra";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Arial", 10F);
            this.labelOr.Location = new System.Drawing.Point(7, 102);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(199, 16);
            this.labelOr.TabIndex = 28;
            this.labelOr.Text = "----------------- or -----------------";
            // 
            // chartSpectrum
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 200D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.Format = "F0";
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Maximum = 1100D;
            chartArea1.AxisX.Minimum = 300D;
            chartArea1.AxisX.Title = "Wavelength (nm)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisY.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Maximum = 4000D;
            chartArea1.AxisY.MaximumAutoSize = 25F;
            chartArea1.AxisY.Minimum = 1000D;
            chartArea1.AxisY.Title = "Intensity (Counts)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Title = "µWatts / cm² / nm";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Blue;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85.46281F;
            chartArea1.InnerPlotPosition.Width = 84.63895F;
            chartArea1.InnerPlotPosition.X = 12.00998F;
            chartArea1.InnerPlotPosition.Y = 2.44677F;
            chartArea1.Name = "ChartAreaSpectraAdvanced";
            this.chartSpectrum.ChartAreas.Add(chartArea1);
            this.chartSpectrum.Location = new System.Drawing.Point(468, 13);
            this.chartSpectrum.Name = "chartSpectrum";
            series1.ChartArea = "ChartAreaSpectraAdvanced";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LegendText = "Air";
            series1.Name = "mainSpectrum";
            this.chartSpectrum.Series.Add(series1);
            this.chartSpectrum.Size = new System.Drawing.Size(450, 308);
            this.chartSpectrum.TabIndex = 9;
            this.chartSpectrum.Text = "Spectrum";
            this.chartSpectrum.Click += new System.EventHandler(this.chartSpectrum_Click);
            // 
            // groupBoxFFT
            // 
            this.groupBoxFFT.Controls.Add(this.buttonSetMaxWav);
            this.groupBoxFFT.Controls.Add(this.buttonSetMinWav);
            this.groupBoxFFT.Controls.Add(this.textBoxMaxWavVal);
            this.groupBoxFFT.Controls.Add(this.textBoxMinWavVal);
            this.groupBoxFFT.Controls.Add(this.labelMaxWav);
            this.groupBoxFFT.Controls.Add(this.labelMinWav);
            this.groupBoxFFT.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBoxFFT.Location = new System.Drawing.Point(245, 13);
            this.groupBoxFFT.Name = "groupBoxFFT";
            this.groupBoxFFT.Size = new System.Drawing.Size(217, 93);
            this.groupBoxFFT.TabIndex = 11;
            this.groupBoxFFT.TabStop = false;
            this.groupBoxFFT.Text = "FFT";
            // 
            // buttonSetMaxWav
            // 
            this.buttonSetMaxWav.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetMaxWav.Location = new System.Drawing.Point(171, 59);
            this.buttonSetMaxWav.Name = "buttonSetMaxWav";
            this.buttonSetMaxWav.Size = new System.Drawing.Size(36, 25);
            this.buttonSetMaxWav.TabIndex = 13;
            this.buttonSetMaxWav.Text = "Set";
            this.buttonSetMaxWav.UseVisualStyleBackColor = true;
            this.buttonSetMaxWav.Click += new System.EventHandler(this.buttonSetMaxWav_Click);
            // 
            // buttonSetMinWav
            // 
            this.buttonSetMinWav.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetMinWav.Location = new System.Drawing.Point(171, 31);
            this.buttonSetMinWav.Name = "buttonSetMinWav";
            this.buttonSetMinWav.Size = new System.Drawing.Size(36, 25);
            this.buttonSetMinWav.TabIndex = 12;
            this.buttonSetMinWav.Text = "Set";
            this.buttonSetMinWav.UseVisualStyleBackColor = true;
            this.buttonSetMinWav.Click += new System.EventHandler(this.buttonSetMinWav_Click);
            // 
            // textBoxMaxWavVal
            // 
            this.textBoxMaxWavVal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxWavVal.Location = new System.Drawing.Point(7, 59);
            this.textBoxMaxWavVal.Name = "textBoxMaxWavVal";
            this.textBoxMaxWavVal.Size = new System.Drawing.Size(40, 21);
            this.textBoxMaxWavVal.TabIndex = 10;
            this.textBoxMaxWavVal.Text = "1000";
            // 
            // textBoxMinWavVal
            // 
            this.textBoxMinWavVal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinWavVal.Location = new System.Drawing.Point(7, 31);
            this.textBoxMinWavVal.Name = "textBoxMinWavVal";
            this.textBoxMinWavVal.Size = new System.Drawing.Size(40, 21);
            this.textBoxMinWavVal.TabIndex = 9;
            this.textBoxMinWavVal.Text = "600";
            // 
            // labelMaxWav
            // 
            this.labelMaxWav.AutoSize = true;
            this.labelMaxWav.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelMaxWav.Location = new System.Drawing.Point(50, 62);
            this.labelMaxWav.Name = "labelMaxWav";
            this.labelMaxWav.Size = new System.Drawing.Size(111, 14);
            this.labelMaxWav.TabIndex = 8;
            this.labelMaxWav.Text = "Maximum Wavelength";
            // 
            // labelMinWav
            // 
            this.labelMinWav.AutoSize = true;
            this.labelMinWav.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelMinWav.Location = new System.Drawing.Point(50, 34);
            this.labelMinWav.Name = "labelMinWav";
            this.labelMinWav.Size = new System.Drawing.Size(107, 14);
            this.labelMinWav.TabIndex = 7;
            this.labelMinWav.Text = "Minimum Wavelength";
            // 
            // chartFFTMag
            // 
            chartArea2.AxisX.Interval = 20D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.Format = "F0";
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 500000D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "FFT Magnitude";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.Title = "µWatts / cm² / nm";
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.Blue;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea2.Name = "ChartAreaMagTime";
            this.chartFFTMag.ChartAreas.Add(chartArea2);
            this.chartFFTMag.Location = new System.Drawing.Point(468, 327);
            this.chartFFTMag.Name = "chartFFTMag";
            series2.ChartArea = "ChartAreaMagTime";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.LegendText = "Air";
            series2.Name = "FFTMagTime";
            this.chartFFTMag.Series.Add(series2);
            this.chartFFTMag.Size = new System.Drawing.Size(450, 345);
            this.chartFFTMag.TabIndex = 28;
            this.chartFFTMag.Text = "FFT";
            // 
            // chartFFTPosition
            // 
            chartArea3.AxisX.Interval = 20D;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.Format = "F0";
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea3.AxisX2.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Maximum = 80000D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Optical Thickness (um)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.Title = "µWatts / cm² / nm";
            chartArea3.AxisY2.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.LineColor = System.Drawing.Color.Blue;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea3.Name = "ChartAreaPosTime";
            this.chartFFTPosition.ChartAreas.Add(chartArea3);
            this.chartFFTPosition.Location = new System.Drawing.Point(12, 327);
            this.chartFFTPosition.Name = "chartFFTPosition";
            series3.ChartArea = "ChartAreaPosTime";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "FFTPosTime";
            this.chartFFTPosition.Series.Add(series3);
            this.chartFFTPosition.Size = new System.Drawing.Size(450, 345);
            this.chartFFTPosition.TabIndex = 29;
            this.chartFFTPosition.Text = "FFT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21F);
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kaiser Pister Development Studios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21F);
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Supported by UCSD and NDair";
            // 
            // backgroundWorkerAdvanced
            // 
            this.backgroundWorkerAdvanced.WorkerReportsProgress = true;
            this.backgroundWorkerAdvanced.WorkerSupportsCancellation = true;
            this.backgroundWorkerAdvanced.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAdvanced_DoWork);
            this.backgroundWorkerAdvanced.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerAdvanced_ProgressChanged);
            this.backgroundWorkerAdvanced.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAdvanced_RunWorkerCompleted);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartFFTPosition);
            this.Controls.Add(this.chartFFTMag);
            this.Controls.Add(this.groupBoxFFT);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartSpectrum);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Advanced";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectrum)).EndInit();
            this.groupBoxFFT.ResumeLayout(false);
            this.groupBoxFFT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFTMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFTPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.DomainUpDown domainUpDownInterval;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.DomainUpDown domainUpDownDuration;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpectrum;
        private System.Windows.Forms.GroupBox groupBoxFFT;
        private System.Windows.Forms.Button buttonSetMaxWav;
        private System.Windows.Forms.Button buttonSetMinWav;
        private System.Windows.Forms.TextBox textBoxMaxWavVal;
        private System.Windows.Forms.TextBox textBoxMinWavVal;
        private System.Windows.Forms.Label labelMaxWav;
        private System.Windows.Forms.Label labelMinWav;
        private System.Windows.Forms.Label labelSpectraNumber;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.TextBox textBoxNumberSpectra;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFTMag;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFTPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAdvanced;
    }
}