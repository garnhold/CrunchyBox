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

        public abstract BasicEventRegister GetBasicEventRegister();
        public abstract BasicEventDeregister GetBasicEventDeregister();

        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public abstract void EmitRegisterEvent(ILCanvas canvas, ILValue target, ILValue evt);
        public abstract void EmitDeregisterEvent(ILCanvas canvas, ILValue target, ILValue evt);

        public EventRegister<T> GetEventRegister<T>()
        {
            return GetBasicEventRegister().GetTypeSafe<T>();
        }

        public EventDeregister<T> GetEventDeregister<T>()
        {
            return GetBasicEventDeregister().GetTypeSafe<T>();
        }

        public void AddDelegate(object obj, Delegate evt)
        {
            GetBasicEventRegister()(obj, evt);
        }

        public void RemoveDelegate(object obj, Delegate evt)
        {
            GetBasicEventDeregister()(obj, evt);
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