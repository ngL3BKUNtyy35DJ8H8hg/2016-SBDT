using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
namespace DienTapLib
{
	internal class CExplodeObj : CAct
	{
		protected CSpriteObj SpriteObj;
		protected float shiftZ;
		protected float speed;
		protected int interval;
		protected CActObj explObj;
		protected Vector3 explPos;
		protected int texcount;
		protected List<Texture> texs;
		private void CreatExplode(string pName, string texfile, float pWidth, float pHeight, float pShiftZ, int start, int pduration, float pspeed, int pisound, bool loop)
		{
			this.Name = pName;
			this.SpriteObj = this.myThucHanh.Add1SpriteObj(texfile, pWidth, pHeight, 1, new Vector3(0f, 0f, 0f), -pHeight / 2f);
			this.SpriteObj.AutoTurn = 1;
			this.shiftZ = pShiftZ;
			this.StartTickCount = start;
			this.duration = pduration;
			this.speed = pspeed;
			if (this.speed < 1f)
			{
				this.speed = 1f;
			}
			this.texcount = 0;
			this.texs = this.myThucHanh.GetTexs(texfile);
			if (this.texs != null)
			{
				this.texcount = this.texs.Count;
			}
			if (this.texcount > 0)
			{
				this.StopTickCount = this.StartTickCount + this.duration;
			}
			else
			{
				this.StopTickCount = this.StartTickCount;
			}
			this.interval = (int)(1000f / this.speed);
			this.isound = pisound;
			this.soundloop = loop;
		}
		public CExplodeObj(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, float pShiftZ, int start, int pduration, float pspeed, CActObj pexplObj, int pisound, bool loop) : base(pThucHanh)
		{
			this.explObj = pexplObj;
			this.explPos = this.explObj.Position;
			this.CreatExplode(pName, texfile, pWidth, pHeight, pShiftZ, start, pduration, pspeed, pisound, loop);
		}
		public CExplodeObj(CThucHanh pThucHanh, string pName, string texfile, float pWidth, float pHeight, float pShiftZ, int start, int pduration, float pspeed, Vector3 pexplPos, int pisound, bool loop) : base(pThucHanh)
		{
			this.explPos = pexplPos;
			this.CreatExplode(pName, texfile, pWidth, pHeight, pShiftZ, start, pduration, pspeed, pisound, loop);
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		protected virtual void GetSpritePos()
		{
			if (this.explObj != null)
			{
				Vector3 position = this.explObj.Position;
				position.Z = this.myThucHanh.myTerrain.getZ(position.X, position.Y) - 0.2f;
				position.Z -= this.shiftZ;
				this.SpriteObj.Position = position;
				return;
			}
			Vector3 position2 = this.explPos;
			if (position2.Z == 0f)
			{
				position2.Z = this.myThucHanh.myTerrain.getZ(position2.X, position2.Y) - 0.2f;
			}
			this.SpriteObj.Position = position2;
		}
		public override void Reset()
		{
			this.done = false;
			this.SpriteObj.visible = false;
			this.started = false;
		}
		public override void Stop()
		{
			this.SpriteObj.visible = false;
			base.endaction();
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				int jj = (pTickCount - this.StartTickCount) % (this.interval * this.texcount);
				int i = this.GetI(jj);
				this.GetSpritePos();
				this.SpriteObj.UpdateTexture(this.texs[i]);
				return;
			}
			this.started = true;
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			this.SpriteObj.visible = true;
		}
		private int GetI(int jj)
		{
			int result = 0;
			for (int i = 0; i < this.texcount; i++)
			{
				if (i * this.interval > jj)
				{
					result = i;
					break;
				}
			}
			return result;
		}
	}
}
