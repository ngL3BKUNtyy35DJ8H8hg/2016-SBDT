using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	internal class CExplodeBbObj : CExplodeObj
	{
		public CExplodeBbObj(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, float pShiftZ, int start, int pduration, float pspeed, CActObj pexplObj, int pisound, bool loop) : base(pThucHanh, pName, texfile, pWidth, pHeight, pShiftZ, start, pduration, pspeed, pexplObj, pisound, loop)
		{
		}
		protected override void GetSpritePos()
		{
			if (this.explObj != null)
			{
				Vector3 position = this.explObj.Position;
				position.Z -= ((CBillboard)this.explObj).BillboardMesh.ShiftZ;
				position.Z -= this.shiftZ;
				this.SpriteObj.Position = position;
			}
		}
	}
}
