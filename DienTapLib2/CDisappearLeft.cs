using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
	internal class CDisappearLeft : CDisappear
	{
		public CDisappearLeft(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, int pisound, bool loop) : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pisound, loop)
		{
		}
		protected override void RefreshTexture(int i)
		{
			Graphics graphics = this.RenderSurface.GetGraphics();
			float num = (float)this.ImageWidth * this.partial;
			float num2 = num * (float)i / (float)this.steps;
			RectangleF clip = new RectangleF((float)this.Obj.PixelsPerGridX, 0f, num - num2, (float)this.Obj.ImageHeight);
			graphics.Clear(CHelper.clrColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.SetClip(clip);
			this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
			this.RenderSurface.ReleaseGraphics();
			graphics.Dispose();
		}
	}
}
