using Microsoft.DirectX;
using System;

namespace DienTapLib
{
    public class CAct : IDisposable, ICloneable
    {
        protected CThucHanh myThucHanh;
        public string Name = "";
        public bool done;
        public int StartTickCount;
        public int StopTickCount;
        protected int duration = 1;
        protected bool started;
        protected int isound = -1;
        protected int iactionsound = -1;
        protected bool soundloop;
        private bool disposed;
        public CAct(CThucHanh pThucHanh)
        {
            this.myThucHanh = pThucHanh;
        }
        public virtual object Clone()
        {
            return base.MemberwiseClone();
        }
        public virtual void UpdateAct(int pTickCount)
        {
        }
        public void Update(int pMainStart)
        {
            int num = Environment.TickCount - pMainStart;
            if (num >= this.StartTickCount)
            {
                this.UpdateAct(num);
                if (num > this.StopTickCount)
                {
                    this.Stop();
                }
            }
        }
        public virtual void Reset()
        {
            this.done = false;
        }
        public virtual void Stop()
        {
            this.endaction();
        }
        protected void endaction()
        {
            this.done = true;
            if (this.iactionsound > -1)
            {
                this.myThucHanh.mySound.StopSound(this.iactionsound);
            }
        }
        public static void NormAngle(ref float pAngle)
        {
            if (pAngle < 0f)
            {
                pAngle += 6.28318548f;
            }
            if (pAngle > 6.28318548f)
            {
                pAngle -= 6.28318548f;
            }
        }
        public static float GetAngleZ(Vector3 addvector)
        {
            float num = (float)Math.Atan2((double)addvector.Y, (double)addvector.X);
            num -= 1.57079637f;
            CAct.NormAngle(ref num);
            return num;
        }
        public static float GetAngleX(Vector3 addvector)
        {
            return (float)Math.Asin((double)(addvector.Z / addvector.Length()));
        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                this.disposed = true;
            }
        }
        ~CAct()
        {
            this.Dispose(false);
        }
    }
}
