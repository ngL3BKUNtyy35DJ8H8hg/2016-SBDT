using System;
namespace DienTapLib
{
	public class CDescriptionDef : CActDef
	{
		public string DescText = "";
		public DescPos Pos = DescPos.Duoi;
		public bool SaBanHide;
		public CDescriptionDef(string pActionType, string pName, string pstart, string pduration, string pDescText, DescPos pPos, bool pSaBanHide, string psoundname, bool loop)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.start = pstart;
			this.duration = pduration;
			this.DescText = pDescText;
			this.Pos = pPos;
			this.SaBanHide = pSaBanHide;
			this.SoundName = psoundname;
			this.SoundLoop = loop;
		}
		public override CActDef Clone()
		{
			return new CDescriptionDef(this.ActionType, this.Name, this.start, this.duration, this.DescText, this.Pos, this.SaBanHide, this.SoundName, this.SoundLoop);
		}
		public override string GetActionStr()
		{
			string text = "<Action ID=\"" + this.Name + "\"";
			text = text + " Type=\"" + this.ActionType + "\"";
			text = text + " Start=\"" + this.start + "\"";
			text = text + " Duration=\"" + this.duration + "\"";
			text = text + " DescText=\"" + this.DescText + "\"";
			object obj = text;
			text = string.Concat(new object[]
			{
				obj,
				" Pos=\"",
				this.Pos,
				"\""
			});
			text = text + " SaBanHide=\"" + (this.SaBanHide ? "true" : "false") + "\"";
			text = text + " SoundName=\"" + this.SoundName + "\"";
			text = text + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
			return text + "></Action>\r\n";
		}
	}
}
