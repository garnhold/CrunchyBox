using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_BinaryOperation_And<T> : Filterer_BinaryOperation<T>
    {
        protected override bool FilterInternal(T item, Filterer<T> f1, Filterer<T> f2)
        {
            return f1.Filter(item) && f2.Filter(item);
        }

        public Filterer_BinaryOperation_And(Filterer<T> f1, Filterer<T> f2) : base(f1, f2) { }
    }

    public class Filterer_BinaryOperation_Or<T> : Filterer_BinaryOperation<T>
    {
        protected override bool FilterInternal(T item, Filterer<T> f1, Filterer<T> f2)
        {
            return f1.Filter(item) || f2.Filter(item);
        }

        public Filterer_BinaryOperation_Or(Filterer<T> f1, Filterer<T> f2) : base(f1, f2) { }
    }

    public abstract class Filterer_BinaryOperation<T> : Filterer<T>
    {
        private Filterer<T> filterer_left;
        private Filterer<T> filterer_right;

        protected abstract bool FilterInternal(T item, Filterer<T> f1, Filterer<T> f2);

        protected override bool EqualsInternal(object obj)
        {
            Filterer_BinaryOperation<T> cast = obj as Filterer_BinaryOperation<T>;

            if(filterer_left.EqualsEX(cast.filterer_left))
            {
                if(filterer_right.EqualsEX(cast.filterer_right))
                    return true;
            }

            return false;
        }

        protected override int GetHashCodeInternal()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + filterer_left.GetHashCodeEX();
                hash = hash * 23 + filterer_right.GetHashCodeEX();
                return hash;
            }
        }

        protected override string GetIdentityInternal()
        {
            return "Binary(" + filterer_left.GetIdentityEX() + "," + filterer_right.GetIdentityEX() + ")";
        }

        public Filterer_BinaryOperation(Filterer<T> f1, Filterer<T> f2)
        {
            filterer_left = f1;
            filterer_right = f2;
        }

        public override bool Filter(T item)
        {
            return FilterInternal(item, filterer_left, filterer_right);
        }
    }
}