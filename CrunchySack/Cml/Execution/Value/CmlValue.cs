
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract class CmlValue
	{
        public abstract CmlScriptValue_Argument CreateScriptArgument();
	}

    static public class CmlValueExtensions
    {
        static public object ForceSystemValue(this CmlValue item)
        {
            return item.Convert<CmlValue_SystemValue>().IfNotNull(v => v.GetSystemValue());
        }

        static public T ForceSystemValueEX<T>(this CmlValue item)
        {
            return item.ForceSystemValue().ConvertEX<T>();
        }

        static public T ForceSystemValue<T>(this CmlValue item)
        {
            return item.ForceSystemValue().Convert<T>();
        }
    }
}
