using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace DienTapLib
{
    public class CBillboardMesh : IDisposable
    {
        private string m_Name;
        private Device m_device;
        public Mesh mesh;
        private string m_TextureFile;
        private int m_ColorKey = Color.Black.ToArgb();
        private List<Texture> m_texs;
        private Material material;
        protected float m_width;
        protected float m_height;
        private float m_ShiftZ;
        private int m_delay;
        private int m_cols;
        private int m_rows;
        private CustomVertex.PositionTextured[] vertices;
        private bool _disposed;
        public string Name
        {
            get
            {
                return this.m_Name;
            }
        }
        public Device device
        {
            get
            {
                return this.m_device;
            }
        }
        public List<Texture> texs
        {
            get
            {
                return this.m_texs;
            }
        }
        public float height
        {
            get
            {
                return this.m_height;
            }
        }
        public float ShiftZ
        {
            get
            {
                return this.m_ShiftZ;
            }
        }
        public int delay
        {
            get
            {
                return this.m_delay;
            }
        }
        public int cols
        {
            get
            {
                return this.m_cols;
            }
        }
        public int rows
        {
            get
            {
                return this.m_rows;
            }
        }
        public CBillboardMesh(string pName, Device pdevice, string pTexFile, int pcols, int prows, int pdelay, float pWidth, float pHeight, float pShiftZ)
        {
            this.m_Name = pName;
            this.m_device = pdevice;
            this.m_TextureFile = pTexFile;
            this.m_ColorKey = Color.Black.ToArgb();
            this.m_width = pWidth;
            this.m_height = pHeight;
            this.m_ShiftZ = pShiftZ;
            this.m_delay = pdelay;
            this.m_cols = pcols;
            this.m_rows = prows;
            this.VertexDeclaration();
            this.LoadTexturesAndMaterials();
        }
        public CBillboardMesh(string pName, Device pdevice, string pTexFile, int pcols, int prows, int pdelay, float pWidth, float pHeight, float pShiftZ, int pLPad, int pRPad, int pTPad, int pBPad)
        {
            this.m_Name = pName;
            this.m_device = pdevice;
            this.m_TextureFile = pTexFile;
            this.m_ColorKey = Color.Black.ToArgb();
            this.m_width = pWidth;
            this.m_height = pHeight;
            this.m_ShiftZ = pShiftZ;
            this.m_delay = pdelay;
            this.m_cols = pcols;
            this.m_rows = prows;
            this.VertexDeclaration();
            this.LoadTexturesAndMaterials();
        }
        private void LoadTexturesAndMaterials()
        {
            this.material = new Material();
            this.material.Diffuse = Color.White;
            this.material.Specular = Color.LightGray;
            this.material.SpecularSharpness = 15f;
            this.m_device.Material = this.material;
            this.m_texs = new List<Texture>();
            Bitmap mImage = new Bitmap(this.m_TextureFile);
            for (int i = 0; i < this.m_rows; i++)
            {
                for (int j = 0; j < this.m_cols; j++)
                {
                    Texture texture = this.getTexture(this.m_device, j, i, mImage, this.m_ColorKey);
                    this.m_texs.Add(texture);
                }
            }
        }
        private Texture getTexture(Device pdevice, int i, int j, Bitmap mImage, int pColorKey)
        {
            Bitmap bitmap = new Bitmap(mImage.Width / this.m_cols, mImage.Height / this.m_rows);
            Graphics graphics = Graphics.FromImage(bitmap);
            RectangleF destRect = new RectangleF(0f, 0f, (float)bitmap.Width, (float)bitmap.Height);
            RectangleF srcRect = new RectangleF((float)mImage.Width * (float)i / (float)this.m_cols, (float)mImage.Height * (float)j / (float)this.m_rows, (float)mImage.Width / (float)this.m_cols, (float)mImage.Height / (float)this.m_rows);
            graphics.DrawImage(mImage, destRect, srcRect, GraphicsUnit.Pixel);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Position = 0L;
            return TextureLoader.FromStream(pdevice, memoryStream, (int)memoryStream.Length, 0, 0, 1, Usage.None, Format.Unknown, Pool.Managed, Filter.None, Filter.None, pColorKey);
        }
        private void LoadTexturesAndMaterials0(int pLPad, int pRPad, int pTPad, int pBPad)
        {
            this.material = new Material();
            this.material.Diffuse = Color.White;
            this.material.Specular = Color.LightGray;
            this.material.SpecularSharpness = 15f;
            this.m_device.Material = this.material;
            this.m_texs = new List<Texture>();
            Bitmap mImage = new Bitmap(this.m_TextureFile);
            for (int i = 0; i < this.m_rows; i++)
            {
                for (int j = 0; j < this.m_cols; j++)
                {
                    Texture texture = this.getTexture0(this.m_device, j, i, mImage, this.m_ColorKey, pLPad, pRPad, pTPad, pBPad);
                    this.m_texs.Add(texture);
                }
            }
        }
        private Texture getTexture0(Device pdevice, int i, int j, Bitmap mImage, int pColorKey, int pLPad, int pRPad, int pTPad, int pBPad)
        {
            Bitmap bitmap = new Bitmap(mImage.Width / this.m_cols - (pLPad + pRPad), mImage.Height / this.m_rows - (pTPad + pBPad));
            Graphics graphics = Graphics.FromImage(bitmap);
            mImage.SetResolution(graphics.DpiX, graphics.DpiY);
            Rectangle destRect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            int x = mImage.Width * i / this.m_cols + pLPad;
            int y = mImage.Height * j / this.m_rows + pTPad;
            Rectangle srcRect = new Rectangle(x, y, bitmap.Width, bitmap.Height);
            graphics.DrawImage(mImage, destRect, srcRect, GraphicsUnit.Pixel);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Position = 0L;
            return TextureLoader.FromStream(pdevice, memoryStream, (int)memoryStream.Length, 0, 0, 1, Usage.None, Format.Unknown, Pool.Managed, Filter.None, Filter.None, pColorKey);
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
                this.mesh.Dispose();
            }
            this._disposed = true;
        }
        ~CBillboardMesh()
        {
            this.Dispose(false);
        }
        private void VertexDeclaration()
        {
            this.vertices = new CustomVertex.PositionTextured[6];
            this.vertices[0].Position = new Vector3(this.m_width / 2f, 0f, -this.m_height);
            this.vertices[1].Position = new Vector3(-this.m_width / 2f, 0f, 0f);
            this.vertices[2].Position = new Vector3(this.m_width / 2f, 0f, 0f);
            this.vertices[3].Position = new Vector3(-this.m_width / 2f, 0f, 0f);
            this.vertices[4].Position = new Vector3(this.m_width / 2f, 0f, -this.m_height);
            this.vertices[5].Position = new Vector3(-this.m_width / 2f, 0f, -this.m_height);
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
        public void Render()
        {
            this.m_device.SetTexture(0, this.m_texs[0]);
            this.m_device.VertexFormat = (VertexFormats.Texture1 | VertexFormats.Position);
            this.m_device.DrawUserPrimitives(PrimitiveType.TriangleList, 2, this.vertices);
        }
        public void Render(int pIndex)
        {
            this.m_device.SetTexture(0, this.m_texs[pIndex]);
            this.m_device.VertexFormat = (VertexFormats.Texture1 | VertexFormats.Position);
            this.m_device.DrawUserPrimitives(PrimitiveType.TriangleList, 2, this.vertices);
        }
        public int GetFrameMax()
        {
            int result = 0;
            if (this.m_cols > 1)
            {
                result = this.m_delay * this.m_cols;
            }
            return result;
        }
    }
}
