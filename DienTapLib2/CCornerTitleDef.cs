using System;
namespace DienTapLib
{
	public class CCornerTitleDef : CActDef
	{
		public string CornerText = "";
		public CCornerTitleDef(string pActionType, string pName, string pstart, string pduration, string pCornerText)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.start = pstart;
			this.duration = pduration;
			this.CornerText = pCornerText;
		}
		public override CActDef Clone()
		{
			return new CCornerTitleDef(this.ActionType, this.Name, this.start, this.duration, this.CornerText);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			str = str + " Start=\"" + this.start + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " CornerText=\"" + this.CornerText + "\"";
			return str + "></Action>\r\n";
		}
	}
}
