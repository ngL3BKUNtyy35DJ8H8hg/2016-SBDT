using System;
namespace DienTapLib
{
    internal class CBlink : CAct
    {
        protected CActObj Obj;
        protected float speed;
        protected int interval;
        public CBlink(CThucHanh pThucHanh, string pName, CActObj pObj, int start, int pduration, float pspeed, int pisound, bool loop)
            : base(pThucHanh)
        {
            this.Name = pName;
            this.Obj = pObj;
            this.StartTickCount = start;
            this.duration = pduration;
            this.speed = pspeed;
            if (this.speed < 1f)
            {
                this.speed = 1f;
            }
            this.StopTickCount = this.StartTickCount + this.duration;
            this.interval = (int)(1000f / this.speed);
            this.isound = pisound;
            this.soundloop = loop;
        }
        public override object Clone()
        {
            return base.MemberwiseClone();
        }
        public override void Reset()
        {
            this.done = false;
            this.Obj.visible = true;
            this.started = false;
        }
        public override void Stop()
        {
            this.Obj.visible = true;
            base.endaction();
        }
        public override void UpdateAct(int pTickCount)
        {
            if (!this.started)
            {
                this.started = true;
                this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
                this.Obj.visible = true;
                return;
            }
            int num = (pTickCount - this.StartTickCount) % this.interval;
            if (num * 2 < this.interval)
            {
                this.Obj.visible = false;
                return;
            }
            this.Obj.visible = true;
        }
    }
}
