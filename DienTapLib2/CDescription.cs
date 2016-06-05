using System;
namespace DienTapLib
{
	internal class CDescription : CAct
	{
		protected string DescText = "";
		protected DescPos Pos = DescPos.Duoi;
		protected bool SaBanHide;
		public CDescription(CThucHanh pThucHanh, string pName, int start, int pduration, string pDescText, DescPos pPos, bool pSaBanHide, int pisound, bool loop) : base(pThucHanh)
		{
			this.Name = pName;
            this.DescText = pDescText;
			this.Pos = pPos;
			this.SaBanHide = pSaBanHide;
			this.StartTickCount = start;
			this.duration = pduration;
			this.StopTickCount = this.StartTickCount + this.duration;
			this.isound = pisound;
			this.soundloop = loop;
		}
		public override object Clone()
		{
			return base.MemberwiseClone();
		}
		public override void Reset()
		{
			this.done = false;
			this.started = false;
		}
		public override void Stop()
		{
			if (this.duration != 0)
			{
				if (this.Pos == DescPos.Giua)
				{
					this.myThucHanh.DescGiuaText = "";
				}
				else if (this.Pos == DescPos.Tren)
				{
					this.myThucHanh.DescTrenText = "";
				}
				else
				{
					this.myThucHanh.DescText = "";
				}
				base.endaction();
				if (this.SaBanHide)
				{
					this.myThucHanh.TerrainVisible = true;
				}
			}
		}
		public override void UpdateAct(int pTickCount)
		{
			if (this.started)
			{
				return;
			}
			this.iactionsound = this.myThucHanh.mySound.AddSound(this.isound, this.soundloop);
			if (this.Pos == DescPos.Giua)
			{
				this.myThucHanh.DescMeasureGiua(this.DescText);
			}
			else if (this.Pos == DescPos.Tren)
			{
				this.myThucHanh.DescMeasureTren(this.DescText);
			}
			else
			{
				this.myThucHanh.DescMeasure(this.DescText);
			}
			if (this.duration != 0)
			{
				this.myThucHanh.TerrainVisible = !this.SaBanHide;
			}
			this.started = true;
		}
	}
}
