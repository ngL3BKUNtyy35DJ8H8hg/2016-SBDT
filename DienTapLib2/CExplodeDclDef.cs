using System;
namespace DienTapLib
{
	public class CExplodeDclDef : CActDef
	{
		public float speed;
		public string imagefile;
		public float width;
		public float height;
		public float shiftZ;
		public CExplodeDclDef(string pActionType, string pName, string texfile, float pWidth, float pHeight, float pshiftZ, string pduration, float pspeed, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.imagefile = texfile;
			this.width = pWidth;
			this.height = pHeight;
			this.shiftZ = pshiftZ;
			this.start = "0";
			this.duration = pduration;
			this.speed = pspeed;
			this.ObjName = "";
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			return new CExplodeDclDef(this.ActionType, this.Name, this.imagefile, this.width, this.height, this.shiftZ, this.duration, this.speed, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			str = str + " ImageFile=\"" + this.imagefile + "\"";
			str = str + " Width=\"" + this.width.ToString() + "\"";
			str = str + " Height=\"" + this.height.ToString() + "\"";
			str = str + " ShiftZ=\"" + this.shiftZ.ToString() + "\"";
			str += " Start=\"0\"";
			str = str + " Speed=\"" + this.speed.ToString() + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " SoundName=\"" + this.SoundName + "\"";
			str = str + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			str += ">\r\n";
			return str + "</Action>\r\n";
		}
	}
}
