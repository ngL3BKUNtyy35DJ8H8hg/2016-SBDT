using System;
namespace DienTapLib
{
	public class CCommentDef : CActDef
	{
		public CCommentDef(string pComment)
		{
			this.ActionType = "Comment";
			this.Name = pComment;
		}
		public override string ToString()
		{
			return this.Name;
		}
		public override CActDef Clone()
		{
			return new CCommentDef(this.Name);
		}
		public override string GetActionStr()
		{
			string str = "<Action ID=\"" + this.Name + "\"";
			str = str + " Type=\"" + this.ActionType + "\"";
			return str + "></Action>\r\n";
		}
	}
}
