using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Filterer<T> : IdentifiableObject
    {
        public abstract bool Filter(T item);

        public virtual bool Filter(T item, out T adjusted)
        {
            adjusted = item;

            return Filter(item);
        }

        static public Filterer<T> operator |(Filterer<T> f1, Filterer<T> f2)
        {
            return new Filterer_BinaryOperation_Or<T>(f1, f2);
        }

        static public Filterer<T> operator &(Filterer<T> f1, Filterer<T> f2)
        {
            return new Filterer_BinaryOperation_And<T>(f1, f2);
        }

        static public Filterer<T> operator !(Filterer<T> f)
        {
            return new Filterer_UnaryOperation_Not<T>(f);
        }

        public virtual IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Empty.IEnumerable<Filterer<Assembly>>();
        }
    }
}