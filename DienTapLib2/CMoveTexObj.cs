using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	internal class CMoveTexObj : CMove
	{
		private int fineness = 10;
		public CMoveTexObj(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, List<Vector3> ptargets, bool pstophide, int pisound, bool loop) : base(pThucHanh, pName, pObj, start, pduration, ptargets, pstophide, pisound, loop)
		{
			this.IniObj();
		}
		private void IniObj()
		{
			if (((CTexObj)this.Obj).texs.Count <= 1)
			{
				this.GetTexs();
			}
		}
		private void GetTexs()
		{
			int num = this.fineness;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Texture texture = ((CTexObj)this.Obj).getTexture(i, j, num);
					if (i != 0 || j != 0)
					{
						((CTexObj)this.Obj).texs.Add(texture);
					}
				}
			}
		}
		private void GetNewTex(float pPosX, float pPosY)
		{
			int num = (int)Math.Floor((double)pPosX);
			int num2 = (int)Math.Floor((double)pPosY);
			int num3 = (int)Math.Floor(((double)pPosX - (double)num) * (double)this.fineness);
			int num4 = (int)Math.Floor(((double)pPosY - (double)num2) * (double)this.fineness);
			((CTexObj)this.Obj).UpdateTexture(((CTexObj)this.Obj).texs[num4 * this.fineness + num3]);
			((CTexObj)this.Obj).Updatedd(num4, num3, this.fineness);
		}
		protected override void UpdateStatus(Vector3 pPos, float pangleZ, float pangleX)
		{
			((CTexObj)this.Obj).UpdateMesh(pPos.X, pPos.Y);
			this.GetNewTex(pPos.X, pPos.Y);
		}
	}
}
