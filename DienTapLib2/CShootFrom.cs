using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CShootFrom : CAct
	{
		protected CSpriteObj SpriteObj;
		protected float speed;
		protected CActObj fromObj;
		protected Vector3 topos;
		private Vector3 frompos;
		private CTarget from2;
		private CTarget to2;
		private int tickcount;
		public CShootFrom(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, CActObj pFromObj, Vector3 pTo, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.fromObj = pFromObj;
			this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 0, this.fromObj.Position, 0f);
			this.topos = pTo;
			if (pTo.Z == 0f)
			{
				this.topos.Z = this.myThucHanh.myTerrain.getZ(this.topos.X, this.topos.Y) - 0.2f;
			}
			this.StartTickCount = start;
			this.duration = pduration;
			this.speed = pspeed;
			this.tickcount = (int)(this.speed * 1000f);
			this.StopTickCount = this.StartTickCount + this.duration;
			this.from2 = new CTarget();
			this.to2 = new CTarget();
			this.isound = pisound;
			this.soundloop = loop;
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		protected virtual void setfrompos()
		{
			if (this.fromObj != null)
			{
				this.frompos = this.fromObj.Position;
			}
			if (this.frompos.Z == 0f)
			{
				this.frompos.Z = this.myThucHanh.myTerrain.getZ(this.frompos.X, this.frompos.Y) - 1f;
			}
			this.from2.Position = this.frompos;
		}
		public override void Reset()
		{
			this.SpriteObj.visible = false;
			this.done = false;
			this.to2.Position = this.topos;
			this.to2.TickCount = 0;
			this.setfrompos();
			this.started = false;
		}
		public override void Stop()
		{
			this.SpriteObj.visible = false;
			base.endaction();
		}
		protected virtual void Calc2()
		{
			this.setfrompos();
			float z = this.myThucHanh.myTerrain.getZ(this.from2.Position.X, this.from2.Position.Y);
			if (this.from2.Position.Z == 0f)
			{
				this.from2.Position.Z = z;
			}
			if (this.from2.Position.Z >= z)
			{
				CTarget expr_7D_cp_0 = this.from2;
				expr_7D_cp_0.Position.Z = expr_7D_cp_0.Position.Z - 0.4f;
			}
			this.from2.TickCount = this.to2.TickCount;
			Vector3 addvector = this.to2.Position - this.from2.Position;
			this.to2.TickCount += this.tickcount;
			this.SpriteObj.angleZ = CAct.GetAngleZ(addvector);
			this.SpriteObj.angleX = CAct.GetAngleX(addvector);
		}
		public override void UpdateAct(int pTickCount)
		{
			if (!this.started)
			{
				this.to2.Position = this.topos;
				this.to2.TickCount = 0;
				this.setfrompos();
				this.Calc2();
				this.started = true;
				this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
				this.SpriteObj.visible = true;
				return;
			}
			int num = pTickCount - this.StartTickCount;
			if (num < this.to2.TickCount)
			{
				double num2 = (double)(num - this.from2.TickCount) / (double)(this.to2.TickCount - this.from2.TickCount);
				Vector3 left = this.to2.Position - this.from2.Position;
				this.SpriteObj.Position = this.from2.Position + left * (float)num2;
				return;
			}
			this.Calc2();
		}
	}
}
