using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	public class CFocusAtDef : CActDef
	{
		public float CenterX;
		public float CenterY;
		public Vector3 cameraPos;
		public float angleZ;
		public float angleX;
		public CFocusAtDef(string pActionType, string pName, string pstart, string pduration, float pCenterX, float pCenterY, Vector3 pcameraPos, float pangleZ, float pangleX)
		{
			this.Name = pName;
			this.ActionType = pActionType;
			this.start = pstart;
			this.duration = pduration;
			this.cameraPos = pcameraPos;
			this.angleZ = pangleZ;
			this.angleX = pangleX;
			this.CenterX = pCenterX;
			this.CenterY = pCenterY;
		}
		public override CActDef Clone()
		{
			return new CFocusAtDef(this.ActionType, this.Name, this.start, this.duration, this.CenterX, this.CenterY, this.cameraPos, this.angleZ, this.angleX);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			str = str + " Start=\"" + this.start + "\"";
			str = str + " Duration=\"" + this.duration + "\"";
			str = str + " CenterX=\"" + this.CenterX.ToString() + "\"";
			str = str + " CenterY=\"" + this.CenterY.ToString() + "\"";
			str = str + " cameraPosX=\"" + this.cameraPos.X.ToString() + "\"";
			str = str + " cameraPosY=\"" + this.cameraPos.Y.ToString() + "\"";
			str = str + " cameraPosZ=\"" + this.cameraPos.Z.ToString() + "\"";
			str = str + " angleZ=\"" + this.angleZ.ToString() + "\"";
			str = str + " angleX=\"" + this.angleX.ToString() + "\"";
			return str + "></Action>\r\n";
		}
	}
}
