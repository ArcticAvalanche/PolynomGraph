namespace PolynomGraph
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maxPositiveX = new System.Windows.Forms.NumericUpDown();
            this.minNegativeX = new System.Windows.Forms.NumericUpDown();
            this.maxPositiveY = new System.Windows.Forms.NumericUpDown();
            this.minNegativeY = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAxiesX = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorStepX = new System.Windows.Forms.NumericUpDown();
            this.minorStepX = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAxiesY = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.majorStepY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minorStepY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.enableGrid = new System.Windows.Forms.CheckBox();
            this.polynomPowerGrid = new System.Windows.Forms.DataGridView();
            this.addGraph = new System.Windows.Forms.Button();
            this.removeGraph = new System.Windows.Forms.Button();
            this.BIG_RED_BUTTON = new System.Windows.Forms.Button();
            this.graphWidth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.power0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPositiveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNegativeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPositiveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNegativeY)).BeginInit();
            this.groupBoxAxiesX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorStepX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorStepX)).BeginInit();
            this.groupBoxAxiesY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorStepY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorStepY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomPowerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = -10D;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.Interval = 0.5D;
            chartArea1.AxisX.MinorTickMark.Size = 0.5F;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = -10D;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.Interval = 0.5D;
            chartArea1.AxisY.MinorTickMark.Size = 0.5F;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.Name = "MainChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 75F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "nullLegend";
            legend1.Position.Auto = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "mainLegend";
            legend2.Title = "Legend:";
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "MainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "nullLegend";
            series1.Name = "StartPoint";
            series1.Points.Add(dataPoint1);
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(774, 644);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            // 
            // maxPositiveX
            // 
            this.maxPositiveX.Location = new System.Drawing.Point(110, 19);
            this.maxPositiveX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxPositiveX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxPositiveX.Name = "maxPositiveX";
            this.maxPositiveX.Size = new System.Drawing.Size(120, 20);
            this.maxPositiveX.TabIndex = 3;
            this.maxPositiveX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxPositiveX.ValueChanged += new System.EventHandler(this.maxPositiveX_ValueChanged);
            // 
            // minNegativeX
            // 
            this.minNegativeX.Location = new System.Drawing.Point(110, 45);
            this.minNegativeX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minNegativeX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.minNegativeX.Name = "minNegativeX";
            this.minNegativeX.Size = new System.Drawing.Size(120, 20);
            this.minNegativeX.TabIndex = 4;
            this.minNegativeX.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.minNegativeX.ValueChanged += new System.EventHandler(this.maxNegativeX_ValueChanged);
            // 
            // maxPositiveY
            // 
            this.maxPositiveY.Location = new System.Drawing.Point(110, 19);
            this.maxPositiveY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxPositiveY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxPositiveY.Name = "maxPositiveY";
            this.maxPositiveY.Size = new System.Drawing.Size(120, 20);
            this.maxPositiveY.TabIndex = 5;
            this.maxPositiveY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxPositiveY.ValueChanged += new System.EventHandler(this.maxPositiveY_ValueChanged);
            // 
            // minNegativeY
            // 
            this.minNegativeY.Location = new System.Drawing.Point(110, 45);
            this.minNegativeY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minNegativeY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.minNegativeY.Name = "minNegativeY";
            this.minNegativeY.Size = new System.Drawing.Size(120, 20);
            this.minNegativeY.TabIndex = 6;
            this.minNegativeY.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.minNegativeY.ValueChanged += new System.EventHandler(this.maxNegativeY_ValueChanged);
            // 
            // groupBoxAxiesX
            // 
            this.groupBoxAxiesX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAxiesX.Controls.Add(this.label4);
            this.groupBoxAxiesX.Controls.Add(this.label3);
            this.groupBoxAxiesX.Controls.Add(this.label2);
            this.groupBoxAxiesX.Controls.Add(this.label1);
            this.groupBoxAxiesX.Controls.Add(this.majorStepX);
            this.groupBoxAxiesX.Controls.Add(this.minorStepX);
            this.groupBoxAxiesX.Controls.Add(this.maxPositiveX);
            this.groupBoxAxiesX.Controls.Add(this.minNegativeX);
            this.groupBoxAxiesX.Location = new System.Drawing.Point(915, 12);
            this.groupBoxAxiesX.Name = "groupBoxAxiesX";
            this.groupBoxAxiesX.Size = new System.Drawing.Size(236, 130);
            this.groupBoxAxiesX.TabIndex = 7;
            this.groupBoxAxiesX.TabStop = false;
            this.groupBoxAxiesX.Text = "X axies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minor step:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Major step:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max X:";
            // 
            // majorStepX
            // 
            this.majorStepX.Location = new System.Drawing.Point(110, 71);
            this.majorStepX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.majorStepX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.majorStepX.Name = "majorStepX";
            this.majorStepX.Size = new System.Drawing.Size(120, 20);
            this.majorStepX.TabIndex = 6;
            this.majorStepX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.majorStepX.ValueChanged += new System.EventHandler(this.majorStepX_ValueChanged);
            // 
            // minorStepX
            // 
            this.minorStepX.Location = new System.Drawing.Point(110, 97);
            this.minorStepX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minorStepX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minorStepX.Name = "minorStepX";
            this.minorStepX.Size = new System.Drawing.Size(120, 20);
            this.minorStepX.TabIndex = 5;
            this.minorStepX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minorStepX.ValueChanged += new System.EventHandler(this.minorStepX_ValueChanged);
            // 
            // groupBoxAxiesY
            // 
            this.groupBoxAxiesY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAxiesY.Controls.Add(this.label5);
            this.groupBoxAxiesY.Controls.Add(this.majorStepY);
            this.groupBoxAxiesY.Controls.Add(this.label6);
            this.groupBoxAxiesY.Controls.Add(this.label7);
            this.groupBoxAxiesY.Controls.Add(this.minorStepY);
            this.groupBoxAxiesY.Controls.Add(this.label8);
            this.groupBoxAxiesY.Controls.Add(this.maxPositiveY);
            this.groupBoxAxiesY.Controls.Add(this.minNegativeY);
            this.groupBoxAxiesY.Location = new System.Drawing.Point(915, 148);
            this.groupBoxAxiesY.Name = "groupBoxAxiesY";
            this.groupBoxAxiesY.Size = new System.Drawing.Size(236, 130);
            this.groupBoxAxiesY.TabIndex = 8;
            this.groupBoxAxiesY.TabStop = false;
            this.groupBoxAxiesY.Text = "Y axies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minor step:";
            // 
            // majorStepY
            // 
            this.majorStepY.Location = new System.Drawing.Point(110, 71);
            this.majorStepY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.majorStepY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.majorStepY.Name = "majorStepY";
            this.majorStepY.Size = new System.Drawing.Size(120, 20);
            this.majorStepY.TabIndex = 8;
            this.majorStepY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.majorStepY.ValueChanged += new System.EventHandler(this.majorStepY_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Major step:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Min X:";
            // 
            // minorStepY
            // 
            this.minorStepY.Location = new System.Drawing.Point(110, 97);
            this.minorStepY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minorStepY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minorStepY.Name = "minorStepY";
            this.minorStepY.Size = new System.Drawing.Size(120, 20);
            this.minorStepY.TabIndex = 7;
            this.minorStepY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minorStepY.ValueChanged += new System.EventHandler(this.minorStepY_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Max X:";
            // 
            // enableGrid
            // 
            this.enableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableGrid.AutoSize = true;
            this.enableGrid.Location = new System.Drawing.Point(792, 12);
            this.enableGrid.Name = "enableGrid";
            this.enableGrid.Size = new System.Drawing.Size(79, 17);
            this.enableGrid.TabIndex = 9;
            this.enableGrid.Text = "Enable grid";
            this.enableGrid.UseVisualStyleBackColor = true;
            this.enableGrid.CheckedChanged += new System.EventHandler(this.enableGrid_CheckedChanged);
            // 
            // polynomPowerGrid
            // 
            this.polynomPowerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.polynomPowerGrid.BackgroundColor = System.Drawing.Color.White;
            this.polynomPowerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polynomPowerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.power0,
            this.power1,
            this.power2,
            this.power3,
            this.power4,
            this.power5,
            this.colorCell});
            this.polynomPowerGrid.Location = new System.Drawing.Point(792, 357);
            this.polynomPowerGrid.Name = "polynomPowerGrid";
            this.polynomPowerGrid.Size = new System.Drawing.Size(359, 127);
            this.polynomPowerGrid.TabIndex = 10;
            this.polynomPowerGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.polynomPowerGrid_CellMouseClick);
            // 
            // addGraph
            // 
            this.addGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addGraph.Location = new System.Drawing.Point(999, 328);
            this.addGraph.Name = "addGraph";
            this.addGraph.Size = new System.Drawing.Size(73, 23);
            this.addGraph.TabIndex = 11;
            this.addGraph.Text = "Add";
            this.addGraph.UseVisualStyleBackColor = true;
            this.addGraph.Click += new System.EventHandler(this.addGraph_Click);
            // 
            // removeGraph
            // 
            this.removeGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeGraph.Location = new System.Drawing.Point(1078, 328);
            this.removeGraph.Name = "removeGraph";
            this.removeGraph.Size = new System.Drawing.Size(73, 23);
            this.removeGraph.TabIndex = 12;
            this.removeGraph.Text = "Remove";
            this.removeGraph.UseVisualStyleBackColor = true;
            this.removeGraph.Click += new System.EventHandler(this.removeGraph_Click);
            // 
            // BIG_RED_BUTTON
            // 
            this.BIG_RED_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BIG_RED_BUTTON.BackColor = System.Drawing.Color.Red;
            this.BIG_RED_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BIG_RED_BUTTON.ForeColor = System.Drawing.Color.White;
            this.BIG_RED_BUTTON.Location = new System.Drawing.Point(792, 490);
            this.BIG_RED_BUTTON.Name = "BIG_RED_BUTTON";
            this.BIG_RED_BUTTON.Size = new System.Drawing.Size(359, 166);
            this.BIG_RED_BUTTON.TabIndex = 0;
            this.BIG_RED_BUTTON.Text = "DRRRAW!!1!1";
            this.BIG_RED_BUTTON.UseVisualStyleBackColor = false;
            this.BIG_RED_BUTTON.Click += new System.EventHandler(this.BIG_RED_BUTTON_Click);
            // 
            // graphWidth
            // 
            this.graphWidth.Location = new System.Drawing.Point(1025, 284);
            this.graphWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.graphWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphWidth.Name = "graphWidth";
            this.graphWidth.Size = new System.Drawing.Size(120, 20);
            this.graphWidth.TabIndex = 13;
            this.graphWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphWidth.ValueChanged += new System.EventHandler(this.graphWidth_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(952, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Graph width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(792, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Enter polynoms:";
            // 
            // power0
            // 
            this.power0.HeaderText = "Const";
            this.power0.Name = "power0";
            this.power0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.power0.Width = 45;
            // 
            // power1
            // 
            this.power1.HeaderText = "^1";
            this.power1.Name = "power1";
            this.power1.Width = 45;
            // 
            // power2
            // 
            this.power2.HeaderText = "^2";
            this.power2.Name = "power2";
            this.power2.Width = 45;
            // 
            // power3
            // 
            this.power3.HeaderText = "^3";
            this.power3.Name = "power3";
            this.power3.Width = 45;
            // 
            // power4
            // 
            this.power4.HeaderText = "^4";
            this.power4.Name = "power4";
            this.power4.Width = 45;
            // 
            // power5
            // 
            this.power5.HeaderText = "^5";
            this.power5.Name = "power5";
            this.power5.Width = 45;
            // 
            // colorCell
            // 
            this.colorCell.HeaderText = "Color";
            this.colorCell.Name = "colorCell";
            this.colorCell.ReadOnly = true;
            this.colorCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorCell.Width = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 664);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.graphWidth);
            this.Controls.Add(this.BIG_RED_BUTTON);
            this.Controls.Add(this.removeGraph);
            this.Controls.Add(this.addGraph);
            this.Controls.Add(this.polynomPowerGrid);
            this.Controls.Add(this.enableGrid);
            this.Controls.Add(this.groupBoxAxiesY);
            this.Controls.Add(this.groupBoxAxiesX);
            this.Controls.Add(this.chart);
            this.Name = "MainForm";
            this.Text = "Polynm graphs";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPositiveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNegativeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPositiveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNegativeY)).EndInit();
            this.groupBoxAxiesX.ResumeLayout(false);
            this.groupBoxAxiesX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorStepX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorStepX)).EndInit();
            this.groupBoxAxiesY.ResumeLayout(false);
            this.groupBoxAxiesY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorStepY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorStepY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomPowerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown maxPositiveX;
        private System.Windows.Forms.NumericUpDown minNegativeX;
        private System.Windows.Forms.NumericUpDown maxPositiveY;
        private System.Windows.Forms.NumericUpDown minNegativeY;
        private System.Windows.Forms.GroupBox groupBoxAxiesX;
        private System.Windows.Forms.NumericUpDown majorStepX;
        private System.Windows.Forms.NumericUpDown minorStepX;
        private System.Windows.Forms.GroupBox groupBoxAxiesY;
        private System.Windows.Forms.CheckBox enableGrid;
        private System.Windows.Forms.NumericUpDown majorStepY;
        private System.Windows.Forms.NumericUpDown minorStepY;
        private System.Windows.Forms.DataGridView polynomPowerGrid;
        private System.Windows.Forms.Button addGraph;
        private System.Windows.Forms.Button removeGraph;
        private System.Windows.Forms.Button BIG_RED_BUTTON;
        private System.Windows.Forms.NumericUpDown graphWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn power0;
        private System.Windows.Forms.DataGridViewTextBoxColumn power1;
        private System.Windows.Forms.DataGridViewTextBoxColumn power2;
        private System.Windows.Forms.DataGridViewTextBoxColumn power3;
        private System.Windows.Forms.DataGridViewTextBoxColumn power4;
        private System.Windows.Forms.DataGridViewTextBoxColumn power5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCell;
    }
}

