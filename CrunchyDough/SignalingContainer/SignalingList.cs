using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class SignalingList<T> : SignalingContainer_Collection_List<T>
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

        public SignalingList(Predicate<T> a, Predicate<T> r)
        {
            SetCanAddPredicate(a);
            SetCanRemovePredicate(r);
        }

        public SignalingList() : this(Predicates<T>.EVERYTHING, Predicates<T>.EVERYTHING)
        {
        }
    }
}