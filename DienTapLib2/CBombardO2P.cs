using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CBombardO2P : CBombard
	{
		public CBombardO2P(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, float pdAngle, CActObj pFromObj, Vector3 pTo, int pisound, bool loop) : base(pThucHanh, pName, texfile, pWidth, pHeight, start, pduration, pspeed, pdAngle, pFromObj, pTo, pisound, loop)
		{
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int num = pTickCount - this.StartTickCount;
				this.itime = base.GetNextTime(num);
				if (this.itime > this.lasttime)
				{
					this.lasttime = this.itime;
					this.Calc1();
				}
				int num2 = num % this.interval;
				this.SpriteObj.visible = true;
				this.itarget = base.GetNextTargetIndex(num2);
				double num3 = (double)(num2 - this.targets[this.itarget].TickCount) / (double)(this.targets[this.itarget + 1].TickCount - this.targets[this.itarget].TickCount);
				Vector3 left = this.targets[this.itarget + 1].Position - this.targets[this.itarget].Position;
				this.UpdateStatus(this.targets[this.itarget].Position + left * (float)num3, this.targets[this.itarget + 1].angleZ, this.targets[this.itarget + 1].angleX);
				return;
			}
			this.lasttime = 0;
			this.Calc1();
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.SpriteObj.visible = true;
		}
	}
}
