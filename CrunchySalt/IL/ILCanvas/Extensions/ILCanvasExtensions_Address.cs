using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILCanvasExtensions_Address
    {
        static public void MakeAddressImmediate(this ILCanvas item, Type type)
        {
            item.UseLocalValueImmediate(type, l => l.RenderIL_LoadAddress(item));
        }
    }        
}