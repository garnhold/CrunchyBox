using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_IEnumerable_Load
    {
        static public void RenderIL_Load<T>(this IEnumerable<T> item, ILCanvas canvas) where T : ILValue
        {
            item.Process(i => i.RenderIL_Load(canvas));
        }
    }
}