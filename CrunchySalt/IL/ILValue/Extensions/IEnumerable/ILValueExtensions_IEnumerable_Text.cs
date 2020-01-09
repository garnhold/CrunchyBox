using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_IEnumerable_Text
    {
        static public void RenderText_Value<T>(this IEnumerable<T> item, ILTextCanvas canvas, string seperator) where T : ILValue
        {
            item.Process(
                i => i.RenderText_Value(canvas),
                i => {
                    canvas.AppendToLine(seperator);
                    i.RenderText_Value(canvas);
                }
            );
        }
    }
}