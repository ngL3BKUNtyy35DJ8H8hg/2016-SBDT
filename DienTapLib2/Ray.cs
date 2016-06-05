using Microsoft.DirectX;
using System;
namespace DienTapLib
{
	public struct Ray
	{
		public Vector3 Position;
		public Vector3 Direction;
		public Ray(Vector3 pos, Vector3 dir)
		{
			this.Position = pos;
			this.Direction = dir;
		}
	}
}
