using System;
namespace DienTapLib
{
	public class CExplodeDcl
	{
		public string DclID;
		public string TextureFile;
		public float Width;
		public float Height;
		public float ShiftZ;
		public float Speed;
		public int Duration;
		public int Isound;
		public bool SoundLoop;
		public CExplodeDcl(string pName, string texfile, float pWidth, float pHeight, float pShiftZ, int pduration, float pspeed, int pisound, bool loop)
		{
			this.DclID = pName;
			this.TextureFile = texfile;
			this.Height = pHeight;
			this.Width = pWidth;
			this.ShiftZ = pShiftZ;
			this.Duration = pduration;
			this.Speed = pspeed;
			this.Isound = pisound;
			this.SoundLoop = loop;
		}
	}
}
