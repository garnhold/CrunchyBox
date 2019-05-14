using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_UnaryOperation_Not<T> : Filterer_UnaryOperation<T>
    {
        protected override bool FilterInternal(T item, Filterer<T> f)
        {
            return f.Filter(item) == false;
        }

        public Filterer_UnaryOperation_Not(Filterer<T> f) : base(f) { }
    }

    public abstract class Filterer_UnaryOperation<T> : Filterer<T>
    {
        private Filterer<T> filterer;

        protected abstract bool FilterInternal(T item, Filterer<T> f1);

        protected override bool EqualsInternal(object obj)
        {
            Filterer_UnaryOperation<T> cast = obj as Filterer_UnaryOperation<T>;

            if(filterer.EqualsEX(cast.filterer))
                return true;

            return false;
        }

        protected override int GetHashCodeInternal()
        {
            return filterer.GetHashCodeEX();
        }

        protected override string GetIdentityInternal()
        {
            return filterer.GetIdentityEX();
        }

        public Filterer_UnaryOperation(Filterer<T> f)
        {
            filterer = f;
        }

        public override bool Filter(T item)
        {
            return FilterInternal(item, filterer);
        }
    }
}