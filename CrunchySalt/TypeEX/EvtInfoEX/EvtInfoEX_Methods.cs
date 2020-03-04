using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class EvtInfoEX_Methods : EvtInfoEX
    {
        private MethodInfo invoke_method;

        private MethodInfo add_method;
        private MethodInfo remove_method;

        public EvtInfoEX_Methods(MethodInfo i, MethodInfo a, MethodInfo r)
        {
            invoke_method = i;

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

        public override bool CanInvoke()
        {
            if (invoke_method != null)
                return true;

            return false;
        }

        public override bool CanAdd()
        {
            if (add_method != null)
                return true;

            return false;
        }

        public override bool CanRemove()
        {
            if (remove_method != null)
                return true;

            return false;
        }

        public override bool IsInvokePublic()
        {
            return invoke_method.IfNotNull(m => m.IsPublicMethod());
        }

        public override bool IsAddPublic()
        {
            return add_method.IfNotNull(m => m.IsPublicMethod());
        }

        public override bool IsRemovePublic()
        {
            return remove_method.IfNotNull(m => m.IsPublicMethod());
        }

        public override BasicEventInvoker GetBasicEventInvoker()
        {
            return delegate (object target) {
                invoke_method.GetBasicMethodInvoker()(target, Empty.Array<object>());
            };
        }

        public override BasicDelegateAdder GetBasicDelegateAdder()
        {
            return delegate(object target, object evt) {
                add_method.GetBasicMethodInvoker()(target, new object[] { evt });
            }; 
        }

        public override BasicDelegateRemover GetBasicDelegateRemover()
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

        public override void EmitAddDelegate(ILCanvas canvas, ILValue target, ILValue @delegate)
        {
            target.GetILMethodInvokation(add_method, @delegate)
                .CreateILCalculate()
                .RenderIL_Execute(canvas);
        }

        public override void EmitRemoveDelegate(ILCanvas canvas, ILValue target, ILValue @delegate)
        {
            target.GetILMethodInvokation(remove_method, @delegate)
                .CreateILCalculate()
                .RenderIL_Execute(canvas);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + invoke_method.GetHashCodeEX();
                hash = hash * 23 + add_method.GetHashCodeEX();
                hash = hash * 23 + remove_method.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            EvtInfoEX_Methods cast;

            if (obj.Convert<EvtInfoEX_Methods>(out cast))
            {
                if (cast.invoke_method == invoke_method)
                {
                    if (cast.add_method == add_method)
                    {
                        if (cast.remove_method == remove_method)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}