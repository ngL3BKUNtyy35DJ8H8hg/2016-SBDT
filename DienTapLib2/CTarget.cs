using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	public class CTarget : IDisposable
	{
		public Vector3 Position;
		public int TickCount;
		public float len;
		public float angleZ;
		public float angleX;
		protected bool _disposed;
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
		~CTarget()
		{
			this.Dispose(false);
		}
	}
}
