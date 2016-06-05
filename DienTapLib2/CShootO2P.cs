using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CShootO2P : CShoot
	{
		protected int itime;
		protected int lasttime;
		private int interval = 1;
		public CShootO2P(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, CActObj pFromObj, Vector3 pTo, int pisound, bool loop) : base(pThucHanh, pName, texfile, pWidth, pHeight, start, pduration, pspeed, pFromObj, pTo, pisound, loop)
		{
			this.interval = (int)(this.speed * 1000f);
		}
		private int GetNextTime(int currTickCount0)
		{
			int num = this.lasttime;
			while (!(currTickCount0 > num * this.interval & currTickCount0 <= (num + 1) * this.interval))
			{
				num++;
			}
			return num;
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int currTickCount = pTickCount - this.StartTickCount;
				this.itime = this.GetNextTime(currTickCount);
				if (this.itime > this.lasttime)
				{
					this.lasttime = this.itime;
					this.Calc2();
				}
				int num = (pTickCount - this.StartTickCount) % this.to2.TickCount;
				double num2 = (double)num / (double)this.to2.TickCount;
				this.SpriteObj.Position = this.from2.Position + this.addvector * (float)num2;
				return;
			}
			this.Calc2();
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.SpriteObj.visible = true;
		}
	}
}
