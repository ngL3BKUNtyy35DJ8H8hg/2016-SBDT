using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	public class CSpinToDef : CActDef
	{
		public Vector3 topos;
		public CSpinToDef(string pActionType, string pName, string pObjName, string pstart, string pduration, Vector3 pTo, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.ObjName = pObjName;
			this.start = pstart;
			this.duration = pduration;
			this.topos = pTo;
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			return new CSpinToDef(this.ActionType, this.Name, this.ObjName, this.start, this.duration, this.topos, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			str = str + " ObjName=\"" + this.ObjName + "\"";
			str = str + " Start=\"" + this.start + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " SoundName=\"" + this.SoundName + "\"";
			str = str + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			str += ">\r\n";
			str += "<Target";
			str = str + " X=\"" + this.topos.X.ToString() + "\"";
			str = str + " Y=\"" + this.topos.Y.ToString() + "\"";
			str = str + " Z=\"" + this.topos.Z.ToString() + "\"";
			str += ">";
			str += "</Target>\r\n";
			return str + "</Action>\r\n";
		}
	}
}
