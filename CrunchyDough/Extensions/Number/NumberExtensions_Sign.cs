using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Heavyside
    {
		static public short GetSign(this short item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
		static public int GetSign(this int item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
		static public long GetSign(this long item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
		static public float GetSign(this float item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
		static public double GetSign(this double item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
		static public decimal GetSign(this decimal item)
        {
            if(item > 0)
                return 1;
                
            if(item < 0)
                return -1;
                
            return 0;
        }
	}
}