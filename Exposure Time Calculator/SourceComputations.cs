using System;
using JPFITS;

namespace Exposure_Time_Calculator
{
	public partial class Form1
	{
		double a_lambda(double lambda)//lambda in nm
		{
			double WaveNum = 1.0 / (lambda / 1000); //Wave Number in units of inverse micrometers
			double y, Fa;

			if (WaveNum < 3.3)
			{
				y = WaveNum - 1.82;
				return (1 + 0.17699 * y - 0.50447 * y * y - 0.02427 * y * y * y + 0.72085 * Math.Pow(y, 4) + 0.01979 * Math.Pow(y, 5) - 0.77530 * Math.Pow(y, 6) + 0.32999 * Math.Pow(y, 7));
			}
			if (WaveNum >= 3.3 && WaveNum < 5.9)
			{
				Fa = 0.0;
			}
			else
			{
				y = WaveNum - 5.9;
				Fa = -0.04473 * y * y - 0.009779 * y * y * y;
			}
			y = WaveNum - 4.67;
			return (1.752 - 0.316 * WaveNum - 0.104 / (y * y + 0.341) + Fa);
		}

		double b_lambda(double lambda)//lambda in nm
		{
			double WaveNum = 1.0 / (lambda / 1000); //Wave Number in units of inverse micrometers
			double y, Fb;

			if (WaveNum <= 3.3)
			{
				y = WaveNum - 1.82;
				return (1.41338 * y + 2.28305 * y * y + 1.07233 * y * y * y - 5.38434 * Math.Pow(y, 4) - 0.62251 * Math.Pow(y, 5) + 5.30260 * Math.Pow(y, 6) - 2.09002 * Math.Pow(y, 7));
			}
			if (WaveNum > 3.3 && WaveNum < 5.9)
			{
				Fb = 0.0;
			}
			else
			{
				y = WaveNum - 5.9;
				Fb = 0.2130 * y * y + 0.1207 * y * y * y;
			}
			y = WaveNum - 4.62;
			return (-3.090 + 1.825 * WaveNum + 1.206 / (y * y + 0.263) + Fb);
		}

		void SourceBlackBody()
		{
			double distance = Convert.ToDouble(DistanceTxt.Text);
			double radius = Convert.ToDouble(RadiusTxt.Text);
			double solidangle = Math.PI * (radius * SR2KPC) * (radius * SR2KPC) / (distance * distance);
			double BB_temp = Convert.ToDouble(SourceBlackbodyTempTxt.Text);
			double lambda;

			for (int i = 0; i < NELEMENTS; i++)
			{
				lambda = LAMBDA_NM[i] * 1e-9; //lambda in meters 
				SOURCE_FLUX[i] = 2 * h * c * c * Math.Pow(lambda, -5) * Math.Pow(Math.Exp((h * c) / (lambda * BB_temp * K)) - 1, -1);
				SOURCE_FLUX_LOCAL[i] = SOURCE_FLUX[i] * solidangle;
			}
		}

		void SourcePowerLaw()
		{
			double alpha = Convert.ToDouble(PowerLawAlphaTxt.Text);
			double norm = Convert.ToDouble(PowerLawNormTxt.Text);
			double lambda;

			if (SourcePowerLawDrop.SelectedIndex == 0)//f(nu)
			{
				for (int i = 0; i < NELEMENTS; i++)
				{
					lambda = LAMBDA_NM[i] * 1e-9; //lambda in meters
					SOURCE_FLUX[i] = c * norm * 1e-10 * (4.13322e-20 / (lambda * lambda)) * Math.Pow(lambda / 1.2398e-9, alpha);
					SOURCE_FLUX_LOCAL[i] = SOURCE_FLUX[i];
				}
			}

			if (SourcePowerLawDrop.SelectedIndex == 1)//f(lambda)
			{
				for (int i = 0; i < NELEMENTS; i++)
				{
					lambda = LAMBDA_NM[i] * 1e-9; //lambda in meters 
					SOURCE_FLUX[i] = norm * 1e-13 * 1e7 * Math.Pow(lambda / 300e-9, -alpha);
					SOURCE_FLUX_LOCAL[i] = SOURCE_FLUX[i];
				}
			}
		}

