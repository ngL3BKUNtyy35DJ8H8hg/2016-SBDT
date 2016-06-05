using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
namespace DienTapLib
{
	public class CMnuItem
	{
		public string id;
		public string Name;
		public string Title;
		public int PosX;
		public int PosY;
		public int Width = 40;
		public int Height = 10;
		public List<CScriptDef> ScriptDefs;
		public CMnuItem(string pid, string pName, string pTitle, int pPosX, int pPosY, int pWidth, int pHeight, List<CScriptDef> pScriptDefs)
		{
			this.id = pid;
			this.Name = pName;
			this.Title = pTitle;
			this.PosX = pPosX;
			this.PosY = pPosY;
			this.Width = pWidth;
			this.Height = pHeight;
			this.ScriptDefs = pScriptDefs;
		}
		public override string ToString()
		{
			return this.Name;
		}
		public void Draw(Microsoft.DirectX.Direct3D.Font pText, Color textColor)
		{
			if (this.PosX != 0 || this.PosY != 0)
			{
				pText.DrawText(null, this.Name, new Point(this.PosX, this.PosY), textColor);
			}
		}
		public bool Hit(int pPosX, int pPosY, float tyleMH)
		{
			bool result = false;
			if ((this.PosX != 0 || this.PosY != 0) && (float)pPosX > (float)this.PosX * tyleMH && (float)pPosX < (float)(this.PosX + this.Width) * tyleMH && (float)pPosY > (float)this.PosY * tyleMH && (float)pPosY < (float)(this.PosY + this.Height) * tyleMH)
			{
				result = true;
			}
			return result;
		}
		public string GetItemStr()
		{
			string str = "<MnuItem Name=\"" + this.Name + "\"";
			if (this.id.Length > 0)
			{
				str = str + " ID=\"" + this.id + "\"";
			}
			str = str + " PosX=\"" + this.PosX.ToString() + "\"";
			str = str + " PosY=\"" + this.PosY.ToString() + "\"";
			str = str + " Width=\"" + this.Width.ToString() + "\"";
			str = str + " Height=\"" + this.Height.ToString() + "\"";
			str = str + " Title=\"" + this.Title + "\"";
			return str + "></MnuItem>\r\n";
		}
	}
}
