using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class EvtInfoEX_MethodPair : EvtInfoEX
    {
        private MethodInfo add_method;
        private MethodInfo remove_method;

        public EvtInfoEX_MethodPair(MethodInfo a, MethodInfo r)
        {
            add_method = a;
            remove_method = r;
        }

        public override string GetName()
        {
            return add_method.Name.DetectEntityEvtName();
        }

        public override Type GetEvtType()
        {
            return add_method.GetEffectiveParameterType(0);
        }

        public override Type GetDeclaringType()
        {
            return add_method.DeclaringType;
        }

        public override BasicEventRegister GetBasicEventRegister()
        {
            return delegate(object target, object evt) {
                add_method.GetBasicMethodInvoker()(target, new object[] { evt });
            }; 
        }

        public override BasicEventDeregister GetBasicEventDeregister()
        {
            return delegate(object target, object evt) {
                remove_method.GetBasicMethodInvoker()(target, new object[] { evt });
            };
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return add_method.IfNotNull(m => m.GetAllCustomAttributes(inherit)).Append(
                remove_method.IfNotNull(m => m.GetAllCustomAttributes(inherit))
            );
        }

        public override void EmitRegisterEvent(ILCanvas canvas, ILValue target, ILValue evt)
        {
            target.GetILMethodInvokation(add_method, evt)
                .CreateILCalculate()
                .RenderIL_Execute(canvas);
        }

        public override void EmitDeregisterEvent(ILCanvas canvas, ILValue target, ILValue evt)
        {
            target.GetILMethodInvokation(remove_method, evt)
                .CreateILCalculate()
                .RenderIL_Execute(canvas);
        }
    }
}