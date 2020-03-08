using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class EvtInfoEX : IDynamicCustomAttributeProvider
    {
        public abstract string GetName();
        public abstract Type GetEvtType();
        public abstract Type GetDeclaringType();

        public abstract bool CanAdd();
        public abstract bool CanRemove();

        public abstract bool IsAddPublic();
        public abstract bool IsRemovePublic();

        public abstract BasicDelegateAdder GetBasicDelegateAdder();
        public abstract BasicDelegateRemover GetBasicDelegateRemover();

        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public abstract void EmitAddDelegate(ILCanvas canvas, ILValue target, ILValue @delegate);
        public abstract void EmitRemoveDelegate(ILCanvas canvas, ILValue target, ILValue @delegate);

        public DelegateAdder<T> GetDelegateAdder<T>()
        {
            return GetBasicDelegateAdder().GetTypeSafe<T>();
        }

        public DelegateRemover<T> GetDelegateRemover<T>()
        {
            return GetBasicDelegateRemover().GetTypeSafe<T>();
        }

        public void AddDelegate(object obj, Delegate @delegate)
        {
            GetBasicDelegateAdder()(obj, @delegate);
        }

        public void RemoveDelegate(object obj, Delegate @delegate)
        {
            GetBasicDelegateRemover()(obj, @delegate);
        }

        public override string ToString()
        {
            return "{0} {1}.{2}".Inject(
                GetEvtType(),
                GetDeclaringType(),
                GetName()
            );
        }
    }
}