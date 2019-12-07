using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    using Salt;
    
    public class ILNewPopulatedArray : ILValue
    {
        private Type element_type;
        private List<ILValue> values;

        public ILNewPopulatedArray(Type e, IEnumerable<ILValue> v)
        {
            element_type = e;
            values = v.ToList();
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.UseValue(
                new ILNewArray(element_type, values.Count),
                delegate(ILValue local) {
                    new ILAssignArray(local, values).RenderIL_Execute(canvas);
                    local.RenderIL_Load(canvas);
                }
            );
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("new ");
            canvas.AppendToLine(element_type.Name);
            canvas.AppendToLine("[");
                values.RenderText_Value(canvas, ", ");
            canvas.AppendToLine("]");
        }

        public override Type GetValueType()
        {
            return element_type.MakeArrayType();
        }

        public override bool IsILCostTrivial()
        {
            return false;
        }

        public override bool CanLoad()
        {
            return true;
        }
    }
}