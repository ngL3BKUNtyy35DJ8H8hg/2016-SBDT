using Microsoft.DirectX;
using System;
namespace DienTapLib
{
    public class CBombardFromDef : CActDef
    {
        public float speed;
        public string imagefile;
        public float width;
        public float height;
        public float dAngle = -45f;
        public Vector3 frompos;
        public Vector3 topos;
        public string ExplID;
        public int repeat = 1;
        public CBombardFromDef(string pActionType, string pName, string texfile, float pWidth, float pHeight, string pstart, string pduration, float pspeed, float pdAngle, Vector3 pFromPos, Vector3 pTo, string psoundname, bool loop, string explid, int prepeat)
        {
            this.Name = pName;
            this.ActionType = pActionType;
            this.imagefile = texfile;
            this.width = pWidth;
            this.height = pHeight;
            this.start = pstart;
            this.duration = pduration;
            this.speed = pspeed;
            this.dAngle = pdAngle;
            this.ObjName = "";
            this.frompos = pFromPos;
            this.topos = pTo;
            this.SoundName = psoundname;
            this.SoundLoop = loop;
            this.ExplID = explid;
            this.repeat = prepeat;
        }
        public CBombardFromDef(string pActionType, string pName, string texfile, float pWidth, float pHeight, string pstart, string pduration, float pspeed, float pdAngle, string pObjName, Vector3 pTo, string psoundname, bool loop, string explid, int prepeat)
        {
            this.Name = pName;
            this.ActionType = pActionType;
            this.imagefile = texfile;
            this.width = pWidth;
            this.height = pHeight;
            this.start = pstart;
            this.duration = pduration;
            this.speed = pspeed;
            this.dAngle = pdAngle;
            this.ObjName = pObjName;
            this.topos = pTo;
            this.SoundName = psoundname;
            this.SoundLoop = loop;
            this.ExplID = explid;
            this.repeat = prepeat;
        }
        public override CActDef Clone()
        {
            if (this.ObjName.Length > 0)
            {
                return new CBombardFromDef(this.ActionType, this.Name, this.imagefile, this.width, this.height, this.start, this.duration, this.speed, this.dAngle, this.ObjName, this.topos, this.SoundName, this.SoundLoop, this.ExplID, this.repeat);
            }
            return new CBombardFromDef(this.ActionType, this.Name, this.imagefile, this.width, this.height, this.start, this.duration, this.speed, this.dAngle, this.frompos, this.topos, this.SoundName, this.SoundLoop, this.ExplID, this.repeat);
        }
        public override string GetActionStr()
        {
            string text = "<Action ID=\"" + this.Name + "\"";
            text = text + " Type=\"" + this.ActionType + "\"";
            if (this.ObjName.Length > 0)
            {
                text = text + " ObjName=\"" + this.ObjName + "\"";
            }
            text = text + " ImageFile=\"" + this.imagefile + "\"";
            text = text + " Width=\"" + this.width.ToString() + "\"";
            text = text + " Height=\"" + this.height.ToString() + "\"";
            text = text + " Start=\"" + this.start + "\"";
            text = text + " Duration=\"" + this.duration + "\"";
            text = text + " Speed=\"" + this.speed.ToString() + "\"";
            text = text + " dAngle=\"" + this.dAngle.ToString() + "\"";
            text = text + " SoundName=\"" + this.SoundName + "\"";
            text = text + " SoundLoop=\"" + (this.SoundLoop ? "1" : "0") + "\"";
            text = text + " ExplID=\"" + this.ExplID + "\"";
            object obj = text;
            text = string.Concat(new object[]
			{
				obj,
				" Repeat=\"",
				this.repeat,
				"\""
			});
            text += ">\r\n";
            if (this.ObjName.Length == 0)
            {
                text += "<From";
                text = text + " X=\"" + this.frompos.X.ToString() + "\"";
                text = text + " Y=\"" + this.frompos.Y.ToString() + "\"";
                text = text + " Z=\"" + this.frompos.Z.ToString() + "\"";
                text += ">";
                text += "</From>\r\n";
            }
            text += "<Target";
            text = text + " X=\"" + this.topos.X.ToString() + "\"";
            text = text + " Y=\"" + this.topos.Y.ToString() + "\"";
            text = text + " Z=\"" + this.topos.Z.ToString() + "\"";
            text += ">";
            text += "</Target>\r\n";
            return text + "</Action>\r\n";
        }
    }
}
