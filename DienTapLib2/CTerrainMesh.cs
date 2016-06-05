using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace DienTapLib
{
	public class CTerrainMesh : IDisposable
	{
		private int numSubSets;
		public FillMode myFillMode = FillMode.Solid;
		public Vector3 lightDirection;
		public Vector3[] v3vertices;
		public int WIDTH = 101;
		public int HEIGHT = 119;
		public float SCALE_FACTOR = 3f;
		public float[,] heightData;
		private CustomVertex.PositionTextured[] vertices;
		private short[] indices;
		private Texture texture;
		private Material material;
		private MemoryStream MemStream;
		private Mesh meshTerrain;
		public Device device;
		private bool _disposed;
		public CTerrainMesh(Device pdevice, float[,] pheightData, float pSCALE_FACTOR)
		{
			try
			{
				this.device = pdevice;
				this.heightData = pheightData;
				this.WIDTH = pheightData.GetUpperBound(0) + 1;
				this.HEIGHT = pheightData.GetUpperBound(1) + 1;
				this.SCALE_FACTOR = pSCALE_FACTOR;
				this.LoadMaterials();
				this.MemStream = new MemoryStream();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		~CTerrainMesh()
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
			if (!this._disposed && disposing)
			{
				this.meshTerrain.Dispose();
			}
			this._disposed = true;
		}
		public Surface GetRenderSurface()
		{
			return this.texture.GetSurfaceLevel(0);
		}
		private void LoadMaterials()
		{
			this.material = new Material();
			this.material.Diffuse = Color.White;
			this.material.Specular = Color.LightGray;
			this.material.SpecularSharpness = 15f;
		}
		public void LoadMemStream(Bitmap pTexImage)
		{
			this.MemStream.Position = 0L;
			pTexImage.Save(this.MemStream, ImageFormat.Jpeg);
			this.MemStream.Position = 0L;
			this.texture = TextureLoader.FromStream(this.device, this.MemStream);
		}
		private void VertexDeclaration()
		{
			try
			{
				this.vertices = new CustomVertex.PositionTextured[this.WIDTH * this.HEIGHT];
				for (int i = 0; i < this.WIDTH; i++)
				{
					for (int j = 0; j < this.HEIGHT; j++)
					{
						this.vertices[i + j * this.WIDTH].Position = new Vector3((float)i, (float)j, -this.heightData[i, j] / this.SCALE_FACTOR);
						float tu = Convert.ToSingle(i) / Convert.ToSingle(this.WIDTH - 1);
						float tv = Convert.ToSingle(this.HEIGHT - 1 - j) / Convert.ToSingle(this.HEIGHT - 1);
						this.vertices[i + j * this.WIDTH].Tu = tu;
						this.vertices[i + j * this.WIDTH].Tv = tv;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		private void IndicesDeclaration()
		{
			try
			{
				this.indices = new short[(this.WIDTH - 1) * (this.HEIGHT - 1) * 6];
				for (int i = 0; i < this.WIDTH - 1; i++)
				{
					for (int j = 0; j < this.HEIGHT - 1; j++)
					{
						this.indices[(i + j * (this.WIDTH - 1)) * 6] = (short)(i + j * this.WIDTH);
						this.indices[(i + j * (this.WIDTH - 1)) * 6 + 1] = (short)(i + 1 + j * this.WIDTH);
						this.indices[(i + j * (this.WIDTH - 1)) * 6 + 2] = (short)(i + 1 + (j + 1) * this.WIDTH);
						this.indices[(i + j * (this.WIDTH - 1)) * 6 + 3] = (short)(i + (j + 1) * this.WIDTH);
						this.indices[(i + j * (this.WIDTH - 1)) * 6 + 4] = (short)(i + j * this.WIDTH);
						this.indices[(i + j * (this.WIDTH - 1)) * 6 + 5] = (short)(i + 1 + (j + 1) * this.WIDTH);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		private void CreateMesh()
		{
			try
			{
				this.meshTerrain = new Mesh((this.WIDTH - 1) * (this.HEIGHT - 1) * 2, this.WIDTH * this.HEIGHT, MeshFlags.Managed, VertexFormats.Texture1 | VertexFormats.Position, this.device);
				this.meshTerrain.SetVertexBufferData(this.vertices, LockFlags.None);
				this.meshTerrain.SetIndexBufferData(this.indices, LockFlags.None);
				int[] array = new int[this.meshTerrain.NumberFaces * 3];
				this.meshTerrain.GenerateAdjacency(0.5f, array);
				this.meshTerrain.OptimizeInPlace(MeshFlags.OptimizeVertexCache, array);
				this.meshTerrain = this.meshTerrain.Clone(this.meshTerrain.Options.Value, VertexFormats.PositionNormal | VertexFormats.Texture1, this.device);
				this.meshTerrain.ComputeNormals();
				this.numSubSets = this.meshTerrain.GetAttributeTable().Length;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void SetLights()
		{
			this.device.Lights[0].Type = LightType.Directional;
			this.device.Lights[0].Diffuse = Color.White;
			this.device.Lights[0].Direction = this.lightDirection;
			this.device.Lights[0].Update();
			this.device.Lights[0].Enabled = true;
			if (this.device.DeviceCaps.MaxActiveLights > 1)
			{
				this.device.Lights[1].Type = LightType.Directional;
				this.device.Lights[1].Diffuse = Color.LightYellow;
				this.device.Lights[1].Direction = new Vector3(-1f, 1f, -1f);
				this.device.Lights[1].Update();
				this.device.Lights[1].Enabled = true;
			}
			else
			{
				this.device.RenderState.Ambient = Color.White;
			}
			this.device.RenderState.CullMode = Cull.None;
			this.device.RenderState.ZBufferEnable = true;
			this.device.RenderState.Ambient = Color.Silver;
			this.device.RenderState.FillMode = this.myFillMode;
			this.device.RenderState.SourceBlend = Blend.SourceAlpha;
			this.device.RenderState.DestinationBlend = Blend.InvSourceAlpha;
		}
		public void Render(Matrix worldMatrix)
		{
			this.device.Transform.World = worldMatrix;
			this.meshTerrain.Device.Material = this.material;
			this.meshTerrain.Device.SetTexture(0, this.texture);
			for (int i = 0; i < this.numSubSets; i++)
			{
				this.meshTerrain.DrawSubset(i);
			}
		}
		public void Render()
		{
			this.meshTerrain.Device.Material = this.material;
			this.meshTerrain.Device.SetTexture(0, this.texture);
			for (int i = 0; i < this.numSubSets; i++)
			{
				this.meshTerrain.DrawSubset(i);
			}
		}
		public void ResetTerrain()
		{
			try
			{
				this.VertexDeclaration();
				this.IndicesDeclaration();
				this.CreateMesh();
				this.v3vertices = this.Getv3Vertices();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Vector3[] Getv3Vertices()
		{
			Vector3[] array = new Vector3[this.indices.Length];
			try
			{
				for (int i = 0; i < this.indices.Length / 3; i++)
				{
					int num = (int)this.indices[i * 3];
					int num2 = (int)this.indices[i * 3 + 1];
					int num3 = (int)this.indices[i * 3 + 2];
					array[i * 3] = this.vertices[num].Position;
					array[i * 3 + 1] = this.vertices[num2].Position;
					array[i * 3 + 2] = this.vertices[num3].Position;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return array;
		}
		public float getZ(float pX, float pY)
		{
			float result = 0f;
			try
			{
				int num = (int)Math.Floor((double)pX);
				int num2 = (int)Math.Floor((double)pY);
				float num3 = (float)Math.Atan2((double)(pY - (float)num2), (double)(pX - (float)num));
				Vector3 left;
				Vector3 left2;
				Vector3 left3;
				float num4;
				float num5;
				if ((double)num3 > 0.78539816339744828)
				{
					left = new Vector3((float)num, (float)(num2 + 1), this.heightData[num, num2 + 1] / this.SCALE_FACTOR);
					left2 = new Vector3((float)(num + 1), (float)(num2 + 1), this.heightData[num + 1, num2 + 1] / this.SCALE_FACTOR);
					left3 = new Vector3((float)num, (float)num2, this.heightData[num, num2] / this.SCALE_FACTOR);
					num4 = pX - (float)num;
					num5 = (float)(num2 + 1) - pY;
				}
				else
				{
					left = new Vector3((float)(num + 1), (float)num2, this.heightData[num + 1, num2] / this.SCALE_FACTOR);
					left2 = new Vector3((float)num, (float)num2, this.heightData[num, num2] / this.SCALE_FACTOR);
					left3 = new Vector3((float)(num + 1), (float)(num2 + 1), this.heightData[num + 1, num2 + 1] / this.SCALE_FACTOR);
					num4 = (float)(num + 1) - pX;
					num5 = pY - (float)num2;
				}
				result = -((1f - num4 - num5) * left + num4 * left2 + num5 * left3).Z;
			}
			catch
			{
			}
			return result;
		}
	}
}
