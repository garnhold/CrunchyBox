
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Array : TyonValue
    {
        public TyonValue_Array(Type element_type, object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonArray(new TyonArray(element_type, value, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonArray().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            int size = GetTyonArray().GetNumberTyonValues();
            Type log_type = GetTyonArray().GetLogSystemType(hydrater);

            int index = 0;
            Variable_IndexedLog log = Variable_IndexedLog.New(log_type);

            if (variable.GetContents() != null)
            {
                foreach (object old_element in variable.GetContents().Convert<IEnumerable>())
                    log.CreateStrongInstance(index++).SetContents(old_element);
            }

            while (index < size)
                log.CreateStrongInstance(index++);

            GetTyonArray().GetTyonValues().ProcessWithIndex((i, v) => v.PushToVariable(log.CreateStrongInstance(i), hydrater));

            hydrater.DeferProcess(delegate() {
                List<object> values = log.GetValues()
                    .Truncate(size)
                    .ToList();

                Type final_type = GetTyonArray().IsExplicitlyTyped().ConvertBool(
                    () => log_type,
                    () => values.Convert(v => v.GetTypeEX()).GetCommonAncestor()
                );   

                variable.SetContents(values.ToArrayOfType(final_type));
            });
        }
    }

}
