using System;
namespace DienTapLib
{
	internal class CCornerTitle : CAct
	{
		protected string CornerText = "";
		public CCornerTitle(CThucHanh pThucHanh, string pName, int start, int pduration, string pCornerText) : base(pThucHanh)
		{
			this.Name = pName;
			this.CornerText = pCornerText;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		public override void Reset()
		{
			this.done = false;
			this.started = false;
		}
		public override void Stop()
		{
			if (this.duration != 0)
			{
				this.myThucHanh.MenuTitleText = "";
				base.endaction();
			}
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				return;
			}
			this.myThucHanh.MenuTitleText = this.CornerText;
			this.started = true;
		}
	}
}
