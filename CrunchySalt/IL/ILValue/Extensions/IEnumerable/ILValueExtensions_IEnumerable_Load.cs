using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_IEnumerable_Load
    {
        static public void RenderIL_Load(this IEnumerable<ILValue> item, ILCanvas canvas)
        {
            item.Process(i => i.RenderIL_Load(canvas));
        }
    }
}