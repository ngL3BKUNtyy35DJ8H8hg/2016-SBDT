using Microsoft.DirectX;
using System;
namespace DienTapLib
{
    public class CActObj : IDisposable
    {
        public bool visible;
        public string Name = "";
        public Vector3 Position;
        public float angleX;
        public float angleZ;
        public string ObjType = "";
        private bool _disposed;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
            }
            this._disposed = true;
        }
        ~CActObj()
        {
            this.Dispose(false);
        }
    }
}
