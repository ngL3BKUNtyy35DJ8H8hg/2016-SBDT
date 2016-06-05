using Microsoft.DirectX.DirectSound;
using System;
namespace DienTapLib
{
	public class CSound
	{
		public SecondaryBuffer buffer;
		public bool loop;
		public CSound(SecondaryBuffer pbuffer, bool ploop)
		{
			this.buffer = pbuffer;
			this.loop = ploop;
		}
	}
}
