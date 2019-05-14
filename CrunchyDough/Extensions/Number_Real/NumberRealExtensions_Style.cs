using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberRealExtensions_Style
    {
		static public string StyleAsPercent(this float item)
		{
			return item.ToString("P2");
		}
		static public string StyleAsPercent(this double item)
		{
			return item.ToString("P2");
		}
		static public string StyleAsPercent(this decimal item)
		{
			return item.ToString("P2");
		}
	}
}