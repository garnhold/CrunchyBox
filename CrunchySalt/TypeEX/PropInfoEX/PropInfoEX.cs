using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class PropInfoEX : IDynamicCustomAttributeProvider
    {
        public abstract string GetName();
        public abstract Type GetPropType();
        public abstract Type GetDeclaringType();

        public abstract bool CanSet();
        public abstract bool CanGet();

        public abstract bool IsSetPublic();
        public abstract bool IsGetPublic();

        public abstract BasicValueSetter GetBasicValueSetter();
        public abstract BasicValueGetter GetBasicValueGetter();

        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public abstract void EmitLoad(ILCanvas canvas, ILValue target);
        public abstract void EmitLoadAddress(ILCanvas canvas, ILValue target);

        public abstract void EmitStore(ILCanvas canvas, ILValue target, ILValue to_store);

        public ValueSetter<T> GetValueSetter<T>()
        {
            return GetBasicValueSetter().GetTypeSafe<T>();
        }   

        public ValueGetter<T> GetValueGetter<T>()
        {
            return GetBasicValueGetter().GetTypeSafe<T>();
        }

        public object GetValue(object obj)
        {
            return GetBasicValueGetter()(obj);
        }

        public void SetValue(object obj, object value)
        {
            GetBasicValueSetter()(obj, value);
        }

        public override string ToString()
        {
            return "{0} {1}.{2}".Inject(
                GetPropType(),
                GetDeclaringType(),
                GetName()
            );
        }
    }
}