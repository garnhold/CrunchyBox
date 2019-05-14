using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Combination_All<T> : Filterer_Combination<T>
    {
        public Filterer_Combination_All(IEnumerable<Filterer<T>> f) : base(f) { }
        public Filterer_Combination_All(params Filterer<T>[] f) : base(f) { }

        public override bool Filter(T item) { return GetFilters().AreAll(f => f.Filter(item)); }
    }
    static public partial class Filterer_Utility
    {
        static public Filterer<T> All<T>(IEnumerable<Filterer<T>> filters)
        {
            return new Filterer_Combination_All<T>(filters);
        }
        static public Filterer<T> All<T>(params Filterer<T>[] filters)
        {
            return All((IEnumerable<Filterer<T>>)filters);
        }
    }

    public class Filterer_Combination_Any<T> : Filterer_Combination<T>
    {
        public Filterer_Combination_Any(IEnumerable<Filterer<T>> f) : base(f) { }
        public Filterer_Combination_Any(params Filterer<T>[] f) : base(f) { }

        public override bool Filter(T item) { return GetFilters().Has(f => f.Filter(item)); }
    }
    static public partial class Filterer_Utility
    {
        static public Filterer<T> Any<T>(IEnumerable<Filterer<T>> filters)
        {
            return new Filterer_Combination_Any<T>(filters);
        }
        static public Filterer<T> Any<T>(params Filterer<T>[] filters)
        {
            return Any((IEnumerable<Filterer<T>>)filters);
        }
    }

    public class Filterer_Combination_None<T> : Filterer_Combination<T>
    {
        public Filterer_Combination_None(IEnumerable<Filterer<T>> f) : base(f) { }
        public Filterer_Combination_None(params Filterer<T>[] f) : base(f) { }

        public override bool Filter(T item) { return GetFilters().AreNone(f => f.Filter(item)); }
    }
    static public partial class Filterer_Utility
    {
        static public Filterer<T> None<T>(IEnumerable<Filterer<T>> filters)
        {
            return new Filterer_Combination_None<T>(filters);
        }
        static public Filterer<T> None<T>(params Filterer<T>[] filters)
        {
            return None((IEnumerable<Filterer<T>>)filters);
        }
    }

    public abstract class Filterer_Combination<T> : Filterer<T>
    {
        private List<Filterer<T>> filters;

        protected override bool EqualsInternal(object obj)
        {
            Filterer_Combination<T> cast = obj as Filterer_Combination<T>;

            if(cast.filters.AreElementsEqual(filters))
                return true;

            return false;
        }

        protected override int GetHashCodeInternal()
        {
            return filters.GetElementsHashCode();
        }

        protected override string GetIdentityInternal()
        {
            return filters.GetElementsIdentity();
        }

        public Filterer_Combination(IEnumerable<Filterer<T>> f)
        {
            filters = new List<Filterer<T>>(f);
        }
        public Filterer_Combination(params Filterer<T>[] f) : this((IEnumerable<Filterer<T>>)f)
        {
        }

        public IEnumerable<Filterer<T>> GetFilters()
        {
            return filters;
        }
    }
}