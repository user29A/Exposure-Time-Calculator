using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using JPFITS;

namespace Exposure_Time_Calculator
{
	public partial class Form1 : Form
	{
		double h = 6.626068E-34; //Js
		double c = 2.9979E8; //m/s
		double K = 1.38065E-23; //J/K
		//double Rsun = 6.96E8; //m
		double SR2KPC = 2.25534E-11; //solar radii to kpc
		double KPC2M = 3.08568025E19; //kpc to meters

		double PLOT_XMIN, PLOT_XMAX;

		int SESSION = 0;
		bool FIRSTSLOAD = false;
		bool COMPUTATION_EXISTS = false;
		bool ISPOINTSOURCE = true;
		int LAMBDASTEP = 1;//lambda steps in 1nm increments
		int APERTURENPIX = 0;
		int SELECTED_FILTER = 0;
		string SOURCES_DIRECTORY;
		string DETECTORSYSTEM_DIRECTORY;
		string QE_FILENAME;
		string MIRROR_REFL_FILENAME;
		string[] FILTER_FILENAMES;
		string[] FILTER_NAMES;
		string BACKGROUND_FILENAME;

		int NELEMENTS;
		int NFILTERS;
		double[] LAMBDA_NM;//nm nanomaters 1e-9meters
		double[] BACKGROUND;
		double[] EXTINCTION;
		double[] DETECTOR_QE;
		double[] MIRROR_REFL;
		double[] SOURCE_FLUX;
		double[] SOURCE_FLUX_LOCAL;
		double[][] FILTERS;
		double[][] FINAL_FLUX_FILTERS;
		double[][] FINAL_FLUX_FILTERS_BG;
		double[] FINAL_COUNTS;
		double[] FINAL_COUNTS_MAXPIX;
		double[] FINAL_COUNTS_BG;
		double[] SN_TIME_MCPS;
		double[] SN_TIME_TCPS;

		private WorldCoordinateSolution BSWTWCS;

		public Form1()
		{
			InitializeComponent();
		}

		void SetReg(System.String ProgramName, System.String KeyName, System.Object KeyValue)
		{
			RegistryKey User = Registry.CurrentUser;
			RegistryKey SW = User.OpenSubKey("Software", true);
			RegistryKey AstroWerks = SW.CreateSubKey("AstroWerks");
			RegistryKey SUBKEY = AstroWerks.CreateSubKey(ProgramName);
			SUBKEY.SetValue(KeyName, KeyValue);
		}

		Object GetReg(System.String ProgramName, System.String KeyName)
		{
			RegistryKey User = Registry.CurrentUser;
			RegistryKey SW = User.OpenSubKey("Software", true);
			RegistryKey AstroWerks = SW.CreateSubKey("AstroWerks");
			RegistryKey SUBKEY = AstroWerks.CreateSubKey(ProgramName);
			Object result = SUBKEY.GetValue(KeyName);
			return result;
		}

