using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using XuLyKHLib;
namespace DienTapLib
{
	public class CTexObj : CActObj
	{
		private Device m_device;
		private Mesh meshTex;
		private string m_TextureFile;
		public List<Texture> texs;
		private Texture renderTex;
		private Material material;
		private int WIDTH = 20;
		private int HEIGHT = 10;
		private float SCALE_FACTOR = 3f;
		private int terrainWIDTH = 100;
		private int terrainHEIGHT = 100;
		private int ShiftX;
		private int ShiftY;
		public int ImageWidth = 20;
		public int ImageHeight = 10;
		public CSymbol3 ObjSymbol;
		public int PixelsPerGridX;
		public int PixelsPerGridY;
		public double ddx;
		public double ddy;
		private float[,] heightData;
		private short[] indices;
		private CustomVertex.PositionTextured[] vertices;
		private bool _disposed;
		public Device device
		{
			get
			{
				return this.m_device;
			}
		}
		public CTexObj(string pName, Device pdevice, string pTexFile, float[,] pheightData, int pWIDTH, int pHEIGHT, float pSCALE_FACTOR, int pShiftX, int pShiftY, int pImageWidth, int pImageHeight)
		{
			this.visible = true;
			this.Name = pName;
			this.m_device = pdevice;
			this.m_TextureFile = pTexFile;
			this.ObjSymbol = CSymbol3.GetSymbol(this.m_TextureFile);
			this.ImageWidth = pImageWidth;
			this.ImageHeight = pImageHeight;
			this.heightData = pheightData;
			this.WIDTH = pWIDTH + 1;
			this.HEIGHT = pHEIGHT + 1;
			this.SCALE_FACTOR = pSCALE_FACTOR;
			this.ShiftX = pShiftX;
			this.ShiftY = pShiftY;
			this.PixelsPerGridX = (int)Math.Ceiling((double)this.ImageWidth / (double)pWIDTH);
			this.PixelsPerGridY = (int)Math.Ceiling((double)this.ImageHeight / (double)pHEIGHT);
			this.terrainWIDTH = this.heightData.GetUpperBound(0);
			this.terrainHEIGHT = this.heightData.GetUpperBound(1);
			this.texs = new List<Texture>();
			this.VertexDeclaration();
			this.IndicesDeclaration();
			this.LoadTexturesAndMaterials(this.m_TextureFile);
			this.meshTex = this.CreateMesh();
			this.Position = new Vector3((float)(this.WIDTH - 1) / 2f + (float)this.ShiftX, (float)(this.HEIGHT - 1) / 2f + (float)this.ShiftY, 0f);
		}
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed && disposing)
			{
				this.renderTex.Dispose();
				this.meshTex.Dispose();
			}
			this._disposed = true;
		}
		~CTexObj()
		{
			base.Dispose();
		}
		private void LoadTexturesAndMaterials(string pTexFile)
		{
			this.material = new Material();
			this.material.Diffuse = Color.White;
			this.material.Specular = Color.LightGray;
			this.material.SpecularSharpness = 15f;
			Bitmap bitmap = new Bitmap(this.ImageWidth, this.ImageHeight);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			this.ObjSymbol.Draw(graphics);
			graphics.Dispose();
			Texture tex = this.GetTex(this.m_device, bitmap);
			this.renderTex = tex;
			this.ResetTex();
			this.texs.Add(tex);
		}
		private void ResetTex()
		{
			Surface surfaceLevel = this.renderTex.GetSurfaceLevel(0);
			Graphics graphics = surfaceLevel.GetGraphics();
			int pa = 254;
			graphics.Clear(CHelper.clrColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			this.ObjSymbol.AplyAlpha(pa);
			this.ObjSymbol.Draw(graphics);
			surfaceLevel.ReleaseGraphics();
			graphics.Dispose();
		}
		public Surface GetRenderSurface()
		{
			return this.renderTex.GetSurfaceLevel(0);
		}
		public Texture GetTex(Device device, Bitmap mTexImage)
		{
			MemoryStream memoryStream = new MemoryStream();
			mTexImage.Save(memoryStream, ImageFormat.Bmp);
			memoryStream.Position = 0L;
			Texture result = TextureLoader.FromStream(device, memoryStream, (int)memoryStream.Length, mTexImage.Width, mTexImage.Height, 1, Usage.None, Format.Unknown, Pool.Managed, Filter.None, Filter.None, Color.White.ToArgb());
			memoryStream.Dispose();
			return result;
		}
		public void Updatedd(int i, int j, int pstep)
		{
			this.ddx = (double)j * (double)this.ImageWidth / (double)(this.WIDTH - 1) / (double)pstep;
			this.ddy = -(double)i * (double)this.ImageHeight / (double)(this.HEIGHT - 1) / (double)pstep;
		}
		public Texture getTexture(int i, int j, int pstep)
		{
			double dx = (double)j * (double)this.ImageWidth / (double)(this.WIDTH - 1) / (double)pstep;
			double dy = -(double)i * (double)this.ImageHeight / (double)(this.HEIGHT - 1) / (double)pstep;
			Bitmap bitmap = new Bitmap(this.ImageWidth, this.ImageHeight);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			this.ObjSymbol.Draw(graphics, dx, dy);
			graphics.Dispose();
			Texture tex = this.GetTex(this.m_device, bitmap);
			bitmap.Dispose();
			return tex;
		}
		private void VertexDeclaration()
		{
			this.vertices = new CustomVertex.PositionTextured[this.WIDTH * this.HEIGHT];
			for (int i = 0; i < this.WIDTH; i++)
			{
				for (int j = 0; j < this.HEIGHT; j++)
				{
					this.vertices[i + j * this.WIDTH].Position = new Vector3((float)i, (float)j, this.GetHeightData(i + this.ShiftX, j + this.ShiftY));
					float tu = (float)Convert.ToDouble(i) / Convert.ToSingle(this.WIDTH - 1);
					float tv = (float)Convert.ToDouble(this.HEIGHT - 1 - j) / Convert.ToSingle(this.HEIGHT - 1);
					this.vertices[i + j * this.WIDTH].Tu = tu;
					this.vertices[i + j * this.WIDTH].Tv = tv;
				}
			}
		}
		private float GetHeightData(int px, int py)
		{
			float result = 0f;
			if (px >= 0 & px <= this.heightData.GetUpperBound(0) & (py >= 0 & py <= this.heightData.GetUpperBound(1)))
			{
				result = -this.heightData[px, py] / this.SCALE_FACTOR;
			}
			return result;
		}
		private void IndicesDeclaration()
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
		private Mesh CreateMesh()
		{
			Mesh mesh = new Mesh((this.WIDTH - 1) * (this.HEIGHT - 1) * 2, this.WIDTH * this.HEIGHT, MeshFlags.Managed, VertexFormats.Texture1 | VertexFormats.Position, this.m_device);
			mesh.SetVertexBufferData(this.vertices, LockFlags.None);
			mesh.SetIndexBufferData(this.indices, LockFlags.None);
			int[] array = new int[mesh.NumberFaces * 3];
			mesh.GenerateAdjacency(0.5f, array);
			mesh.OptimizeInPlace(MeshFlags.OptimizeVertexCache, array);
			mesh = mesh.Clone(mesh.Options.Value, VertexFormats.PositionNormal | VertexFormats.Texture1, this.m_device);
			mesh.ComputeNormals();
			return mesh;
		}
		public void Render(Microsoft.DirectX.Matrix pTerrainMatrix)
		{
			this.Render(pTerrainMatrix, this.renderTex);
		}
		public void UpdateTexture(Texture ptexture)
		{
			this.renderTex = ptexture;
		}
		public void UpdateMesh(float pPosX, float pPosY)
		{
			float num = pPosX - (float)((this.WIDTH - 1) / 2);
			float num2 = pPosY - (float)((this.HEIGHT - 1) / 2);
			int num3 = (int)Math.Floor((double)num);
			int num4 = (int)Math.Floor((double)num2);
			if (this.WIDTH + num3 >= 0 && this.WIDTH + num3 < this.terrainWIDTH && this.HEIGHT + num4 >= 0 && this.HEIGHT + num4 < this.terrainHEIGHT)
			{
				this.ShiftX = num3;
				this.ShiftY = num4;
				for (int i = 0; i < this.WIDTH; i++)
				{
					for (int j = 0; j < this.HEIGHT; j++)
					{
						this.vertices[i + j * this.WIDTH].Z = this.GetHeightData(i + this.ShiftX, j + this.ShiftY);
					}
				}
				this.meshTex.Dispose();
				this.meshTex = this.CreateMesh();
			}
			this.Position.X = pPosX;
			this.Position.Y = pPosY;
		}
		private void Render(Microsoft.DirectX.Matrix pTerrainMatrix, Texture ptexture)
		{
			this.m_device.Transform.World = Microsoft.DirectX.Matrix.Translation((float)this.ShiftX, (float)this.ShiftY, 0f) * pTerrainMatrix;
			int num = this.meshTex.GetAttributeTable().Length;
			this.m_device.Material = this.material;
			this.m_device.SetTexture(0, ptexture);
			for (int i = 0; i < num; i++)
			{
				this.meshTex.DrawSubset(i);
			}
		}
	}
}
