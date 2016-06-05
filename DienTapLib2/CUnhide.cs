using System;
namespace DienTapLib
{
	internal class CUnhide : CAct
	{
		protected CActObj Obj;
		protected bool stophide;
		public CUnhide(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, bool pstophide, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
			this.stophide = pstophide;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.isound = pisound;
			this.soundloop = loop;
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		public override void Reset()
		{
			this.done = false;
			this.Obj.visible = false;
			this.started = false;
		}
		public override void Stop()
		{
			this.Obj.visible = true;
			base.endaction();
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				return;
			}
			if (this.duration > 0)
			{
				this.started = true;
				this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
				this.Obj.visible = true;
				return;
			}
			this.Stop();
		}
	}
}
