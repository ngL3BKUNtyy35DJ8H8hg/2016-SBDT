using System;
namespace DienTapLib
{
	internal class CHide : CAct
	{
		protected CActObj Obj;
		public CHide(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
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
			this.Obj.visible = true;
			this.started = false;
		}
		public override void Stop()
		{
			this.Obj.visible = false;
			base.endaction();
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				return;
			}
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.Obj.visible = true;
		}
	}
}
