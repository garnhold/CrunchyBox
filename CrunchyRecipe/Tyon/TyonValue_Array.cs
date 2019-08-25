
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
        public TyonValue_Array(VariableInstance variable, TyonDehydrater dehydrater) : this()
        {
            SetTyonArray(new TyonArray(variable, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonArray().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            int size = GetTyonArray().GetNumberTyonValues();
            Type type = GetTyonArray().GetTyonType().GetSystemType(hydrater);

            if (type != null)
            {
                int index = 0;
                Variable_IndexedLog log = Variable_IndexedLog.New(type);

                if (variable.GetContents() != null)
                {
                    foreach (object old_element in variable.GetContents().Convert<IEnumerable>())
                        log.CreateStrongInstance(index++).SetContents(old_element);
                }

                while (index < size)
                    log.CreateStrongInstance(index++);

                GetTyonArray().GetTyonValues().ProcessWithIndex((i, v) => v.PushToVariable(log.CreateStrongInstance(i), hydrater));

                hydrater.DeferProcess(delegate() {
                    variable.SetContents(log.GetValues().Truncate(size).ToArrayOfType(type));
                });
            }
        }
    }

}
