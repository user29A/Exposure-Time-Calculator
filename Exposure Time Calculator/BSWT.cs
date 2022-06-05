using System;
using JPFITS;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Exposure_Time_Calculator
{
	public partial class Form1
	{
		private string QUERYFILENAME;
		Rectangle[] PSESRECTS;
		double[] CAT_MAGs;

		private void TabBSWT_Layout(object sender, EventArgs e)
		{
			RATargetTxt.Text = (string)GetReg("CETC", "RATargetTxt");
			DecTargetTxt.Text = (string)GetReg("CETC", "DecTargetTxt");
			FieldBufferUpD.Value = Convert.ToDecimal(GetReg("CETC", "FieldBufferUpD"));
			FieldShapeBtn.Text = (string)GetReg("CETC", "FieldShapeBtn");
			BSWTCatalogueDrop.SelectedIndex = (int)GetReg("CETC", "BSWTCatalogueDrop");
			BSWTFilterDrop.SelectedIndex = (int)GetReg("CETC", "BSWTFilterDrop");
			BSWTMagLimitUpD.Value = Convert.ToDecimal(GetReg("CETC", "BSWTMagLimitTxt"));
			BSWTPlateScaleUpD.Value = Convert.ToDecimal(GetReg("CETC", "BSWTPlateScaleUpD"));
			BSWTHorizontalPixUpD.Value = Convert.ToDecimal(GetReg("CETC", "BSWTHorizontalPixUpD"));
			BSWTVerticalPixUpD.Value = Convert.ToDecimal(GetReg("CETC", "BSWTVerticalPixUpD"));
			BSWTMaxBrightSourcesUpD.Value = Convert.ToDecimal(GetReg("CETC", "BSWTMaxBrightSourcesUpD"));
		}

		private void RATargetBtn_Click(object sender, EventArgs e)
		{
			if (RATargetTxt.Text != "")
				if (JPMath.IsNumeric(RATargetTxt.Text))//then switch to sexagesimal
				{
					string rasex, decsex;
					WorldCoordinateSolution.DegreeElementstoSexagesimalElements(Convert.ToDouble(RATargetTxt.Text), 0.0, out rasex, out decsex, ":", 2);
					RATargetTxt.Text = rasex;
				}
				else
				{
					double ra, dec;
					WorldCoordinateSolution.SexagesimalElementsToDegreeElements(RATargetTxt.Text, "00:00:00.0", ":", out ra, out dec);
					RATargetTxt.Text = ra.ToString();
				}

			if (DecTargetTxt.Text != "")
				if (JPMath.IsNumeric(DecTargetTxt.Text))//then switch to sexagesimal
				{
					string rasex, decsex;
					WorldCoordinateSolution.DegreeElementstoSexagesimalElements(0.0, Convert.ToDouble(DecTargetTxt.Text), out rasex, out decsex, ":", 1);
					DecTargetTxt.Text = decsex;
				}
				else
				{
					double ra, dec;
					WorldCoordinateSolution.SexagesimalElementsToDegreeElements("00:00:00.0", DecTargetTxt.Text, ":", out ra, out dec);
					DecTargetTxt.Text = dec.ToString();
				}
		}

		private void FieldShapeBtn_Click(object sender, EventArgs e)
		{
			if (FieldShapeBtn.Text == "Square")
				FieldShapeBtn.Text = "Circle";
			else
				FieldShapeBtn.Text = "Square";
		}

		private void BSWTExecuteBtn_Click(object sender, EventArgs e)
		{
			SetReg("CETC", "RATargetTxt", RATargetTxt.Text);
			SetReg("CETC", "DecTargetTxt", DecTargetTxt.Text);
			SetReg("CETC", "FieldBufferUpD", FieldBufferUpD.Value);
			SetReg("CETC", "FieldShapeBtn", FieldShapeBtn.Text);
			SetReg("CETC", "BSWTCatalogueDrop", BSWTCatalogueDrop.SelectedIndex);
			SetReg("CETC", "BSWTFilterDrop", BSWTFilterDrop.SelectedIndex);
			SetReg("CETC", "BSWTMagLimitTxt", BSWTMagLimitUpD.Value);
			SetReg("CETC", "BSWTPlateScaleUpD", BSWTPlateScaleUpD.Value);
			SetReg("CETC", "BSWTHorizontalPixUpD", BSWTHorizontalPixUpD.Value);
			SetReg("CETC", "BSWTVerticalPixUpD", BSWTVerticalPixUpD.Value);
			SetReg("CETC", "BSWTMaxBrightSourcesUpD", BSWTMaxBrightSourcesUpD.Value);

			BSWTMessageBox.Items.Clear();
			BSWTMessageBox.Visible = true;

			string rasexfilename = RATargetTxt.Text;
			string decsexfilename = DecTargetTxt.Text;
			double radeg, decdeg;

			if (!JPMath.IsNumeric(RATargetTxt.Text))//get rid of decimal from sexagesimal seconds for filename
			{
				WorldCoordinateSolution.SexagesimalElementsToDegreeElements(rasexfilename, decsexfilename, ":", out radeg, out decdeg);//for function call below

				if (rasexfilename.Contains("."))
					rasexfilename.Remove(rasexfilename.IndexOf("."));
				if (decsexfilename.Contains("."))
					decsexfilename.Remove(decsexfilename.IndexOf("."));
			}
			else//then switch to sexagesimal for filename
			{
				radeg = Convert.ToDouble(RATargetTxt.Text);
				decdeg = Convert.ToDouble(DecTargetTxt.Text);

				WorldCoordinateSolution.DegreeElementstoSexagesimalElements(radeg, decdeg, out rasexfilename, out decsexfilename, ":", 0);				
			}

			decsexfilename = decsexfilename.Replace("-", "m");
			decsexfilename = decsexfilename.Replace("+", "p");
			rasexfilename = rasexfilename.Replace(":", "_");
			decsexfilename = decsexfilename.Replace(":", "_");
			rasexfilename = "RA" + rasexfilename;
			decsexfilename = "DEC" + decsexfilename;
			string file = rasexfilename + decsexfilename + ".fit";

			QUERYFILENAME = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Astrowerks\\BSWT\\AstroQueries\\" + file;

			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Astrowerks\\BSWT\\AstroQueries\\"))
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Astrowerks\\BSWT\\AstroQueries\\");

			string fieldshape;
			if (FieldShapeBtn.Text == "Square")
				fieldshape = "1";
			else
				fieldshape = "0";

			double fieldradius = (double)BSWTHorizontalPixUpD.Value / 2 * (double)BSWTPlateScaleUpD.Value / 60 + (double)FieldBufferUpD.Value;

			if (!File.Exists(QUERYFILENAME) || BSWTForceQueryChck.Checked)
				WCSAutoSolver.GaiaDR3QueryN(radeg.ToString(), decdeg.ToString(), QUERYFILENAME, fieldradius.ToString(), fieldshape, BSWTMaxBrightSourcesUpD.Value.ToString(), BSWTFilterDrop.SelectedItem.ToString());
			BSWTForceQueryChck.Checked = false;

			FITSBinTable bt = new JPFITS.FITSBinTable(QUERYFILENAME, "");
			double[] CAT_CVAL1s = bt.GetTTYPEEntry("ra");
			double[] CAT_CVAL2s = bt.GetTTYPEEntry("dec");
			CAT_MAGs = bt.GetTTYPEEntry("phot_" + BSWTFilterDrop.SelectedItem.ToString() + "_mean_mag");

			//need to check mag for NaN's and re-form ra dec mag
			int catcnt = 0;
			for (int i = 0; i < CAT_CVAL1s.Length; i++)
			{
				if (Double.IsNaN(CAT_MAGs[i]))
					continue;

				CAT_CVAL1s[catcnt] = CAT_CVAL1s[i];
				CAT_CVAL2s[catcnt] = CAT_CVAL2s[i];
				CAT_MAGs[catcnt] = CAT_MAGs[i];
				catcnt++;
			}

			Array.Resize(ref CAT_CVAL1s, catcnt);
			Array.Resize(ref CAT_CVAL2s, catcnt);
			Array.Resize(ref CAT_MAGs, catcnt);

			//sort the catalogue list by magnitude
			double[] keysref = new double[CAT_MAGs.Length];
			Array.Copy(CAT_MAGs, keysref, CAT_MAGs.Length);
			Array.Sort(CAT_MAGs, CAT_CVAL1s);
			Array.Copy(keysref, CAT_MAGs, CAT_MAGs.Length);
			Array.Sort(CAT_MAGs, CAT_CVAL2s);

			BSWTWCS = new WorldCoordinateSolution((double)BSWTPlateScaleUpD.Value, (int)BSWTHorizontalPixUpD.Value, (int)BSWTVerticalPixUpD.Value, radeg, decdeg);
			double[] xpix, ypix;
			BSWTWCS.Get_Pixels(CAT_CVAL1s, CAT_CVAL2s, "TAN", out xpix, out ypix, true);

			float xsc = ((float)(BSWTPictureBox.Size.Width) / (float)BSWTHorizontalPixUpD.Value);
			float ysc = ((float)(BSWTPictureBox.Size.Height) / (float)BSWTVerticalPixUpD.Value);
			PSESRECTS = new Rectangle[CAT_MAGs.Length];
			for (int i = 0; i < PSESRECTS.Length; i++)
				PSESRECTS[i] = new Rectangle((int)(((float)(xpix[i]) + 0.5) * xsc - 3), (int)(((float)(ypix[i]) + 0.5) * ysc - 3), 7, 7);

			double maglimit = Convert.ToDouble(BSWTMagLimitUpD.Value);
			int[] noff = JPMath.Find(CAT_MAGs, maglimit, "<=");
			BSWTMessageBox.Items.Add("Found " + noff.Length + " bright sources out of " + BSWTMaxBrightSourcesUpD.Value + " in the query list.");

			BSWTWCS.Grid_MakeWCSGrid((int)BSWTHorizontalPixUpD.Value, (int)BSWTVerticalPixUpD.Value, BSWTPictureBox.Size.Width, BSWTPictureBox.Size.Height, 7);
			BSWTPictureBox.Refresh();			
		}

		private void BSWTPictureBox_Paint(object sender, PaintEventArgs e)
		{
			if (BSWTWCS == null)
				return;

			BSWTWCS.Grid_DrawWCSGrid(BSWTPictureBox, e);

			Pen SAFE_IMAGEWINDOWPEN = new Pen(Color.Green);
			Pen BRIT_IMAGEWINDOWPEN = new Pen(Color.Red, 5);
			double maglimit = Convert.ToDouble(BSWTMagLimitUpD.Value);
			for (int i = 0; i < PSESRECTS.Length; i++)
				if (CAT_MAGs[i] <= maglimit)
					e.Graphics.DrawEllipse(BRIT_IMAGEWINDOWPEN, PSESRECTS[i]);
				else
					e.Graphics.DrawEllipse(SAFE_IMAGEWINDOWPEN, PSESRECTS[i]);			
		}
	}
}

