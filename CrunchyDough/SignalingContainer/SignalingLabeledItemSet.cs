using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class SignalingLabeledItemSet<LABEL_TYPE, ELEMENT_TYPE> : SignalingContainer_Collection_LabeledItemSet<LABEL_TYPE, ELEMENT_TYPE> where ELEMENT_TYPE : LabeledItem<LABEL_TYPE>
    {
        private Predicate<ELEMENT_TYPE> can_add_predicate;
        private Predicate<ELEMENT_TYPE> can_remove_predicate;

        protected override bool CanAdd(ELEMENT_TYPE item)
        {
            return can_add_predicate.DoesDescribe(item);
        }

        protected override bool CanRemove(ELEMENT_TYPE item)
        {
            return can_remove_predicate.DoesDescribe(item);
        }

        protected void SetCanAddPredicate(Predicate<ELEMENT_TYPE> a)
        {
            can_add_predicate = a;
        }

        protected void SetCanRemovePredicate(Predicate<ELEMENT_TYPE> r)
        {
            can_remove_predicate = r;
        }

        public SignalingLabeledItemSet(Predicate<ELEMENT_TYPE> a, Predicate<ELEMENT_TYPE> r)
        {
            SetCanAddPredicate(a);
            SetCanRemovePredicate(r);
        }

        public SignalingLabeledItemSet() : this(Predicates<ELEMENT_TYPE>.EVERYTHING, Predicates<ELEMENT_TYPE>.EVERYTHING)
        {
        }
    }
}