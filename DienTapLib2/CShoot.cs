using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CShoot : CAct
	{
		protected CSpriteObj SpriteObj;
		protected float speed;
		protected CActObj fromObj;
		protected Vector3 frompos;
		protected Vector3 topos;
		protected CTarget from2;
		protected CTarget to2;
		protected Vector3 addvector;
		private bool NeedShiftZ;
		private Vector3 origtopos;
		public CShoot(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, Vector3 pFromPos, Vector3 pTo, int pisound, bool loop) : base(pThucHanh)
		{
            this.Name = pName;
			this.frompos = pFromPos;
			this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 0, this.frompos, 0f);
			this.origtopos = pTo;
			if (this.origtopos.Z == 0f & this.frompos.Z == 0f)
			{
				this.NeedShiftZ = true;
			}
			if (this.origtopos.Z == 0f)
			{
				this.origtopos.Z = this.myThucHanh.myTerrain.getZ(this.origtopos.X, this.origtopos.Y);
			}
			this.StartTickCount = start;
			this.duration = pduration;
			this.speed = pspeed;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.from2 = new CTarget();
			this.to2 = new CTarget();
			this.Calc2();
			this.isound = pisound;
			this.soundloop = loop;
		}
		public CShoot(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, int start, int pduration, float pspeed, CActObj pFromObj, Vector3 pTo, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.fromObj = pFromObj;
			this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 0, this.fromObj.Position, 0f);
			this.origtopos = pTo;
			if (this.origtopos.Z == 0f & this.frompos.Z == 0f)
			{
				this.NeedShiftZ = true;
			}
			if (this.origtopos.Z == 0f)
			{
				this.origtopos.Z = this.myThucHanh.myTerrain.getZ(this.origtopos.X, this.origtopos.Y);
			}
			this.StartTickCount = start;
			this.duration = pduration;
			this.speed = pspeed;
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
		protected virtual void Calc2()
		{
			this.setfrompos();
			this.addvector = this.topos - this.frompos;
			float num = this.addvector.Length();
			float right = this.SpriteObj.Length / (num * 2f);
			this.from2.Position = this.frompos + this.addvector * right;
			this.to2.Position = this.topos - this.addvector * right;
			this.from2.TickCount = 0;
			this.to2.TickCount = (int)(this.speed * 1000f);
			this.SpriteObj.angleZ = CAct.GetAngleZ(this.addvector);
			this.SpriteObj.angleX = CAct.GetAngleX(this.addvector);
			this.addvector = this.to2.Position - this.from2.Position;
		}
		protected virtual void setfrompos()
		{
			this.topos = this.origtopos;
			if (this.fromObj != null)
			{
				this.frompos = this.fromObj.Position;
			}
			if (this.frompos.Z == 0f)
			{
				this.frompos.Z = this.myThucHanh.myTerrain.getZ(this.frompos.X, this.frompos.Y);
			}
			if (this.NeedShiftZ)
			{
				float shiftZ = this.getShiftZ();
				if (shiftZ != 0f)
				{
					this.topos.Z = this.topos.Z - (shiftZ + 0.1f);
					this.frompos.Z = this.frompos.Z - (shiftZ + 0.1f);
				}
			}
		}
		private float getShiftZ()
		{
			float num = 0f;
			this.addvector = this.topos - this.frompos;
			float num2 = this.addvector.Length();
			int num3 = (int)(num2 * 3f);
			for (int i = 0; i < num3; i++)
			{
				Vector3 vector = this.frompos + this.addvector * ((float)i / (float)num3);
				float z = this.myThucHanh.myTerrain.getZ(vector.X, vector.Y);
				if (vector.Z > z && num < vector.Z - z)
				{
					num = vector.Z - z;
				}
			}
			return num;
		}
		public override void Reset()
		{
			this.SpriteObj.visible = false;
			this.done = false;
			this.started = false;
		}
		public override void Stop()
		{
			this.SpriteObj.visible = false;
			base.endaction();
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int num = (pTickCount - this.StartTickCount) % this.to2.TickCount;
				double num2 = (double)num / (double)this.to2.TickCount;
				this.SpriteObj.Position = this.from2.Position + this.addvector * (float)num2;
				return;
			}
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.SpriteObj.visible = true;
		}
	}
}
