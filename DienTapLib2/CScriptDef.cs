using System;
namespace DienTapLib
{
	public class CScriptDef
	{
		public string id;
		public string scrptfile;
		public string mnuItemRef = "";
		public string start;
		public int StartTickCount;
		public int StopTickCount;
		public CScriptDef(string pid, string pscrptfile, string pmnuItemRef, string pstart)
		{
			this.scrptfile = pscrptfile;
			this.mnuItemRef = pmnuItemRef;
			this.start = pstart;
			this.id = pid;
			this.StartTickCount = 0;
			this.StopTickCount = 0;
		}
		public CScriptDef(string pid, string pscrptfile, string pmnuItemRef, string pstart, int pStartTickCount, int pStopTickCount)
		{
			this.scrptfile = pscrptfile;
			this.mnuItemRef = pmnuItemRef;
			this.start = pstart;
			this.id = pid;
			this.StartTickCount = pStartTickCount;
			this.StopTickCount = pStopTickCount;
		}
		public void UpdateStart(int pStart)
		{
			int num = pStart - this.StartTickCount;
			this.StartTickCount = pStart;
			this.StopTickCount += num;
		}
		public string GetScriptStr()
		{
			string str = "<Script";
			if (this.id.Length > 0)
			{
				str = str + " ID=\"" + this.id + "\"";
			}
			if (this.scrptfile.Length > 0)
			{
				str = str + " ScrptFile=\"" + this.scrptfile + "\"";
			}
			if (this.mnuItemRef.Length > 0)
			{
				str = str + " MnuItemRef=\"" + this.mnuItemRef + "\"";
			}
			str = str + " Start=\"" + this.start + "\"";
			return str + "> </Script>";
		}
	}
}
