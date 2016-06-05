using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	public class CSpriteObj : IDisposable
	{
		public bool visible;
		protected CThucHanh myThucHanh;
		protected Vector3 m_position;
		protected float m_AngleX;
		protected float m_AngleZ;
		protected float m_AngleY;
		protected float m_shiftZ;
		protected int m_AutoTurn;
		protected string m_TextureFile;
		protected CustomVertex.PositionTextured[] vertices;
		protected float m_width;
		protected float m_height;
		public Texture texture;
		protected Texture renderTex;
		private bool _disposed;
		public Vector3 Position
		{
			get
			{
				return this.m_position;
			}
			set
			{
				this.m_position = value;
			}
		}
		public float angleX
		{
			get
			{
				return this.m_AngleX;
			}
			set
			{
				this.m_AngleX = value;
			}
		}
		public float angleZ
		{
			get
			{
				return this.m_AngleZ;
			}
			set
			{
				this.m_AngleZ = value;
			}
		}
		public float angleY
		{
			get
			{
				return this.m_AngleY;
			}
			set
			{
				this.m_AngleY = value;
			}
		}
		public int AutoTurn
		{
			set
			{
				this.m_AutoTurn = value;
			}
		}
		public float Length
		{
			get
			{
				return this.m_height;
			}
		}
		public CSpriteObj(CThucHanh pThucHanh, float pwidth, float pheight, int pVertical, string pTexFile, Vector3 position, float pshiftZ)
		{
			this.myThucHanh = pThucHanh;
			this.m_position = position;
			if (position.Z == 0f)
			{
				this.m_position.Z = this.myThucHanh.myTerrain.getZ(this.m_position.X, this.m_position.Y);
			}
			this.m_AngleX = 0f;
			this.m_AngleZ = 0f;
			this.m_AngleY = 0f;
			this.m_shiftZ = pshiftZ;
			this.m_TextureFile = pTexFile;
			this.m_width = pwidth;
			this.m_height = pheight;
			this.VertexDeclaration(pVertical);
			this.LoadTexturesAndMaterials(pTexFile);
		}
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				this.texture.Dispose();
			}
			this._disposed = true;
		}
		~CSpriteObj()
		{
			this.Dispose(false);
		}
		private void LoadTexturesAndMaterials(string pTexFile)
		{
			List<Texture> texs = this.myThucHanh.GetTexs(pTexFile);
			this.texture = texs[0];
			this.renderTex = this.texture;
		}
		private void VertexDeclaration(int pVertical)
		{
			this.vertices = new CustomVertex.PositionTextured[6];
			if (pVertical == 0)
			{
				this.vertices[0].Position = new Vector3(this.m_width / 2f, this.m_height / 2f, 0f);
				this.vertices[1].Position = new Vector3(-this.m_width / 2f, -this.m_height / 2f, 0f);
				this.vertices[2].Position = new Vector3(this.m_width / 2f, -this.m_height / 2f, 0f);
				this.vertices[3].Position = new Vector3(-this.m_width / 2f, -this.m_height / 2f, 0f);
				this.vertices[4].Position = new Vector3(this.m_width / 2f, this.m_height / 2f, 0f);
				this.vertices[5].Position = new Vector3(-this.m_width / 2f, this.m_height / 2f, 0f);
			}
			else
			{
				this.vertices[0].Position = new Vector3(this.m_width / 2f, 0f, -this.m_height);
				this.vertices[1].Position = new Vector3(-this.m_width / 2f, 0f, 0f);
				this.vertices[2].Position = new Vector3(this.m_width / 2f, 0f, 0f);
				this.vertices[3].Position = new Vector3(-this.m_width / 2f, 0f, 0f);
				this.vertices[4].Position = new Vector3(this.m_width / 2f, 0f, -this.m_height);
				this.vertices[5].Position = new Vector3(-this.m_width / 2f, 0f, -this.m_height);
			}
			this.vertices[0].Tu = 1f;
			this.vertices[0].Tv = 0f;
			this.vertices[1].Tu = 0f;
			this.vertices[1].Tv = 1f;
			this.vertices[2].Tu = 1f;
			this.vertices[2].Tv = 1f;
			this.vertices[3].Tu = 0f;
			this.vertices[3].Tv = 1f;
			this.vertices[4].Tu = 1f;
			this.vertices[4].Tv = 0f;
			this.vertices[5].Tu = 0f;
			this.vertices[5].Tv = 0f;
		}
		public virtual void Render(Matrix pTerrainMatrix, float pAngleZ)
		{
			float angle;
			if (this.m_AutoTurn == 1)
			{
				angle = this.m_AngleZ - pAngleZ;
			}
			else
			{
				angle = this.m_AngleZ;
			}
			this.myThucHanh.myTerrain.device.Transform.World = Matrix.RotationX(this.m_AngleX) * Matrix.RotationZ(angle) * Matrix.Translation(this.m_position.X, this.m_position.Y, this.m_position.Z - this.m_shiftZ) * pTerrainMatrix;
			this.myThucHanh.myTerrain.device.SetTexture(0, this.renderTex);
			this.myThucHanh.myTerrain.device.VertexFormat = (VertexFormats.Texture1 | VertexFormats.Position);
			this.myThucHanh.myTerrain.device.DrawUserPrimitives(PrimitiveType.TriangleList, 2, this.vertices);
		}
		public void UpdateTexture(Texture ptexture)
		{
			this.renderTex = ptexture;
		}
	}
}
