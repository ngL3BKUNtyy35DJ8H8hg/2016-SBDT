using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace DienTapLib
{
	public class CSpriteTex
	{
		private Device m_device;
		private string m_TextureFile;
		private List<Texture> m_texs;
		public string Name
		{
			get
			{
				return this.m_TextureFile;
			}
		}
		public List<Texture> texs
		{
			get
			{
				return this.m_texs;
			}
		}
		public CSpriteTex(Device pdevice, string pTexFile, int pColorKey, int ptexCount, int pWidth, int pHeight)
		{
			this.m_device = pdevice;
			this.m_TextureFile = pTexFile;
			this.m_texs = new List<Texture>();
			Bitmap mImage = new Bitmap(pTexFile);
			for (int i = 0; i < ptexCount; i++)
			{
				Texture texture = this.getTexture(this.m_device, i, ptexCount, mImage, pColorKey, pWidth, pHeight);
				this.m_texs.Add(texture);
			}
		}
		private Texture getTexture(Device pdevice, int i, int pstep, Bitmap mImage, int pColorKey, int pWidth, int pHeight)
		{
			Bitmap bitmap = new Bitmap(pWidth, pHeight);
			Graphics graphics = Graphics.FromImage(bitmap);
			RectangleF destRect = new RectangleF(0f, 0f, (float)bitmap.Width, (float)bitmap.Height);
			RectangleF srcRect = new RectangleF((float)mImage.Width * (float)i / (float)pstep, 0f, (float)mImage.Width / (float)pstep, (float)mImage.Height);
			graphics.DrawImage(mImage, destRect, srcRect, GraphicsUnit.Pixel);
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Bmp);
			memoryStream.Position = 0L;
			return TextureLoader.FromStream(pdevice, memoryStream, (int)memoryStream.Length, 0, 0, 1, Usage.None, Format.Unknown, Pool.Managed, Filter.None, Filter.None, pColorKey);
		}
	}
}
