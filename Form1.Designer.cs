namespace Cringe
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartSpectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.buttonLoadOther = new System.Windows.Forms.Button();
            this.buttonLoadLiquid = new System.Windows.Forms.Button();
            this.buttonLoadAir = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveOther = new System.Windows.Forms.Button();
            this.buttonSaveLiquid = new System.Windows.Forms.Button();
            this.buttonSaveAir = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonReflectance = new System.Windows.Forms.Button();
            this.buttonMirror = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntegrationTimeMillisec = new System.Windows.Forms.NumericUpDown();
            this.labelIntegrationTime = new System.Windows.Forms.Label();
            this.labelPixelText = new System.Windows.Forms.Label();
            this.labelPixels = new System.Windows.Forms.Label();
            this.textBoxEventLog = new System.Windows.Forms.TextBox();
            this.backgroundWorkerAcquisition = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialogSpectra = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxFFT = new System.Windows.Forms.GroupBox();
            this.buttonSwapGraphs = new System.Windows.Forms.Button();
            this.buttonSetMaxWav = new System.Windows.Forms.Button();
            this.buttonSetMinWav = new System.Windows.Forms.Button();
            this.buttonPerform = new System.Windows.Forms.Button();
            this.textMaxWavVal = new System.Windows.Forms.TextBox();
            this.textMinWavVal = new System.Windows.Forms.TextBox();
            this.labelMaxWav = new System.Windows.Forms.Label();
            this.labelMinWav = new System.Windows.Forms.Label();
            this.groupBoxCalc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDownAir = new System.Windows.Forms.DomainUpDown();
            this.textAirIndex = new System.Windows.Forms.TextBox();
            this.labelIndex2 = new System.Windows.Forms.Label();
            this.labelIndex1 = new System.Windows.Forms.Label();
            this.domainUpDownOther = new System.Windows.Forms.DomainUpDown();
            this.text2nLOther = new System.Windows.Forms.TextBox();
            this.label2nLOther = new System.Windows.Forms.Label();
            this.textOtherIndex = new System.Windows.Forms.TextBox();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.text2nLair = new System.Windows.Forms.TextBox();
            this.label2nLAir = new System.Windows.Forms.Label();
            this.domainUpDownLiquid = new System.Windows.Forms.DomainUpDown();
            this.buttonLooyenga = new System.Windows.Forms.Button();
            this.labelNM = new System.Windows.Forms.Label();
            this.labelThickness = new System.Windows.Forms.Label();
            this.labelPorosity = new System.Windows.Forms.Label();
            this.label2nLLiquid = new System.Windows.Forms.Label();
            this.text2nLliquid = new System.Windows.Forms.TextBox();
            this.textThickness = new System.Windows.Forms.TextBox();
            this.textPorosity = new System.Windows.Forms.TextBox();
            this.textLiquidIndex = new System.Windows.Forms.TextBox();
            this.labelSkeleton = new System.Windows.Forms.Label();
            this.textSkeleton = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelXAxis = new System.Windows.Forms.Label();
            this.labelYAxis = new System.Windows.Forms.Label();
            this.groupBoxSpectra = new System.Windows.Forms.GroupBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.checkBoxLiquid = new System.Windows.Forms.CheckBox();
            this.checkBoxAir = new System.Windows.Forms.CheckBox();
            this.chartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxSimpleSlim = new System.Windows.Forms.GroupBox();
            this.buttonLooyengaSimple = new System.Windows.Forms.Button();
            this.buttonPerformSimple = new System.Windows.Forms.Button();
            this.buttonSaveLiquidSimple = new System.Windows.Forms.Button();
            this.buttonSaveAirSimple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectrum)).BeginInit();
            this.groupBoxButton.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegrationTimeMillisec)).BeginInit();
            this.groupBoxFFT.SuspendLayout();
            this.groupBoxCalc.SuspendLayout();
            this.groupBoxSpectra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).BeginInit();
            this.groupBoxSimpleSlim.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSpectrum
            // 
            chartArea1.AxisX.Interval = 100D;
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
            chartArea1.Name = "ChartArea1";
            this.chartSpectrum.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartSpectrum.Legends.Add(legend1);
            this.chartSpectrum.Location = new System.Drawing.Point(9, 13);
            this.chartSpectrum.Name = "chartSpectrum";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Air";
            series1.Name = "airSpectrum";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.LegendText = "Liquid";
            series2.Name = "liquidSpectrum";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Magenta;
            series3.Legend = "Legend1";
            series3.LegendText = "Other";
            series3.Name = "otherSpectrum";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.LegendText = "Mirror";
            series4.Name = "mirrorSpectrum";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "working";
            this.chartSpectrum.Series.Add(series1);
            this.chartSpectrum.Series.Add(series2);
            this.chartSpectrum.Series.Add(series3);
            this.chartSpectrum.Series.Add(series4);
            this.chartSpectrum.Series.Add(series5);
            this.chartSpectrum.Size = new System.Drawing.Size(633, 501);
            this.chartSpectrum.TabIndex = 0;
            this.chartSpectrum.Text = "Spectrum";
            this.chartSpectrum.Click += new System.EventHandler(this.chartSpectrum_Click);
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonLoadOther);
            this.groupBoxButton.Controls.Add(this.buttonLoadLiquid);
            this.groupBoxButton.Controls.Add(this.buttonLoadAir);
            this.groupBoxButton.Controls.Add(this.buttonHelp);
            this.groupBoxButton.Controls.Add(this.buttonSaveOther);
            this.groupBoxButton.Controls.Add(this.buttonSaveLiquid);
            this.groupBoxButton.Controls.Add(this.buttonSaveAir);
            this.groupBoxButton.Controls.Add(this.buttonReset);
            this.groupBoxButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxButton.Location = new System.Drawing.Point(9, 623);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(633, 58);
            this.groupBoxButton.TabIndex = 3;
            this.groupBoxButton.TabStop = false;
            this.groupBoxButton.Text = "Controls";
            // 
            // buttonLoadOther
            // 
            this.buttonLoadOther.Location = new System.Drawing.Point(467, 21);
            this.buttonLoadOther.Name = "buttonLoadOther";
            this.buttonLoadOther.Size = new System.Drawing.Size(71, 25);
            this.buttonLoadOther.TabIndex = 20;
            this.buttonLoadOther.Text = "Load Other";
            this.buttonLoadOther.UseVisualStyleBackColor = true;
            this.buttonLoadOther.Click += new System.EventHandler(this.buttonLoadOther_Click);
            // 
            // buttonLoadLiquid
            // 
            this.buttonLoadLiquid.Location = new System.Drawing.Point(390, 21);
            this.buttonLoadLiquid.Name = "buttonLoadLiquid";
            this.buttonLoadLiquid.Size = new System.Drawing.Size(71, 25);
            this.buttonLoadLiquid.TabIndex = 19;
            this.buttonLoadLiquid.Text = "Load Liquid";
            this.buttonLoadLiquid.UseVisualStyleBackColor = true;
            this.buttonLoadLiquid.Click += new System.EventHandler(this.buttonLoadLiquid_Click);
            // 
            // buttonLoadAir
            // 
            this.buttonLoadAir.Location = new System.Drawing.Point(313, 21);
            this.buttonLoadAir.Name = "buttonLoadAir";
            this.buttonLoadAir.Size = new System.Drawing.Size(71, 25);
            this.buttonLoadAir.TabIndex = 18;
            this.buttonLoadAir.Text = "Load Air";
            this.buttonLoadAir.UseVisualStyleBackColor = true;
            this.buttonLoadAir.Click += new System.EventHandler(this.buttonLoadAir_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Arial", 8.25F);
            this.buttonHelp.Location = new System.Drawing.Point(545, 21);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(82, 25);
            this.buttonHelp.TabIndex = 25;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSaveOther
            // 
            this.buttonSaveOther.Location = new System.Drawing.Point(236, 21);
            this.buttonSaveOther.Name = "buttonSaveOther";
            this.buttonSaveOther.Size = new System.Drawing.Size(71, 25);
            this.buttonSaveOther.TabIndex = 17;
            this.buttonSaveOther.Text = "Save Other";
            this.buttonSaveOther.UseVisualStyleBackColor = true;
            this.buttonSaveOther.Click += new System.EventHandler(this.buttonSaveOther_Click);
            // 
            // buttonSaveLiquid
            // 
            this.buttonSaveLiquid.Location = new System.Drawing.Point(153, 21);
            this.buttonSaveLiquid.Name = "buttonSaveLiquid";
            this.buttonSaveLiquid.Size = new System.Drawing.Size(77, 25);
            this.buttonSaveLiquid.TabIndex = 16;
            this.buttonSaveLiquid.Text = "Save Liquid";
            this.buttonSaveLiquid.UseVisualStyleBackColor = true;
            this.buttonSaveLiquid.Click += new System.EventHandler(this.buttonSaveLiquid_Click);
            // 
            // buttonSaveAir
            // 
            this.buttonSaveAir.Location = new System.Drawing.Point(79, 21);
            this.buttonSaveAir.Name = "buttonSaveAir";
            this.buttonSaveAir.Size = new System.Drawing.Size(68, 25);
            this.buttonSaveAir.TabIndex = 15;
            this.buttonSaveAir.Text = "Save Air";
            this.buttonSaveAir.UseVisualStyleBackColor = true;
            this.buttonSaveAir.Click += new System.EventHandler(this.buttonSaveAir_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(6, 21);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(67, 25);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonReflectance
            // 
            this.buttonReflectance.Location = new System.Drawing.Point(723, 157);
            this.buttonReflectance.Name = "buttonReflectance";
            this.buttonReflectance.Size = new System.Drawing.Size(73, 25);
            this.buttonReflectance.TabIndex = 15;
            this.buttonReflectance.Text = "Reflectance";
            this.buttonReflectance.UseVisualStyleBackColor = true;
            this.buttonReflectance.Click += new System.EventHandler(this.buttonReflectance_Click);
            // 
            // buttonMirror
            // 
            this.buttonMirror.Location = new System.Drawing.Point(650, 157);
            this.buttonMirror.Name = "buttonMirror";
            this.buttonMirror.Size = new System.Drawing.Size(67, 25);
            this.buttonMirror.TabIndex = 13;
            this.buttonMirror.Text = "Mirror";
            this.buttonMirror.UseVisualStyleBackColor = true;
            this.buttonMirror.Click += new System.EventHandler(this.buttonMirror_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.numericUpDownIntegrationTimeMillisec);
            this.groupBoxInfo.Controls.Add(this.labelIntegrationTime);
            this.groupBoxInfo.Controls.Add(this.labelPixelText);
            this.groupBoxInfo.Controls.Add(this.labelPixels);
            this.groupBoxInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(649, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(206, 47);
            this.groupBoxInfo.TabIndex = 4;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Spectrometer";
            // 
            // numericUpDownIntegrationTimeMillisec
            // 
            this.numericUpDownIntegrationTimeMillisec.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIntegrationTimeMillisec.Location = new System.Drawing.Point(77, 17);
            this.numericUpDownIntegrationTimeMillisec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIntegrationTimeMillisec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntegrationTimeMillisec.Name = "numericUpDownIntegrationTimeMillisec";
            this.numericUpDownIntegrationTimeMillisec.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownIntegrationTimeMillisec.TabIndex = 6;
            this.numericUpDownIntegrationTimeMillisec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownIntegrationTimeMillisec.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIntegrationTimeMillisec.ValueChanged += new System.EventHandler(this.numericUpDownIntegrationTimeMillisec_ValueChanged);
            // 
            // labelIntegrationTime
            // 
            this.labelIntegrationTime.AutoSize = true;
            this.labelIntegrationTime.Font = new System.Drawing.Font("Arial", 9.25F);
            this.labelIntegrationTime.Location = new System.Drawing.Point(6, 17);
            this.labelIntegrationTime.Name = "labelIntegrationTime";
            this.labelIntegrationTime.Size = new System.Drawing.Size(62, 16);
            this.labelIntegrationTime.TabIndex = 7;
            this.labelIntegrationTime.Text = "Integ (ns)";
            // 
            // labelPixelText
            // 
            this.labelPixelText.AutoSize = true;
            this.labelPixelText.Location = new System.Drawing.Point(139, 17);
            this.labelPixelText.Name = "labelPixelText";
            this.labelPixelText.Size = new System.Drawing.Size(35, 14);
            this.labelPixelText.TabIndex = 5;
            this.labelPixelText.Text = "Pixels";
            // 
            // labelPixels
            // 
            this.labelPixels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPixels.Font = new System.Drawing.Font("Arial", 6.25F);
            this.labelPixels.Location = new System.Drawing.Point(170, 17);
            this.labelPixels.Name = "labelPixels";
            this.labelPixels.Size = new System.Drawing.Size(31, 16);
            this.labelPixels.TabIndex = 4;
            this.labelPixels.Text = "0";
            // 
            // textBoxEventLog
            // 
            this.textBoxEventLog.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventLog.Location = new System.Drawing.Point(6, 286);
            this.textBoxEventLog.Multiline = true;
            this.textBoxEventLog.Name = "textBoxEventLog";
            this.textBoxEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventLog.Size = new System.Drawing.Size(194, 81);
            this.textBoxEventLog.TabIndex = 0;
            // 
            // backgroundWorkerAcquisition
            // 
            this.backgroundWorkerAcquisition.WorkerReportsProgress = true;
            this.backgroundWorkerAcquisition.WorkerSupportsCancellation = true;
            this.backgroundWorkerAcquisition.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAcquisition_DoWork);
            this.backgroundWorkerAcquisition.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerAcquisition_ProgressChanged);
            this.backgroundWorkerAcquisition.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAcquisition_RunWorkerCompleted);
            // 
            // saveFileDialogSpectra
            // 
            this.saveFileDialogSpectra.DefaultExt = "txt";
            // 
            // groupBoxFFT
            // 
            this.groupBoxFFT.Controls.Add(this.buttonSwapGraphs);
            this.groupBoxFFT.Controls.Add(this.buttonSetMaxWav);
            this.groupBoxFFT.Controls.Add(this.buttonSetMinWav);
            this.groupBoxFFT.Controls.Add(this.buttonPerform);
            this.groupBoxFFT.Controls.Add(this.textMaxWavVal);
            this.groupBoxFFT.Controls.Add(this.textMinWavVal);
            this.groupBoxFFT.Controls.Add(this.labelMaxWav);
            this.groupBoxFFT.Controls.Add(this.labelMinWav);
            this.groupBoxFFT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFFT.Location = new System.Drawing.Point(649, 195);
            this.groupBoxFFT.Name = "groupBoxFFT";
            this.groupBoxFFT.Size = new System.Drawing.Size(207, 107);
            this.groupBoxFFT.TabIndex = 6;
            this.groupBoxFFT.TabStop = false;
            this.groupBoxFFT.Text = "FFT";
            // 
            // buttonSwapGraphs
            // 
            this.buttonSwapGraphs.Location = new System.Drawing.Point(108, 74);
            this.buttonSwapGraphs.Name = "buttonSwapGraphs";
            this.buttonSwapGraphs.Size = new System.Drawing.Size(92, 25);
            this.buttonSwapGraphs.TabIndex = 14;
            this.buttonSwapGraphs.Text = "Swap Graphs";
            this.buttonSwapGraphs.UseVisualStyleBackColor = true;
            this.buttonSwapGraphs.Click += new System.EventHandler(this.buttonSwapGraphs_Click);
            // 
            // buttonSetMaxWav
            // 
            this.buttonSetMaxWav.Location = new System.Drawing.Point(164, 42);
            this.buttonSetMaxWav.Name = "buttonSetMaxWav";
            this.buttonSetMaxWav.Size = new System.Drawing.Size(36, 25);
            this.buttonSetMaxWav.TabIndex = 13;
            this.buttonSetMaxWav.Text = "Set";
            this.buttonSetMaxWav.UseVisualStyleBackColor = true;
            this.buttonSetMaxWav.Click += new System.EventHandler(this.buttonSetMaxWav_Click);
            // 
            // buttonSetMinWav
            // 
            this.buttonSetMinWav.Location = new System.Drawing.Point(164, 14);
            this.buttonSetMinWav.Name = "buttonSetMinWav";
            this.buttonSetMinWav.Size = new System.Drawing.Size(36, 25);
            this.buttonSetMinWav.TabIndex = 12;
            this.buttonSetMinWav.Text = "Set";
            this.buttonSetMinWav.UseVisualStyleBackColor = true;
            this.buttonSetMinWav.Click += new System.EventHandler(this.buttonSetMinWav_Click);
            // 
            // buttonPerform
            // 
            this.buttonPerform.Location = new System.Drawing.Point(6, 75);
            this.buttonPerform.Name = "buttonPerform";
            this.buttonPerform.Size = new System.Drawing.Size(96, 25);
            this.buttonPerform.TabIndex = 11;
            this.buttonPerform.Text = "Perform FFT";
            this.buttonPerform.UseVisualStyleBackColor = true;
            this.buttonPerform.Click += new System.EventHandler(this.buttonPerform_Click);
            // 
            // textMaxWavVal
            // 
            this.textMaxWavVal.Location = new System.Drawing.Point(6, 45);
            this.textMaxWavVal.Name = "textMaxWavVal";
            this.textMaxWavVal.Size = new System.Drawing.Size(40, 20);
            this.textMaxWavVal.TabIndex = 10;
            this.textMaxWavVal.Text = "1000";
            // 
            // textMinWavVal
            // 
            this.textMinWavVal.Location = new System.Drawing.Point(6, 17);
            this.textMinWavVal.Name = "textMinWavVal";
            this.textMinWavVal.Size = new System.Drawing.Size(40, 20);
            this.textMinWavVal.TabIndex = 9;
            this.textMinWavVal.Text = "600";
            // 
            // labelMaxWav
            // 
            this.labelMaxWav.AutoSize = true;
            this.labelMaxWav.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxWav.Location = new System.Drawing.Point(49, 48);
            this.labelMaxWav.Name = "labelMaxWav";
            this.labelMaxWav.Size = new System.Drawing.Size(111, 14);
            this.labelMaxWav.TabIndex = 8;
            this.labelMaxWav.Text = "Maximum Wavelength";
            // 
            // labelMinWav
            // 
            this.labelMinWav.AutoSize = true;
            this.labelMinWav.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinWav.Location = new System.Drawing.Point(49, 20);
            this.labelMinWav.Name = "labelMinWav";
            this.labelMinWav.Size = new System.Drawing.Size(107, 14);
            this.labelMinWav.TabIndex = 7;
            this.labelMinWav.Text = "Minimum Wavelength";
            // 
            // groupBoxCalc
            // 
            this.groupBoxCalc.Controls.Add(this.textBoxEventLog);
            this.groupBoxCalc.Controls.Add(this.label1);
            this.groupBoxCalc.Controls.Add(this.domainUpDownAir);
            this.groupBoxCalc.Controls.Add(this.textAirIndex);
            this.groupBoxCalc.Controls.Add(this.labelIndex2);
            this.groupBoxCalc.Controls.Add(this.labelIndex1);
            this.groupBoxCalc.Controls.Add(this.domainUpDownOther);
            this.groupBoxCalc.Controls.Add(this.text2nLOther);
            this.groupBoxCalc.Controls.Add(this.label2nLOther);
            this.groupBoxCalc.Controls.Add(this.textOtherIndex);
            this.groupBoxCalc.Controls.Add(this.buttonAdvanced);
            this.groupBoxCalc.Controls.Add(this.text2nLair);
            this.groupBoxCalc.Controls.Add(this.label2nLAir);
            this.groupBoxCalc.Controls.Add(this.domainUpDownLiquid);
            this.groupBoxCalc.Controls.Add(this.buttonLooyenga);
            this.groupBoxCalc.Controls.Add(this.labelNM);
            this.groupBoxCalc.Controls.Add(this.labelThickness);
            this.groupBoxCalc.Controls.Add(this.labelPorosity);
            this.groupBoxCalc.Controls.Add(this.label2nLLiquid);
            this.groupBoxCalc.Controls.Add(this.text2nLliquid);
            this.groupBoxCalc.Controls.Add(this.textThickness);
            this.groupBoxCalc.Controls.Add(this.textPorosity);
            this.groupBoxCalc.Controls.Add(this.textLiquidIndex);
            this.groupBoxCalc.Controls.Add(this.labelSkeleton);
            this.groupBoxCalc.Controls.Add(this.textSkeleton);
            this.groupBoxCalc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCalc.Location = new System.Drawing.Point(649, 308);
            this.groupBoxCalc.Name = "groupBoxCalc";
            this.groupBoxCalc.Size = new System.Drawing.Size(207, 373);
            this.groupBoxCalc.TabIndex = 7;
            this.groupBoxCalc.TabStop = false;
            this.groupBoxCalc.Text = "Calculations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "Air";
            // 
            // domainUpDownAir
            // 
            this.domainUpDownAir.Enabled = false;
            this.domainUpDownAir.Items.Add("Air");
            this.domainUpDownAir.Items.Add("Methanol");
            this.domainUpDownAir.Items.Add("Ethanol");
            this.domainUpDownAir.Items.Add("Dichloromethane");
            this.domainUpDownAir.Items.Add("Toluene");
            this.domainUpDownAir.Items.Add("Water");
            this.domainUpDownAir.Items.Add("Other");
            this.domainUpDownAir.Location = new System.Drawing.Point(61, 51);
            this.domainUpDownAir.Name = "domainUpDownAir";
            this.domainUpDownAir.Size = new System.Drawing.Size(75, 20);
            this.domainUpDownAir.TabIndex = 27;
            this.domainUpDownAir.Text = "Liquid";
            this.domainUpDownAir.SelectedItemChanged += new System.EventHandler(this.domainUpDownAir_SelectedItemChanged);
            // 
            // textAirIndex
            // 
            this.textAirIndex.Enabled = false;
            this.textAirIndex.Location = new System.Drawing.Point(142, 50);
            this.textAirIndex.Name = "textAirIndex";
            this.textAirIndex.Size = new System.Drawing.Size(49, 20);
            this.textAirIndex.TabIndex = 26;
            this.textAirIndex.Text = "1.000";
            // 
            // labelIndex2
            // 
            this.labelIndex2.AutoSize = true;
            this.labelIndex2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelIndex2.Location = new System.Drawing.Point(12, 105);
            this.labelIndex2.Name = "labelIndex2";
            this.labelIndex2.Size = new System.Drawing.Size(42, 14);
            this.labelIndex2.TabIndex = 24;
            this.labelIndex2.Text = "Index 3";
            // 
            // labelIndex1
            // 
            this.labelIndex1.AutoSize = true;
            this.labelIndex1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelIndex1.Location = new System.Drawing.Point(12, 79);
            this.labelIndex1.Name = "labelIndex1";
            this.labelIndex1.Size = new System.Drawing.Size(42, 14);
            this.labelIndex1.TabIndex = 23;
            this.labelIndex1.Text = "Index 2";
            // 
            // domainUpDownOther
            // 
            this.domainUpDownOther.Items.Add("Methanol");
            this.domainUpDownOther.Items.Add("Ethanol");
            this.domainUpDownOther.Items.Add("Dichloromethane");
            this.domainUpDownOther.Items.Add("Toluene");
            this.domainUpDownOther.Items.Add("Water");
            this.domainUpDownOther.Items.Add("Other");
            this.domainUpDownOther.Location = new System.Drawing.Point(61, 103);
            this.domainUpDownOther.Name = "domainUpDownOther";
            this.domainUpDownOther.Size = new System.Drawing.Size(75, 20);
            this.domainUpDownOther.TabIndex = 22;
            this.domainUpDownOther.Text = "Liquid";
            this.domainUpDownOther.SelectedItemChanged += new System.EventHandler(this.domainUpDownOther_SelectedItemChanged);
            // 
            // text2nLOther
            // 
            this.text2nLOther.Location = new System.Drawing.Point(87, 206);
            this.text2nLOther.Margin = new System.Windows.Forms.Padding(1);
            this.text2nLOther.Name = "text2nLOther";
            this.text2nLOther.Size = new System.Drawing.Size(100, 20);
            this.text2nLOther.TabIndex = 21;
            this.text2nLOther.Text = "0.0";
            // 
            // label2nLOther
            // 
            this.label2nLOther.AutoEllipsis = true;
            this.label2nLOther.AutoSize = true;
            this.label2nLOther.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2nLOther.Location = new System.Drawing.Point(12, 209);
            this.label2nLOther.Name = "label2nLOther";
            this.label2nLOther.Size = new System.Drawing.Size(63, 14);
            this.label2nLOther.TabIndex = 20;
            this.label2nLOther.Text = "2nL (Other)";
            // 
            // textOtherIndex
            // 
            this.textOtherIndex.Location = new System.Drawing.Point(142, 102);
            this.textOtherIndex.Name = "textOtherIndex";
            this.textOtherIndex.Size = new System.Drawing.Size(49, 20);
            this.textOtherIndex.TabIndex = 18;
            this.textOtherIndex.Text = "0.0";
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Location = new System.Drawing.Point(100, 129);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(87, 25);
            this.buttonAdvanced.TabIndex = 16;
            this.buttonAdvanced.Text = "Advanced";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // text2nLair
            // 
            this.text2nLair.Location = new System.Drawing.Point(87, 158);
            this.text2nLair.Margin = new System.Windows.Forms.Padding(1);
            this.text2nLair.Name = "text2nLair";
            this.text2nLair.Size = new System.Drawing.Size(100, 20);
            this.text2nLair.TabIndex = 15;
            this.text2nLair.Text = "0.0";
            // 
            // label2nLAir
            // 
            this.label2nLAir.AutoSize = true;
            this.label2nLAir.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2nLAir.Location = new System.Drawing.Point(12, 162);
            this.label2nLAir.Name = "label2nLAir";
            this.label2nLAir.Size = new System.Drawing.Size(48, 14);
            this.label2nLAir.TabIndex = 14;
            this.label2nLAir.Text = "2nL (air)";
            // 
            // domainUpDownLiquid
            // 
            this.domainUpDownLiquid.Items.Add("Methanol");
            this.domainUpDownLiquid.Items.Add("Ethanol");
            this.domainUpDownLiquid.Items.Add("Dichloromethane");
            this.domainUpDownLiquid.Items.Add("Toluene");
            this.domainUpDownLiquid.Items.Add("Water");
            this.domainUpDownLiquid.Items.Add("Other");
            this.domainUpDownLiquid.Location = new System.Drawing.Point(61, 77);
            this.domainUpDownLiquid.Name = "domainUpDownLiquid";
            this.domainUpDownLiquid.Size = new System.Drawing.Size(75, 20);
            this.domainUpDownLiquid.TabIndex = 13;
            this.domainUpDownLiquid.Text = "Liquid";
            this.domainUpDownLiquid.SelectedItemChanged += new System.EventHandler(this.domainUpDownLiquid_SelectedItemChanged);
            // 
            // buttonLooyenga
            // 
            this.buttonLooyenga.Location = new System.Drawing.Point(9, 129);
            this.buttonLooyenga.Name = "buttonLooyenga";
            this.buttonLooyenga.Size = new System.Drawing.Size(87, 25);
            this.buttonLooyenga.TabIndex = 12;
            this.buttonLooyenga.Text = "Looyenga";
            this.buttonLooyenga.UseVisualStyleBackColor = true;
            this.buttonLooyenga.Click += new System.EventHandler(this.buttonLooyenga_Click);
            // 
            // labelNM
            // 
            this.labelNM.AutoSize = true;
            this.labelNM.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelNM.Location = new System.Drawing.Point(166, 256);
            this.labelNM.Name = "labelNM";
            this.labelNM.Size = new System.Drawing.Size(29, 14);
            this.labelNM.TabIndex = 10;
            this.labelNM.Text = "(nm)";
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelThickness.Location = new System.Drawing.Point(12, 256);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(56, 14);
            this.labelThickness.TabIndex = 9;
            this.labelThickness.Text = "Thickness";
            // 
            // labelPorosity
            // 
            this.labelPorosity.AutoSize = true;
            this.labelPorosity.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelPorosity.Location = new System.Drawing.Point(12, 233);
            this.labelPorosity.Name = "labelPorosity";
            this.labelPorosity.Size = new System.Drawing.Size(46, 14);
            this.labelPorosity.TabIndex = 8;
            this.labelPorosity.Text = "Porosity";
            // 
            // label2nLLiquid
            // 
            this.label2nLLiquid.AutoSize = true;
            this.label2nLLiquid.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2nLLiquid.Location = new System.Drawing.Point(12, 185);
            this.label2nLLiquid.Name = "label2nLLiquid";
            this.label2nLLiquid.Size = new System.Drawing.Size(60, 14);
            this.label2nLLiquid.TabIndex = 7;
            this.label2nLLiquid.Text = "2nL (liquid)";
            // 
            // text2nLliquid
            // 
            this.text2nLliquid.Location = new System.Drawing.Point(87, 182);
            this.text2nLliquid.Margin = new System.Windows.Forms.Padding(1);
            this.text2nLliquid.Name = "text2nLliquid";
            this.text2nLliquid.Size = new System.Drawing.Size(100, 20);
            this.text2nLliquid.TabIndex = 6;
            this.text2nLliquid.Text = "0.0";
            // 
            // textThickness
            // 
            this.textThickness.Location = new System.Drawing.Point(87, 253);
            this.textThickness.Margin = new System.Windows.Forms.Padding(1);
            this.textThickness.Name = "textThickness";
            this.textThickness.Size = new System.Drawing.Size(75, 20);
            this.textThickness.TabIndex = 5;
            this.textThickness.Text = "0.0";
            // 
            // textPorosity
            // 
            this.textPorosity.Location = new System.Drawing.Point(87, 229);
            this.textPorosity.Margin = new System.Windows.Forms.Padding(1);
            this.textPorosity.Name = "textPorosity";
            this.textPorosity.Size = new System.Drawing.Size(100, 20);
            this.textPorosity.TabIndex = 4;
            this.textPorosity.Text = "0.0";
            // 
            // textLiquidIndex
            // 
            this.textLiquidIndex.Location = new System.Drawing.Point(142, 76);
            this.textLiquidIndex.Name = "textLiquidIndex";
            this.textLiquidIndex.Size = new System.Drawing.Size(49, 20);
            this.textLiquidIndex.TabIndex = 3;
            this.textLiquidIndex.Text = "0.0";
            // 
            // labelSkeleton
            // 
            this.labelSkeleton.AutoSize = true;
            this.labelSkeleton.Location = new System.Drawing.Point(52, 22);
            this.labelSkeleton.Name = "labelSkeleton";
            this.labelSkeleton.Size = new System.Drawing.Size(143, 14);
            this.labelSkeleton.TabIndex = 1;
            this.labelSkeleton.Text = "Refractive Index of Skeleton";
            // 
            // textSkeleton
            // 
            this.textSkeleton.Location = new System.Drawing.Point(9, 19);
            this.textSkeleton.Name = "textSkeleton";
            this.textSkeleton.Size = new System.Drawing.Size(37, 20);
            this.textSkeleton.TabIndex = 0;
            this.textSkeleton.Text = "3.1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labelXAxis
            // 
            this.labelXAxis.AutoSize = true;
            this.labelXAxis.BackColor = System.Drawing.SystemColors.Window;
            this.labelXAxis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXAxis.Location = new System.Drawing.Point(551, 500);
            this.labelXAxis.Name = "labelXAxis";
            this.labelXAxis.Size = new System.Drawing.Size(37, 14);
            this.labelXAxis.TabIndex = 8;
            this.labelXAxis.Text = "x-axis";
            // 
            // labelYAxis
            // 
            this.labelYAxis.AutoSize = true;
            this.labelYAxis.BackColor = System.Drawing.SystemColors.Window;
            this.labelYAxis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYAxis.Location = new System.Drawing.Point(590, 500);
            this.labelYAxis.Name = "labelYAxis";
            this.labelYAxis.Size = new System.Drawing.Size(37, 14);
            this.labelYAxis.TabIndex = 9;
            this.labelYAxis.Text = "y-axis";
            // 
            // groupBoxSpectra
            // 
            this.groupBoxSpectra.Controls.Add(this.checkBoxOther);
            this.groupBoxSpectra.Controls.Add(this.checkBoxLiquid);
            this.groupBoxSpectra.Controls.Add(this.checkBoxAir);
            this.groupBoxSpectra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpectra.Location = new System.Drawing.Point(649, 67);
            this.groupBoxSpectra.Name = "groupBoxSpectra";
            this.groupBoxSpectra.Size = new System.Drawing.Size(206, 84);
            this.groupBoxSpectra.TabIndex = 4;
            this.groupBoxSpectra.TabStop = false;
            this.groupBoxSpectra.Text = "Spectra";
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Location = new System.Drawing.Point(6, 57);
            this.checkBoxOther.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(151, 18);
            this.checkBoxOther.TabIndex = 2;
            this.checkBoxOther.Text = "Other (magenta) (Index 3)";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiquid
            // 
            this.checkBoxLiquid.AutoSize = true;
            this.checkBoxLiquid.Location = new System.Drawing.Point(6, 39);
            this.checkBoxLiquid.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxLiquid.Name = "checkBoxLiquid";
            this.checkBoxLiquid.Size = new System.Drawing.Size(131, 18);
            this.checkBoxLiquid.TabIndex = 1;
            this.checkBoxLiquid.Text = "Liquid (blue) (Index 2)";
            this.checkBoxLiquid.UseVisualStyleBackColor = true;
            // 
            // checkBoxAir
            // 
            this.checkBoxAir.AutoSize = true;
            this.checkBoxAir.Location = new System.Drawing.Point(6, 20);
            this.checkBoxAir.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAir.Name = "checkBoxAir";
            this.checkBoxAir.Size = new System.Drawing.Size(67, 18);
            this.checkBoxAir.TabIndex = 0;
            this.checkBoxAir.Text = "Air (red)";
            this.checkBoxAir.UseVisualStyleBackColor = true;
            // 
            // chartFFT
            // 
            chartArea2.AxisX.Interval = 20000D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea2.AxisX.LabelStyle.Format = "F0";
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 160000D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Optical Thickness (2nL), um";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 500000D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "FFT Magnitude";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.Title = "µWatts / cm² / nm";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.Blue;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea2.Name = "ChartAreaFFT";
            this.chartFFT.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "LegendFFT";
            legend2.TitleFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartFFT.Legends.Add(legend2);
            this.chartFFT.Location = new System.Drawing.Point(9, 13);
            this.chartFFT.Name = "chartFFT";
            series6.ChartArea = "ChartAreaFFT";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "LegendFFT";
            series6.LegendText = "Air";
            series6.Name = "airFFT";
            series7.ChartArea = "ChartAreaFFT";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "LegendFFT";
            series7.LegendText = "Liquid";
            series7.Name = "liquidFFT";
            series8.ChartArea = "ChartAreaFFT";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Magenta;
            series8.IsVisibleInLegend = false;
            series8.Legend = "LegendFFT";
            series8.LegendText = "Other";
            series8.Name = "otherFFT";
            this.chartFFT.Series.Add(series6);
            this.chartFFT.Series.Add(series7);
            this.chartFFT.Series.Add(series8);
            this.chartFFT.Size = new System.Drawing.Size(633, 501);
            this.chartFFT.TabIndex = 10;
            this.chartFFT.Text = "FFT";
            this.chartFFT.Visible = false;
            // 
            // groupBoxSimpleSlim
            // 
            this.groupBoxSimpleSlim.Controls.Add(this.buttonLooyengaSimple);
            this.groupBoxSimpleSlim.Controls.Add(this.buttonPerformSimple);
            this.groupBoxSimpleSlim.Controls.Add(this.buttonSaveLiquidSimple);
            this.groupBoxSimpleSlim.Controls.Add(this.buttonSaveAirSimple);
            this.groupBoxSimpleSlim.Location = new System.Drawing.Point(15, 520);
            this.groupBoxSimpleSlim.Name = "groupBoxSimpleSlim";
            this.groupBoxSimpleSlim.Size = new System.Drawing.Size(627, 100);
            this.groupBoxSimpleSlim.TabIndex = 16;
            this.groupBoxSimpleSlim.TabStop = false;
            this.groupBoxSimpleSlim.Text = "Simple SLIM";
            // 
            // buttonLooyengaSimple
            // 
            this.buttonLooyengaSimple.Font = new System.Drawing.Font("Arial", 16F);
            this.buttonLooyengaSimple.Location = new System.Drawing.Point(476, 27);
            this.buttonLooyengaSimple.Name = "buttonLooyengaSimple";
            this.buttonLooyengaSimple.Size = new System.Drawing.Size(145, 56);
            this.buttonLooyengaSimple.TabIndex = 29;
            this.buttonLooyengaSimple.Text = "4. Looyenga";
            this.buttonLooyengaSimple.UseVisualStyleBackColor = true;
            this.buttonLooyengaSimple.Click += new System.EventHandler(this.buttonLooyenga_Click);
            // 
            // buttonPerformSimple
            // 
            this.buttonPerformSimple.Font = new System.Drawing.Font("Arial", 16F);
            this.buttonPerformSimple.Location = new System.Drawing.Point(302, 27);
            this.buttonPerformSimple.Name = "buttonPerformSimple";
            this.buttonPerformSimple.Size = new System.Drawing.Size(169, 56);
            this.buttonPerformSimple.TabIndex = 27;
            this.buttonPerformSimple.Text = "3. Perform FFT";
            this.buttonPerformSimple.UseVisualStyleBackColor = true;
            this.buttonPerformSimple.Click += new System.EventHandler(this.buttonPerform_Click);
            // 
            // buttonSaveLiquidSimple
            // 
            this.buttonSaveLiquidSimple.Font = new System.Drawing.Font("Arial", 16F);
            this.buttonSaveLiquidSimple.Location = new System.Drawing.Point(133, 27);
            this.buttonSaveLiquidSimple.Name = "buttonSaveLiquidSimple";
            this.buttonSaveLiquidSimple.Size = new System.Drawing.Size(163, 56);
            this.buttonSaveLiquidSimple.TabIndex = 26;
            this.buttonSaveLiquidSimple.Text = "2. Save Liquid";
            this.buttonSaveLiquidSimple.UseVisualStyleBackColor = true;
            this.buttonSaveLiquidSimple.Click += new System.EventHandler(this.buttonSaveLiquid_Click);
            // 
            // buttonSaveAirSimple
            // 
            this.buttonSaveAirSimple.Font = new System.Drawing.Font("Arial", 15.5F);
            this.buttonSaveAirSimple.Location = new System.Drawing.Point(6, 27);
            this.buttonSaveAirSimple.Name = "buttonSaveAirSimple";
            this.buttonSaveAirSimple.Size = new System.Drawing.Size(121, 56);
            this.buttonSaveAirSimple.TabIndex = 16;
            this.buttonSaveAirSimple.Text = "1. Save Air";
            this.buttonSaveAirSimple.UseVisualStyleBackColor = true;
            this.buttonSaveAirSimple.Click += new System.EventHandler(this.buttonSaveAir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 694);
            this.Controls.Add(this.groupBoxSimpleSlim);
            this.Controls.Add(this.buttonReflectance);
            this.Controls.Add(this.labelYAxis);
            this.Controls.Add(this.labelXAxis);
            this.Controls.Add(this.buttonMirror);
            this.Controls.Add(this.groupBoxSpectra);
            this.Controls.Add(this.groupBoxCalc);
            this.Controls.Add(this.groupBoxFFT);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.chartSpectrum);
            this.Controls.Add(this.chartFFT);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cringe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouseScroll);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectrum)).EndInit();
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegrationTimeMillisec)).EndInit();
            this.groupBoxFFT.ResumeLayout(false);
            this.groupBoxFFT.PerformLayout();
            this.groupBoxCalc.ResumeLayout(false);
            this.groupBoxCalc.PerformLayout();
            this.groupBoxSpectra.ResumeLayout(false);
            this.groupBoxSpectra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).EndInit();
            this.groupBoxSimpleSlim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpectrum;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownIntegrationTimeMillisec;
        private System.Windows.Forms.Label labelIntegrationTime;
        private System.Windows.Forms.TextBox textBoxEventLog;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAcquisition;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSpectra;
        private System.Windows.Forms.GroupBox groupBoxFFT;
        private System.Windows.Forms.Label labelMaxWav;
        private System.Windows.Forms.Label labelMinWav;
        private System.Windows.Forms.Button buttonPerform;
        private System.Windows.Forms.TextBox textMaxWavVal;
        private System.Windows.Forms.TextBox textMinWavVal;
        private System.Windows.Forms.GroupBox groupBoxCalc;
        private System.Windows.Forms.Label labelSkeleton;
        private System.Windows.Forms.TextBox textSkeleton;
        private System.Windows.Forms.Label labelNM;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.Label labelPorosity;
        private System.Windows.Forms.Label label2nLLiquid;
        private System.Windows.Forms.TextBox text2nLliquid;
        private System.Windows.Forms.TextBox textThickness;
        private System.Windows.Forms.TextBox textPorosity;
        private System.Windows.Forms.TextBox textLiquidIndex;
        private System.Windows.Forms.Button buttonLooyenga;
        private System.Windows.Forms.Label labelPixelText;
        private System.Windows.Forms.Label labelPixels;
        private System.Windows.Forms.DomainUpDown domainUpDownLiquid;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox text2nLair;
        private System.Windows.Forms.Label label2nLAir;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Button buttonReflectance;
        private System.Windows.Forms.Button buttonMirror;
        private System.Windows.Forms.Button buttonSetMaxWav;
        private System.Windows.Forms.Button buttonSetMinWav;
        private System.Windows.Forms.Label labelXAxis;
        private System.Windows.Forms.Label labelYAxis;
        private System.Windows.Forms.GroupBox groupBoxSpectra;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxLiquid;
        private System.Windows.Forms.CheckBox checkBoxAir;
        private System.Windows.Forms.TextBox textOtherIndex;
        private System.Windows.Forms.Button buttonSwapGraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFT;
        private System.Windows.Forms.TextBox text2nLOther;
        private System.Windows.Forms.Label label2nLOther;
        private System.Windows.Forms.Label labelIndex2;
        private System.Windows.Forms.Label labelIndex1;
        private System.Windows.Forms.DomainUpDown domainUpDownOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDownAir;
        private System.Windows.Forms.TextBox textAirIndex;
        private System.Windows.Forms.Button buttonSaveOther;
        private System.Windows.Forms.Button buttonSaveLiquid;
        private System.Windows.Forms.Button buttonSaveAir;
        private System.Windows.Forms.Button buttonLoadOther;
        private System.Windows.Forms.Button buttonLoadLiquid;
        private System.Windows.Forms.Button buttonLoadAir;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxSimpleSlim;
        private System.Windows.Forms.Button buttonLooyengaSimple;
        private System.Windows.Forms.Button buttonPerformSimple;
        private System.Windows.Forms.Button buttonSaveLiquidSimple;
        private System.Windows.Forms.Button buttonSaveAirSimple;
    }
}

