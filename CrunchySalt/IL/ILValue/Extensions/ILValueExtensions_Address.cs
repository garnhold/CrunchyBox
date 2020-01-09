using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Address
    {
        static public void RenderIL_LoadAddress(this ILValue item, ILCanvas canvas)
        {
            ILAddressable cast;

            if (item.Convert<ILAddressable>(out cast))
                cast.RenderIL_LoadAddress(canvas);
            else
                item.RenderIL_LoadAddressInternal(canvas);
        }

        static public void RenderIL_LoadAddressInternal(this ILValue item, ILCanvas canvas)
        {
            item.RenderIL_Load(canvas);
            canvas.MakeAddressImmediate(item.GetValueType());
        }
    }
}