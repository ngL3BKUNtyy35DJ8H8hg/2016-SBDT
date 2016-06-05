using Microsoft.DirectX;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	internal class CFly : CMove
	{
		public CFly(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, List<Vector3> ptargets, bool pstophide, int pisound, bool loop) : base(pThucHanh, pName, pObj, start, pduration, ptargets, pstophide, pisound, loop)
		{
		}
		public override void Stop()
		{
			this.UpdateStatus(this.targets[this.targetsCount - 1].Position, this.targets[this.targetsCount - 1].angleZ, this.targets[this.targetsCount - 1].angleX);
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
		protected override void UpdateStatus(Vector3 pPos, float pangleZ, float pangleX)
		{
			this.Obj.Position = pPos;
			this.Obj.angleZ = pangleZ;
			this.Obj.angleX = pangleX;
		}
	}
}