		void Form1_Load(System.Object sender, System.EventArgs e)
		{
			FIRSTSLOAD = true;

			SourceGalaxyDrop.SelectedIndex = Convert.ToInt32(GetReg("CETC", "SourceGalaxyDropIndex"));
			SourceStarDrop.SelectedIndex = Convert.ToInt32(GetReg("CETC", "SourceStarDropIndex"));
			SourceBlackbodyTempTxt.Text = (string)GetReg("CETC", "SourceBlackbodyTempTxt");
			SourceStarRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "SourceStarRadBtn"));
			SourceGalaxyRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "SourceGalaxyRadBtn"));
			SourceBlackbodyRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "SourceBlackbodyRadBtn"));
			SourceAGNRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "SourceAGNRadBtn"));
			SourceAGNDrop.SelectedIndex = Convert.ToInt32(GetReg("CETC", "SourceAGNDropIndex"));
			SourcePowerLawRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "SourcePowerLawRadBtn"));
			SourcePowerLawDrop.SelectedIndex = Convert.ToInt32(GetReg("CETC", "SourcePowerLawDropIndex"));
			DistanceRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "DistanceRadBtn"));
			mvRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "mvRadBtn"));
			ExtinctionColumnDensityTxt.Text = (string)GetReg("CETC", "ExtinctionColumnDensityTxt");
			ExtinctionAvTxt.Text = (string)GetReg("CETC", "ExtinctionAvTxt");
			ExtinctionRvTxt.Text = (string)GetReg("CETC", "ExtinctionRvTxt");
			ExtinctionColumnDensityRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "ExtinctionColumnDensityRadBtn"));
			ExtinctionDistanceRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "ExtinctionDistanceRadBtn"));
			ExtinctionAvRadBtn.Checked = Convert.ToBoolean(GetReg("CETC", "ExtinctionAvRadBtn"));
			RadiusTxt.Text = (string)GetReg("CETC", "RadiusTxt");
			mvTxt.Text = (string)GetReg("CETC", "mvTxt");
			DistanceTxt.Text = (string)GetReg("CETC", "DistanceTxt");
			RedShiftUpDown.Value = Convert.ToDecimal(GetReg("CETC", "RedShiftUpDown"));
			mIeTxt.Text = (string)GetReg("CETC", "mTxt");
			PowerLawNormTxt.Text = (string)GetReg("CETC", "PowerLawNormTxt");
			PowerLawAlphaTxt.Text = (string)GetReg("CETC", "PowerLawAlphaTxt");
			SNTargetUpD.Value = Convert.ToDecimal(GetReg("CETC", "SNTargetUpD"));
			MirrorAreaUpD.Value = Convert.ToDecimal(GetReg("CETC", "MirrorArea"));
			PlateScaleUpD.Value = Convert.ToDecimal(GetReg("CETC", "PlateScaleUpD"));
			FWHMUpD.Value = Convert.ToDecimal(GetReg("CETC", "FWHMUpD"));
			SersicReffUpD.Value = Convert.ToDecimal(GetReg("CETC", "SersicReffUpD"));
			SersicnUpD.Value = Convert.ToDecimal(GetReg("CETC", "SersicnUpD"));
			ReadNoiseUpD.Value = Convert.ToDecimal(GetReg("CETC", "ReadNoiseUpD"));
			DarkRateUpD.Value = Convert.ToDecimal(GetReg("CETC", "DarkRateUpD"));
			PlotLimitXMinText.Text = (string)GetReg("CETC", "PlotLimitXMinText");
			PlotLimitXMaxText.Text = (string)GetReg("CETC", "PlotLimitXMaxText");
			PLOT_XMIN = Convert.ToDouble(PlotLimitXMinText.Text);
			PLOT_XMAX = Convert.ToDouble(PlotLimitXMaxText.Text);

			NELEMENTS = (int)(PLOT_XMAX - PLOT_XMIN + 1);// ex. 20-10 = 10 -> 11 elements
			EXTINCTION = new double[NELEMENTS];
			SOURCE_FLUX = new double[NELEMENTS];
			SOURCE_FLUX_LOCAL = new double[NELEMENTS];
			LAMBDA_NM = new double[NELEMENTS];
			for (int i = 0; i < NELEMENTS; i++)
				LAMBDA_NM[i] = PLOT_XMIN + i;			

			//sources
			SOURCES_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Astrowerks\\Exposure Time Calculator\\Sources\\";
			BACKGROUND_FILENAME = SOURCES_DIRECTORY + "Background\\background.fits";
			FITSBinTable fbt = new FITSBinTable(BACKGROUND_FILENAME, "");
			double[] bg = fbt.GetTTYPEEntry("BACKGROUND");
			double[] wavl = fbt.GetTTYPEEntry("WAVELENGTH");
			BACKGROUND = JPMath.Interpolate1d(wavl, bg, LAMBDA_NM, "linear", false);

			//detector system
			DETECTORSYSTEM_DIRECTORY = (string)GetReg("CETC", "DSDirectory");
			if (!Directory.Exists(DETECTORSYSTEM_DIRECTORY))
			{
				if (MessageBox.Show("Please direct me to your detector system database folder.", "Exposure Time Calculator...", MessageBoxButtons.OKCancel) == DialogResult.OK)
					SelectNewDetectorMenuBtn.PerformClick();
				return;
			}
			LoadedDetectorSystemMenuLabel.Text = "Loaded: " + (new DirectoryInfo(DETECTORSYSTEM_DIRECTORY)).Name;

			QE_FILENAME = DETECTORSYSTEM_DIRECTORY + "QE\\QE.fits";
			fbt = new FITSBinTable(QE_FILENAME, "");
			double[] qe = fbt.GetTTYPEEntry("QE");
			wavl = fbt.GetTTYPEEntry("WAVELENGTH");
			DETECTOR_QE = JPMath.Interpolate1d(wavl, qe, LAMBDA_NM, "linear", false);

			MIRROR_REFL_FILENAME = DETECTORSYSTEM_DIRECTORY + "Reflectivity\\reflectivity.fits";
			fbt = new FITSBinTable(MIRROR_REFL_FILENAME, "");
			double[] refl = fbt.GetTTYPEEntry("REFLECTIVITY");
			wavl = fbt.GetTTYPEEntry("WAVELENGTH");
			MIRROR_REFL = JPMath.Interpolate1d(wavl, refl, LAMBDA_NM, "linear", false);

			FILTER_FILENAMES = Directory.GetFiles(DETECTORSYSTEM_DIRECTORY + "Filters\\", "*.fits", SearchOption.TopDirectoryOnly);
			NFILTERS = FILTER_FILENAMES.Length;
			Array.Sort(FILTER_FILENAMES);			
			FILTERS = new double[NFILTERS][];
			for (int i = 0; i < NFILTERS; i++)
			{
				fbt = new FITSBinTable(FILTER_FILENAMES[i], "");
				double[] trans = fbt.GetTTYPEEntry("TRANSMISSION");
				wavl = fbt.GetTTYPEEntry("WAVELENGTH");
				FILTERS[i] = JPMath.Interpolate1d(wavl, trans, LAMBDA_NM, "linear", false);
			}
			FILTER_NAMES = new string[NFILTERS];
			for (int i = 0; i < NFILTERS; i++)
				FILTER_NAMES[i] = (new FileInfo(FILTER_FILENAMES[i])).Name.Replace(".fits", "");
			FilterDropDown.Items.AddRange(FILTER_NAMES);

			FINAL_FLUX_FILTERS = new double[NFILTERS][];
			FINAL_FLUX_FILTERS_BG = new double[NFILTERS][];
			for (int i = 0; i < NFILTERS; i++)
			{
				FINAL_FLUX_FILTERS[i] = new double[NELEMENTS];
				FINAL_FLUX_FILTERS_BG[i] = new double[NELEMENTS];
			}

			FIRSTSLOAD = false;
		}

		private void SelectNewDetectorMenuBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Please select the detector database folder...";
			fbd.SelectedPath = DETECTORSYSTEM_DIRECTORY;
			if (fbd.ShowDialog() == DialogResult.Cancel)
				return;

			DETECTORSYSTEM_DIRECTORY = fbd.SelectedPath + "\\";
			SetReg("CETC", "DSDirectory", DETECTORSYSTEM_DIRECTORY);
			//LoadedDetectorSystemMenuLabel.Text = "Loaded: " + (new DirectoryInfo(DETECTORSYSTEM_DIRECTORY)).Name;

			Form1_Load(sender, e);
		}

		private void PlotLimitXMinText_KeyDown(object sender, KeyEventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", ((ToolStripTextBox)sender).Name, ((ToolStripTextBox)sender).Text);
				ThroughPutETC();
			}
		}

		void SaveOutPuts()
		{
			string outdir = SOURCES_DIRECTORY + "Output\\" + SESSION.ToString() + "\\";
			System.IO.Directory.CreateDirectory(outdir);

			System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(Chart_Source.Width, Chart_Source.Height);
			Chart_Source.DrawToBitmap(bmp, Chart_Source.DisplayRectangle);
			bmp.Save(outdir + "source_" + SESSION.ToString() + ".jpeg");

			bmp = new System.Drawing.Bitmap(Chart_Filter.Width, Chart_Filter.Height);
			Chart_Filter.DrawToBitmap(bmp, Chart_Filter.DisplayRectangle);
			bmp.Save(outdir + "filter_" + SESSION.ToString() + ".jpeg");

			bmp = new System.Drawing.Bitmap(Chart_Final.Width, Chart_Final.Height);
			Chart_Final.DrawToBitmap(bmp, Chart_Final.DisplayRectangle);
			bmp.Save(outdir + "final_" + SESSION.ToString() + ".jpeg");

			string[] labels = new string[11] { "lambda", "UVDark", "UV", "UVWide", "u", "g", "UVDarkBackground", "UVBackground", "UVWideBackground", "uBackground", "gBackground" };
			TypeCode[] tcodes = new TypeCode[11] { TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double, TypeCode.Double };
			int[] instances = new int[11] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
			string[] units = new string[11] { "nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm", "CPS/nm" };
			object[] dataobj = new object[11];
			dataobj[0] = (Object)LAMBDA_NM;
			double[] line = new double[FINAL_FLUX_FILTERS.GetLength(0)];
			for (int i = 0; i < NFILTERS; i++)
			{
				for (int j = 0; j < line.Length; j++)
					line[j] = FINAL_FLUX_FILTERS[i][j];
				dataobj[i + 1] = (Object)line;

				for (int j = 0; j < line.Length; j++)
					line[j] = FINAL_FLUX_FILTERS_BG[i][j] * (double)(APERTURENPIX);
				dataobj[i + 6] = (Object)line;
			}
			FITSBinTable output = new FITSBinTable();
			output.SetTTYPEEntries(labels, units, dataobj);
			output.Write(outdir + "filterstable_" + SESSION.ToString() + ".fits", "FilterThrougputs", true);

			System.IO.StreamWriter sw = new System.IO.StreamWriter(outdir + "counts_" + SESSION.ToString() + ".txt");
			if (ISPOINTSOURCE)
				sw.WriteLine("Max Pixel CPS" + "	" + "Total CPS" + "	" + "Max CPS SN Time" + "	" + "Total CPS SN Time");
			else
				sw.WriteLine("Max Pixel CPS" + "	" + "Re CPS" + "	" + "Max CPS SN Time" + "	" + "Re CPS SN Time");
			/*sw.WriteLine(MaxCountUVDarkLabel.Text + "		" + TotalCountUVDarkLabel.Text + "		" + MSNTimeUVDarkLabel.Text + "		" + TSNTimeUVDarkLabel.Text);
			sw.WriteLine(MaxCountUVLabel.Text + "		" + TotalCountUVLabel.Text + "		" + MSNTimeUVLabel.Text + "		" + TSNTimeUVLabel.Text);
			sw.WriteLine(MaxCountuWideLabel.Text + "		" + TotalCountuWideLabel.Text + "		" + MSNTimeuWideLabel.Text + "		" + TSNTimeuWideLabel.Text);
			sw.WriteLine(MaxCountuLabel.Text + "		" + TotalCountuLabel.Text + "		" + MSNTimeuLabel.Text + "		" + TSNTimeuLabel.Text);
			sw.WriteLine(MaxCountgLabel.Text + "		" + TotalCountgLabel.Text + "		" + MSNTimegLabel.Text + "		" + TSNTimegLabel.Text);*/
			sw.Close();
		}

		void SaveOutputsBtn_Click(System.Object sender, System.EventArgs e)
		{
			Random r = new Random();
			SESSION = r.Next(1000000);
			SaveOutPuts();

			string outdir = SOURCES_DIRECTORY + "Output\\" + SESSION.ToString() + "\\";
			System.Diagnostics.Process.Start("Explorer.exe", outdir);
		}

		void EscBtn_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				return;

			Application.Exit();
		}

		void ShowLocalFlux_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (!COMPUTATION_EXISTS)
				return;

			if (ShowLocalFlux.Checked)
				Chart_Source.Titles[0].Text = "Local Source Flux (Source * Extinction * Distance)";
			else
				Chart_Source.Titles[0].Text = "Source Flux";

			Chart_Source.Series[0].Points.Clear();
			if (ShowLocalFlux.Checked)
				for (int i = 0; i < NELEMENTS; i++)
					Chart_Source.Series[0].Points.AddXY(LAMBDA_NM[i], SOURCE_FLUX_LOCAL[i]);
			else
				for (int i = 0; i < NELEMENTS; i++)
					Chart_Source.Series[0].Points.AddXY(LAMBDA_NM[i], SOURCE_FLUX[i]);

			Chart_Source.ChartAreas[0].AxisX.Minimum = PLOT_XMIN;
			Chart_Source.ChartAreas[0].AxisX.Maximum = PLOT_XMAX;
		}

		void SourceStarRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceStarRadBtn.Checked)
			{
				mvRadBtn.Enabled = true;
				SourceStarDrop.Enabled = true;
				DistanceRadBtn.Enabled = true;
				if (DistanceRadBtn.Checked)
					DistanceTxt.Enabled = true;
				else
					DistanceTxt.Enabled = false;
				mvRadBtn.Enabled = true;
				if (mvRadBtn.Checked)
					mvTxt.Enabled = true;
				else
					mvTxt.Enabled = false;
				SourceBlackbodyTempTxt.Enabled = false;
				RadiusTxt.Enabled = true;
				PowerLawAlphaTxt.Enabled = false;
				PowerLawNormTxt.Enabled = false;
				mIeTxt.Enabled = false;
				RedShiftUpDown.Enabled = false;
				ISPOINTSOURCE = true;

				if (FIRSTSLOAD)
					return;

				ThroughPutETC();
			}
			else
			{
				SourceStarDrop.Enabled = false;
				mvRadBtn.Enabled = false;
			}

			SetReg("CETC", "SourceStarRadBtn", SourceStarRadBtn.Checked);
		}

		void SourceStarDrop_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SourceStarDropIndex", SourceStarDrop.SelectedIndex);

			ThroughPutETC();
		}

		void SourceAGNRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceAGNRadBtn.Checked)
			{
				SourceAGNDrop.Enabled = true;
				SourceAGNDrop_SelectedIndexChanged(sender, e);//trigger changes
				SersicReffUpD.Enabled = false;
				SersicnUpD.Enabled = false;
				RedShiftUpDown.Enabled = true;
				mIeTxt.Enabled = true;
				mvRadBtn.Enabled = false;
				mvTxt.Enabled = false;
				PowerLawAlphaTxt.Enabled = false;
				PowerLawNormTxt.Enabled = false;
				DistanceRadBtn.Enabled = false;
				DistanceTxt.Enabled = false;
				RadiusTxt.Enabled = false;
				ISPOINTSOURCE = true;

				if (FIRSTSLOAD)
					return;
				ThroughPutETC();
			}
			else
			{
				SourceAGNDrop.Enabled = false;
				RedShiftUpDown.Enabled = false;
				mIeTxt.Enabled = false;
			}

			SetReg("CETC", "SourceAGNRadBtn", SourceAGNRadBtn.Checked);
		}

		void SourceGalaxyRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceGalaxyRadBtn.Checked)
			{
				label5.Text = "V Mag:";//"Ie:";
				//label6.Text = "ReCPS";
				//toolTip1.SetToolTip(label6, "Re Counts per Second per Pixel");
				//label22.Text = "ReCPS T";
				//toolTip1.SetToolTip(label22, "Time to reach SN for Re Counts per Second (ReCPS)");
				SersicReffUpD.Enabled = true;
				SersicnUpD.Enabled = true;
				SourceGalaxyDrop.Enabled = true;
				RedShiftUpDown.Enabled = true;
				mIeTxt.Enabled = true;
				mvRadBtn.Enabled = false;
				mvTxt.Enabled = false;
				PowerLawAlphaTxt.Enabled = false;
				PowerLawNormTxt.Enabled = false;
				DistanceRadBtn.Enabled = false;
				DistanceTxt.Enabled = false;
				RadiusTxt.Enabled = false;
				ISPOINTSOURCE = false;

				if (FIRSTSLOAD)
					return;
				ThroughPutETC();
			}
			else
			{
				//label6.Text = "TotCPS";
				//toolTip1.SetToolTip(label6, "Total Counts per Second");
				//label22.Text = "TotCPS T";
				//toolTip1.SetToolTip(label22, "Time to reach SN for Total Counts per Second (TotCPS)");
				SourceGalaxyDrop.Enabled = false;
				RedShiftUpDown.Enabled = false;
				mIeTxt.Enabled = false;
			}

			SetReg("CETC", "SourceGalaxyRadBtn", SourceGalaxyRadBtn.Checked);
		}

		void SourceGalaxyDrop_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SourceGalaxyDropIndex", SourceGalaxyDrop.SelectedIndex);

			ThroughPutETC();
		}

		void SourceBlackbodyRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceBlackbodyRadBtn.Checked)
			{
				SourceBlackbodyTempTxt.Enabled = true;
				DistanceRadBtn.Enabled = true;
				DistanceRadBtn.Checked = true;
				RadiusTxt.Enabled = true;
				DistanceTxt.Enabled = true;
				mvRadBtn.Enabled = false;
				mvTxt.Enabled = false;
				PowerLawAlphaTxt.Enabled = false;
				PowerLawNormTxt.Enabled = false;
				mIeTxt.Enabled = false;
				RedShiftUpDown.Enabled = false;
				ISPOINTSOURCE = true;

				if (FIRSTSLOAD)
					return;

				ThroughPutETC();
			}
			else
				SourceBlackbodyTempTxt.Enabled = false;

			SetReg("CETC", "SourceBlackbodyRadBtn", SourceBlackbodyRadBtn.Checked);
		}

		void DistanceRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (DistanceRadBtn.Checked)
			{
				DistanceTxt.Enabled = true;
				if (FIRSTSLOAD)
					return;
				ThroughPutETC();
			}
			else
				DistanceTxt.Enabled = false;

			SetReg("CETC", "DistanceRadBtn", DistanceRadBtn.Checked);
		}

		void mvRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (mvRadBtn.Checked)
			{
				mvTxt.Enabled = true;
				if (FIRSTSLOAD)
					return;
				ThroughPutETC();
			}
			else
				mvTxt.Enabled = false;

			SetReg("CETC", "mvRadBtn", mvRadBtn.Checked);
		}

		void DistanceTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "DistanceTxt", DistanceTxt.Text);
				ThroughPutETC();
			}
		}

		void RadiusTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "RadiusTxt", RadiusTxt.Text);
				ThroughPutETC();
			}
		}

		void PowerLawAlphaTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "PowerLawAlphaTxt", PowerLawAlphaTxt.Text);
				ThroughPutETC();
			}
		}

		void PowerLawNormTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "PowerLawNormTxt", PowerLawNormTxt.Text);
				ThroughPutETC();
			}
		}

		void ExtinctionAvTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "ExtinctionAvTxt", ExtinctionAvTxt.Text);
				ThroughPutETC();
			}
		}

		void ExtinctionColumnDensityTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "ExtinctionColumnDensityTxt", ExtinctionColumnDensityTxt.Text);
				ThroughPutETC();
			}
		}

		void ExtinctionRvTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "ExtinctionRvTxt", ExtinctionRvTxt.Text);
				ThroughPutETC();
			}
		}

		void mvTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "mvTxt", mvTxt.Text);
				ThroughPutETC();
			}
		}

		void mTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "mTxt", mIeTxt.Text);
				ThroughPutETC();
			}
		}

		void RedShiftTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				SetReg("CETC", "RedShiftUpDown", RedShiftUpDown.Value);
				ThroughPutETC();
			}
		}

		void SourceBlackbodyTempTxt_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (SourceBlackbodyTempTxt.Text == "")
					return;
				SetReg("CETC", "SourceBlackbodyTempTxt", SourceBlackbodyTempTxt.Text);
				if (SourceBlackbodyRadBtn.Checked)
					ThroughPutETC();
				else
					SourceBlackbodyRadBtn.Checked = true;
			}
		}

		void SourceBlackbodyTempTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceBlackbodyTempTxt.Text == "")
				return;
			try
			{
				Convert.ToDouble(SourceBlackbodyTempTxt.Text);
				SetReg("CETC", "SourceBlackbodyTempTxt", SourceBlackbodyTempTxt.Text);
			}
			catch
			{
				SourceBlackbodyTempTxt.Text = (string)GetReg("CETC", "SourceBlackbodyTempTxt");
			}
		}

		void SourcePowerLawRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (SourcePowerLawRadBtn.Checked)
			{
				SourcePowerLawDrop.Enabled = true;
				PowerLawAlphaTxt.Enabled = true;
				PowerLawNormTxt.Enabled = true;
				SourceGalaxyDrop.Enabled = false;
				RedShiftUpDown.Enabled = false;
				mIeTxt.Enabled = false;
				mvRadBtn.Enabled = false;
				mvTxt.Enabled = false;
				DistanceRadBtn.Enabled = false;
				DistanceTxt.Enabled = false;
				RadiusTxt.Enabled = false;
				ISPOINTSOURCE = true;

				if (FIRSTSLOAD)
					return;
				ThroughPutETC();
			}
			else
			{
				SourcePowerLawDrop.Enabled = false;
				PowerLawAlphaTxt.Enabled = false;
				PowerLawNormTxt.Enabled = false;
			}

			SetReg("CETC", "SourcePowerLawRadBtn", SourcePowerLawRadBtn.Checked);
		}

		void SourcePowerLawDrop_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (SourcePowerLawDrop.SelectedIndex == 0)
				PowerLawAlphaLabel.Text = "Alpha nu:";
			else
				PowerLawAlphaLabel.Text = "Alpha lambda:";

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SourcePowerLawDropIndex", SourcePowerLawDrop.SelectedIndex);

			ThroughPutETC();
		}

		void FilterUpDate()
		{
			Chart_Filter.Series[0].Points.Clear();
			Chart_Final.Series.Clear();
			Chart_Final.Series.Add("Source");
			Chart_Final.Series["Source"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			Chart_Final.Series["Source"].BorderWidth = 3;
			Chart_Final.Series["Source"].Color = System.Drawing.Color.Red;
			Chart_Final.Series.Add("Background");
			Chart_Final.Series["Background"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			Chart_Final.Series["Background"].BorderWidth = 1;
			Chart_Final.Series["Background"].Color = System.Drawing.Color.Black;
			for (int i = 0; i < NELEMENTS; i++)
			{
				Chart_Filter.Series[0].Points.AddXY(LAMBDA_NM[i], FILTERS[SELECTED_FILTER][i]);
				Chart_Final.Series["Source"].Points.AddXY(LAMBDA_NM[i], FINAL_FLUX_FILTERS[SELECTED_FILTER][i]);
				Chart_Final.Series["Background"].Points.AddXY(LAMBDA_NM[i], FINAL_FLUX_FILTERS_BG[SELECTED_FILTER][i] * (double)(APERTURENPIX));
			}
		}

		private void FilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			SELECTED_FILTER = FilterDropDown.SelectedIndex;
			if (!COMPUTATION_EXISTS)
				return;
			FilterUpDate();
		}

		void CheckTextToNum(TextBox textbox)
		{
			if (textbox.Text == "." || textbox.Text == "")
				return;

			try
			{
				double var = Convert.ToDouble(textbox.Text);
				if (var < 0)
					textbox.Text = "0";
			}
			catch
			{
				textbox.Text = "0";
			}
		}

		void PowerLawAlphaTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "PowerLawAlphaTxt", PowerLawAlphaTxt.Text);
		}

		void PowerLawNormTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "PowerLawNormTxt", PowerLawNormTxt.Text);
		}

		void mTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "mTxt", mIeTxt.Text);
		}		

		void DistanceTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "DistanceTxt", DistanceTxt.Text);
		}

		void mvTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "mvTxt", mvTxt.Text);
		}

		void RadiusTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "RadiusTxt", RadiusTxt.Text);
		}

		void ExtinctionRvTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "ExtinctionRvTxt", ExtinctionRvTxt.Text);
		}

		void ExtinctionAvTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "ExtinctionAvTxt", ExtinctionAvTxt.Text);
		}

		void ExtinctionColumnDensityTxt_TextChanged(System.Object sender, System.EventArgs e)
		{
			CheckTextToNum((TextBox)sender);
			SetReg("CETC", "ExtinctionColumnDensityTxt", ExtinctionColumnDensityTxt.Text);
		}

		void ExtinctionAvRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (ExtinctionAvRadBtn.Checked)
			{
				ExtinctionAvTxt.Enabled = true;
				ExtinctionColumnDensityTxt.Enabled = false;
			}
			else
				ExtinctionAvTxt.Enabled = false;

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "ExtinctionAvRadBtn", ExtinctionAvRadBtn.Checked);

			ThroughPutETC();
		}

		void ExtinctionColumnDensityRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (ExtinctionColumnDensityRadBtn.Checked)
			{
				ExtinctionColumnDensityTxt.Enabled = true;
				ExtinctionAvTxt.Enabled = false;
			}
			else
				ExtinctionColumnDensityTxt.Enabled = false;

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "ExtinctionColumnDensityRadBtn", ExtinctionColumnDensityRadBtn.Checked);

			ThroughPutETC();
		}

		void ExtinctionDistanceRadBtn_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (ExtinctionDistanceRadBtn.Checked)
			{
				ExtinctionAvTxt.Enabled = false;
				ExtinctionColumnDensityTxt.Enabled = false;
			}

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "ExtinctionDistanceRadBtn", ExtinctionDistanceRadBtn.Checked);

			ThroughPutETC();
		}

		void SourceGalaxyDrop_DropDown(System.Object sender, System.EventArgs e)
		{
			SourceGalaxyDrop.Width = 310;
		}

		void SourceGalaxyDrop_DropDownClosed(System.Object sender, System.EventArgs e)
		{
			SourceGalaxyDrop.Width = 88;
		}

		void SourceAGNDrop_DropDown(System.Object sender, System.EventArgs e)
		{
			SourceAGNDrop.Width = 200;
		}

		void SourceAGNDrop_DropDownClosed(System.Object sender, System.EventArgs e)
		{
			SourceAGNDrop.Width = 88;
		}

		void ExtinctionHelpBtn_Click(System.Object sender, System.EventArgs e)
		{
			string helpfile = SOURCES_DIRECTORY + "Help\\HelpExtinction.txt";
			System.IO.StreamReader sr = new System.IO.StreamReader(helpfile);
			string help = sr.ReadToEnd();
			sr.Close();
			MessageBox.Show(help, "Extinction Help...");
		}

		void SpectralTypeHelpBtn_Click(System.Object sender, System.EventArgs e)
		{
			string helpfile = SOURCES_DIRECTORY + "Help\\HelpSpectralType.txt";
			System.IO.StreamReader sr = new System.IO.StreamReader(helpfile);
			string help = sr.ReadToEnd();
			sr.Close();
			MessageBox.Show(help, "Spectral Type Help...");
		}

		void AGNTypeHelpBtn_Click(System.Object sender, System.EventArgs e)
		{
			string helpfile = SOURCES_DIRECTORY + "Help\\HelpAGN.txt";
			System.IO.StreamReader sr = new System.IO.StreamReader(helpfile);
			string help = sr.ReadToEnd();
			sr.Close();
			MessageBox.Show(help, "AGN Help...");
		}

		void GalaxyTypeHelpBtn_Click(System.Object sender, System.EventArgs e)
		{
			string helpfile = SOURCES_DIRECTORY + "Help\\HelpGalaxy.txt";
			System.IO.StreamReader sr = new System.IO.StreamReader(helpfile);
			string help = sr.ReadToEnd();
			sr.Close();
			MessageBox.Show(help, "Galaxy Help...");
		}

		void SNHelpBtn_Click(System.Object sender, System.EventArgs e)
		{
			string helpfile = SOURCES_DIRECTORY + "Help\\HelpSN.txt";
			System.IO.StreamReader sr = new System.IO.StreamReader(helpfile);
			string help = sr.ReadToEnd();
			sr.Close();
			MessageBox.Show(help, "SN Help...");
		}

		private void RedShiftUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "RedShiftUpDown", RedShiftUpDown.Value);
			ThroughPutETC();
		}

		void SNTargetUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SNTargetUpD", SNTargetUpD.Value.ToString());
			ThroughPutETC();
		}

		void SersicReffUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SersicReffUpD", SersicReffUpD.Value.ToString());
			ThroughPutETC();
		}

		void SersicnUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SersicnUpD", SersicnUpD.Value.ToString());
			ThroughPutETC();
		}

		void MirrorAreaUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "MirrorArea", MirrorAreaUpD.Value.ToString());
			ThroughPutETC();
		}

		void PlateScaleUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			double platescale = (double)PlateScaleUpD.Value;//arcsec/pixel
			double psfFWHM = (double)FWHMUpD.Value;//arcsec
			FWHMpixelsTxt.Text = "{" + (Math.Round(psfFWHM / platescale, 2)).ToString() + "px}";

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "PlateScaleUpD", PlateScaleUpD.Value.ToString());
			ThroughPutETC();
		}

		void FWHMUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			double platescale = (double)PlateScaleUpD.Value;//arcsec/pixel
			double psfFWHM = (double)FWHMUpD.Value;//arcsec
			FWHMpixelsTxt.Text = "{" + (Math.Round(psfFWHM / platescale, 2)).ToString() + "px}";

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "FWHMUpD", FWHMUpD.Value.ToString());
			ThroughPutETC();
		}

		void ReadNoiseUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "ReadNoiseUpD", ReadNoiseUpD.Value.ToString());
			ThroughPutETC();
		}

		void DarkRateUpD_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "DarkRateUpD", DarkRateUpD.Value.ToString());
			ThroughPutETC();
		}

		void SourceAGNDrop_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (SourceAGNDrop.SelectedIndex == 0 || SourceAGNDrop.SelectedIndex == 1 || SourceAGNDrop.SelectedIndex == 4)
				label5.Text = "V Mag:";
			else
				label5.Text = "B Mag:";

			if (FIRSTSLOAD)
				return;

			SetReg("CETC", "SourceAGNDropIndex", SourceAGNDrop.SelectedIndex);

			ThroughPutETC();
		}

		private void FilterGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex == 0)
				if (e.RowIndex >= 0)
					FilterDropDown.SelectedIndex = e.RowIndex;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 0)
			{
				ETCMenu.Enabled = true;
				BSWTMenu.Enabled = false;
			}
			else if (tabControl1.SelectedIndex == 1)
			{
				ETCMenu.Enabled = false;
				BSWTMenu.Enabled = true;
			}
		}

		private void FileMenuQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TabBSWT_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				EscBtn.PerformClick();
		}

		private void tabControl1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				EscBtn.PerformClick();
		}

		void FormatLabels()
		{
			System.Data.DataTable dt = new System.Data.DataTable();
			dt.Columns.Add("Filter", Type.GetType("System.String"));
			dt.Columns.Add("Max CPS", Type.GetType("System.String"));
			dt.Columns.Add("Total CPS", Type.GetType("System.String"));
			dt.Columns.Add("BG CPS", Type.GetType("System.String"));
			dt.Columns.Add("Time", Type.GetType("System.String"));

			for (int i = 0; i < NFILTERS; i++)
			{
				System.Data.DataRow dr = dt.NewRow();
				dr["Filter"] = FILTER_NAMES[i];
				dr["Max CPS"] = FINAL_COUNTS_MAXPIX[i].ToString("0.00e+0");
				dr["Total CPS"] = FINAL_COUNTS[i].ToString("0.00e+0");
				dr["BG CPS"] = FINAL_COUNTS_BG[i].ToString("0.00e+0");
				dr["Time"] = SN_TIME_TCPS[i].ToString("0.00e+0");
				dt.Rows.Add(dr);
			}

			dt.AcceptChanges();
			FilterGridView.DataSource = dt;

			FilterGridView.Columns["Filter"].SortMode = DataGridViewColumnSortMode.NotSortable;
			FilterGridView.Columns["Max CPS"].SortMode = DataGridViewColumnSortMode.NotSortable;
			FilterGridView.Columns["Total CPS"].SortMode = DataGridViewColumnSortMode.NotSortable;
			FilterGridView.Columns["BG CPS"].SortMode = DataGridViewColumnSortMode.NotSortable;
			FilterGridView.Columns["Time"].SortMode = DataGridViewColumnSortMode.NotSortable;

			FilterGridView.BackgroundColor = System.Drawing.Color.Silver;
			FilterGridView.BorderStyle = BorderStyle.None;
			//FilterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}		
	}
}