		void SourceSpectralType()
		{
			string spectype = (string)SourceStarDrop.SelectedItem;
			string Kuruczfile = "";
			string grav = "";
			double FV_SURFACE = 0;

			switch (spectype)
			{
				case "O5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_45000.fits";
					grav = "g50";
					RadiusTxt.Text = "7.4";
					FV_SURFACE = 7.2463e8;
					break;
				}

				case "O6V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_40000.fits";
					grav = "g45";
					RadiusTxt.Text = "7.4";
					FV_SURFACE = 6.3521E8;
					break;
				}

				case "O8V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_35000.fits";
					grav = "g40";
					RadiusTxt.Text = "7.4";
					FV_SURFACE = 5.3639E8;
					break;
				}

				case "B0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_30000.fits";
					grav = "g40";
					RadiusTxt.Text = "6.64";
					FV_SURFACE = 4.0320E8;
					break;
				}

				case "B3V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_19000.fits";
					grav = "g40";
					RadiusTxt.Text = "3.25";
					FV_SURFACE = 1.7375E8;
					break;
				}

				case "B5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_15000.fits";
					grav = "g40";
					RadiusTxt.Text = "2.74";
					FV_SURFACE = 1.1849E8;
					break;
				}

				case "B8V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_12000.fits";
					grav = "g40";
					RadiusTxt.Text = "2.23";
					FV_SURFACE = 8.0542E7;
					break;
				}

				case "A0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_9500.fits";
					grav = "g40";
					RadiusTxt.Text = "1.87";
					FV_SURFACE = 4.9985E7;
					break;
				}

				case "A5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_8250.fits";
					grav = "g45";
					RadiusTxt.Text = "1.69";
					FV_SURFACE = 3.3059E7;
					break;
				}

				case "F0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_7250.fits";
					grav = "g45";
					RadiusTxt.Text = "1.51";
					FV_SURFACE = 1.9702E7;
					break;
				}

				case "F5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_6500.fits";
					grav = "g45";
					RadiusTxt.Text = "1.32";
					FV_SURFACE = 1.2481E7;
					break;
				}

				case "G0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_6000.fits";
					grav = "g45";
					RadiusTxt.Text = "1.08";
					FV_SURFACE = 8.7620E6;
					break;
				}

				case "G5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_5750.fits";
					grav = "g45";
					RadiusTxt.Text = "0.96";
					FV_SURFACE = 7.1766E6;
					break;
				}

				case "K0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_5250.fits";
					grav = "g45";
					RadiusTxt.Text = "0.81";
					FV_SURFACE = 4.4845E6;
					break;
				}

				case "K5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_4250.fits";
					grav = "g45";
					RadiusTxt.Text = "0.68";
					FV_SURFACE = 1.1103E6;
					break;
				}

				case "M0V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3750.fits";
					grav = "g45";
					RadiusTxt.Text = "0.61";
					FV_SURFACE = 4.3687E5;
					break;
				}

				case "M2V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3500.fits";
					grav = "g45";
					RadiusTxt.Text = "0.55";
					FV_SURFACE = 2.3601E5;
					break;
				}

				case "M5V":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3500.fits";
					grav = "g50";
					RadiusTxt.Text = "0.49";
					FV_SURFACE = 2.4302E5;
					break;
				}

				case "B0III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_29000.fits";
					grav = "g35";
					RadiusTxt.Text = "3.0";
					FV_SURFACE = 3.9357E8;
					break;
				}

				case "B5III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_15000.fits";
					grav = "g35";
					RadiusTxt.Text = "3.0";
					FV_SURFACE = 1.1880E8;
					break;
				}

				case "G0III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_5750.fits";
					grav = "g30";
					RadiusTxt.Text = "5.0";
					FV_SURFACE = 7.2888E6;
					break;
				}

				case "G5III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_5250.fits";
					grav = "g25";
					RadiusTxt.Text = "8.0";
					FV_SURFACE = 4.6069E6;
					break;
				}

				case "K0III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_4750.fits";
					grav = "g20";
					RadiusTxt.Text = "11.0";
					FV_SURFACE = 2.5875E6;
					break;
				}

				case "K5III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_4000.fits";
					grav = "g15";
					RadiusTxt.Text = "28.0";
					FV_SURFACE = 7.3310E5;
					break;
				}

				case "M0III":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3750.fits";
					grav = "g15";
					RadiusTxt.Text = "28.0";
					FV_SURFACE = 4.0315E5;
					break;
				}

				case "O5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_40000.fits";
					grav = "g45";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 6.3521E8;
					break;
				}

				case "O6I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_40000.fits";
					grav = "g45";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 6.3521E8;
					break;
				}

				case "O8I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_34000.fits";
					grav = "g40";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 5.1313E8;
					break;
				}

				case "B0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_26000.fits";
					grav = "g30";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 3.2939E8;
					break;
				}

				case "B5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_14000.fits";
					grav = "g25";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 1.0584E8;
					break;
				}

				case "A0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_9750.fits";
					grav = "g20";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 5.2038E7;
					break;
				}

				case "A5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_8500.fits";
					grav = "g20";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 3.7259E7;
					break;
				}

				case "F0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_7750.fits";
					grav = "g20";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 2.7696E7;
					break;
				}

				case "F5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_7000.fits";
					grav = "g15";
					RadiusTxt.Text = "60.0";
					FV_SURFACE = 1.8639E7;
					break;
				}

				case "G0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_5500.fits";
					grav = "g15";
					RadiusTxt.Text = "75.0";
					FV_SURFACE = 5.9486E6;
					break;
				}

				case "G5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_4750.fits";
					grav = "g10";
					RadiusTxt.Text = "95.0";
					FV_SURFACE = 2.6013E6;
					break;
				}

				case "K0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_4500.fits";
					grav = "g10";
					RadiusTxt.Text = "110.0";
					FV_SURFACE = 1.8243E6;
					break;
				}

				case "K5I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3750.fits";
					grav = "g05";
					RadiusTxt.Text = "150.0";
					FV_SURFACE = 4.0596E5;
					break;
				}

				case "M0I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3750.fits";
					grav = "g00";
					RadiusTxt.Text = "150.0";
					FV_SURFACE = 4.0151E5;
					break;
				}

				case "M2I":
				{
					Kuruczfile = SOURCES_DIRECTORY + "SpectralType\\kp00_3500.fits";
					grav = "g00";
					RadiusTxt.Text = "150.0";
					FV_SURFACE = 1.8380E5;
					break;
				}
				default:
					throw new Exception("Spectral Source type not found.");
			}

			FITSBinTable fbt = new FITSBinTable(Kuruczfile, "");
			double[] kurucz_lambda = fbt.GetTTYPEEntry("WAVELENGTH");//Angstroms
			double[] kurucz_source = fbt.GetTTYPEEntry(grav);//erg/s/cm3

			for (int i = 0; i < kurucz_lambda.Length; i++)
			{
				kurucz_lambda[i] /= 10;//Kurucz profiles are tabulated in Angstroms - source vs. lambda in Angstroms, therefore need to scale Angstrom to nm -> nm = 10 times larger
				kurucz_source[i] *= 1e7;//convert from erg/s/cm3 . J/s/m3;
			}

			SOURCE_FLUX = JPMath.Interpolate1d(kurucz_lambda, kurucz_source, LAMBDA_NM, "linear", false);

			double distance = Convert.ToDouble(DistanceTxt.Text);
			double radius = Convert.ToDouble(RadiusTxt.Text);

			if (mvRadBtn.Checked)
			{
				double magnitude = Convert.ToDouble(mvTxt.Text);
				radius = Convert.ToDouble(RadiusTxt.Text);
				distance = Math.Sqrt(Math.Pow(10, 0.4 * magnitude) * Math.Pow(3.085680E17 / 1.87, 2) / 4.9885E7 * Math.Pow(radius, 2) * FV_SURFACE) / KPC2M;
				DistanceTxt.Text = Math.Round(distance, 3).ToString();
				if (distance < 0.001)
					DistanceTxt.Text = "0.001";
			}

			double solidangle = Math.PI * (radius * SR2KPC) * (radius * SR2KPC) / (distance * distance);

			for (int i = 0; i < NELEMENTS; i++)
				SOURCE_FLUX_LOCAL[i] = solidangle * SOURCE_FLUX[i] / Math.PI;// divide by PI because spectrum input is surface flux not intensity: surface flux = PI*intensity
		}

		void SourceGalaxy()
		{
			string galtype = (string)SourceGalaxyDrop.SelectedItem;
			string galfile = "";
			double NORM_MAG = 0;

			switch (galtype)
			{
				case "Bulge (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\bulge_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Elliptical (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\elliptical_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "S0 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\s0_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Sa (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\sa_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Sb (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\sb_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Sc (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\sc_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst1: e(b-v)<0.1 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb1_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst2: 0.11< e(b-v)<0.21 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb2_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst3: 0.25< e(b-v)<0.35 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb3_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst4: 0.39< e(b-v)<0.50 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb4_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst5: 0.51< e(b-v)<0.60 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb5_template.fits";
					NORM_MAG = 12.5;
					break;
				}

				case "Starburst6: 0.61< e(b-v)<0.70 (norm: v=12.5)":
				{
					galfile = SOURCES_DIRECTORY + "Galaxies\\starb6_template.fits";
					NORM_MAG = 12.5;
					break;
				}
				default:
					throw new Exception("Galaxy type not found.");
			}

			FITSBinTable fbt = new FITSBinTable(galfile, "");
			double[] gal_lambda = fbt.GetTTYPEEntry("WAVELENGTH");
			double[] gal_source = fbt.GetTTYPEEntry("FLUX");
			double redshift = Convert.ToDouble(RedShiftUpDown.Value);
			double m = Convert.ToDouble(mIeTxt.Text);

			for (int i = 0; i < gal_lambda.Length; i++)
			{
				gal_lambda[i] /= 10;//Galaxy profiles are tabulated in Angstroms - source vs. lambda in Angstroms, therefore need to scale Angstrom to nm -> nm = 10 times larger
				gal_lambda[i] = gal_lambda[i] * (1 + redshift);//shift the spectrum for the given redshift to get local source flux
				gal_source[i] *= 1e7;//convert from erg/s/cm3 . J/s/m3;
			}

			SOURCE_FLUX = JPMath.Interpolate1d(gal_lambda, gal_source, LAMBDA_NM, "linear", false);

			//now redshift the local source flux and scale the magnitude
			for (int i = 0; i < NELEMENTS; i++)
				SOURCE_FLUX_LOCAL[i] = (SOURCE_FLUX[i] / (1 + redshift)) * (Math.Pow(10, -0.4 * (m - NORM_MAG)) / (1 + redshift));
		}

		void SourceAGN()
		{
			string AGNtype = (string)SourceAGNDrop.SelectedItem;
			string AGNfile = "";
			double NORM_MAG = 0;

			switch (AGNtype)
			{
				case "Liner (norm: v=12.5)":
				{
					AGNfile = SOURCES_DIRECTORY + "AGN\\liner_template.fits";
					NORM_MAG = 12.5;
					break;
				}
				case "NGC-1068 (norm: v=10.3)":
				{
					AGNfile = SOURCES_DIRECTORY + "AGN\\ngc1068_template.fits";
					NORM_MAG = 10.3;
					break;
				}
				case "QSO (norm: b=12.5)":
				{
					AGNfile = SOURCES_DIRECTORY + "AGN\\qso_template.fits";
					NORM_MAG = 12.5;
					break;
				}
				case "Seyfert1 (norm: b=12.5)":
				{
					AGNfile = SOURCES_DIRECTORY + "AGN\\seyfert1_template.fits";
					NORM_MAG = 12.5;
					break;
				}
				case "Seyfert2 (norm: v=12.5)":
				{
					AGNfile = SOURCES_DIRECTORY + "AGN\\seyfert2_template.fits";
					NORM_MAG = 12.5;
					break;
				}
				default:
					throw new Exception("AGN type not found.");
		}			

			FITSBinTable fbt = new FITSBinTable(AGNfile, "");
			double[] AGN_lambda = fbt.GetTTYPEEntry("WAVELENGTH");
			double[] AGN_source = fbt.GetTTYPEEntry("FLUX");
			double redshift = Convert.ToDouble(RedShiftUpDown.Value);
			double m = Convert.ToDouble(mIeTxt.Text);

			for (int i = 0; i < AGN_lambda.Length; i++)
			{
				AGN_lambda[i] /= 10;//Galaxy profiles are tabulated in Angstroms - source vs. lambda in Angstroms, therefore need to scale Angstrom to nm -> nm = 10 times larger
				AGN_lambda[i] = AGN_lambda[i] * (1 + redshift);//shift the spectrum for the given redshift to get local source flux
				AGN_source[i] *= 1e7;//convert from erg/s/cm3 . J/s/m3;
			}

			SOURCE_FLUX = JPMath.Interpolate1d(AGN_lambda, AGN_source, LAMBDA_NM, "linear", false);

			//now redshift the local source flux and scale the magnitude
			for (int i = 0; i < NELEMENTS; i++)
				SOURCE_FLUX_LOCAL[i] = (SOURCE_FLUX[i] / (1 + redshift)) * (Math.Pow(10, -0.4 * (m - NORM_MAG)) / (1 + redshift));
		}
	}
}

