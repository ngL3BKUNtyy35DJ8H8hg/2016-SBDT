using System;
namespace DienTapLib
{
	public class CSpinDef : CActDef
	{
		public float dAngleZ;
		public CSpinDef(string pActionType, string pName, string pObjName, string pstart, string pduration, float pdAngleZ, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.ObjName = pObjName;
			this.start = pstart;
			this.duration = pduration;
			this.dAngleZ = pdAngleZ;
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			return new CSpinDef(this.ActionType, this.Name, this.ObjName, this.start, this.duration, this.dAngleZ, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			str = str + " ObjName=\"" + this.ObjName + "\"";
			str = str + " Start=\"" + this.start + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " dAngle=\"" + this.dAngleZ.ToString() + "\"";
			str = str + " SoundName=\"" + this.SoundName + "\"";
			str = str + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			return str + "></Action>\r\n";
		}
	}
}
