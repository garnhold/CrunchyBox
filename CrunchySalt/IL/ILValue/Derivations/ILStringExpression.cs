using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILStringExpression : ILValue
    {
        private List<ILValue> values;

        public ILStringExpression(IEnumerable<ILValue> v)
        {
            values = v.ToList();
        }

        public ILStringExpression(params ILValue[] v) : this((IEnumerable<ILValue>)v) { }

        public ILStringExpression(string pattern, string format, Operation<ILValue, Match> operation)
            : this(
                format.RegexConvert<ILValue>(pattern,
                    s => s,
                    m => operation(m)
                )) { }

        public ILStringExpression(string format, Operation<ILValue, string> operation)
            : this("\\{(.*?)\\}", format, m => operation(m.Groups[1].Value)) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            MethodInfoEX explicit_method = typeof(string).GetStaticMethod(
                "Concat", typeof(object).Repeat(values.Count)
            );

            if (explicit_method != null)
                explicit_method.GetStaticILMethodInvokation(values).RenderIL_Load(canvas);
            else
                typeof(string).GetStaticILMethodInvokation("Concat", new ILNewPopulatedArray(typeof(object), values)).RenderIL_Load(canvas);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            values.RenderText_Value(canvas, " + ");
        }

        public override Type GetValueType()
        {
            return typeof(string);
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