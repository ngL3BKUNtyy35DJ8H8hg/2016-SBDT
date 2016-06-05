using System;
namespace DienTapLib
{
    public class CAppearDef : CActDef
    {
        public int steps;
        public float partial;
        public int repeat = 1;
        public bool stophide;
        public CAppearDef(string pActionType, string pName, string pObjName, string pstart, string pduration, int psteps, float ppartial, bool pstophide, string psoundname, bool loop, int prepeat)
        {
            this.Name = pName;
            this.ActionType = pActionType;
            this.ObjName = pObjName;
            this.start = pstart;
            this.duration = pduration;
            this.stophide = pstophide;
            this.steps = psteps;
            this.partial = ppartial;
            this.SoundName = psoundname;
            this.SoundLoop = loop;
            this.repeat = prepeat;
        }
        public override CActDef Clone()
        {
            return new CAppearDef(this.ActionType, this.Name, this.ObjName, this.start, this.duration, this.steps, this.partial, this.stophide, this.SoundName, this.SoundLoop, this.repeat);
        }
        public override string GetActionStr()
        {
            string text = "<Action ID=\"" + this.Name + "\"";
            text = text + " Type=\"" + this.ActionType + "\"";
            text = text + " ObjName=\"" + this.ObjName + "\"";
            text = text + " Start=\"" + this.start + "\"";
            text = text + " Duration=\"" + this.duration + "\"";
            text = text + " Steps=\"" + this.steps.ToString() + "\"";
            text = text + " Partial=\"" + this.partial.ToString() + "\"";
            text = text + " Hide=\"" + (this.stophide ? "true" : "false") + "\"";
            text = text + " SoundName=\"" + this.SoundName + "\"";
            text = text + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
            object obj = text;
            text = string.Concat(new object[]
			{
				obj,
				" Repeat=\"",
				this.repeat,
				"\""
			});
            return text + "></Action>\r\n";
        }
    }
}
