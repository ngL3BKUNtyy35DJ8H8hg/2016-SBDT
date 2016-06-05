using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	public class CRay
	{
		private static Ray CalculateCursorRay(Device device, Vector2 cursorpos, Matrix projectionMatrix, Matrix viewMatrix, Matrix worldMatrix)
		{
			Vector3 v = new Vector3(cursorpos.X, cursorpos.Y, 0f);
			Vector3 v2 = new Vector3(cursorpos.X, cursorpos.Y, 1f);
			Vector3 vector = Vector3.Unproject(v, device.Viewport, projectionMatrix, viewMatrix, worldMatrix);
			Vector3 left = Vector3.Unproject(v2, device.Viewport, projectionMatrix, viewMatrix, worldMatrix);
			Vector3 dir = left - vector;
			dir.Normalize();
			return new Ray(vector, dir);
		}
		private static void RayIntersectsTriangle(ref Ray ray, ref Vector3 vertex1, ref Vector3 vertex2, ref Vector3 vertex3, out float? result, out float ptriangleU, out float ptriangleV)
		{
			Vector3 vector = Vector3.Subtract(vertex2, vertex1);
			Vector3 vector2 = Vector3.Subtract(vertex3, vertex1);
			Vector3 right = Vector3.Cross(ray.Direction, vector2);
			float num = Vector3.Dot(vector, right);
			if (num > -1.401298E-45f && num < 1.401298E-45f)
			{
				result = null;
				ptriangleU = 0f;
				ptriangleV = 0f;
				return;
			}
			float num2 = 1f / num;
			Vector3 left = Vector3.Subtract(ray.Position, vertex1);
			float num3 = Vector3.Dot(left, right);
			num3 *= num2;
			if (num3 < 0f || num3 > 1f)
			{
				result = null;
				ptriangleU = 0f;
				ptriangleV = 0f;
				return;
			}
			Vector3 right2 = Vector3.Cross(left, vector);
			float num4 = Vector3.Dot(ray.Direction, right2);
			num4 *= num2;
			if (num4 < 0f || num3 + num4 > 1f)
			{
				result = null;
				ptriangleU = 0f;
				ptriangleV = 0f;
				return;
			}
			float num5 = Vector3.Dot(vector2, right2);
			num5 *= num2;
			if (num5 < 0f)
			{
				result = null;
				ptriangleU = 0f;
				ptriangleV = 0f;
				return;
			}
			ptriangleU = num3;
			ptriangleV = num4;
			result = new float?(num5);
		}
		private static float? RayIntersectsTerrain(Ray ray, Vector3[] vertices, Matrix modelTransform, out bool insideBoundingSphere, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out float ptriangleU, out float ptriangleV)
		{
			vertex1 = (vertex2 = (vertex3 = new Vector3(0f, 0f, 0f)));
			insideBoundingSphere = true;
			float? num = null;
			ptriangleU = 0f;
			ptriangleV = 0f;
			for (int i = 0; i < vertices.Length; i += 3)
			{
				float num2 = 0f;
				float num3 = 0f;
				float? num4;
				CRay.RayIntersectsTriangle(ref ray, ref vertices[i], ref vertices[i + 1], ref vertices[i + 2], out num4, out num2, out num3);
				if (num4.HasValue)
				{
					if (num.HasValue)
					{
						float? num5 = num4;
						float? num6 = num;
						if (num5.GetValueOrDefault() >= num6.GetValueOrDefault() || !(num5.HasValue & num6.HasValue))
						{
							goto IL_10E;
						}
					}
					num = num4;
					vertex1 = vertices[i];
					vertex2 = vertices[i + 1];
					vertex3 = vertices[i + 2];
					ptriangleU = num2;
					ptriangleV = num3;
				}
				IL_10E:;
			}
			return num;
		}
		public static Vector3 GetPickingPoint(Device device, Vector3[] v3vertices, Vector2 cursorpos, Matrix worldMatrix, Matrix viewMatrix, Matrix projectionMatrix)
		{
			Vector3 result = Vector3.Empty;
			Ray ray = CRay.CalculateCursorRay(device, cursorpos, projectionMatrix, viewMatrix, worldMatrix);
			bool flag;
			Vector3 item;
			Vector3 item2;
			Vector3 item3;
			float num;
			float num2;
			if (CRay.RayIntersectsTerrain(ray, v3vertices, worldMatrix, out flag, out item, out item2, out item3, out num, out num2).HasValue)
			{
				List<Vector3> list = new List<Vector3>();
				list.Add(item);
				list.Add(item2);
				list.Add(item3);
				result = (1f - num - num2) * list[0] + num * list[1] + num2 * list[2];
			}
			return result;
		}
	}
}
