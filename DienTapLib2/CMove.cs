using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	internal class CMove : CAct
	{
		protected CActObj Obj;
		protected List<CTarget> targets;
		protected bool stophide;
		protected float stopangleZ;
		protected int itarget;
		protected int targetsCount;
		private float ftotallen;
		public CMove(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, List<Vector3> ptargets, bool pstophide, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.stophide = pstophide;
			this.targets = new List<CTarget>();
			foreach (Vector3 current in ptargets)
			{
				CTarget cTarget = new CTarget();
				cTarget.Position = current;
				if (cTarget.Position.Z == 0f)
				{
					cTarget.Position.Z = this.myThucHanh.myTerrain.getZ(current.X, current.Y);
				}
				this.targets.Add(cTarget);
			}
			this.targetsCount = this.targets.Count;
			this.SetTickCount();
			this.itarget = 0;
			this.done = false;
			this.isound = pisound;
			this.soundloop = loop;
		}
		public CMove(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, List<Vector3> ptargets, bool pstophide, float pdstopangleZ, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
			this.Obj = pObj;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.stophide = pstophide;
			this.stopangleZ = Geometry.DegreeToRadian(pdstopangleZ);
			this.targets = new List<CTarget>();
			foreach (Vector3 current in ptargets)
			{
				CTarget cTarget = new CTarget();
				cTarget.Position = current;
				if (cTarget.Position.Z == 0f)
				{
					cTarget.Position.Z = this.myThucHanh.myTerrain.getZ(current.X, current.Y);
				}
				this.targets.Add(cTarget);
			}
			this.targetsCount = this.targets.Count;
			this.SetTickCount();
			this.itarget = 0;
			this.done = false;
			this.isound = pisound;
			this.soundloop = loop;
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		private void SetTickCount()
		{
			if (this.targetsCount > 1)
			{
				for (int i = 1; i < this.targetsCount; i++)
				{
					Vector3 addvector = this.targets[i].Position - this.targets[i - 1].Position;
					this.targets[i].len = addvector.Length();
					this.ftotallen += this.targets[i].len;
					if (this.targets[i].len > 0f)
					{
						this.targets[i].angleZ = CAct.GetAngleZ(addvector);
						this.targets[i].angleX = CAct.GetAngleX(addvector);
					}
					else
					{
						this.targets[i].angleZ = this.targets[i - 1].angleZ;
						this.targets[i].angleX = this.targets[i - 1].angleX;
					}
				}
				this.targets[0].TickCount = 0;
				float num = 0f;
				for (int j = 1; j < this.targetsCount; j++)
				{
					num += this.targets[j].len;
					if (this.ftotallen > 0f)
					{
						this.targets[j].TickCount = (int)Math.Floor((double)(num * (float)this.duration) / (double)this.ftotallen);
					}
					else
					{
						this.targets[j].TickCount = this.duration;
					}
				}
			}
		}
		private void ReSetAngles()
		{
			if (this.targetsCount > 1)
			{
				this.targets[0].angleZ = this.Obj.angleZ;
				this.targets[0].angleX = this.Obj.angleX;
				if (this.ftotallen == 0f)
				{
					for (int i = 1; i < this.targetsCount; i++)
					{
						this.targets[i].angleZ = this.targets[i - 1].angleZ;
						this.targets[i].angleX = this.targets[i - 1].angleX;
					}
				}
			}
		}
		public override void Reset()
		{
			this.UpdateStatus(this.targets[0].Position, this.targets[1].angleZ, this.targets[1].angleX);
			this.done = false;
			this.Obj.visible = true;
			this.started = false;
		}
		public override void Stop()
		{
			this.UpdateStatus(this.targets[this.targetsCount - 1].Position, this.targets[this.targetsCount - 1].angleZ, this.targets[this.targetsCount - 1].angleX);
			if (this.Obj.ObjType == "Billboard")
			{
				((CBillboard)this.Obj).SetAnimation(false);
			}
			if (this.stophide)
			{
				this.Obj.visible = false;
			}
			else
			{
				this.Obj.visible = true;
			}
			base.endaction();
		}
		protected virtual void UpdateStatus(Vector3 pPos, float pangleZ, float pangleX)
		{
			this.Obj.Position = pPos;
			this.Obj.Position.Z = this.myThucHanh.myTerrain.getZ(this.Obj.Position.X, this.Obj.Position.Y);
			this.Obj.angleZ = pangleZ;
			this.Obj.angleX = pangleX;
		}
		private int GetNextTargetIndex(int pTickCount)
		{
			int num = 0;
			for (int i = 0; i < this.targetsCount; i++)
			{
				if (this.targets[i].TickCount > pTickCount)
				{
					num = i - 1;
					break;
				}
			}
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int num = pTickCount - this.StartTickCount;
				this.itarget = this.GetNextTargetIndex(num);
				double num2 = (double)(num - this.targets[this.itarget].TickCount) / (double)(this.targets[this.itarget + 1].TickCount - this.targets[this.itarget].TickCount);
				Vector3 left = this.targets[this.itarget + 1].Position - this.targets[this.itarget].Position;
				Vector3 pPos = this.targets[this.itarget].Position + left * (float)num2;
				this.UpdateStatus(pPos, this.targets[this.itarget + 1].angleZ, this.targets[this.itarget + 1].angleX);
				return;
			}
			this.ReSetAngles();
			if (this.Obj.ObjType == "Billboard")
			{
				((CBillboard)this.Obj).SetAnimation(true);
			}
			this.UpdateStatus(this.targets[0].Position, this.targets[0].angleZ, this.targets[0].angleX);
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.Obj.visible = true;
		}
	}
}
