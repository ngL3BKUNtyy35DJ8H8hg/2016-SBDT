using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace DienTapLib
{
	public class CHelper
	{
		public static string cDecSepa = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		public static string cGrpSepa = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
		public static Color clrColor = Color.FromArgb(255, Color.White);
		[DllImport("winmm.dll")]
		private static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);
		public static string GetSoundName(string pSoundFile)
		{
			string result = pSoundFile;
			int num = pSoundFile.LastIndexOf("\\");
			if (num > -1)
			{
				result = pSoundFile.Substring(num + 1);
			}
			return result;
		}
		public static int GetSoundLength(string fileName)
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			CHelper.mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
			CHelper.mciSendString("status wave length", stringBuilder, stringBuilder.Capacity, IntPtr.Zero);
			CHelper.mciSendString("close wave", null, 0, IntPtr.Zero);
			int result = 0;
			int.TryParse(stringBuilder.ToString(), out result);
			return result;
		}
		public static Color GetClrColor(Bitmap pTexImage)
		{
			Color white = Color.White;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < pTexImage.Width / 2; i++)
			{
				for (int j = 0; j < pTexImage.Height / 2; j++)
				{
					Color pixel = pTexImage.GetPixel(i, j);
					num4++;
					num += (int)pixel.R;
					num2 += (int)pixel.G;
					num3 += (int)pixel.B;
				}
			}
			return Color.FromArgb(255, num / num4, num / num4, num / num4);
		}
		public static void SetClrColor(Bitmap pTexImage)
		{
			CHelper.clrColor = CHelper.GetClrColor(pTexImage);
		}
		public static float myToSingle(string strSingle)
		{
			float result = 0f;
			string value = strSingle;
			try
			{
				if (strSingle.IndexOf(CHelper.cGrpSepa) > -1)
				{
					value = strSingle.Replace(CHelper.cGrpSepa, CHelper.cDecSepa);
				}
				result = Convert.ToSingle(value);
			}
			catch
			{
			}
			return result;
		}
		public static FontStyle myGetFontStyle(string strFontStyle)
		{
			FontStyle fontStyle = FontStyle.Regular;
			if (strFontStyle.IndexOf("Bold") > -1)
			{
				fontStyle |= FontStyle.Bold;
			}
			if (strFontStyle.IndexOf("Italic") > -1)
			{
				fontStyle |= FontStyle.Italic;
			}
			if (strFontStyle.IndexOf("Underline") > -1)
			{
				fontStyle |= FontStyle.Underline;
			}
			return fontStyle;
		}
		public static Size GetDesktopSize()
		{
			return SystemInformation.PrimaryMonitorSize;
		}
		public static MyTimeSpan GetTimeSpan(int mCount)
		{
			decimal num = Math.Floor(mCount / 60000m);
			decimal d = mCount - num * 60000m;
			decimal num2 = Math.Floor(d / 1000m);
			decimal milliseconds = d - num2 * 1000m;
			MyTimeSpan result;
			result.Minutes = num;
			result.Seconds = num2;
			result.Milliseconds = milliseconds;
			return result;
		}
	}
}
