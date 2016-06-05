using System;
namespace DienTapLib
{
    public class CActDef
    {
        public string Name = "";
        public string ActionType = "";
        public string start = "0";
        public string duration = "0";
        public string ObjName = "";
        public string SoundName = "";
        public bool SoundLoop;
        public virtual string GetActionStr()
        {
            return "";
        }
        public override string ToString()
        {
            return string.Concat(new string[]
			{
				"ID='",
				this.Name,
				"' Act='",
				this.ActionType,
				"' Start='",
				this.start,
				"' Obj='",
				this.ObjName,
				"' Sound='",
				this.SoundName,
				"' Duration='",
				this.duration,
				"'"
			});
        }
        public virtual CActDef Clone()
        {
            return new CActDef();
        }
    }
}
