using Microsoft.DirectX.Direct3D;
using System;
namespace DienTapLib
{
	internal class CSpin : CAct
	{
		protected CModel Obj;
		private float dAngleZ = 5f;
		private float rAngleZ;
		private int LastTickCount;
		private float saveAngleZ;
		public CSpin(CThucHanh pThucHanh, string pName, CModel pObj, int start, int pduration, float pAngleZ, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.dAngleZ = pAngleZ;
			this.rAngleZ = Geometry.DegreeToRadian(this.dAngleZ);
			this.saveAngleZ = this.Obj.angleZ;
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
			this.Obj.angleZ = this.saveAngleZ + this.rAngleZ;
			this.Obj.visible = true;
			base.endaction();
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
