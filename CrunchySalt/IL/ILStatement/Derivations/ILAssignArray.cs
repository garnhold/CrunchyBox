using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILAssignArray : ILStatement
    {
        private ILValue array;

        private List<ILValue> values;

        public ILAssignArray(ILValue a, IEnumerable<ILValue> v)
        {
            array = a;
            values = v.ToList();
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            canvas.UseValue(array, delegate(ILValue local) {
                values.ProcessWithIndex(
                    (i, v) => local.GetILIndexed(i).RenderIL_Store(canvas, v)
                );
            });
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            array.RenderText_Value(canvas);
            canvas.AppendToLine(" = [");
                values.RenderText_ValueEX(canvas, ", ");
            canvas.AppendToLine("];");
        }

        public ILValue GetArray()
        {
            return array;
        }

        public IEnumerable<ILValue> GetValues()
        {
            return values;
        }
    }
}