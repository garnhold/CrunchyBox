
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public partial class TyonValue_Array : TyonValue
    {
        public TyonValue_Array(object value, Variable variable, TyonContext_Dehydration context) : this()
        {
            SetTyonArray(new TyonArray(value, variable, context));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonArray().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            int size = GetTyonArray().GetNumberTyonValues();
            Type type = GetTyonArray().GetTyonType().GetSystemType();
            
            int index = 0;
            Variable_IndexedLog log = Variable_IndexedLog.New(type);

            if (variable.GetContents() != null)
            {
                foreach (object old_element in variable.GetContents().Convert<IEnumerable>())
                    log.CreateStrongInstance(index++).SetContents(old_element);
            }

            while (index < size)
                log.CreateStrongInstance(index++);

            GetTyonArray().GetTyonValues().ProcessWithIndex((i, v) => v.PushToVariable(log.CreateStrongInstance(i), context));

            context.DeferProcess(delegate() {
                variable.SetContents(log.GetValues().Truncate(size).ToArrayOfType(type));
            });
        }
    }

}
