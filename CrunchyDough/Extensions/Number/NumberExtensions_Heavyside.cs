using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Heavyside
    {
		static public byte HeavysideTo(this byte item, byte value, byte radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public short HeavysideTo(this short item, short value, short radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public int HeavysideTo(this int item, int value, int radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public long HeavysideTo(this long item, long value, long radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public float HeavysideTo(this float item, float value, float radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public double HeavysideTo(this double item, double value, double radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
		static public decimal HeavysideTo(this decimal item, decimal value, decimal radius)
        {
			if(item.IsBoundAround(value, radius))
                return value;
                
            return item;
        }
	}
}