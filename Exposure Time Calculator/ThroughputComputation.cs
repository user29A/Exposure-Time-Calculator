using System;
using JPFITS;

namespace Exposure_Time_Calculator
{
	public partial class Form1
	{
		void ThroughPutETC()
		{
			double psfFWHM = (double)FWHMUpD.Value;//arcsec
			double platescale = (double)PlateScaleUpD.Value;//arcsec/pixel
			int apertureHWpix = (int)Math.Ceiling(3 * psfFWHM / 2.355 / platescale);//pixels
			double mirrorarea = (double)MirrorAreaUpD.Value;//m^2
			double RN = (double)ReadNoiseUpD.Value;
			double DR = ((double)DarkRateUpD.Value) / 60;
			double CR = 0;//cosmic ray rate

			APERTURENPIX = 0;
			if (ISPOINTSOURCE)
			{
				for (int i = -apertureHWpix; i <= apertureHWpix; i++)
					for (int j = -apertureHWpix; j <= apertureHWpix; j++)
						if (i * i + j * j <= apertureHWpix * apertureHWpix)
							APERTURENPIX++;

				//toolTip1.SetToolTip(label16, APERTURENPIX.ToString() + " total pixels in total count aperture (+-3 sigma radius of PSF)");
			}
			else
			{
				APERTURENPIX = 1;
				//toolTip1.SetToolTip(label16, APERTURENPIX.ToString() + " pixel in count values");
			}			

			//background is in log values; needs to be converted to SI and to appropriate pixel area, from (erg/cm2/s/A/arcsec2) to (J/m2/s/m/Npix2)
			//= 1x10-7 (J/erg) / 1x10-4 (m2/cm2) / 1x10-10 (m/A) * pscale2 (arcsec2/pixel2) = 1e7 * pscale2
			double fac = 1e7 * platescale * platescale;
			double[] background = new double[NELEMENTS];
			for (int i = 0; i < NELEMENTS; i++)
				background[i] = Math.Pow(10, BACKGROUND[i]) * fac;

			#region Sources and Source Flux Computation
			if (SourceBlackbodyRadBtn.Checked)
				SourceBlackBody();//sets SOURCE_FLUX and SOURCE_FLUX_LOCAL (before extinction)

			if (SourcePowerLawRadBtn.Checked)
				SourcePowerLaw();//sets SOURCE_FLUX and SOURCE_FLUX_LOCAL (before extinction)

			if (SourceStarRadBtn.Checked)
				SourceSpectralType();//sets SOURCE_FLUX and SOURCE_FLUX_LOCAL (before extinction)

			if (SourceGalaxyRadBtn.Checked)
				SourceGalaxy();//sets SOURCE_FLUX and SOURCE_FLUX_LOCAL (before extinction)

			if (SourceAGNRadBtn.Checked)
				SourceAGN();//sets SOURCE_FLUX and SOURCE_FLUX_LOCAL (before extinction)
			#endregion

			#region Extinction Computation
			double Av = 1;
			if (ExtinctionAvRadBtn.Checked)
				Av = Convert.ToDouble(ExtinctionAvTxt.Text);
			if (ExtinctionColumnDensityRadBtn.Checked)
				Av = Convert.ToDouble(ExtinctionColumnDensityTxt.Text);
			if (ExtinctionDistanceRadBtn.Checked)
				Av = Convert.ToDouble(DistanceTxt.Text) * 1.6;

			double Rv = Convert.ToDouble(ExtinctionRvTxt.Text);

			for (int i = 0; i < NELEMENTS; i++)
			{
				double Alambda = (a_lambda(LAMBDA_NM[i]) + b_lambda(LAMBDA_NM[i]) / Rv) * Av;
				EXTINCTION[i] = Math.Pow(10, -0.4 * Alambda);
				SOURCE_FLUX_LOCAL[i] *= EXTINCTION[i];//extinction is computed into the local source flux here, not below at the filter flux computation//
			}
			#endregion

			#region Final Filter Flux Computation
			double SN_target = (double)SNTargetUpD.Value;
			for (int i = 0; i < NFILTERS; i++)
			{
				for (int j = 0; j < NELEMENTS; j++)
				{
					double lambda_m = LAMBDA_NM[j] * 1e-9;

					FINAL_FLUX_FILTERS[i][j] = (SOURCE_FLUX_LOCAL[j] * lambda_m / (h * c)) * DETECTOR_QE[j] * FILTERS[i][j] * MIRROR_REFL[j] * MIRROR_REFL[j] * mirrorarea * 1e-9;
					FINAL_FLUX_FILTERS_BG[i][j] = (background[j] * lambda_m / (h * c)) * DETECTOR_QE[j] * FILTERS[i][j] * MIRROR_REFL[j] * MIRROR_REFL[j] * mirrorarea * 1e-9;

					FINAL_COUNTS[i] += FINAL_FLUX_FILTERS[i][j] * LAMBDASTEP;
					FINAL_COUNTS_BG[i] += FINAL_FLUX_FILTERS_BG[i][j] * LAMBDASTEP;
				}

				if (ISPOINTSOURCE)//blackbody, spectral type, power law, AGN
				{
					int n = 50;
					double tn_2 = (double)(2 * n * 2 * n);
					double psfsigma = psfFWHM / 2.355 / platescale;//pixels
					double t_s2 = 2 * psfsigma * psfsigma;
					double tnp1_2 = (double)((2 * n + 1) * (2 * n + 1));

					double sum = 0;
					for (int x = -n; x <= n; x++)
						for (int y = -n; y <= n; y++)
							sum += Math.Exp(-(double)(x * x + y * y) / tn_2 / t_s2);

					double A = FINAL_COUNTS[i] / (2 * Math.PI * psfsigma * psfsigma);
					FINAL_COUNTS_MAXPIX[i] = sum * A / tnp1_2;
				}
				else//galaxy
				{
					//compute Sersic function, get max value

					double SersicN = (double)(SersicnUpD.Value);
					double SersicReff = (double)(SersicReffUpD.Value);//arcsec
																	  //double SersicIeff = Convert.ToDouble(mIeTxt.Text);
					double b = 1.9992 * SersicN - 0.3271;

					double Ie = FINAL_COUNTS[i] * Math.Pow(b, 2 * SersicN) / alglib.gammafunction(2 * SersicN) / SersicReff / SersicReff / 2 / Math.PI / SersicN / Math.Exp(b);
					double I0 = Ie * Math.Exp(b);

					Ie = Ie / platescale / platescale;//from /arcsec2 to /pixel2
					I0 = I0 / platescale / platescale;//from /arcsec2 to /pixel2

					FINAL_COUNTS_MAXPIX[i] = I0;
					FINAL_COUNTS[i] = Ie;//change final counts here, which are total counts for a point source, to the counts at Re since the SN at Re is what we want
				}

				//SN_TIME_MCPS[i] = SN_target * SN_target * (1 + FINAL_COUNTS_BG[i] / FINAL_COUNTS_MAXPIX[i]) / FINAL_COUNTS_MAXPIX[i];
				//SN_TIME_TCPS[i] = SN_target * SN_target * (1 + FINAL_COUNTS_BG[i] * (double)(APERTURENPIX) / FINAL_COUNTS[i]) / FINAL_COUNTS[i];

				double a = FINAL_COUNTS_MAXPIX[i] * FINAL_COUNTS_MAXPIX[i] / SN_target / SN_target;
				double r = FINAL_COUNTS_MAXPIX[i] + FINAL_COUNTS_BG[i] + DR + CR;

				SN_TIME_MCPS[i] = 0.5 / a * (r + Math.Sqrt(r * r + 4 * a * RN));

				a = FINAL_COUNTS[i] * FINAL_COUNTS[i] / SN_target / SN_target;
				r = FINAL_COUNTS[i] + (FINAL_COUNTS_BG[i] + DR + CR) * (double)(APERTURENPIX);

				SN_TIME_TCPS[i] = 0.5 / a * (r + Math.Sqrt(r * r + 4 * a * RN * (double)(APERTURENPIX)));
			}
			#endregion

			COMPUTATION_EXISTS = true;

			FormatLabels();

			PLOT_XMIN = Convert.ToDouble(PlotLimitXMinText.Text);
			PLOT_XMAX = Convert.ToDouble(PlotLimitXMaxText.Text);

			//plot source flux * extinction * distance
			Chart_Source.Series[0].Points.Clear();
			if (ShowLocalFlux.Checked)
			{
				Chart_Source.Titles[0].Text = "Local Source Flux (Source * Extinction * Distance)";
				for (int i = 0; i < NELEMENTS; i++)
					Chart_Source.Series[0].Points.AddXY(LAMBDA_NM[i], SOURCE_FLUX_LOCAL[i]);
			}
			else
			{
				Chart_Source.Titles[0].Text = "Source Flux";
				for (int i = 0; i < NELEMENTS; i++)
					Chart_Source.Series[0].Points.AddXY(LAMBDA_NM[i], SOURCE_FLUX[i]);
			}
			Chart_Source.ChartAreas[0].AxisX.Minimum = PLOT_XMIN;
			Chart_Source.ChartAreas[0].AxisX.Maximum = PLOT_XMAX;

			Chart_Filter.Series[0].Points.Clear();
			Chart_Final.Series.Clear();
			Chart_Final.Series.Add("Source");
			Chart_Final.Series["Source"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			Chart_Final.Series["Source"].BorderWidth = 1;
			Chart_Final.Series["Source"].Color = System.Drawing.Color.Red;
			Chart_Final.Series.Add("background");
			Chart_Final.Series["background"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			Chart_Final.Series["background"].BorderWidth = 3;
			Chart_Final.Series["background"].Color = System.Drawing.Color.Black;
			for (int i = 0; i < NELEMENTS; i++)
			{
				Chart_Filter.Series[0].Points.AddXY(LAMBDA_NM[i], FILTERS[SELECTED_FILTER][i]);
				Chart_Final.Series["Source"].Points.AddXY(LAMBDA_NM[i], FINAL_FLUX_FILTERS[SELECTED_FILTER][i]);
				Chart_Final.Series["background"].Points.AddXY(LAMBDA_NM[i], FINAL_FLUX_FILTERS_BG[SELECTED_FILTER][i] * (double)(APERTURENPIX));
			}

			Chart_Filter.ChartAreas[0].AxisX.Minimum = PLOT_XMIN;
			Chart_Filter.ChartAreas[0].AxisX.Maximum = PLOT_XMAX;

			Chart_Final.ChartAreas[0].AxisX.Minimum = PLOT_XMIN;
			Chart_Final.ChartAreas[0].AxisX.Maximum = PLOT_XMAX;

			Chart_Final.Legends.Clear();
			Chart_Final.Legends.Add("legend");
			Chart_Final.Legends["legend"].DockedToChartArea = Chart_Final.ChartAreas[0].Name;
		}
	}
}

