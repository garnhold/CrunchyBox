using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILStatementExtensions_Text
    {
        static public void RenderText_StatementEX(this ILStatement item, ILTextCanvas canvas)
        {
            item.IfNotNull(i => i.RenderText_Statement(canvas), () => canvas.AppendToLine("?????;"));
        }
    }
}