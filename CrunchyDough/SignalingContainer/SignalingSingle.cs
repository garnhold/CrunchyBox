using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class SignalingSingle<T> : SignalingContainer_Single<T>
    {
        private Predicate<T> can_add_predicate;
        private Predicate<T> can_remove_predicate;

        protected override bool CanAdd(T item)
        {
            return can_add_predicate.DoesDescribe(item);
        }

        protected override bool CanRemove(T item)
        {
            return can_remove_predicate.DoesDescribe(item);
        }

        protected void SetCanAddPredicate(Predicate<T> a)
        {
            can_add_predicate = a;
        }

        protected void SetCanRemovePredicate(Predicate<T> r)
        {
            can_remove_predicate = r;
        }

        public SignalingSingle(Predicate<T> a, Predicate<T> r)
        {
            SetCanAddPredicate(a);
            SetCanRemovePredicate(r);
        }

        public SignalingSingle() : this(Predicates<T>.EVERYTHING, Predicates<T>.EVERYTHING)
        {
        }
    }
}