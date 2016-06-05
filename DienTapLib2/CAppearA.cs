using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
    internal class CAppearA : CAppear
    {
        public CAppearA(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, bool pstophide, int pisound, bool loop)
            : base(pThucHanh, pName, pObj, start, pduration, psteps, pPartial, pstophide, pisound, loop)
        {
        }
        protected override void RefreshTexture(int i)
        {
            Graphics graphics = this.RenderSurface.GetGraphics();
            int num = (int)((float)(i * 254) / (float)this.steps);
            if (num < 0)
            {
                num = 0;
            }
            if (num > 254)
            {
                num = 254;
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
