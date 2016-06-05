using Microsoft.DirectX.DirectSound;
using System;
using System.Collections;
using System.Windows.Forms;
namespace DienTapLib
{
	public class CSounds
	{
		private Device sounddevice;
		private BufferDescription description;
		private ArrayList soundlist = new ArrayList();
		private ArrayList actionsoundlist = new ArrayList();
		private ArrayList availsoundlist = new ArrayList();
		public CSounds(Form f)
		{
			this.InitializeSound(f);
			this.soundlist = new ArrayList();
			this.actionsoundlist = new ArrayList();
			this.availsoundlist = new ArrayList();
		}
		private void InitializeSound(Form f)
		{
			this.sounddevice = new Device();
			this.sounddevice.SetCooperativeLevel(f, CooperativeLevel.Normal);
			this.description = new BufferDescription();
			this.description.ControlEffects = false;
		}
		public void LoadSound(string soundFile)
		{
			SecondaryBuffer value;
			try
			{
				value = new SecondaryBuffer(soundFile, this.description, this.sounddevice);
			}
			catch
			{
				value = new SecondaryBuffer(this.description, this.sounddevice);
			}
			this.availsoundlist.Add(value);
		}
		public void SoundAffairs()
		{
			if (this.soundlist.Count > 0)
			{
				for (int i = this.soundlist.Count - 1; i > -1; i--)
				{
					CSound cSound = (CSound)this.soundlist[i];
					if (!cSound.buffer.Status.Playing)
					{
						this.soundlist.RemoveAt(i);
					}
				}
			}
		}
		public void ClearSounds()
		{
			if (this.soundlist.Count > 0)
			{
				for (int i = this.soundlist.Count - 1; i > -1; i--)
				{
					CSound cSound = (CSound)this.soundlist[i];
					cSound.buffer.Stop();
					this.soundlist.RemoveAt(i);
				}
			}
			if (this.actionsoundlist.Count > 0)
			{
				for (int j = this.actionsoundlist.Count - 1; j > -1; j--)
				{
					CSound cSound2 = (CSound)this.actionsoundlist[j];
					cSound2.buffer.Dispose();
					this.actionsoundlist.RemoveAt(j);
				}
			}
		}
		public int AddSound(int isound, bool soundloop)
		{
			if (isound > -1 && isound < this.availsoundlist.Count)
			{
				SecondaryBuffer secondaryBuffer = (SecondaryBuffer)this.availsoundlist[isound];
				SecondaryBuffer pbuffer = secondaryBuffer.Clone(this.sounddevice);
				CSound cSound = new CSound(pbuffer, soundloop);
				if (soundloop)
				{
					cSound.buffer.Play(0, BufferPlayFlags.Looping);
				}
				else
				{
					cSound.buffer.Play(0, BufferPlayFlags.Default);
				}
				this.soundlist.Add(cSound);
				this.actionsoundlist.Add(cSound);
				return this.actionsoundlist.Count - 1;
			}
			return -1;
		}
		public void StopSound(int isound)
		{
			try
			{
				CSound cSound = (CSound)this.actionsoundlist[isound];
				cSound.buffer.Stop();
			}
			catch
			{
			}
		}
		public void StopSounds()
		{
			foreach (CSound cSound in this.soundlist)
			{
				cSound.buffer.Stop();
			}
		}
		public void PauseSounds()
		{
			foreach (CSound cSound in this.soundlist)
			{
				if (cSound.loop)
				{
					cSound.buffer.Stop();
				}
				else
				{
					cSound.buffer.Stop();
				}
			}
		}
		public void ResumeSounds()
		{
			foreach (CSound cSound in this.soundlist)
			{
				if (cSound.loop)
				{
					cSound.buffer.Play(0, BufferPlayFlags.Looping);
				}
				else
				{
					cSound.buffer.Play(0, BufferPlayFlags.Default);
				}
			}
		}
	}
}
