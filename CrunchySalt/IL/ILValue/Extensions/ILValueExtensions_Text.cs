using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Text
    {
        static public void RenderText_ValueEX(this ILValue item, ILTextCanvas canvas)
        {
            item.IfNotNull(i => i.RenderText_Value(canvas), () => canvas.AppendToLine("?????"));
        }
    }
}