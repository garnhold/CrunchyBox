using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILCanvasExtensions_RenderUse
    {
        static public void UseValue(this ILCanvas item, ILValue value, Process<ILValue> process)
        {
            if (value.IsILCostTrivial())
                process(value);
            else
                item.UseLocalValue(value, l => process(l));
        }

        static public void UseLocal(this ILCanvas item, Type type, Process<ILLocal> process)
        {
            ILLocal local = new ILLocal(type, null, null, false);

            local.Allocate(item);
                process(local);
            local.Release(item);
        }

        static public void UseLocalValue(this ILCanvas item, ILValue value, Process<ILLocal> process)
        {
            item.UseLocal(value.GetValueType(), delegate(ILLocal local) {
                local.RenderIL_Store(item, value);
                process(local);
            });
        }

        static public void UseLocalValueImmediate(this ILCanvas item, Type type, Process<ILLocal> process)
        {
            item.UseLocal(type, delegate(ILLocal local) {
                local.RenderIL_StoreImmediate(item);
                process(local);
            });
        }
    }        
}