using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
    internal class CAppearDown : CAppear
    {
        public CAppearDown(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, bool pstophide, int pisound, bool loop)
            : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pstophide, pisound, loop)
        {
        }
        protected override void RefreshTexture(int i)
        {
            Graphics graphics = this.RenderSurface.GetGraphics();
            float num = (float)this.ImageHeight * this.partial;
            float num2 = (float)this.ImageHeight * (float)i / (float)this.steps;
            RectangleF clip = new RectangleF(0f, (float)this.Obj.PixelsPerGridY + num2 - num, (float)this.Obj.ImageWidth, num);
            graphics.Clear(CHelper.clrColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.SetClip(clip);
            this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
            this.RenderSurface.ReleaseGraphics();
            graphics.Dispose();
        }
    }
}
