using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    public class IndexerInfoEX_MethodPair : IndexerInfoEX
    {
        private MethodInfoEX set_method;
        private MethodInfoEX get_method;

        public IndexerInfoEX_MethodPair(MethodInfoEX s, MethodInfoEX g) : base(
            s.IfNotNull(z => z.DeclaringType) ?? g.IfNotNull(z => z.DeclaringType),
            s.IfNotNull(z => z.GetEffectiveParameterType(0)) ?? g.IfNotNull(z => z.GetEffectiveParameterType(0)),
            s.IfNotNull(z => z.GetEffectiveParameterType(1)) ?? g.IfNotNull(z => z.ReturnType)
        )
        {
            set_method = s;
            get_method = g;
        }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            new ILMethodInvokation(target, get_method, index).RenderIL_Load(canvas);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            new ILMethodInvokation(target, set_method, index, value).CreateILCalculate().RenderIL_Execute(canvas);
        }

        public override bool CanLoad()
        {
            if (get_method != null)
                return true;

            return false;
        }

        public override bool CanStore()
        {
            if (set_method != null)
                return true;

            return false;
        }
    }
}