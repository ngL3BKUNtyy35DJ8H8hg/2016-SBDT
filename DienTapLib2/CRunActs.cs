using System;
using System.Collections.Generic;
namespace DienTapLib
{
	public class CRunActs
	{
		public List<CAct> actions;
		public int StartTickCount;
		public int StopTickCount;
		public CRunActs()
		{
			this.actions = new List<CAct>();
			this.StartTickCount = 0;
			this.StopTickCount = 0;
		}
		public void UpdateStart(int pStart)
		{
			int num = pStart - this.StartTickCount;
			foreach (CAct current in this.actions)
			{
				current.StartTickCount += num;
				current.StopTickCount += num;
			}
			this.StartTickCount = pStart;
			this.StopTickCount += num;
		}
	}
}
