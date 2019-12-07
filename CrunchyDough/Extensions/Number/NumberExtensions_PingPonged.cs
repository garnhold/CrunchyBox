using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_PingPonged
    {
		static public byte GetPingPonged(this byte item, byte length)
        {
			long times = (long)(item / length);
			byte looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (byte)(length - looped);
			
			return looped;
        }
		static public short GetPingPonged(this short item, short length)
        {
			long times = (long)(item / length);
			short looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (short)(length - looped);
			
			return looped;
        }
		static public int GetPingPonged(this int item, int length)
        {
			long times = (long)(item / length);
			int looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (int)(length - looped);
			
			return looped;
        }
		static public long GetPingPonged(this long item, long length)
        {
			long times = (long)(item / length);
			long looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (long)(length - looped);
			
			return looped;
        }
		static public float GetPingPonged(this float item, float length)
        {
			long times = (long)(item / length);
			float looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (float)(length - looped);
			
			return looped;
        }
		static public double GetPingPonged(this double item, double length)
        {
			long times = (long)(item / length);
			double looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (double)(length - looped);
			
			return looped;
        }
		static public decimal GetPingPonged(this decimal item, decimal length)
        {
			long times = (long)(item / length);
			decimal looped = item.GetLooped(length);

			if(times % 2 == 0)
				return (decimal)(length - looped);
			
			return looped;
        }
	}
}