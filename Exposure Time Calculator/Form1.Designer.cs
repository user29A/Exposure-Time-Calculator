namespace Exposure_Time_Calculator
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Chart_Source = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Chart_Final = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.SourceTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.SourceBlackbodyTempTxt = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.GalaxyTypeHelpBtn = new System.Windows.Forms.Button();
			this.AGNTypeHelpBtn = new System.Windows.Forms.Button();
			this.SpectralTypeHelpBtn = new System.Windows.Forms.Button();
			this.SourcePowerLawDrop = new System.Windows.Forms.ComboBox();
			this.SourceAGNDrop = new System.Windows.Forms.ComboBox();
			this.SourcePowerLawRadBtn = new System.Windows.Forms.RadioButton();
			this.SourceBlackbodyRadBtn = new System.Windows.Forms.RadioButton();
			this.SourceAGNRadBtn = new System.Windows.Forms.RadioButton();
			this.SourceGalaxyDrop = new System.Windows.Forms.ComboBox();
			this.SourceGalaxyRadBtn = new System.Windows.Forms.RadioButton();
			this.SourceStarDrop = new System.Windows.Forms.ComboBox();
			this.SourceStarRadBtn = new System.Windows.Forms.RadioButton();
			this.ExtinctionGroupBox = new System.Windows.Forms.GroupBox();
			this.ExtinctionColumnDensityTxt = new System.Windows.Forms.TextBox();
			this.ExtinctionAvTxt = new System.Windows.Forms.TextBox();
			this.ExtinctionHelpBtn = new System.Windows.Forms.Button();
			this.ExtinctionDistanceRadBtn = new System.Windows.Forms.RadioButton();
			this.ExtinctionColumnDensityRadBtn = new System.Windows.Forms.RadioButton();
			this.ExtinctionAvRadBtn = new System.Windows.Forms.RadioButton();
			this.ExtinctionRvTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.FilterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterGridView = new System.Windows.Forms.DataGridView();
			this.label19 = new System.Windows.Forms.Label();
			this.FilterDropDown = new System.Windows.Forms.ComboBox();
			this.SNTargetUpD = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.SNHelpBtn = new System.Windows.Forms.Button();
			this.SourcePropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.RedShiftUpDown = new System.Windows.Forms.NumericUpDown();
			this.SersicnUpD = new System.Windows.Forms.NumericUpDown();
			this.SersicReffUpD = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.DistanceTxt = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.PowerLawNormTxt = new System.Windows.Forms.TextBox();
			this.RadiusTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mIeTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PowerLawAlphaLabel = new System.Windows.Forms.Label();
			this.PowerLawAlphaTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mvTxt = new System.Windows.Forms.TextBox();
			this.mvRadBtn = new System.Windows.Forms.RadioButton();
			this.DistanceRadBtn = new System.Windows.Forms.RadioButton();
			this.Chart_Filter = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ShowLocalFlux = new System.Windows.Forms.CheckBox();
			this.DetectorGroupBox = new System.Windows.Forms.GroupBox();
			this.MirrorAreaUpD = new System.Windows.Forms.NumericUpDown();
			this.label18 = new System.Windows.Forms.Label();
			this.DarkRateUpD = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.ReadNoiseUpD = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.FWHMpixelsTxt = new System.Windows.Forms.Label();
			this.PlateScaleUpD = new System.Windows.Forms.NumericUpDown();
			this.FWHMUpD = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.DecTargetTxt = new System.Windows.Forms.TextBox();
			this.RATargetTxt = new System.Windows.Forms.TextBox();
			this.BSWTForceQueryChck = new System.Windows.Forms.CheckBox();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FileMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.ETCMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.DetectorSystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadedDetectorSystemMenuLabel = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectNewDetectorMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.PlotLimitsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.xAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PlotLimitXMinText = new System.Windows.Forms.ToolStripTextBox();
			this.xAxisMaximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PlotLimitXMaxText = new System.Windows.Forms.ToolStripTextBox();
			this.BSWTMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabETC = new System.Windows.Forms.TabPage();
			this.SaveOutputsBtn = new System.Windows.Forms.Button();
			this.EscBtn = new System.Windows.Forms.Button();
			this.TabBSWT = new System.Windows.Forms.TabPage();
			this.BSWTMaxBrightSourcesUpD = new System.Windows.Forms.NumericUpDown();
			this.label29 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.BSWTVerticalPixUpD = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.BSWTHorizontalPixUpD = new System.Windows.Forms.NumericUpDown();
			this.label21 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.BSWTPlateScaleUpD = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.BSWTMessageBox = new System.Windows.Forms.ListBox();
			this.BSWTExecuteBtn = new System.Windows.Forms.Button();
			this.BSWTPictureBox = new System.Windows.Forms.PictureBox();
			this.FieldBufferUpD = new System.Windows.Forms.NumericUpDown();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.BSWTFilterDrop = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.BSWTCatalogueDrop = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.FieldShapeBtn = new System.Windows.Forms.Button();
			this.DecTargetBtn = new System.Windows.Forms.Button();
			this.RATargetBtn = new System.Windows.Forms.Button();
			this.BSWTMagLimitUpD = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Source)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Final)).BeginInit();
			this.SourceTypeGroupBox.SuspendLayout();
			this.ExtinctionGroupBox.SuspendLayout();
			this.FilterGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FilterGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SNTargetUpD)).BeginInit();
			this.SourcePropertiesGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RedShiftUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SersicnUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SersicReffUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Filter)).BeginInit();
			this.DetectorGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MirrorAreaUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DarkRateUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReadNoiseUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PlateScaleUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FWHMUpD)).BeginInit();
			this.MainMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.TabETC.SuspendLayout();
			this.TabBSWT.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BSWTMaxBrightSourcesUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTVerticalPixUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTHorizontalPixUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTPlateScaleUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FieldBufferUpD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTMagLimitUpD)).BeginInit();
			this.SuspendLayout();
			// 
			// Chart_Source
			// 
			this.Chart_Source.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Source.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.AxisX.Title = "Wavelength";
			chartArea1.AxisY.LabelStyle.Format = "e1";
			chartArea1.BackColor = System.Drawing.Color.DimGray;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BackSecondaryColor = System.Drawing.Color.Silver;
			chartArea1.Name = "ChartArea1";
			this.Chart_Source.ChartAreas.Add(chartArea1);
			this.Chart_Source.Location = new System.Drawing.Point(6, 6);
			this.Chart_Source.Name = "Chart_Source";
			series1.BorderColor = System.Drawing.Color.White;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Red;
			series1.Name = "Series1";
			this.Chart_Source.Series.Add(series1);
			this.Chart_Source.Size = new System.Drawing.Size(827, 258);
			this.Chart_Source.TabIndex = 0;
			this.Chart_Source.Text = "chart1";
			title1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "Title1";
			title1.Text = "Local Source Flux (Source * Extinction * Distance)";
			title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
			this.Chart_Source.Titles.Add(title1);
			// 
			// Chart_Final
			// 
			this.Chart_Final.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Final.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea2.AxisX.Title = "Wavelength";
			chartArea2.AxisY.LabelStyle.Format = "e1";
			chartArea2.BackColor = System.Drawing.Color.DimGray;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.BackSecondaryColor = System.Drawing.Color.Silver;
			chartArea2.Name = "ChartArea1";
			this.Chart_Final.ChartAreas.Add(chartArea2);
			this.Chart_Final.Location = new System.Drawing.Point(6, 534);
			this.Chart_Final.Name = "Chart_Final";
			series2.BorderColor = System.Drawing.Color.White;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Red;
			series2.Name = "Series1";
			this.Chart_Final.Series.Add(series2);
			this.Chart_Final.Size = new System.Drawing.Size(827, 258);
			this.Chart_Final.TabIndex = 4;
			this.Chart_Final.Text = "chart1";
			title2.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title2.Name = "Title1";
			title2.Text = "Final Throughput";
			title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
			this.Chart_Final.Titles.Add(title2);
			// 
			// SourceTypeGroupBox
			// 
			this.SourceTypeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SourceTypeGroupBox.BackColor = System.Drawing.Color.Silver;
			this.SourceTypeGroupBox.Controls.Add(this.SourceBlackbodyTempTxt);
			this.SourceTypeGroupBox.Controls.Add(this.label14);
			this.SourceTypeGroupBox.Controls.Add(this.GalaxyTypeHelpBtn);
			this.SourceTypeGroupBox.Controls.Add(this.AGNTypeHelpBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SpectralTypeHelpBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SourcePowerLawDrop);
			this.SourceTypeGroupBox.Controls.Add(this.SourceAGNDrop);
			this.SourceTypeGroupBox.Controls.Add(this.SourcePowerLawRadBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SourceBlackbodyRadBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SourceAGNRadBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SourceGalaxyDrop);
			this.SourceTypeGroupBox.Controls.Add(this.SourceGalaxyRadBtn);
			this.SourceTypeGroupBox.Controls.Add(this.SourceStarDrop);
			this.SourceTypeGroupBox.Controls.Add(this.SourceStarRadBtn);
			this.SourceTypeGroupBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceTypeGroupBox.Location = new System.Drawing.Point(835, 11);
			this.SourceTypeGroupBox.Name = "SourceTypeGroupBox";
			this.SourceTypeGroupBox.Size = new System.Drawing.Size(247, 165);
			this.SourceTypeGroupBox.TabIndex = 5;
			this.SourceTypeGroupBox.TabStop = false;
			this.SourceTypeGroupBox.Text = "Source Type";
			// 
			// SourceBlackbodyTempTxt
			// 
			this.SourceBlackbodyTempTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceBlackbodyTempTxt.Location = new System.Drawing.Point(123, 25);
			this.SourceBlackbodyTempTxt.Name = "SourceBlackbodyTempTxt";
			this.SourceBlackbodyTempTxt.Size = new System.Drawing.Size(88, 22);
			this.SourceBlackbodyTempTxt.TabIndex = 21;
			this.SourceBlackbodyTempTxt.TextChanged += new System.EventHandler(this.SourceBlackbodyTempTxt_TextChanged);
			this.SourceBlackbodyTempTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SourceBlackbodyTempTxt_KeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(220, 28);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(17, 16);
			this.label14.TabIndex = 18;
			this.label14.Text = "K";
			// 
			// GalaxyTypeHelpBtn
			// 
			this.GalaxyTypeHelpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GalaxyTypeHelpBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GalaxyTypeHelpBtn.Location = new System.Drawing.Point(217, 131);
			this.GalaxyTypeHelpBtn.Name = "GalaxyTypeHelpBtn";
			this.GalaxyTypeHelpBtn.Size = new System.Drawing.Size(26, 26);
			this.GalaxyTypeHelpBtn.TabIndex = 20;
			this.GalaxyTypeHelpBtn.Text = "?";
			this.GalaxyTypeHelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.GalaxyTypeHelpBtn.UseVisualStyleBackColor = true;
			this.GalaxyTypeHelpBtn.Click += new System.EventHandler(this.GalaxyTypeHelpBtn_Click);
			// 
			// AGNTypeHelpBtn
			// 
			this.AGNTypeHelpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AGNTypeHelpBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AGNTypeHelpBtn.Location = new System.Drawing.Point(217, 104);
			this.AGNTypeHelpBtn.Name = "AGNTypeHelpBtn";
			this.AGNTypeHelpBtn.Size = new System.Drawing.Size(26, 26);
			this.AGNTypeHelpBtn.TabIndex = 20;
			this.AGNTypeHelpBtn.Text = "?";
			this.AGNTypeHelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AGNTypeHelpBtn.UseVisualStyleBackColor = true;
			this.AGNTypeHelpBtn.Click += new System.EventHandler(this.AGNTypeHelpBtn_Click);
			// 
			// SpectralTypeHelpBtn
			// 
			this.SpectralTypeHelpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SpectralTypeHelpBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpectralTypeHelpBtn.Location = new System.Drawing.Point(217, 50);
			this.SpectralTypeHelpBtn.Name = "SpectralTypeHelpBtn";
			this.SpectralTypeHelpBtn.Size = new System.Drawing.Size(26, 26);
			this.SpectralTypeHelpBtn.TabIndex = 20;
			this.SpectralTypeHelpBtn.Text = "?";
			this.SpectralTypeHelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SpectralTypeHelpBtn.UseVisualStyleBackColor = true;
			this.SpectralTypeHelpBtn.Click += new System.EventHandler(this.SpectralTypeHelpBtn_Click);
			// 
			// SourcePowerLawDrop
			// 
			this.SourcePowerLawDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourcePowerLawDrop.Enabled = false;
			this.SourcePowerLawDrop.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourcePowerLawDrop.FormattingEnabled = true;
			this.SourcePowerLawDrop.Items.AddRange(new object[] {
            "f(nu)",
            "f(lambda)"});
			this.SourcePowerLawDrop.Location = new System.Drawing.Point(123, 79);
			this.SourcePowerLawDrop.Name = "SourcePowerLawDrop";
			this.SourcePowerLawDrop.Size = new System.Drawing.Size(88, 22);
			this.SourcePowerLawDrop.TabIndex = 14;
			this.SourcePowerLawDrop.SelectedIndexChanged += new System.EventHandler(this.SourcePowerLawDrop_SelectedIndexChanged);
			// 
			// SourceAGNDrop
			// 
			this.SourceAGNDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourceAGNDrop.Enabled = false;
			this.SourceAGNDrop.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceAGNDrop.FormattingEnabled = true;
			this.SourceAGNDrop.Items.AddRange(new object[] {
            "Liner (norm: v=12.5)",
            "NGC-1068 (norm: v=10.3)",
            "QSO (norm: b=12.5)",
            "Seyfert1 (norm: b=12.5)",
            "Seyfert2 (norm: v=12.5)"});
			this.SourceAGNDrop.Location = new System.Drawing.Point(123, 106);
			this.SourceAGNDrop.Name = "SourceAGNDrop";
			this.SourceAGNDrop.Size = new System.Drawing.Size(88, 22);
			this.SourceAGNDrop.TabIndex = 12;
			this.SourceAGNDrop.DropDown += new System.EventHandler(this.SourceAGNDrop_DropDown);
			this.SourceAGNDrop.SelectedIndexChanged += new System.EventHandler(this.SourceAGNDrop_SelectedIndexChanged);
			this.SourceAGNDrop.DropDownClosed += new System.EventHandler(this.SourceAGNDrop_DropDownClosed);
			// 
			// SourcePowerLawRadBtn
			// 
			this.SourcePowerLawRadBtn.AutoSize = true;
			this.SourcePowerLawRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourcePowerLawRadBtn.Location = new System.Drawing.Point(6, 78);
			this.SourcePowerLawRadBtn.Name = "SourcePowerLawRadBtn";
			this.SourcePowerLawRadBtn.Size = new System.Drawing.Size(90, 20);
			this.SourcePowerLawRadBtn.TabIndex = 13;
			this.SourcePowerLawRadBtn.TabStop = true;
			this.SourcePowerLawRadBtn.Text = "Power Law:";
			this.SourcePowerLawRadBtn.UseVisualStyleBackColor = true;
			this.SourcePowerLawRadBtn.CheckedChanged += new System.EventHandler(this.SourcePowerLawRadBtn_CheckedChanged);
			// 
			// SourceBlackbodyRadBtn
			// 
			this.SourceBlackbodyRadBtn.AutoSize = true;
			this.SourceBlackbodyRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceBlackbodyRadBtn.Location = new System.Drawing.Point(6, 23);
			this.SourceBlackbodyRadBtn.Name = "SourceBlackbodyRadBtn";
			this.SourceBlackbodyRadBtn.Size = new System.Drawing.Size(86, 20);
			this.SourceBlackbodyRadBtn.TabIndex = 9;
			this.SourceBlackbodyRadBtn.TabStop = true;
			this.SourceBlackbodyRadBtn.Text = "Blackbody:";
			this.SourceBlackbodyRadBtn.UseVisualStyleBackColor = true;
			this.SourceBlackbodyRadBtn.CheckedChanged += new System.EventHandler(this.SourceBlackbodyRadBtn_CheckedChanged);
			// 
			// SourceAGNRadBtn
			// 
			this.SourceAGNRadBtn.AutoSize = true;
			this.SourceAGNRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceAGNRadBtn.Location = new System.Drawing.Point(6, 105);
			this.SourceAGNRadBtn.Name = "SourceAGNRadBtn";
			this.SourceAGNRadBtn.Size = new System.Drawing.Size(91, 20);
			this.SourceAGNRadBtn.TabIndex = 11;
			this.SourceAGNRadBtn.TabStop = true;
			this.SourceAGNRadBtn.Text = "AGN Type:";
			this.SourceAGNRadBtn.UseVisualStyleBackColor = true;
			this.SourceAGNRadBtn.CheckedChanged += new System.EventHandler(this.SourceAGNRadBtn_CheckedChanged);
			// 
			// SourceGalaxyDrop
			// 
			this.SourceGalaxyDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourceGalaxyDrop.Enabled = false;
			this.SourceGalaxyDrop.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceGalaxyDrop.FormattingEnabled = true;
			this.SourceGalaxyDrop.Items.AddRange(new object[] {
            "Elliptical (norm: v=12.5)",
            "Bulge (norm: v=12.5)",
            "S0 (norm: v=12.5)",
            "Sa (norm: v=12.5)",
            "Sb (norm: v=12.5)",
            "Sc (norm: v=12.5)",
            "Starburst1: e(b-v)<0.1 (norm: v=12.5)",
            "Starburst2: 0.11< e(b-v)<0.21 (norm: v=12.5)",
            "Starburst3: 0.25< e(b-v)<0.35 (norm: v=12.5)",
            "Starburst4: 0.39< e(b-v)<0.50 (norm: v=12.5)",
            "Starburst5: 0.51< e(b-v)<0.60 (norm: v=12.5)",
            "Starburst6: 0.61< e(b-v)<0.70 (norm: v=12.5)"});
			this.SourceGalaxyDrop.Location = new System.Drawing.Point(123, 133);
			this.SourceGalaxyDrop.Name = "SourceGalaxyDrop";
			this.SourceGalaxyDrop.Size = new System.Drawing.Size(88, 22);
			this.SourceGalaxyDrop.TabIndex = 8;
			this.SourceGalaxyDrop.DropDown += new System.EventHandler(this.SourceGalaxyDrop_DropDown);
			this.SourceGalaxyDrop.SelectedIndexChanged += new System.EventHandler(this.SourceGalaxyDrop_SelectedIndexChanged);
			this.SourceGalaxyDrop.DropDownClosed += new System.EventHandler(this.SourceGalaxyDrop_DropDownClosed);
			// 
			// SourceGalaxyRadBtn
			// 
			this.SourceGalaxyRadBtn.AutoSize = true;
			this.SourceGalaxyRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceGalaxyRadBtn.Location = new System.Drawing.Point(6, 133);
			this.SourceGalaxyRadBtn.Name = "SourceGalaxyRadBtn";
			this.SourceGalaxyRadBtn.Size = new System.Drawing.Size(98, 20);
			this.SourceGalaxyRadBtn.TabIndex = 7;
			this.SourceGalaxyRadBtn.TabStop = true;
			this.SourceGalaxyRadBtn.Text = "Galaxy Type:";
			this.SourceGalaxyRadBtn.UseVisualStyleBackColor = true;
			this.SourceGalaxyRadBtn.CheckedChanged += new System.EventHandler(this.SourceGalaxyRadBtn_CheckedChanged);
			// 
			// SourceStarDrop
			// 
			this.SourceStarDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourceStarDrop.Enabled = false;
			this.SourceStarDrop.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceStarDrop.FormattingEnabled = true;
			this.SourceStarDrop.Items.AddRange(new object[] {
            "O5V",
            "O6V",
            "O8V",
            "B0V",
            "B3V",
            "B5V",
            "B8V",
            "A0V",
            "A5V",
            "F0V",
            "F5V",
            "G0V",
            "G5V",
            "K0V",
            "K5V",
            "M0V",
            "M2V",
            "M5V",
            "B0III",
            "B5III",
            "G0III",
            "G5III",
            "K0III",
            "K5III",
            "M0III",
            "O5I",
            "O6I",
            "O8I",
            "B0I",
            "B5I",
            "A0I",
            "A5I",
            "F0I",
            "F5I",
            "G0I",
            "G5I",
            "K0I",
            "K5I",
            "M0I",
            "M2I"});
			this.SourceStarDrop.Location = new System.Drawing.Point(123, 52);
			this.SourceStarDrop.Name = "SourceStarDrop";
			this.SourceStarDrop.Size = new System.Drawing.Size(88, 22);
			this.SourceStarDrop.TabIndex = 6;
			this.SourceStarDrop.SelectedIndexChanged += new System.EventHandler(this.SourceStarDrop_SelectedIndexChanged);
			// 
			// SourceStarRadBtn
			// 
			this.SourceStarRadBtn.AutoSize = true;
			this.SourceStarRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceStarRadBtn.Location = new System.Drawing.Point(6, 50);
			this.SourceStarRadBtn.Name = "SourceStarRadBtn";
			this.SourceStarRadBtn.Size = new System.Drawing.Size(104, 20);
			this.SourceStarRadBtn.TabIndex = 0;
			this.SourceStarRadBtn.TabStop = true;
			this.SourceStarRadBtn.Text = "Spectral Type:";
			this.SourceStarRadBtn.UseVisualStyleBackColor = true;
			this.SourceStarRadBtn.CheckedChanged += new System.EventHandler(this.SourceStarRadBtn_CheckedChanged);
			// 
			// ExtinctionGroupBox
			// 
			this.ExtinctionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionColumnDensityTxt);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionAvTxt);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionHelpBtn);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionDistanceRadBtn);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionColumnDensityRadBtn);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionAvRadBtn);
			this.ExtinctionGroupBox.Controls.Add(this.ExtinctionRvTxt);
			this.ExtinctionGroupBox.Controls.Add(this.label4);
			this.ExtinctionGroupBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionGroupBox.Location = new System.Drawing.Point(835, 182);
			this.ExtinctionGroupBox.Name = "ExtinctionGroupBox";
			this.ExtinctionGroupBox.Size = new System.Drawing.Size(301, 140);
			this.ExtinctionGroupBox.TabIndex = 6;
			this.ExtinctionGroupBox.TabStop = false;
			this.ExtinctionGroupBox.Text = "Exctinction";
			// 
			// ExtinctionColumnDensityTxt
			// 
			this.ExtinctionColumnDensityTxt.Enabled = false;
			this.ExtinctionColumnDensityTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionColumnDensityTxt.Location = new System.Drawing.Point(253, 82);
			this.ExtinctionColumnDensityTxt.Name = "ExtinctionColumnDensityTxt";
			this.ExtinctionColumnDensityTxt.Size = new System.Drawing.Size(41, 22);
			this.ExtinctionColumnDensityTxt.TabIndex = 20;
			this.ExtinctionColumnDensityTxt.Text = "1";
			this.ExtinctionColumnDensityTxt.TextChanged += new System.EventHandler(this.ExtinctionColumnDensityTxt_TextChanged);
			this.ExtinctionColumnDensityTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtinctionColumnDensityTxt_KeyDown);
			// 
			// ExtinctionAvTxt
			// 
			this.ExtinctionAvTxt.Enabled = false;
			this.ExtinctionAvTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionAvTxt.Location = new System.Drawing.Point(253, 54);
			this.ExtinctionAvTxt.Name = "ExtinctionAvTxt";
			this.ExtinctionAvTxt.Size = new System.Drawing.Size(41, 22);
			this.ExtinctionAvTxt.TabIndex = 17;
			this.ExtinctionAvTxt.Text = "1";
			this.ExtinctionAvTxt.TextChanged += new System.EventHandler(this.ExtinctionAvTxt_TextChanged);
			this.ExtinctionAvTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtinctionAvTxt_KeyDown);
			// 
			// ExtinctionHelpBtn
			// 
			this.ExtinctionHelpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ExtinctionHelpBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionHelpBtn.Location = new System.Drawing.Point(271, 15);
			this.ExtinctionHelpBtn.Name = "ExtinctionHelpBtn";
			this.ExtinctionHelpBtn.Size = new System.Drawing.Size(26, 26);
			this.ExtinctionHelpBtn.TabIndex = 19;
			this.ExtinctionHelpBtn.Text = "?";
			this.ExtinctionHelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ExtinctionHelpBtn.UseVisualStyleBackColor = true;
			this.ExtinctionHelpBtn.Click += new System.EventHandler(this.ExtinctionHelpBtn_Click);
			// 
			// ExtinctionDistanceRadBtn
			// 
			this.ExtinctionDistanceRadBtn.AutoSize = true;
			this.ExtinctionDistanceRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionDistanceRadBtn.Location = new System.Drawing.Point(9, 109);
			this.ExtinctionDistanceRadBtn.Name = "ExtinctionDistanceRadBtn";
			this.ExtinctionDistanceRadBtn.Size = new System.Drawing.Size(73, 20);
			this.ExtinctionDistanceRadBtn.TabIndex = 18;
			this.ExtinctionDistanceRadBtn.Text = "Distance";
			this.ExtinctionDistanceRadBtn.UseVisualStyleBackColor = true;
			this.ExtinctionDistanceRadBtn.CheckedChanged += new System.EventHandler(this.ExtinctionDistanceRadBtn_CheckedChanged);
			// 
			// ExtinctionColumnDensityRadBtn
			// 
			this.ExtinctionColumnDensityRadBtn.AutoSize = true;
			this.ExtinctionColumnDensityRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionColumnDensityRadBtn.Location = new System.Drawing.Point(9, 81);
			this.ExtinctionColumnDensityRadBtn.Name = "ExtinctionColumnDensityRadBtn";
			this.ExtinctionColumnDensityRadBtn.Size = new System.Drawing.Size(204, 20);
			this.ExtinctionColumnDensityRadBtn.TabIndex = 17;
			this.ExtinctionColumnDensityRadBtn.Text = "Column Density (10^21 / cm2):";
			this.ExtinctionColumnDensityRadBtn.UseVisualStyleBackColor = true;
			this.ExtinctionColumnDensityRadBtn.CheckedChanged += new System.EventHandler(this.ExtinctionColumnDensityRadBtn_CheckedChanged);
			// 
			// ExtinctionAvRadBtn
			// 
			this.ExtinctionAvRadBtn.AutoSize = true;
			this.ExtinctionAvRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionAvRadBtn.Location = new System.Drawing.Point(9, 53);
			this.ExtinctionAvRadBtn.Name = "ExtinctionAvRadBtn";
			this.ExtinctionAvRadBtn.Size = new System.Drawing.Size(174, 20);
			this.ExtinctionAvRadBtn.TabIndex = 14;
			this.ExtinctionAvRadBtn.Text = "Visual Band Extinction Av:";
			this.ExtinctionAvRadBtn.UseVisualStyleBackColor = true;
			this.ExtinctionAvRadBtn.CheckedChanged += new System.EventHandler(this.ExtinctionAvRadBtn_CheckedChanged);
			// 
			// ExtinctionRvTxt
			// 
			this.ExtinctionRvTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtinctionRvTxt.Location = new System.Drawing.Point(42, 24);
			this.ExtinctionRvTxt.Name = "ExtinctionRvTxt";
			this.ExtinctionRvTxt.Size = new System.Drawing.Size(41, 22);
			this.ExtinctionRvTxt.TabIndex = 16;
			this.ExtinctionRvTxt.Text = "3.1";
			this.ExtinctionRvTxt.TextChanged += new System.EventHandler(this.ExtinctionRvTxt_TextChanged);
			this.ExtinctionRvTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtinctionRvTxt_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Rv:";
			// 
			// FilterGroupBox
			// 
			this.FilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FilterGroupBox.Controls.Add(this.FilterGridView);
			this.FilterGroupBox.Controls.Add(this.label19);
			this.FilterGroupBox.Controls.Add(this.FilterDropDown);
			this.FilterGroupBox.Controls.Add(this.SNTargetUpD);
			this.FilterGroupBox.Controls.Add(this.label15);
			this.FilterGroupBox.Controls.Add(this.SNHelpBtn);
			this.FilterGroupBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FilterGroupBox.Location = new System.Drawing.Point(835, 328);
			this.FilterGroupBox.Name = "FilterGroupBox";
			this.FilterGroupBox.Size = new System.Drawing.Size(596, 243);
			this.FilterGroupBox.TabIndex = 9;
			this.FilterGroupBox.TabStop = false;
			this.FilterGroupBox.Text = "Filter && Results";
			// 
			// FilterGridView
			// 
			this.FilterGridView.AllowUserToAddRows = false;
			this.FilterGridView.AllowUserToDeleteRows = false;
			this.FilterGridView.AllowUserToResizeColumns = false;
			this.FilterGridView.AllowUserToResizeRows = false;
			this.FilterGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.FilterGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.FilterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FilterGridView.Location = new System.Drawing.Point(11, 48);
			this.FilterGridView.Name = "FilterGridView";
			this.FilterGridView.ReadOnly = true;
			this.FilterGridView.RowHeadersVisible = false;
			this.FilterGridView.RowHeadersWidth = 62;
			this.FilterGridView.Size = new System.Drawing.Size(446, 183);
			this.FilterGridView.TabIndex = 45;
			this.FilterGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FilterGridView_CellMouseDown);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Garamond", 10F);
			this.label19.Location = new System.Drawing.Point(6, 23);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(84, 16);
			this.label19.TabIndex = 44;
			this.label19.Text = "Display Filter:";
			// 
			// FilterDropDown
			// 
			this.FilterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FilterDropDown.Font = new System.Drawing.Font("Garamond", 10F);
			this.FilterDropDown.FormattingEnabled = true;
			this.FilterDropDown.Location = new System.Drawing.Point(96, 20);
			this.FilterDropDown.Name = "FilterDropDown";
			this.FilterDropDown.Size = new System.Drawing.Size(121, 22);
			this.FilterDropDown.TabIndex = 20;
			this.FilterDropDown.SelectedIndexChanged += new System.EventHandler(this.FilterDropDown_SelectedIndexChanged);
			// 
			// SNTargetUpD
			// 
			this.SNTargetUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SNTargetUpD.Location = new System.Drawing.Point(307, 20);
			this.SNTargetUpD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.SNTargetUpD.Name = "SNTargetUpD";
			this.SNTargetUpD.Size = new System.Drawing.Size(52, 22);
			this.SNTargetUpD.TabIndex = 19;
			this.SNTargetUpD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.SNTargetUpD.ValueChanged += new System.EventHandler(this.SNTargetUpD_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Garamond", 10F);
			this.label15.Location = new System.Drawing.Point(226, 23);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(75, 16);
			this.label15.TabIndex = 31;
			this.label15.Text = "Target S/N:";
			// 
			// SNHelpBtn
			// 
			this.SNHelpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SNHelpBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SNHelpBtn.Location = new System.Drawing.Point(559, 14);
			this.SNHelpBtn.Name = "SNHelpBtn";
			this.SNHelpBtn.Size = new System.Drawing.Size(26, 26);
			this.SNHelpBtn.TabIndex = 20;
			this.SNHelpBtn.Text = "?";
			this.SNHelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SNHelpBtn.UseVisualStyleBackColor = true;
			this.SNHelpBtn.Click += new System.EventHandler(this.SNHelpBtn_Click);
			// 
			// SourcePropertiesGroupBox
			// 
			this.SourcePropertiesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SourcePropertiesGroupBox.Controls.Add(this.RedShiftUpDown);
			this.SourcePropertiesGroupBox.Controls.Add(this.SersicnUpD);
			this.SourcePropertiesGroupBox.Controls.Add(this.SersicReffUpD);
			this.SourcePropertiesGroupBox.Controls.Add(this.label12);
			this.SourcePropertiesGroupBox.Controls.Add(this.DistanceTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.label10);
			this.SourcePropertiesGroupBox.Controls.Add(this.PowerLawNormTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.RadiusTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.label1);
			this.SourcePropertiesGroupBox.Controls.Add(this.label5);
			this.SourcePropertiesGroupBox.Controls.Add(this.mIeTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.label3);
			this.SourcePropertiesGroupBox.Controls.Add(this.PowerLawAlphaLabel);
			this.SourcePropertiesGroupBox.Controls.Add(this.PowerLawAlphaTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.label2);
			this.SourcePropertiesGroupBox.Controls.Add(this.mvTxt);
			this.SourcePropertiesGroupBox.Controls.Add(this.mvRadBtn);
			this.SourcePropertiesGroupBox.Controls.Add(this.DistanceRadBtn);
			this.SourcePropertiesGroupBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourcePropertiesGroupBox.Location = new System.Drawing.Point(1088, 11);
			this.SourcePropertiesGroupBox.Name = "SourcePropertiesGroupBox";
			this.SourcePropertiesGroupBox.Size = new System.Drawing.Size(343, 165);
			this.SourcePropertiesGroupBox.TabIndex = 13;
			this.SourcePropertiesGroupBox.TabStop = false;
			this.SourcePropertiesGroupBox.Text = "Source Properties";
			// 
			// RedShiftUpDown
			// 
			this.RedShiftUpDown.DecimalPlaces = 2;
			this.RedShiftUpDown.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedShiftUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.RedShiftUpDown.Location = new System.Drawing.Point(291, 108);
			this.RedShiftUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.RedShiftUpDown.Name = "RedShiftUpDown";
			this.RedShiftUpDown.Size = new System.Drawing.Size(47, 22);
			this.RedShiftUpDown.TabIndex = 20;
			this.toolTip1.SetToolTip(this.RedShiftUpDown, "arcseconds");
			this.RedShiftUpDown.ValueChanged += new System.EventHandler(this.RedShiftUpDown_ValueChanged);
			// 
			// SersicnUpD
			// 
			this.SersicnUpD.DecimalPlaces = 1;
			this.SersicnUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SersicnUpD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.SersicnUpD.Location = new System.Drawing.Point(125, 134);
			this.SersicnUpD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.SersicnUpD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.SersicnUpD.Name = "SersicnUpD";
			this.SersicnUpD.Size = new System.Drawing.Size(45, 22);
			this.SersicnUpD.TabIndex = 20;
			this.SersicnUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SersicnUpD.ValueChanged += new System.EventHandler(this.SersicnUpD_ValueChanged);
			// 
			// SersicReffUpD
			// 
			this.SersicReffUpD.DecimalPlaces = 1;
			this.SersicReffUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SersicReffUpD.Location = new System.Drawing.Point(291, 134);
			this.SersicReffUpD.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.SersicReffUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SersicReffUpD.Name = "SersicReffUpD";
			this.SersicReffUpD.Size = new System.Drawing.Size(47, 22);
			this.SersicReffUpD.TabIndex = 19;
			this.toolTip1.SetToolTip(this.SersicReffUpD, "arcseconds");
			this.SersicReffUpD.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.SersicReffUpD.ValueChanged += new System.EventHandler(this.SersicReffUpD_ValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 135);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 16);
			this.label12.TabIndex = 27;
			this.label12.Text = "Sersic Factor n:";
			// 
			// DistanceTxt
			// 
			this.DistanceTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DistanceTxt.Location = new System.Drawing.Point(125, 29);
			this.DistanceTxt.Name = "DistanceTxt";
			this.DistanceTxt.Size = new System.Drawing.Size(45, 22);
			this.DistanceTxt.TabIndex = 14;
			this.DistanceTxt.Text = "0.5";
			this.DistanceTxt.TextChanged += new System.EventHandler(this.DistanceTxt_TextChanged);
			this.DistanceTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DistanceTxt_KeyDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(259, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 16);
			this.label10.TabIndex = 25;
			this.label10.Text = "Re:";
			// 
			// PowerLawNormTxt
			// 
			this.PowerLawNormTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PowerLawNormTxt.Location = new System.Drawing.Point(291, 82);
			this.PowerLawNormTxt.Name = "PowerLawNormTxt";
			this.PowerLawNormTxt.Size = new System.Drawing.Size(47, 22);
			this.PowerLawNormTxt.TabIndex = 18;
			this.PowerLawNormTxt.Text = "1";
			this.PowerLawNormTxt.TextChanged += new System.EventHandler(this.PowerLawNormTxt_TextChanged);
			this.PowerLawNormTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PowerLawNormTxt_KeyDown);
			// 
			// RadiusTxt
			// 
			this.RadiusTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadiusTxt.Location = new System.Drawing.Point(291, 28);
			this.RadiusTxt.Name = "RadiusTxt";
			this.RadiusTxt.Size = new System.Drawing.Size(47, 22);
			this.RadiusTxt.TabIndex = 16;
			this.RadiusTxt.Text = "1";
			this.RadiusTxt.TextChanged += new System.EventHandler(this.RadiusTxt_TextChanged);
			this.RadiusTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadiusTxt_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Red Shift:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 19;
			this.label5.Text = "Mag:";
			// 
			// mIeTxt
			// 
			this.mIeTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mIeTxt.Location = new System.Drawing.Point(125, 107);
			this.mIeTxt.Name = "mIeTxt";
			this.mIeTxt.Size = new System.Drawing.Size(45, 22);
			this.mIeTxt.TabIndex = 20;
			this.mIeTxt.Text = "12.5";
			this.mIeTxt.TextChanged += new System.EventHandler(this.mTxt_TextChanged);
			this.mIeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxt_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(240, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Norm:";
			// 
			// PowerLawAlphaLabel
			// 
			this.PowerLawAlphaLabel.AutoSize = true;
			this.PowerLawAlphaLabel.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PowerLawAlphaLabel.Location = new System.Drawing.Point(6, 85);
			this.PowerLawAlphaLabel.Name = "PowerLawAlphaLabel";
			this.PowerLawAlphaLabel.Size = new System.Drawing.Size(60, 16);
			this.PowerLawAlphaLabel.TabIndex = 15;
			this.PowerLawAlphaLabel.Text = "Alpha nu:";
			// 
			// PowerLawAlphaTxt
			// 
			this.PowerLawAlphaTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PowerLawAlphaTxt.Location = new System.Drawing.Point(125, 81);
			this.PowerLawAlphaTxt.Name = "PowerLawAlphaTxt";
			this.PowerLawAlphaTxt.Size = new System.Drawing.Size(45, 22);
			this.PowerLawAlphaTxt.TabIndex = 15;
			this.PowerLawAlphaTxt.Text = "1";
			this.PowerLawAlphaTxt.TextChanged += new System.EventHandler(this.PowerLawAlphaTxt_TextChanged);
			this.PowerLawAlphaTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PowerLawAlphaTxt_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(182, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Radius (RSun):";
			// 
			// mvTxt
			// 
			this.mvTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mvTxt.Location = new System.Drawing.Point(125, 55);
			this.mvTxt.Name = "mvTxt";
			this.mvTxt.Size = new System.Drawing.Size(45, 22);
			this.mvTxt.TabIndex = 15;
			this.mvTxt.Text = "0.5";
			this.mvTxt.TextChanged += new System.EventHandler(this.mvTxt_TextChanged);
			this.mvTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mvTxt_KeyDown);
			// 
			// mvRadBtn
			// 
			this.mvRadBtn.AutoSize = true;
			this.mvRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mvRadBtn.Location = new System.Drawing.Point(6, 56);
			this.mvRadBtn.Name = "mvRadBtn";
			this.mvRadBtn.Size = new System.Drawing.Size(46, 20);
			this.mvRadBtn.TabIndex = 12;
			this.mvRadBtn.TabStop = true;
			this.mvRadBtn.Text = "mv:";
			this.mvRadBtn.UseVisualStyleBackColor = true;
			this.mvRadBtn.CheckedChanged += new System.EventHandler(this.mvRadBtn_CheckedChanged);
			// 
			// DistanceRadBtn
			// 
			this.DistanceRadBtn.AutoSize = true;
			this.DistanceRadBtn.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DistanceRadBtn.Location = new System.Drawing.Point(6, 27);
			this.DistanceRadBtn.Name = "DistanceRadBtn";
			this.DistanceRadBtn.Size = new System.Drawing.Size(108, 20);
			this.DistanceRadBtn.TabIndex = 10;
			this.DistanceRadBtn.TabStop = true;
			this.DistanceRadBtn.Text = "Distance (kpc):";
			this.DistanceRadBtn.UseVisualStyleBackColor = true;
			this.DistanceRadBtn.CheckedChanged += new System.EventHandler(this.DistanceRadBtn_CheckedChanged);
			// 
			// Chart_Filter
			// 
			this.Chart_Filter.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Filter.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea3.AxisX.Title = "Wavelength";
			chartArea3.BackColor = System.Drawing.Color.DimGray;
			chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea3.BackSecondaryColor = System.Drawing.Color.Silver;
			chartArea3.Name = "ChartArea1";
			this.Chart_Filter.ChartAreas.Add(chartArea3);
			this.Chart_Filter.Location = new System.Drawing.Point(6, 270);
			this.Chart_Filter.Name = "Chart_Filter";
			series3.BorderColor = System.Drawing.Color.White;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.Red;
			series3.Name = "Series1";
			this.Chart_Filter.Series.Add(series3);
			this.Chart_Filter.Size = new System.Drawing.Size(827, 258);
			this.Chart_Filter.TabIndex = 14;
			this.Chart_Filter.Text = "chart1";
			title3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title3.Name = "Title1";
			title3.Text = "Mirror * Filter * QE";
			title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
			this.Chart_Filter.Titles.Add(title3);
			// 
			// ShowLocalFlux
			// 
			this.ShowLocalFlux.AutoSize = true;
			this.ShowLocalFlux.Checked = true;
			this.ShowLocalFlux.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ShowLocalFlux.Location = new System.Drawing.Point(116, 13);
			this.ShowLocalFlux.Name = "ShowLocalFlux";
			this.ShowLocalFlux.Size = new System.Drawing.Size(52, 17);
			this.ShowLocalFlux.TabIndex = 15;
			this.ShowLocalFlux.Text = "Local";
			this.ShowLocalFlux.UseVisualStyleBackColor = true;
			this.ShowLocalFlux.CheckedChanged += new System.EventHandler(this.ShowLocalFlux_CheckedChanged);
			// 
			// DetectorGroupBox
			// 
			this.DetectorGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DetectorGroupBox.Controls.Add(this.MirrorAreaUpD);
			this.DetectorGroupBox.Controls.Add(this.label18);
			this.DetectorGroupBox.Controls.Add(this.DarkRateUpD);
			this.DetectorGroupBox.Controls.Add(this.label17);
			this.DetectorGroupBox.Controls.Add(this.ReadNoiseUpD);
			this.DetectorGroupBox.Controls.Add(this.label11);
			this.DetectorGroupBox.Controls.Add(this.FWHMpixelsTxt);
			this.DetectorGroupBox.Controls.Add(this.PlateScaleUpD);
			this.DetectorGroupBox.Controls.Add(this.FWHMUpD);
			this.DetectorGroupBox.Controls.Add(this.label9);
			this.DetectorGroupBox.Controls.Add(this.label8);
			this.DetectorGroupBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DetectorGroupBox.Location = new System.Drawing.Point(1142, 182);
			this.DetectorGroupBox.Name = "DetectorGroupBox";
			this.DetectorGroupBox.Size = new System.Drawing.Size(232, 140);
			this.DetectorGroupBox.TabIndex = 16;
			this.DetectorGroupBox.TabStop = false;
			this.DetectorGroupBox.Text = "Detector && Optics";
			// 
			// MirrorAreaUpD
			// 
			this.MirrorAreaUpD.DecimalPlaces = 3;
			this.MirrorAreaUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MirrorAreaUpD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.MirrorAreaUpD.Location = new System.Drawing.Point(173, 20);
			this.MirrorAreaUpD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.MirrorAreaUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.MirrorAreaUpD.Name = "MirrorAreaUpD";
			this.MirrorAreaUpD.Size = new System.Drawing.Size(56, 22);
			this.MirrorAreaUpD.TabIndex = 10;
			this.toolTip1.SetToolTip(this.MirrorAreaUpD, "Effective mirror collecting area");
			this.MirrorAreaUpD.Value = new decimal(new int[] {
            785,
            0,
            0,
            196608});
			this.MirrorAreaUpD.ValueChanged += new System.EventHandler(this.MirrorAreaUpD_ValueChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 22);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(128, 16);
			this.label18.TabIndex = 9;
			this.label18.Text = "Collecting Area (m^2)";
			this.toolTip1.SetToolTip(this.label18, "Effective mirror collecting area");
			// 
			// DarkRateUpD
			// 
			this.DarkRateUpD.DecimalPlaces = 1;
			this.DarkRateUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DarkRateUpD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.DarkRateUpD.Location = new System.Drawing.Point(173, 112);
			this.DarkRateUpD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.DarkRateUpD.Name = "DarkRateUpD";
			this.DarkRateUpD.Size = new System.Drawing.Size(56, 22);
			this.DarkRateUpD.TabIndex = 8;
			this.toolTip1.SetToolTip(this.DarkRateUpD, "counts per minute per pixel");
			this.DarkRateUpD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.DarkRateUpD.ValueChanged += new System.EventHandler(this.DarkRateUpD_ValueChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 114);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(101, 16);
			this.label17.TabIndex = 7;
			this.label17.Text = "Dark Rate (cpm)";
			this.toolTip1.SetToolTip(this.label17, "counts per minute per pixel");
			// 
			// ReadNoiseUpD
			// 
			this.ReadNoiseUpD.DecimalPlaces = 1;
			this.ReadNoiseUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReadNoiseUpD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ReadNoiseUpD.Location = new System.Drawing.Point(173, 89);
			this.ReadNoiseUpD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ReadNoiseUpD.Name = "ReadNoiseUpD";
			this.ReadNoiseUpD.Size = new System.Drawing.Size(56, 22);
			this.ReadNoiseUpD.TabIndex = 6;
			this.toolTip1.SetToolTip(this.ReadNoiseUpD, "per pixel");
			this.ReadNoiseUpD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.ReadNoiseUpD.ValueChanged += new System.EventHandler(this.ReadNoiseUpD_ValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 91);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 16);
			this.label11.TabIndex = 5;
			this.label11.Text = "Read Noise (ADU\'s)";
			this.toolTip1.SetToolTip(this.label11, "per pixel");
			// 
			// FWHMpixelsTxt
			// 
			this.FWHMpixelsTxt.AutoSize = true;
			this.FWHMpixelsTxt.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FWHMpixelsTxt.Location = new System.Drawing.Point(102, 68);
			this.FWHMpixelsTxt.Name = "FWHMpixelsTxt";
			this.FWHMpixelsTxt.Size = new System.Drawing.Size(68, 16);
			this.FWHMpixelsTxt.TabIndex = 4;
			this.FWHMpixelsTxt.Text = "FWHMPix";
			// 
			// PlateScaleUpD
			// 
			this.PlateScaleUpD.DecimalPlaces = 2;
			this.PlateScaleUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlateScaleUpD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.PlateScaleUpD.Location = new System.Drawing.Point(173, 43);
			this.PlateScaleUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.PlateScaleUpD.Name = "PlateScaleUpD";
			this.PlateScaleUpD.Size = new System.Drawing.Size(56, 22);
			this.PlateScaleUpD.TabIndex = 1;
			this.PlateScaleUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.PlateScaleUpD.ValueChanged += new System.EventHandler(this.PlateScaleUpD_ValueChanged);
			// 
			// FWHMUpD
			// 
			this.FWHMUpD.DecimalPlaces = 2;
			this.FWHMUpD.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FWHMUpD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.FWHMUpD.Location = new System.Drawing.Point(173, 66);
			this.FWHMUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.FWHMUpD.Name = "FWHMUpD";
			this.FWHMUpD.Size = new System.Drawing.Size(56, 22);
			this.FWHMUpD.TabIndex = 3;
			this.FWHMUpD.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
			this.FWHMUpD.ValueChanged += new System.EventHandler(this.FWHMUpD_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 68);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 16);
			this.label9.TabIndex = 2;
			this.label9.Text = "FWHM (arcsec)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Plate Scale (arcsec/pixel)";
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 200;
			this.toolTip1.AutoPopDelay = 7000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			// 
			// DecTargetTxt
			// 
			this.DecTargetTxt.Location = new System.Drawing.Point(277, 8);
			this.DecTargetTxt.Name = "DecTargetTxt";
			this.DecTargetTxt.Size = new System.Drawing.Size(101, 20);
			this.DecTargetTxt.TabIndex = 12;
			this.toolTip1.SetToolTip(this.DecTargetTxt, "degrees or sexagesimal format");
			// 
			// RATargetTxt
			// 
			this.RATargetTxt.Location = new System.Drawing.Point(89, 8);
			this.RATargetTxt.Name = "RATargetTxt";
			this.RATargetTxt.Size = new System.Drawing.Size(101, 20);
			this.RATargetTxt.TabIndex = 3;
			this.toolTip1.SetToolTip(this.RATargetTxt, "degrees or sexagesimal format");
			// 
			// BSWTForceQueryChck
			// 
			this.BSWTForceQueryChck.AutoSize = true;
			this.BSWTForceQueryChck.Location = new System.Drawing.Point(110, 223);
			this.BSWTForceQueryChck.Name = "BSWTForceQueryChck";
			this.BSWTForceQueryChck.Size = new System.Drawing.Size(131, 17);
			this.BSWTForceQueryChck.TabIndex = 51;
			this.BSWTForceQueryChck.Text = "Force New Astroquery";
			this.toolTip1.SetToolTip(this.BSWTForceQueryChck, "Forces a fresh download of the astroquery table...helpful if the field target has" +
        "n\'t changed but the field properties have.");
			this.BSWTForceQueryChck.UseVisualStyleBackColor = true;
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.Color.Silver;
			this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ETCMenu,
            this.BSWTMenu});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.MainMenu.Size = new System.Drawing.Size(1446, 24);
			this.MainMenu.TabIndex = 19;
			this.MainMenu.Text = "menuStrip1";
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuQuit});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(37, 22);
			this.FileMenu.Text = "File";
			// 
			// FileMenuQuit
			// 
			this.FileMenuQuit.Name = "FileMenuQuit";
			this.FileMenuQuit.Size = new System.Drawing.Size(125, 22);
			this.FileMenuQuit.Text = "Quit (Esc)";
			this.FileMenuQuit.Click += new System.EventHandler(this.FileMenuQuit_Click);
			// 
			// ETCMenu
			// 
			this.ETCMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetectorSystemMenuItem,
            this.PlotLimitsMenu});
			this.ETCMenu.Name = "ETCMenu";
			this.ETCMenu.Size = new System.Drawing.Size(153, 22);
			this.ETCMenu.Text = "Exposure Time Calculator";
			// 
			// DetectorSystemMenuItem
			// 
			this.DetectorSystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadedDetectorSystemMenuLabel,
            this.SelectNewDetectorMenuBtn});
			this.DetectorSystemMenuItem.Name = "DetectorSystemMenuItem";
			this.DetectorSystemMenuItem.Size = new System.Drawing.Size(160, 22);
			this.DetectorSystemMenuItem.Text = "Detector System";
			// 
			// LoadedDetectorSystemMenuLabel
			// 
			this.LoadedDetectorSystemMenuLabel.Enabled = false;
			this.LoadedDetectorSystemMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.LoadedDetectorSystemMenuLabel.Name = "LoadedDetectorSystemMenuLabel";
			this.LoadedDetectorSystemMenuLabel.Size = new System.Drawing.Size(166, 22);
			this.LoadedDetectorSystemMenuLabel.Text = "Loaded: CASTOR";
			// 
			// SelectNewDetectorMenuBtn
			// 
			this.SelectNewDetectorMenuBtn.Name = "SelectNewDetectorMenuBtn";
			this.SelectNewDetectorMenuBtn.Size = new System.Drawing.Size(166, 22);
			this.SelectNewDetectorMenuBtn.Text = "Select New";
			this.SelectNewDetectorMenuBtn.Click += new System.EventHandler(this.SelectNewDetectorMenuBtn_Click);
			// 
			// PlotLimitsMenu
			// 
			this.PlotLimitsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xAxisToolStripMenuItem,
            this.PlotLimitXMinText,
            this.xAxisMaximumToolStripMenuItem,
            this.PlotLimitXMaxText});
			this.PlotLimitsMenu.Name = "PlotLimitsMenu";
			this.PlotLimitsMenu.Size = new System.Drawing.Size(160, 22);
			this.PlotLimitsMenu.Text = "Plot Limits";
			// 
			// xAxisToolStripMenuItem
			// 
			this.xAxisToolStripMenuItem.Name = "xAxisToolStripMenuItem";
			this.xAxisToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.xAxisToolStripMenuItem.Text = "X-Axis Minimum (nm)";
			// 
			// PlotLimitXMinText
			// 
			this.PlotLimitXMinText.BackColor = System.Drawing.Color.Silver;
			this.PlotLimitXMinText.Name = "PlotLimitXMinText";
			this.PlotLimitXMinText.Size = new System.Drawing.Size(100, 23);
			this.PlotLimitXMinText.Text = "120";
			this.PlotLimitXMinText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlotLimitXMinText_KeyDown);
			// 
			// xAxisMaximumToolStripMenuItem
			// 
			this.xAxisMaximumToolStripMenuItem.Name = "xAxisMaximumToolStripMenuItem";
			this.xAxisMaximumToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.xAxisMaximumToolStripMenuItem.Text = "X-Axis Maximum (nm)";
			// 
			// PlotLimitXMaxText
			// 
			this.PlotLimitXMaxText.BackColor = System.Drawing.Color.Silver;
			this.PlotLimitXMaxText.Name = "PlotLimitXMaxText";
			this.PlotLimitXMaxText.Size = new System.Drawing.Size(100, 23);
			this.PlotLimitXMaxText.Text = "600";
			this.PlotLimitXMaxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlotLimitXMinText_KeyDown);
			// 
			// BSWTMenu
			// 
			this.BSWTMenu.Name = "BSWTMenu";
			this.BSWTMenu.Size = new System.Drawing.Size(49, 22);
			this.BSWTMenu.Text = "BSWT";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabETC);
			this.tabControl1.Controls.Add(this.TabBSWT);
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1446, 818);
			this.tabControl1.TabIndex = 20;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
			// 
			// TabETC
			// 
			this.TabETC.BackColor = System.Drawing.Color.Silver;
			this.TabETC.Controls.Add(this.Chart_Filter);
			this.TabETC.Controls.Add(this.Chart_Final);
			this.TabETC.Controls.Add(this.SaveOutputsBtn);
			this.TabETC.Controls.Add(this.EscBtn);
			this.TabETC.Controls.Add(this.DetectorGroupBox);
			this.TabETC.Controls.Add(this.SourceTypeGroupBox);
			this.TabETC.Controls.Add(this.ShowLocalFlux);
			this.TabETC.Controls.Add(this.ExtinctionGroupBox);
			this.TabETC.Controls.Add(this.SourcePropertiesGroupBox);
			this.TabETC.Controls.Add(this.FilterGroupBox);
			this.TabETC.Controls.Add(this.Chart_Source);
			this.TabETC.Location = new System.Drawing.Point(4, 22);
			this.TabETC.Name = "TabETC";
			this.TabETC.Padding = new System.Windows.Forms.Padding(3);
			this.TabETC.Size = new System.Drawing.Size(1438, 792);
			this.TabETC.TabIndex = 0;
			this.TabETC.Text = "ETC";
			// 
			// SaveOutputsBtn
			// 
			this.SaveOutputsBtn.Location = new System.Drawing.Point(1340, 733);
			this.SaveOutputsBtn.Name = "SaveOutputsBtn";
			this.SaveOutputsBtn.Size = new System.Drawing.Size(91, 23);
			this.SaveOutputsBtn.TabIndex = 18;
			this.SaveOutputsBtn.Text = "Save Outputs";
			this.SaveOutputsBtn.UseVisualStyleBackColor = true;
			this.SaveOutputsBtn.Click += new System.EventHandler(this.SaveOutputsBtn_Click);
			// 
			// EscBtn
			// 
			this.EscBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.EscBtn.Location = new System.Drawing.Point(1356, 762);
			this.EscBtn.Name = "EscBtn";
			this.EscBtn.Size = new System.Drawing.Size(75, 23);
			this.EscBtn.TabIndex = 12;
			this.EscBtn.Text = "Quit (Esc)";
			this.EscBtn.UseVisualStyleBackColor = true;
			this.EscBtn.Click += new System.EventHandler(this.EscBtn_Click);
			// 
			// TabBSWT
			// 
			this.TabBSWT.BackColor = System.Drawing.Color.Silver;
			this.TabBSWT.Controls.Add(this.BSWTMagLimitUpD);
			this.TabBSWT.Controls.Add(this.BSWTForceQueryChck);
			this.TabBSWT.Controls.Add(this.BSWTMaxBrightSourcesUpD);
			this.TabBSWT.Controls.Add(this.label29);
			this.TabBSWT.Controls.Add(this.label22);
			this.TabBSWT.Controls.Add(this.BSWTVerticalPixUpD);
			this.TabBSWT.Controls.Add(this.label20);
			this.TabBSWT.Controls.Add(this.BSWTHorizontalPixUpD);
			this.TabBSWT.Controls.Add(this.label21);
			this.TabBSWT.Controls.Add(this.label16);
			this.TabBSWT.Controls.Add(this.BSWTPlateScaleUpD);
			this.TabBSWT.Controls.Add(this.label7);
			this.TabBSWT.Controls.Add(this.label13);
			this.TabBSWT.Controls.Add(this.BSWTMessageBox);
			this.TabBSWT.Controls.Add(this.BSWTExecuteBtn);
			this.TabBSWT.Controls.Add(this.BSWTPictureBox);
			this.TabBSWT.Controls.Add(this.FieldBufferUpD);
			this.TabBSWT.Controls.Add(this.label27);
			this.TabBSWT.Controls.Add(this.label28);
			this.TabBSWT.Controls.Add(this.BSWTFilterDrop);
			this.TabBSWT.Controls.Add(this.label26);
			this.TabBSWT.Controls.Add(this.BSWTCatalogueDrop);
			this.TabBSWT.Controls.Add(this.label25);
			this.TabBSWT.Controls.Add(this.label24);
			this.TabBSWT.Controls.Add(this.FieldShapeBtn);
			this.TabBSWT.Controls.Add(this.DecTargetBtn);
			this.TabBSWT.Controls.Add(this.RATargetBtn);
			this.TabBSWT.Controls.Add(this.DecTargetTxt);
			this.TabBSWT.Controls.Add(this.RATargetTxt);
			this.TabBSWT.Location = new System.Drawing.Point(4, 22);
			this.TabBSWT.Name = "TabBSWT";
			this.TabBSWT.Padding = new System.Windows.Forms.Padding(3);
			this.TabBSWT.Size = new System.Drawing.Size(1438, 792);
			this.TabBSWT.TabIndex = 1;
			this.TabBSWT.Text = "BSWT";
			this.TabBSWT.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabBSWT_Layout);
			this.TabBSWT.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TabBSWT_PreviewKeyDown);
			// 
			// BSWTMaxBrightSourcesUpD
			// 
			this.BSWTMaxBrightSourcesUpD.Location = new System.Drawing.Point(109, 246);
			this.BSWTMaxBrightSourcesUpD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.BSWTMaxBrightSourcesUpD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.BSWTMaxBrightSourcesUpD.Name = "BSWTMaxBrightSourcesUpD";
			this.BSWTMaxBrightSourcesUpD.Size = new System.Drawing.Size(56, 20);
			this.BSWTMaxBrightSourcesUpD.TabIndex = 50;
			this.BSWTMaxBrightSourcesUpD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(171, 250);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(90, 13);
			this.label29.TabIndex = 49;
			this.label29.Text = "Brightest Sources";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(278, 83);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 27);
			this.label22.TabIndex = 48;
			this.label22.Text = "vertical pixels";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BSWTVerticalPixUpD
			// 
			this.BSWTVerticalPixUpD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.BSWTVerticalPixUpD.Location = new System.Drawing.Point(216, 86);
			this.BSWTVerticalPixUpD.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.BSWTVerticalPixUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.BSWTVerticalPixUpD.Name = "BSWTVerticalPixUpD";
			this.BSWTVerticalPixUpD.Size = new System.Drawing.Size(56, 20);
			this.BSWTVerticalPixUpD.TabIndex = 47;
			this.BSWTVerticalPixUpD.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(156, 83);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(54, 27);
			this.label20.TabIndex = 46;
			this.label20.Text = "horizontal pixels";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BSWTHorizontalPixUpD
			// 
			this.BSWTHorizontalPixUpD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.BSWTHorizontalPixUpD.Location = new System.Drawing.Point(98, 86);
			this.BSWTHorizontalPixUpD.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.BSWTHorizontalPixUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.BSWTHorizontalPixUpD.Name = "BSWTHorizontalPixUpD";
			this.BSWTHorizontalPixUpD.Size = new System.Drawing.Size(56, 20);
			this.BSWTHorizontalPixUpD.TabIndex = 45;
			this.BSWTHorizontalPixUpD.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(6, 89);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(73, 17);
			this.label21.TabIndex = 43;
			this.label21.Text = "Image Size:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 195);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 17);
			this.label16.TabIndex = 41;
			this.label16.Text = "Mag Limit:";
			// 
			// BSWTPlateScaleUpD
			// 
			this.BSWTPlateScaleUpD.DecimalPlaces = 3;
			this.BSWTPlateScaleUpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BSWTPlateScaleUpD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
			this.BSWTPlateScaleUpD.Location = new System.Drawing.Point(98, 113);
			this.BSWTPlateScaleUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.BSWTPlateScaleUpD.Name = "BSWTPlateScaleUpD";
			this.BSWTPlateScaleUpD.Size = new System.Drawing.Size(56, 20);
			this.BSWTPlateScaleUpD.TabIndex = 40;
			this.BSWTPlateScaleUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(160, 116);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 13);
			this.label7.TabIndex = 38;
			this.label7.Text = "(arcsec/pixel)";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 114);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 17);
			this.label13.TabIndex = 37;
			this.label13.Text = "Plate Scale:";
			// 
			// BSWTMessageBox
			// 
			this.BSWTMessageBox.BackColor = System.Drawing.Color.Gainsboro;
			this.BSWTMessageBox.FormattingEnabled = true;
			this.BSWTMessageBox.Location = new System.Drawing.Point(9, 273);
			this.BSWTMessageBox.Name = "BSWTMessageBox";
			this.BSWTMessageBox.Size = new System.Drawing.Size(355, 160);
			this.BSWTMessageBox.TabIndex = 36;
			this.BSWTMessageBox.Visible = false;
			// 
			// BSWTExecuteBtn
			// 
			this.BSWTExecuteBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BSWTExecuteBtn.Location = new System.Drawing.Point(9, 221);
			this.BSWTExecuteBtn.Name = "BSWTExecuteBtn";
			this.BSWTExecuteBtn.Size = new System.Drawing.Size(94, 45);
			this.BSWTExecuteBtn.TabIndex = 35;
			this.BSWTExecuteBtn.Text = "Query Target Area";
			this.BSWTExecuteBtn.UseVisualStyleBackColor = true;
			this.BSWTExecuteBtn.Click += new System.EventHandler(this.BSWTExecuteBtn_Click);
			// 
			// BSWTPictureBox
			// 
			this.BSWTPictureBox.BackColor = System.Drawing.Color.Black;
			this.BSWTPictureBox.Location = new System.Drawing.Point(434, 7);
			this.BSWTPictureBox.Name = "BSWTPictureBox";
			this.BSWTPictureBox.Size = new System.Drawing.Size(777, 777);
			this.BSWTPictureBox.TabIndex = 34;
			this.BSWTPictureBox.TabStop = false;
			this.BSWTPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.BSWTPictureBox_Paint);
			// 
			// FieldBufferUpD
			// 
			this.FieldBufferUpD.DecimalPlaces = 1;
			this.FieldBufferUpD.Location = new System.Drawing.Point(98, 35);
			this.FieldBufferUpD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.FieldBufferUpD.Name = "FieldBufferUpD";
			this.FieldBufferUpD.Size = new System.Drawing.Size(56, 20);
			this.FieldBufferUpD.TabIndex = 33;
			this.FieldBufferUpD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(160, 39);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(67, 13);
			this.label27.TabIndex = 32;
			this.label27.Text = "(arc minutes)";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(6, 37);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(80, 17);
			this.label28.TabIndex = 31;
			this.label28.Text = "Field Buffer:";
			// 
			// BSWTFilterDrop
			// 
			this.BSWTFilterDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BSWTFilterDrop.FormattingEnabled = true;
			this.BSWTFilterDrop.Items.AddRange(new object[] {
            "bp",
            "g",
            "rp"});
			this.BSWTFilterDrop.Location = new System.Drawing.Point(98, 167);
			this.BSWTFilterDrop.Name = "BSWTFilterDrop";
			this.BSWTFilterDrop.Size = new System.Drawing.Size(90, 21);
			this.BSWTFilterDrop.TabIndex = 30;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(6, 169);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(40, 17);
			this.label26.TabIndex = 29;
			this.label26.Text = "Filter:";
			// 
			// BSWTCatalogueDrop
			// 
			this.BSWTCatalogueDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BSWTCatalogueDrop.FormattingEnabled = true;
			this.BSWTCatalogueDrop.Items.AddRange(new object[] {
            "GaiaDR3"});
			this.BSWTCatalogueDrop.Location = new System.Drawing.Point(98, 141);
			this.BSWTCatalogueDrop.Name = "BSWTCatalogueDrop";
			this.BSWTCatalogueDrop.Size = new System.Drawing.Size(90, 21);
			this.BSWTCatalogueDrop.TabIndex = 28;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(6, 141);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(68, 17);
			this.label25.TabIndex = 27;
			this.label25.Text = "Catalogue:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(6, 61);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(77, 17);
			this.label24.TabIndex = 25;
			this.label24.Text = "Field Shape:";
			// 
			// FieldShapeBtn
			// 
			this.FieldShapeBtn.Location = new System.Drawing.Point(98, 57);
			this.FieldShapeBtn.Name = "FieldShapeBtn";
			this.FieldShapeBtn.Size = new System.Drawing.Size(56, 23);
			this.FieldShapeBtn.TabIndex = 24;
			this.FieldShapeBtn.Text = "Square";
			this.FieldShapeBtn.UseVisualStyleBackColor = true;
			this.FieldShapeBtn.Click += new System.EventHandler(this.FieldShapeBtn_Click);
			// 
			// DecTargetBtn
			// 
			this.DecTargetBtn.Location = new System.Drawing.Point(196, 6);
			this.DecTargetBtn.Name = "DecTargetBtn";
			this.DecTargetBtn.Size = new System.Drawing.Size(75, 23);
			this.DecTargetBtn.TabIndex = 11;
			this.DecTargetBtn.Text = "Dec Target:";
			this.DecTargetBtn.UseVisualStyleBackColor = true;
			this.DecTargetBtn.Click += new System.EventHandler(this.RATargetBtn_Click);
			// 
			// RATargetBtn
			// 
			this.RATargetBtn.Location = new System.Drawing.Point(8, 6);
			this.RATargetBtn.Name = "RATargetBtn";
			this.RATargetBtn.Size = new System.Drawing.Size(75, 23);
			this.RATargetBtn.TabIndex = 2;
			this.RATargetBtn.Text = "RA Target:";
			this.RATargetBtn.UseVisualStyleBackColor = true;
			this.RATargetBtn.Click += new System.EventHandler(this.RATargetBtn_Click);
			// 
			// BSWTMagLimitUpD
			// 
			this.BSWTMagLimitUpD.DecimalPlaces = 1;
			this.BSWTMagLimitUpD.Location = new System.Drawing.Point(98, 195);
			this.BSWTMagLimitUpD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.BSWTMagLimitUpD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.BSWTMagLimitUpD.Name = "BSWTMagLimitUpD";
			this.BSWTMagLimitUpD.Size = new System.Drawing.Size(56, 20);
			this.BSWTMagLimitUpD.TabIndex = 52;
			this.BSWTMagLimitUpD.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Silver;
			this.CancelButton = this.EscBtn;
			this.ClientSize = new System.Drawing.Size(1446, 842);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.MainMenu);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exposure Time Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Chart_Source)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Final)).EndInit();
			this.SourceTypeGroupBox.ResumeLayout(false);
			this.SourceTypeGroupBox.PerformLayout();
			this.ExtinctionGroupBox.ResumeLayout(false);
			this.ExtinctionGroupBox.PerformLayout();
			this.FilterGroupBox.ResumeLayout(false);
			this.FilterGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FilterGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SNTargetUpD)).EndInit();
			this.SourcePropertiesGroupBox.ResumeLayout(false);
			this.SourcePropertiesGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RedShiftUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SersicnUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SersicReffUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Filter)).EndInit();
			this.DetectorGroupBox.ResumeLayout(false);
			this.DetectorGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MirrorAreaUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DarkRateUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReadNoiseUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PlateScaleUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FWHMUpD)).EndInit();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.TabETC.ResumeLayout(false);
			this.TabETC.PerformLayout();
			this.TabBSWT.ResumeLayout(false);
			this.TabBSWT.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BSWTMaxBrightSourcesUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTVerticalPixUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTHorizontalPixUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTPlateScaleUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FieldBufferUpD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BSWTMagLimitUpD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Source;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Final;
		private System.Windows.Forms.GroupBox SourceTypeGroupBox;
		private System.Windows.Forms.RadioButton SourceStarRadBtn;
		private System.Windows.Forms.ComboBox SourceStarDrop;
		private System.Windows.Forms.RadioButton SourceGalaxyRadBtn;
		private System.Windows.Forms.GroupBox ExtinctionGroupBox;
		private System.Windows.Forms.ComboBox SourceGalaxyDrop;
		private System.Windows.Forms.RadioButton SourceBlackbodyRadBtn;
		private System.Windows.Forms.ComboBox SourceAGNDrop;
		private System.Windows.Forms.RadioButton SourceAGNRadBtn;
		private System.Windows.Forms.GroupBox FilterGroupBox;
		private System.Windows.Forms.RadioButton SourcePowerLawRadBtn;
		private System.Windows.Forms.ComboBox SourcePowerLawDrop;
		private System.Windows.Forms.GroupBox SourcePropertiesGroupBox;
		private System.Windows.Forms.RadioButton DistanceRadBtn;
		private System.Windows.Forms.RadioButton mvRadBtn;
		private System.Windows.Forms.TextBox DistanceTxt;
		private System.Windows.Forms.TextBox mvTxt;
		private System.Windows.Forms.TextBox RadiusTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ExtinctionRvTxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton ExtinctionColumnDensityRadBtn;
		private System.Windows.Forms.RadioButton ExtinctionAvRadBtn;
		private System.Windows.Forms.RadioButton ExtinctionDistanceRadBtn;
		private System.Windows.Forms.Button ExtinctionHelpBtn;
		private System.Windows.Forms.TextBox ExtinctionColumnDensityTxt;
		private System.Windows.Forms.TextBox ExtinctionAvTxt;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Filter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label PowerLawAlphaLabel;
		private System.Windows.Forms.TextBox PowerLawAlphaTxt;
		private System.Windows.Forms.TextBox PowerLawNormTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox mIeTxt;
		private System.Windows.Forms.CheckBox ShowLocalFlux;
		private System.Windows.Forms.Button GalaxyTypeHelpBtn;
		private System.Windows.Forms.Button AGNTypeHelpBtn;
		private System.Windows.Forms.Button SpectralTypeHelpBtn;
		private System.Windows.Forms.NumericUpDown SNTargetUpD;
		private System.Windows.Forms.GroupBox DetectorGroupBox;
		private System.Windows.Forms.NumericUpDown PlateScaleUpD;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown FWHMUpD;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button SNHelpBtn;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox SourceBlackbodyTempTxt;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label FWHMpixelsTxt;
		private System.Windows.Forms.NumericUpDown SersicReffUpD;
		private System.Windows.Forms.NumericUpDown SersicnUpD;
		private System.Windows.Forms.NumericUpDown ReadNoiseUpD;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown DarkRateUpD;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown MirrorAreaUpD;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ComboBox FilterDropDown;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DataGridView FilterGridView;
		private System.Windows.Forms.NumericUpDown RedShiftUpDown;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabETC;
		private System.Windows.Forms.TabPage TabBSWT;
		private System.Windows.Forms.ToolStripMenuItem ETCMenu;
		private System.Windows.Forms.ToolStripMenuItem PlotLimitsMenu;
		private System.Windows.Forms.ToolStripMenuItem xAxisToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox PlotLimitXMinText;
		private System.Windows.Forms.ToolStripMenuItem xAxisMaximumToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox PlotLimitXMaxText;
		private System.Windows.Forms.ToolStripMenuItem DetectorSystemMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LoadedDetectorSystemMenuLabel;
		private System.Windows.Forms.ToolStripMenuItem SelectNewDetectorMenuBtn;
		private System.Windows.Forms.Button SaveOutputsBtn;
		private System.Windows.Forms.Button EscBtn;
		private System.Windows.Forms.ToolStripMenuItem FileMenuQuit;
		private System.Windows.Forms.Button RATargetBtn;
		private System.Windows.Forms.TextBox DecTargetTxt;
		private System.Windows.Forms.Button DecTargetBtn;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button FieldShapeBtn;
		private System.Windows.Forms.ToolStripMenuItem BSWTMenu;
		private System.Windows.Forms.ComboBox BSWTCatalogueDrop;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox BSWTFilterDrop;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.NumericUpDown FieldBufferUpD;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.PictureBox BSWTPictureBox;
		private System.Windows.Forms.Button BSWTExecuteBtn;
		private System.Windows.Forms.ListBox BSWTMessageBox;
		private System.Windows.Forms.TextBox RATargetTxt;
		private System.Windows.Forms.NumericUpDown BSWTPlateScaleUpD;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.NumericUpDown BSWTHorizontalPixUpD;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.NumericUpDown BSWTVerticalPixUpD;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.NumericUpDown BSWTMaxBrightSourcesUpD;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.CheckBox BSWTForceQueryChck;
		private System.Windows.Forms.NumericUpDown BSWTMagLimitUpD;
	}
}

