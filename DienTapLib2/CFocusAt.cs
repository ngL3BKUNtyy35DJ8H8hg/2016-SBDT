using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CFocusAt : CAct
	{
		protected float CenterX;
		protected float CenterY;
		protected Vector3 cameraPos;
		protected float angleZ;
		protected float angleX;
		private float rAngleZ;
		private float rAngleX;
		private float rCenterX;
		private float rCenterY;
		private float rcameraPosY;
		private int LastTickCount;
		public CFocusAt(CThucHanh pThucHanh, string pName, int start, int pduration, float pCenterX, float pCenterY, Vector3 pcameraPos, float pangleZ, float pangleX) : base(pThucHanh)
		{
			this.Name = pName;
			this.cameraPos = pcameraPos;
			this.angleZ = pangleZ;
			this.angleX = pangleX;
			this.CenterX = pCenterX;
			this.CenterY = pCenterY;
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
			base.endaction();
		}
		private void Calc2()
		{
			CAct.NormAngle(ref this.myThucHanh.angleZ);
			this.rAngleZ = this.angleZ - this.myThucHanh.angleZ;
			CAct.NormAngle(ref this.rAngleZ);
			if (this.rAngleZ > 3.14159274f)
			{
				this.rAngleZ -= 6.28318548f;
			}
			CAct.NormAngle(ref this.myThucHanh.angleX);
			this.rAngleX = this.angleX - this.myThucHanh.angleX;
			CAct.NormAngle(ref this.rAngleX);
			if (this.rAngleX > 3.14159274f)
			{
				this.rAngleX -= 6.28318548f;
			}
			this.rCenterX = this.CenterX - this.myThucHanh.CenterX;
			this.rCenterY = this.CenterY - this.myThucHanh.CenterY;
			this.rcameraPosY = this.cameraPos.Y - this.myThucHanh.cameraPos.Y;
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int num = pTickCount - this.LastTickCount;
				this.LastTickCount += num;
				this.myThucHanh.angleZ += this.rAngleZ * (float)num / (float)this.duration;
				this.myThucHanh.angleX += this.rAngleX * (float)num / (float)this.duration;
				this.myThucHanh.CenterX += this.rCenterX * (float)num / (float)this.duration;
				this.myThucHanh.CenterY += this.rCenterY * (float)num / (float)this.duration;
				CThucHanh expr_B9_cp_0 = this.myThucHanh;
				expr_B9_cp_0.cameraPos.Y = expr_B9_cp_0.cameraPos.Y + this.rcameraPosY * (float)num / (float)this.duration;
				this.myThucHanh.cameraPos.Z = this.myThucHanh.cameraPos.Y / 2f;
				return;
			}
			if (this.duration > 0)
			{
				this.Calc2();
				this.LastTickCount = this.StartTickCount;
				this.started = true;
				return;
			}
			this.myThucHanh.ChangeFocus(this.CenterX, this.CenterY, this.cameraPos, this.angleZ, this.angleX);
		}
	}
}
