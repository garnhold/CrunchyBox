using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class FactoryBase<T>
    {
        private ConstructorInvoker<T> constructor_invoker;

        protected T InvokeConstructor(params object[] args)
        {
            return constructor_invoker(args);
        }

        public FactoryBase(Type type, IEnumerable<Type> parameter_types)
        {
            constructor_invoker = type.GetFilteredConstructors(
                Filterer_ConstructorInfo.CanEffectiveParametersHold(parameter_types)
            ).GetFirst().GetConstructorInvoker<T>();
        }

        public FactoryBase(Type type, params Type[] parameter_types) : this(type, (IEnumerable<Type>)parameter_types) { }
    }

    public class Factory<T> : FactoryBase<T>
    {
        public Factory(Type type) : base(type) { }

        public T Create()
        {
            return InvokeConstructor();
        }
    }

    public class Factory<T, P1> : FactoryBase<T>
    {
        public Factory(Type type) : base(type, typeof(P1)) { }

        public T Create(P1 p1)
        {
            return InvokeConstructor(p1);
        }
    }

    public class Factory<T, P1, P2> : FactoryBase<T>
    {
        public Factory(Type type) : base(type, typeof(P1), typeof(P2)) { }

        public T Create(P1 p1, P2 p2)
        {
            return InvokeConstructor(p1, p2);
        }
    }

    public class Factory<T, P1, P2, P3> : FactoryBase<T>
    {
        public Factory(Type type) : base(type, typeof(P1), typeof(P2), typeof(P3)) { }

        public T Create(P1 p1, P2 p2, P3 p3)
        {
            return InvokeConstructor(p1, p2, p3);
        }
    }

    public class Factory<T, P1, P2, P3, P4> : FactoryBase<T>
    {
        public Factory(Type type) : base(type, typeof(P1), typeof(P2), typeof(P3), typeof(P4)) { }

        public T Create(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return InvokeConstructor(p1, p2, p3, p4);
        }
    }
}