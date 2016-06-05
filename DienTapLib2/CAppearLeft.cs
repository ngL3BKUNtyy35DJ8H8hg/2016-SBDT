using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
    internal class CAppearLeft : CAppear
    {
        public CAppearLeft(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, bool pstophide, int pisound, bool loop)
            : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pstophide, pisound, loop)
        {
        }
        protected override void RefreshTexture(int i)
        {
            Graphics graphics = this.RenderSurface.GetGraphics();
            float width = (float)this.ImageWidth * this.partial;
            float num = (float)this.ImageWidth * (float)i / (float)this.steps;
            RectangleF clip = new RectangleF((float)(this.Obj.PixelsPerGridX + this.ImageWidth) - num, 0f, width, (float)this.Obj.ImageHeight);
            graphics.Clear(CHelper.clrColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.SetClip(clip);
            this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
            this.RenderSurface.ReleaseGraphics();
            graphics.Dispose();
        }
    }
}
