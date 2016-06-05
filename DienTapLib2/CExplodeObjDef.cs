using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	public class CExplodeObjDef : CActDef
	{
		public float speed;
		public string imagefile;
		public float width;
		public float height;
		public float shiftZ;
		public Vector3 frompos;
		public CExplodeObjDef(string pActionType, string pName, string texfile, float pWidth, float pHeight, float pshiftZ, string pstart, string pduration, float pspeed, Vector3 pFromPos, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.imagefile = texfile;
			this.width = pWidth;
			this.height = pHeight;
			this.shiftZ = pshiftZ;
			this.start = pstart;
			this.duration = pduration;
			this.speed = pspeed;
			this.ObjName = "";
			this.frompos = pFromPos;
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public CExplodeObjDef(string pActionType, string pName, string texfile, float pWidth, float pHeight, float pshiftZ, string pstart, string pduration, float pspeed, string pObjName, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.imagefile = texfile;
			this.width = pWidth;
			this.height = pHeight;
			this.shiftZ = pshiftZ;
			this.start = pstart;
			this.duration = pduration;
			this.speed = pspeed;
			this.ObjName = pObjName;
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			if (this.ObjName.Length > 0)
			{
				return new CExplodeObjDef(this.ActionType, this.Name, this.imagefile, this.width, this.height, this.shiftZ, this.start, this.duration, this.speed, this.ObjName, this.SoundName, this.SoundLoop);
			}
			return new CExplodeObjDef(this.ActionType, this.Name, this.imagefile, this.width, this.height, this.shiftZ, this.start, this.duration, this.speed, this.frompos, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			if (this.ObjName.Length > 0)
			{
				str = str + " ObjName=\"" + this.ObjName + "\"";
			}
			str = str + " ImageFile=\"" + this.imagefile + "\"";
			str = str + " Width=\"" + this.width.ToString() + "\"";
			str = str + " Height=\"" + this.height.ToString() + "\"";
			str = str + " ShiftZ=\"" + this.shiftZ.ToString() + "\"";
			str = str + " Start=\"" + this.start + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " Speed=\"" + this.speed.ToString() + "\"";
			str = str + " SoundName=\"" + this.SoundName + "\"";
			str = str + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			str += ">\r\n";
			if (this.ObjName.Length == 0)
			{
				str += "<Target";
				str = str + " X=\"" + this.frompos.X.ToString() + "\"";
				str = str + " Y=\"" + this.frompos.Y.ToString() + "\"";
				str = str + " Z=\"" + this.frompos.Z.ToString() + "\"";
				str += ">";
				str += "</Target>\r\n";
			}
			return str + "</Action>\r\n";
		}
	}
}
