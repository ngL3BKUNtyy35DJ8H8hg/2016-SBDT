using Microsoft.DirectX;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	public class CMoveObjDef : CActDef
	{
		public bool stophide;
		public float stopangleZ;
		public List<Vector3> targets;
		public CMoveObjDef(string pActionType, string pName, string pObjName, string pstart, string pduration, bool pstophide, List<Vector3> ptargets, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.ObjName = pObjName;
			this.start = pstart;
			this.duration = pduration;
			this.stophide = pstophide;
			this.targets = new List<Vector3>();
			foreach (Vector3 current in ptargets)
			{
				Vector3 item = current;
				this.targets.Add(item);
			}
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public CMoveObjDef(string pActionType, string pName, string pObjName, string pstart, string pduration, bool pstophide, float pstopangleZ, List<Vector3> ptargets, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.ObjName = pObjName;
			this.start = pstart;
			this.duration = pduration;
			this.stophide = pstophide;
			this.stopangleZ = pstopangleZ;
			this.targets = new List<Vector3>();
			foreach (Vector3 current in ptargets)
			{
				Vector3 item = current;
				this.targets.Add(item);
			}
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			return new CMoveObjDef(this.ActionType, this.Name, this.ObjName, this.start, this.duration, this.stophide, this.stopangleZ, this.targets, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string text = "<Action ID=\"" + this.Name + "\"";
			text = text + " Type=\"" + this.ActionType + "\"";
			text = text + " ObjName=\"" + this.ObjName + "\"";
			text = text + " Start=\"" + this.start + "\"";
			text = text + " Duration=\"" + this.duration + "\"";
			text = text + " Hide=\"" + (this.stophide ? "true" : "false") + "\"";
			object obj = text;
			text = string.Concat(new object[]
			{
				obj,
				" StopAngleZ=\"",
				this.stopangleZ,
				"\""
			});
			text = text + " SoundName=\"" + this.SoundName + "\"";
			text = text + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			text += ">\r\n";
			text += "<Targets>\r\n";
			foreach (Vector3 current in this.targets)
			{
				text += "<Target";
				string arg_15E_0 = text;
				string arg_15E_1 = " X=\"";
				float x = current.X;
				text = arg_15E_0 + arg_15E_1 + x.ToString() + "\"";
				string arg_17F_0 = text;
				string arg_17F_1 = " Y=\"";
				float y = current.Y;
				text = arg_17F_0 + arg_17F_1 + y.ToString() + "\"";
				string arg_1A0_0 = text;
				string arg_1A0_1 = " Z=\"";
				float z = current.Z;
				text = arg_1A0_0 + arg_1A0_1 + z.ToString() + "\"";
				text += ">";
				text += "</Target>\r\n";
			}
			text += "</Targets>\r\n";
			text += "</Action>\r\n";
			return text;
		}
	}
}
