using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
	internal class CDisappearDown : CDisappear
	{
		public CDisappearDown(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, int pisound, bool loop) : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pisound, loop)
		{
		}
		protected override void RefreshTexture(int i)
		{
			Graphics graphics = this.RenderSurface.GetGraphics();
			float num = (float)this.ImageHeight * this.partial;
			float num2 = num * (float)i / (float)this.steps;
			RectangleF clip = new RectangleF(0f, (float)(this.Obj.PixelsPerGridY + this.ImageHeight) - num + num2, (float)this.Obj.ImageWidth, num - num2);
			graphics.Clear(CHelper.clrColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.SetClip(clip);
			this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
			this.RenderSurface.ReleaseGraphics();
			graphics.Dispose();
		}
	}
}
