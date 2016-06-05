using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
namespace DienTapLib
{
	public class CModelMesh : IDisposable
	{
		private Device m_device;
		private string m_meshFile;
		public Mesh mesh;
		private Material[] meshMaterials;
		private Texture[] meshTextures;
		public string myName;
		public Vector3 myAngle;
		public float myScale;
		public float myShiftX;
		public float myShiftY;
		public float myShiftZ;
		public int myAutoTurn;
		private bool _disposed;
		private static readonly VertexFormats vertexFormats = VertexFormats.PositionNormal | VertexFormats.Texture1;
		public CModelMesh(Device device, string meshFile, string pName, Vector3 pAngle, float pScale, float pShiftX, float pShiftY, float pShiftZ, int pAutoTurn)
		{
			this.m_device = device;
			this.m_meshFile = meshFile;
			this.LoadMesh();
			this.myName = pName;
			this.myAngle = pAngle;
			this.myScale = pScale;
			this.myShiftX = pShiftX;
			this.myShiftY = pShiftY;
			this.myShiftZ = pShiftZ;
			this.myAutoTurn = pAutoTurn;
		}
		~CModelMesh()
		{
			this.Dispose(false);
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
				this.mesh.Dispose();
			}
			this._disposed = true;
		}
		private void LoadMesh()
		{
			ExtendedMaterial[] array = null;
			int num = this.m_meshFile.LastIndexOf("\\");
			string str = "";
			if (num > 0)
			{
				str = this.m_meshFile.Substring(0, num + 1);
			}
			this.mesh = Mesh.FromFile(this.m_meshFile, MeshFlags.Managed, this.m_device, out array);
			if (CModelMesh.vertexFormats != this.mesh.VertexFormat)
			{
				Mesh mesh = this.mesh.Clone(MeshFlags.Managed, CModelMesh.vertexFormats, this.m_device);
				mesh.ComputeNormals();
				this.mesh.Dispose();
				this.mesh = mesh;
			}
			if (array != null && array.Length > 0)
			{
				try
				{
					this.meshTextures = new Texture[array.Length + 1];
					this.meshMaterials = new Material[array.Length + 1];
					for (int i = 0; i < array.Length; i++)
					{
						this.meshMaterials[i] = array[i].Material3D;
						this.meshMaterials[i].Ambient = this.meshMaterials[i].Diffuse;
						if (array[i].TextureFilename != null && !(array[i].TextureFilename == string.Empty))
						{
							this.meshTextures[i] = TextureLoader.FromFile(this.m_device, str + array[i].TextureFilename);
						}
					}
				}
				catch
				{
				}
			}
		}
		public void Render()
		{
			for (int i = 0; i < this.meshMaterials.Length; i++)
			{
				this.m_device.Material = this.meshMaterials[i];
				this.m_device.SetTexture(0, this.meshTextures[i]);
				this.mesh.DrawSubset(i);
			}
		}
	}
}
