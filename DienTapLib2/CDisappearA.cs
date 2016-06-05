using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
	internal class CDisappearA : CDisappear
	{
		public CDisappearA(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, int pisound, bool loop) : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pisound, loop)
		{
		}
		protected override void RefreshTexture(int i)
		{
			Graphics graphics = this.RenderSurface.GetGraphics();
			int num = 255 - (int)((float)(i * 255) / (float)this.steps);
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
			}
			graphics.Clear(CHelper.clrColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			this.Obj.ObjSymbol.AplyAlpha(num);
			this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
			this.RenderSurface.ReleaseGraphics();
			graphics.Dispose();
		}
	}
}
