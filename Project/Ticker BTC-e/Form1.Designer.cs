﻿namespace Ticker_BTC_e
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1now = new System.Windows.Forms.Label();
            this.ChartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.textBoxBuyP = new System.Windows.Forms.TextBox();
            this.buttonBuyV11 = new System.Windows.Forms.Button();
            this.buttonBuyV12 = new System.Windows.Forms.Button();
            this.buttonBuyPL = new System.Windows.Forms.Button();
            this.buttonBuyPM = new System.Windows.Forms.Button();
            this.labelBuyHave = new System.Windows.Forms.Label();
            this.buttonBuyV14 = new System.Windows.Forms.Button();
            this.labeBuyV = new System.Windows.Forms.Label();
            this.textBoxBuyV = new System.Windows.Forms.TextBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonSellV11 = new System.Windows.Forms.Button();
            this.buttonSellL = new System.Windows.Forms.Button();
            this.buttonSellM = new System.Windows.Forms.Button();
            this.buttonSellV12 = new System.Windows.Forms.Button();
            this.buttonSellV14 = new System.Windows.Forms.Button();
            this.textBoxSellP = new System.Windows.Forms.TextBox();
            this.textBoxSellV = new System.Windows.Forms.TextBox();
            this.labelSellHave = new System.Windows.Forms.Label();
            this.labelSellV = new System.Windows.Forms.Label();
            this.buttonCancelA = new System.Windows.Forms.Button();
            this.buttonCancelS = new System.Windows.Forms.Button();
            this.comboBoxPair = new System.Windows.Forms.ComboBox();
            this.listViewBid = new Ticker_BTC_e.ListViewNF();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOpenOrders = new Ticker_BTC_e.ListViewNF();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHistory = new Ticker_BTC_e.ListViewNF();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAsk = new Ticker_BTC_e.ListViewNF();
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBuyV18 = new System.Windows.Forms.Button();
            this.buttonSellV18 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1now
            // 
            this.label1now.AutoSize = true;
            this.label1now.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1now.Location = new System.Drawing.Point(85, 1);
            this.label1now.Name = "label1now";
            this.label1now.Size = new System.Drawing.Size(57, 20);
            this.label1now.TabIndex = 1;
            this.label1now.Text = "0 USD";
            this.label1now.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChartMain
            // 
            this.ChartMain.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.IsStartedFromZero = false;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY2.IsLabelAutoFit = false;
            chartArea3.AxisY2.IsStartedFromZero = false;
            chartArea3.AxisY2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.LineWidth = 0;
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorTickMark.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.ChartMain.ChartAreas.Add(chartArea3);
            this.ChartMain.Location = new System.Drawing.Point(-3, 20);
            this.ChartMain.Name = "ChartMain";
            this.ChartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.Lavender;
            series17.Name = "Area";
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series17.YValuesPerPoint = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series18.CustomProperties = "PixelPointWidth=2, PriceDownColor=Red, PointWidth=1, PriceUpColor=Green";
            series18.Name = "Candlestick";
            series18.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series18.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series18.YValuesPerPoint = 4;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Enabled = false;
            series19.Name = "Line";
            series19.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series19.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Enabled = false;
            series20.Name = "LineMA1";
            series20.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Enabled = false;
            series21.Name = "LineMA2";
            series21.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Enabled = false;
            series22.Name = "LineMA3";
            series22.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Enabled = false;
            series23.Name = "LineMA4";
            series23.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series24.BorderColor = System.Drawing.Color.Transparent;
            series24.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.Gray;
            series24.CustomProperties = "IsXAxisQuantitative=True";
            series24.Name = "LineNow";
            series24.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series24.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series24.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.ChartMain.Series.Add(series17);
            this.ChartMain.Series.Add(series18);
            this.ChartMain.Series.Add(series19);
            this.ChartMain.Series.Add(series20);
            this.ChartMain.Series.Add(series21);
            this.ChartMain.Series.Add(series22);
            this.ChartMain.Series.Add(series23);
            this.ChartMain.Series.Add(series24);
            this.ChartMain.Size = new System.Drawing.Size(319, 118);
            this.ChartMain.TabIndex = 3;
            this.ChartMain.Text = "ChartMain";
            this.ChartMain.Click += new System.EventHandler(this.ChartMain_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBuy.Location = new System.Drawing.Point(237, 185);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(71, 25);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // textBoxBuyP
            // 
            this.textBoxBuyP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxBuyP.Location = new System.Drawing.Point(4, 187);
            this.textBoxBuyP.Name = "textBoxBuyP";
            this.textBoxBuyP.Size = new System.Drawing.Size(75, 20);
            this.textBoxBuyP.TabIndex = 5;
            this.textBoxBuyP.Text = "0";
            this.textBoxBuyP.TextChanged += new System.EventHandler(this.textBoxP_TextChanged);
            this.textBoxBuyP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuyP_KeyDown);
            // 
            // buttonBuyV11
            // 
            this.buttonBuyV11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyV11.Location = new System.Drawing.Point(82, 159);
            this.buttonBuyV11.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyV11.Name = "buttonBuyV11";
            this.buttonBuyV11.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyV11.TabIndex = 4;
            this.buttonBuyV11.Text = "1:1";
            this.buttonBuyV11.UseVisualStyleBackColor = true;
            this.buttonBuyV11.Click += new System.EventHandler(this.buttonBuyV11_Click);
            // 
            // buttonBuyV12
            // 
            this.buttonBuyV12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyV12.Location = new System.Drawing.Point(112, 159);
            this.buttonBuyV12.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyV12.Name = "buttonBuyV12";
            this.buttonBuyV12.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyV12.TabIndex = 4;
            this.buttonBuyV12.Text = "1:2";
            this.buttonBuyV12.UseVisualStyleBackColor = true;
            this.buttonBuyV12.Click += new System.EventHandler(this.buttonBuyV12_Click);
            // 
            // buttonBuyPL
            // 
            this.buttonBuyPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyPL.Location = new System.Drawing.Point(82, 185);
            this.buttonBuyPL.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyPL.Name = "buttonBuyPL";
            this.buttonBuyPL.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyPL.TabIndex = 4;
            this.buttonBuyPL.Text = "L";
            this.buttonBuyPL.UseVisualStyleBackColor = true;
            this.buttonBuyPL.Click += new System.EventHandler(this.buttonBuyPL_Click);
            // 
            // buttonBuyPM
            // 
            this.buttonBuyPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyPM.Location = new System.Drawing.Point(112, 185);
            this.buttonBuyPM.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyPM.Name = "buttonBuyPM";
            this.buttonBuyPM.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyPM.TabIndex = 4;
            this.buttonBuyPM.Text = "M";
            this.buttonBuyPM.UseVisualStyleBackColor = true;
            this.buttonBuyPM.Click += new System.EventHandler(this.buttonBuyPM_Click);
            // 
            // labelBuyHave
            // 
            this.labelBuyHave.AutoSize = true;
            this.labelBuyHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuyHave.Location = new System.Drawing.Point(2, 141);
            this.labelBuyHave.Name = "labelBuyHave";
            this.labelBuyHave.Size = new System.Drawing.Size(102, 17);
            this.labelBuyHave.TabIndex = 6;
            this.labelBuyHave.Text = "0 USD (0 BTC)";
            this.labelBuyHave.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonBuyV14
            // 
            this.buttonBuyV14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyV14.Location = new System.Drawing.Point(142, 159);
            this.buttonBuyV14.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyV14.Name = "buttonBuyV14";
            this.buttonBuyV14.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyV14.TabIndex = 4;
            this.buttonBuyV14.Text = "1:4";
            this.buttonBuyV14.UseVisualStyleBackColor = true;
            this.buttonBuyV14.Click += new System.EventHandler(this.buttonBuyV14_Click);
            // 
            // labeBuyV
            // 
            this.labeBuyV.AutoSize = true;
            this.labeBuyV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeBuyV.Location = new System.Drawing.Point(145, 190);
            this.labeBuyV.Name = "labeBuyV";
            this.labeBuyV.Size = new System.Drawing.Size(47, 17);
            this.labeBuyV.TabIndex = 6;
            this.labeBuyV.Text = "0 BTC";
            this.labeBuyV.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxBuyV
            // 
            this.textBoxBuyV.Location = new System.Drawing.Point(4, 161);
            this.textBoxBuyV.Name = "textBoxBuyV";
            this.textBoxBuyV.Size = new System.Drawing.Size(75, 20);
            this.textBoxBuyV.TabIndex = 5;
            this.textBoxBuyV.Text = "0";
            this.textBoxBuyV.TextChanged += new System.EventHandler(this.textBoxV_TextChanged);
            this.textBoxBuyV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuyV_KeyDown);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.ForeColor = System.Drawing.Color.Red;
            this.buttonSell.Location = new System.Drawing.Point(237, 272);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(71, 25);
            this.buttonSell.TabIndex = 4;
            this.buttonSell.Text = "SELL";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonSellV11
            // 
            this.buttonSellV11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellV11.Location = new System.Drawing.Point(82, 246);
            this.buttonSellV11.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellV11.Name = "buttonSellV11";
            this.buttonSellV11.Size = new System.Drawing.Size(30, 25);
            this.buttonSellV11.TabIndex = 4;
            this.buttonSellV11.Text = "1:1";
            this.buttonSellV11.UseVisualStyleBackColor = true;
            this.buttonSellV11.Click += new System.EventHandler(this.buttonSellV11_Click);
            // 
            // buttonSellL
            // 
            this.buttonSellL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellL.Location = new System.Drawing.Point(82, 272);
            this.buttonSellL.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellL.Name = "buttonSellL";
            this.buttonSellL.Size = new System.Drawing.Size(30, 25);
            this.buttonSellL.TabIndex = 4;
            this.buttonSellL.Text = "L";
            this.buttonSellL.UseVisualStyleBackColor = true;
            this.buttonSellL.Click += new System.EventHandler(this.buttonSellL_Click);
            // 
            // buttonSellM
            // 
            this.buttonSellM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellM.Location = new System.Drawing.Point(112, 272);
            this.buttonSellM.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellM.Name = "buttonSellM";
            this.buttonSellM.Size = new System.Drawing.Size(30, 25);
            this.buttonSellM.TabIndex = 4;
            this.buttonSellM.Text = "M";
            this.buttonSellM.UseVisualStyleBackColor = true;
            this.buttonSellM.Click += new System.EventHandler(this.buttonSellM_Click);
            // 
            // buttonSellV12
            // 
            this.buttonSellV12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellV12.Location = new System.Drawing.Point(112, 246);
            this.buttonSellV12.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellV12.Name = "buttonSellV12";
            this.buttonSellV12.Size = new System.Drawing.Size(30, 25);
            this.buttonSellV12.TabIndex = 4;
            this.buttonSellV12.Text = "1:2";
            this.buttonSellV12.UseVisualStyleBackColor = true;
            this.buttonSellV12.Click += new System.EventHandler(this.buttonSellV12_Click);
            // 
            // buttonSellV14
            // 
            this.buttonSellV14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellV14.Location = new System.Drawing.Point(142, 246);
            this.buttonSellV14.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellV14.Name = "buttonSellV14";
            this.buttonSellV14.Size = new System.Drawing.Size(30, 25);
            this.buttonSellV14.TabIndex = 4;
            this.buttonSellV14.Text = "1:4";
            this.buttonSellV14.UseVisualStyleBackColor = true;
            this.buttonSellV14.Click += new System.EventHandler(this.buttonSellV14_Click);
            // 
            // textBoxSellP
            // 
            this.textBoxSellP.Location = new System.Drawing.Point(4, 274);
            this.textBoxSellP.Name = "textBoxSellP";
            this.textBoxSellP.Size = new System.Drawing.Size(75, 20);
            this.textBoxSellP.TabIndex = 5;
            this.textBoxSellP.Text = "0";
            this.textBoxSellP.TextChanged += new System.EventHandler(this.textBoxSellP_TextChanged);
            this.textBoxSellP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSellP_KeyDown);
            // 
            // textBoxSellV
            // 
            this.textBoxSellV.Location = new System.Drawing.Point(4, 248);
            this.textBoxSellV.Name = "textBoxSellV";
            this.textBoxSellV.Size = new System.Drawing.Size(75, 20);
            this.textBoxSellV.TabIndex = 5;
            this.textBoxSellV.Text = "0";
            this.textBoxSellV.TextChanged += new System.EventHandler(this.textBoxSellV_TextChanged);
            this.textBoxSellV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSellV_KeyDown);
            // 
            // labelSellHave
            // 
            this.labelSellHave.AutoSize = true;
            this.labelSellHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellHave.Location = new System.Drawing.Point(2, 228);
            this.labelSellHave.Name = "labelSellHave";
            this.labelSellHave.Size = new System.Drawing.Size(102, 17);
            this.labelSellHave.TabIndex = 6;
            this.labelSellHave.Text = "0 BTC (0 USD)";
            this.labelSellHave.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSellV
            // 
            this.labelSellV.AutoSize = true;
            this.labelSellV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellV.Location = new System.Drawing.Point(145, 277);
            this.labelSellV.Name = "labelSellV";
            this.labelSellV.Size = new System.Drawing.Size(49, 17);
            this.labelSellV.TabIndex = 6;
            this.labelSellV.Text = "0 USD";
            this.labelSellV.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCancelA
            // 
            this.buttonCancelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelA.Location = new System.Drawing.Point(278, 316);
            this.buttonCancelA.Name = "buttonCancelA";
            this.buttonCancelA.Size = new System.Drawing.Size(30, 26);
            this.buttonCancelA.TabIndex = 9;
            this.buttonCancelA.Text = "A";
            this.buttonCancelA.UseVisualStyleBackColor = true;
            this.buttonCancelA.Click += new System.EventHandler(this.buttonCancelA_Click);
            // 
            // buttonCancelS
            // 
            this.buttonCancelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelS.Location = new System.Drawing.Point(250, 316);
            this.buttonCancelS.Name = "buttonCancelS";
            this.buttonCancelS.Size = new System.Drawing.Size(30, 26);
            this.buttonCancelS.TabIndex = 9;
            this.buttonCancelS.Text = "S";
            this.buttonCancelS.UseVisualStyleBackColor = true;
            this.buttonCancelS.Click += new System.EventHandler(this.buttonCancelS_Click);
            // 
            // comboBoxPair
            // 
            this.comboBoxPair.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPair.Items.AddRange(new object[] {
            "BTC/USD",
            "BTC/RUR",
            "BTC/EUR",
            "LTC/BTC",
            "LTC/USD",
            "LTC/RUR",
            "LTC/EUR",
            "NMC/BTC",
            "NMC/USD",
            "NVC/BTC",
            "NVC/USD",
            "USD/RUR",
            "EUR/USD",
            "TRC/BTC",
            "PPC/BTC",
            "PPC/USD",
            "FTC/BTC",
            "XPM/BTC"});
            this.comboBoxPair.Location = new System.Drawing.Point(4, 0);
            this.comboBoxPair.Name = "comboBoxPair";
            this.comboBoxPair.Size = new System.Drawing.Size(75, 21);
            this.comboBoxPair.TabIndex = 10;
            this.comboBoxPair.SelectedIndexChanged += new System.EventHandler(this.comboBoxPair_SelectedIndexChanged);
            // 
            // listViewBid
            // 
            this.listViewBid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBid.FullRowSelect = true;
            this.listViewBid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBid.Location = new System.Drawing.Point(528, 0);
            this.listViewBid.MultiSelect = false;
            this.listViewBid.Name = "listViewBid";
            this.listViewBid.ShowGroups = false;
            this.listViewBid.Size = new System.Drawing.Size(208, 310);
            this.listViewBid.TabIndex = 8;
            this.listViewBid.UseCompatibleStateImageBehavior = false;
            this.listViewBid.View = System.Windows.Forms.View.Details;
            this.listViewBid.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Price";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Volume";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Depth";
            // 
            // listViewOpenOrders
            // 
            this.listViewOpenOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader15,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12});
            this.listViewOpenOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOpenOrders.FullRowSelect = true;
            this.listViewOpenOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOpenOrders.Location = new System.Drawing.Point(4, 316);
            this.listViewOpenOrders.MultiSelect = false;
            this.listViewOpenOrders.Name = "listViewOpenOrders";
            this.listViewOpenOrders.Size = new System.Drawing.Size(304, 210);
            this.listViewOpenOrders.TabIndex = 8;
            this.listViewOpenOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOpenOrders.View = System.Windows.Forms.View.Details;
            this.listViewOpenOrders.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pair";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "T";
            this.columnHeader15.Width = 20;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Volume";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Volume";
            this.columnHeader12.Width = 72;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader16,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHistory.Location = new System.Drawing.Point(314, 316);
            this.listViewHistory.MaximumSize = new System.Drawing.Size(1000, 700);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.ShowGroups = false;
            this.listViewHistory.Size = new System.Drawing.Size(422, 210);
            this.listViewHistory.TabIndex = 8;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pair";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "T";
            this.columnHeader16.Width = 20;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Volume";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Volume";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "+0%";
            this.columnHeader11.Width = 36;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "+1%";
            this.columnHeader14.Width = 36;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "+2%";
            this.columnHeader17.Width = 36;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "+4%";
            this.columnHeader18.Width = 36;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "+8%";
            this.columnHeader19.Width = 36;
            // 
            // listViewAsk
            // 
            this.listViewAsk.BackColor = System.Drawing.SystemColors.Window;
            this.listViewAsk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPrice,
            this.columnHeaderVolume,
            this.columnHeaderDepth});
            this.listViewAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAsk.FullRowSelect = true;
            this.listViewAsk.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAsk.Location = new System.Drawing.Point(314, 0);
            this.listViewAsk.MultiSelect = false;
            this.listViewAsk.Name = "listViewAsk";
            this.listViewAsk.ShowGroups = false;
            this.listViewAsk.Size = new System.Drawing.Size(208, 310);
            this.listViewAsk.TabIndex = 8;
            this.listViewAsk.UseCompatibleStateImageBehavior = false;
            this.listViewAsk.View = System.Windows.Forms.View.Details;
            this.listViewAsk.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            // 
            // columnHeaderVolume
            // 
            this.columnHeaderVolume.Text = "Volume";
            this.columnHeaderVolume.Width = 63;
            // 
            // columnHeaderDepth
            // 
            this.columnHeaderDepth.Text = "Depth";
            // 
            // buttonBuyV18
            // 
            this.buttonBuyV18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyV18.Location = new System.Drawing.Point(172, 159);
            this.buttonBuyV18.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyV18.Name = "buttonBuyV18";
            this.buttonBuyV18.Size = new System.Drawing.Size(30, 25);
            this.buttonBuyV18.TabIndex = 4;
            this.buttonBuyV18.Text = "1:8";
            this.buttonBuyV18.UseVisualStyleBackColor = true;
            this.buttonBuyV18.Click += new System.EventHandler(this.buttonBuyV18_Click);
            // 
            // buttonSellV18
            // 
            this.buttonSellV18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellV18.Location = new System.Drawing.Point(172, 246);
            this.buttonSellV18.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSellV18.Name = "buttonSellV18";
            this.buttonSellV18.Size = new System.Drawing.Size(30, 25);
            this.buttonSellV18.TabIndex = 4;
            this.buttonSellV18.Text = "1:8";
            this.buttonSellV18.UseVisualStyleBackColor = true;
            this.buttonSellV18.Click += new System.EventHandler(this.buttonSellV18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(737, 526);
            this.Controls.Add(this.comboBoxPair);
            this.Controls.Add(this.buttonCancelS);
            this.Controls.Add(this.buttonCancelA);
            this.Controls.Add(this.listViewBid);
            this.Controls.Add(this.listViewOpenOrders);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.listViewAsk);
            this.Controls.Add(this.labelSellV);
            this.Controls.Add(this.labeBuyV);
            this.Controls.Add(this.labelSellHave);
            this.Controls.Add(this.labelBuyHave);
            this.Controls.Add(this.textBoxSellV);
            this.Controls.Add(this.textBoxSellP);
            this.Controls.Add(this.textBoxBuyV);
            this.Controls.Add(this.buttonSellV18);
            this.Controls.Add(this.buttonSellV14);
            this.Controls.Add(this.textBoxBuyP);
            this.Controls.Add(this.buttonSellV12);
            this.Controls.Add(this.buttonBuyV18);
            this.Controls.Add(this.buttonBuyV14);
            this.Controls.Add(this.buttonSellM);
            this.Controls.Add(this.buttonBuyV12);
            this.Controls.Add(this.buttonSellL);
            this.Controls.Add(this.buttonBuyPM);
            this.Controls.Add(this.buttonSellV11);
            this.Controls.Add(this.buttonBuyPL);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonBuyV11);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.ChartMain);
            this.Controls.Add(this.label1now);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "True Terminal";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1now;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMain;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxBuyP;
        private System.Windows.Forms.Button buttonBuyV11;
        private System.Windows.Forms.Button buttonBuyV12;
        private System.Windows.Forms.Button buttonBuyPL;
        private System.Windows.Forms.Button buttonBuyPM;
        private System.Windows.Forms.Label labelBuyHave;
        private System.Windows.Forms.Button buttonBuyV14;
        private System.Windows.Forms.Label labeBuyV;
        private System.Windows.Forms.TextBox textBoxBuyV;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonSellV11;
        private System.Windows.Forms.Button buttonSellL;
        private System.Windows.Forms.Button buttonSellM;
        private System.Windows.Forms.Button buttonSellV12;
        private System.Windows.Forms.Button buttonSellV14;
        private System.Windows.Forms.TextBox textBoxSellP;
        private System.Windows.Forms.TextBox textBoxSellV;
        private System.Windows.Forms.Label labelSellHave;
        private System.Windows.Forms.Label labelSellV;
        private ListViewNF listViewAsk;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderVolume;
        private System.Windows.Forms.ColumnHeader columnHeaderDepth;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button buttonCancelA;
        private ListViewNF listViewBid;
        private ListViewNF listViewHistory;
        private ListViewNF listViewOpenOrders;
        private System.Windows.Forms.Button buttonCancelS;
        private System.Windows.Forms.ComboBox comboBoxPair;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Button buttonBuyV18;
        private System.Windows.Forms.Button buttonSellV18;
    }
}

