using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CSpinToBB : CAct
	{
		protected CBillboard Obj;
		private Vector3 topos;
		private float rAngleZ;
		private int LastTickCount;
		public CSpinToBB(CThucHanh pThucHanh, string pName, CBillboard pObj, int start, int pduration, Vector3 ptopos, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.topos = ptopos;
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
			this.started = false;
		}
		public override void Stop()
		{
			this.Obj.angleZ = CAct.GetAngleZ(this.topos - this.Obj.Position);
			this.Obj.visible = true;
			base.endaction();
		}
		private void Calc2()
		{
			CAct.NormAngle(ref this.Obj.angleZ);
			this.rAngleZ = CAct.GetAngleZ(this.topos - this.Obj.Position) - this.Obj.angleZ;
			CAct.NormAngle(ref this.rAngleZ);
			if (this.rAngleZ > 3.14159274f)
			{
				this.rAngleZ -= 6.28318548f;
			}
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int num = pTickCount - this.LastTickCount;
				this.LastTickCount += num;
				this.Obj.angleZ += this.rAngleZ * (float)num / (float)this.duration;
				return;
			}
			if (this.duration > 0)
			{
				this.Calc2();
				this.LastTickCount = this.StartTickCount;
				this.started = true;
				this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
				this.Obj.visible = true;
				return;
			}
			this.Stop();
		}
	}
}
