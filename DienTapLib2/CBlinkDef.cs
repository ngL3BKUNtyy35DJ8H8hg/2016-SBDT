using System;
namespace DienTapLib
{
    public class CBlinkDef : CActDef
    {
        public float speed;
        public CBlinkDef(string pActionType, string pName, string pObjName, string pstart, string pduration, float pspeed, string psoundname, bool loop)
        {
            this.Name = pName;
            this.ActionType = pActionType;
            this.ObjName = pObjName;
            this.start = pstart;
            this.duration = pduration;
            this.speed = pspeed;
            this.SoundName = psoundname;
            this.SoundLoop = loop;
        }
        public override CActDef Clone()
        {
            return new CBlinkDef(this.ActionType, this.Name, this.ObjName, this.start, this.duration, this.speed, this.SoundName, this.SoundLoop);
        }
        public override string GetActionStr()
        {
            string str = "<Action ID=\"" + this.Name + "\"";
            str = str + " Type=\"" + this.ActionType + "\"";
            str = str + " ObjName=\"" + this.ObjName + "\"";
            str = str + " Start=\"" + this.start + "\"";
            str = str + " Duration=\"" + this.duration + "\"";
            str = str + " Speed=\"" + this.speed.ToString() + "\"";
            str = str + " SoundName=\"" + this.SoundName + "\"";
            str = str + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
            return str + "></Action>\r\n";
        }
    }
}
