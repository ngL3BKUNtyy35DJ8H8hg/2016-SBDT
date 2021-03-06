using Microsoft.DirectX.Direct3D;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DienTapLib
{
    internal class CAppear : CAct
    {
        protected CTexObj Obj;
        protected int steps;
        protected float partial = 1f;
        protected int interval;
        protected int iLastStep;
        protected Surface RenderSurface;
        protected int ImageWidth;
        protected int ImageHeight;
        protected bool stophide;
        public CAppear(CThucHanh pThucHanh, string pName, CTexObj pObj, int start, int pduration, int psteps, float pPartial, bool pstophide, int pisound, bool loop)
            : base(pThucHanh)
        {
            this.Name = pName;
            this.Obj = pObj;
            this.RenderSurface = this.Obj.GetRenderSurface();
            this.StartTickCount = start;
            this.duration = pduration;
            this.stophide = pstophide;
            this.steps = psteps;
            if (this.steps < 1)
            {
                this.steps = 1;
            }
            this.partial = pPartial;
            if (this.partial < 0.1f)
            {
                this.partial = 0.1f;
            }
            if (this.partial > 1f)
            {
                this.partial = 1f;
            }
            this.StopTickCount = this.StartTickCount + this.duration;
            this.interval = this.duration / this.steps;
            this.ImageWidth = this.Obj.ImageWidth - 2 * this.Obj.PixelsPerGridX;
            this.ImageHeight = this.Obj.ImageHeight - 2 * this.Obj.PixelsPerGridY;
            this.done = false;
            this.isound = pisound;
            this.soundloop = loop;
            this.iLastStep = 0;
        }
        protected virtual void RefreshTexture(int i)
        {
            Graphics graphics = this.RenderSurface.GetGraphics();
            float num = (float)this.ImageWidth * this.partial;
            float num2 = (float)this.ImageWidth * (float)i / (float)this.steps;
            RectangleF clip = new RectangleF((float)this.Obj.PixelsPerGridX + num2 - num, 0f, num, (float)this.Obj.ImageHeight);
            graphics.Clear(CHelper.clrColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.SetClip(clip);
            this.Obj.ObjSymbol.Draw(graphics, this.Obj.ddx, this.Obj.ddy);
            this.RenderSurface.ReleaseGraphics();
            graphics.Dispose();
        }
        public override void Reset()
        {
            this.Obj.visible = false;
            this.done = false;
            this.iLastStep = 0;
            if (this.duration > 0)
            {
                this.RefreshTexture(0);
            }
            else
            {
                this.RefreshTexture(this.steps);
            }
            this.started = false;
        }
        public override void Stop()
        {
            this.RefreshTexture(this.steps);
            this.Obj.visible = true;
            base.endaction();
        }
        public override void UpdateAct(int pTickCount)
        {
            if (this.started)
            {
                int num = (pTickCount - this.StartTickCount) / this.interval;
                if (num > this.steps)
                {
                    num = this.steps;
                }
                if (num > this.iLastStep)
                {
                    this.RefreshTexture(num);
                    this.iLastStep = num;
                    return;
                }
            }
            else
            {
                if (this.interval > 0)
                {
                    this.started = true;
                    this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
                    this.Obj.visible = true;
                    return;
                }
                this.Stop();
            }
        }
    }
}
