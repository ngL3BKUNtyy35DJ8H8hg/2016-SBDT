using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
namespace DienTapLib
{
	public class CModel : CActObj
	{
		private CModelMesh m_ModelMesh;
		private Device m_device;
		public Matrix myworldMatrix;
		public Mesh mesh
		{
			get
			{
				return this.m_ModelMesh.mesh;
			}
		}
		public CModelMesh ModelMesh
		{
			get
			{
				return this.m_ModelMesh;
			}
		}
		public float X
		{
			get
			{
				return this.Position.X;
			}
			set
			{
				this.Position.X = value;
			}
		}
		public float Y
		{
			get
			{
				return this.Position.Y;
			}
			set
			{
				this.Position.Y = value;
			}
		}
		public float Z
		{
			get
			{
				return this.Position.Z;
			}
			set
			{
				this.Position.Z = value;
			}
		}
		public CModel(string pName, Device device, CModelMesh pCModelMesh, Vector3 position, float pAngleZ)
		{
			this.visible = true;
			this.Name = pName;
			this.m_ModelMesh = pCModelMesh;
			this.m_device = device;
			this.Position = position;
			this.angleZ = pAngleZ;
		}
		public void Render(Matrix pTerrainMatrix, float pAngleZ)
		{
			float angle;
			if (this.m_ModelMesh.myAutoTurn == 1)
			{
				angle = this.m_ModelMesh.myAngle.Z - pAngleZ;
			}
			else
			{
				angle = this.m_ModelMesh.myAngle.Z;
			}
			this.myworldMatrix = Matrix.Identity * Matrix.RotationX(this.m_ModelMesh.myAngle.X) * Matrix.RotationY(this.m_ModelMesh.myAngle.Y) * Matrix.RotationZ(angle) * Matrix.Scaling(this.m_ModelMesh.myScale, this.m_ModelMesh.myScale, this.m_ModelMesh.myScale) * Matrix.Translation(this.m_ModelMesh.myShiftX, this.m_ModelMesh.myShiftY, -this.m_ModelMesh.myShiftZ) * Matrix.RotationX(this.angleX) * Matrix.RotationZ(this.angleZ) * Matrix.Translation(this.Position.X, this.Position.Y, this.Position.Z);
			this.m_device.Transform.World = this.myworldMatrix * pTerrainMatrix;
			this.m_ModelMesh.Render();
		}
	}
}
