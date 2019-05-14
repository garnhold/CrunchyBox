using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class HoldingLabeledItemSet<P, LABEL_TYPE, ELEMENT_TYPE> : SignalingLabeledItemSet<LABEL_TYPE, ELEMENT_TYPE>, HoldingContainer<P> where ELEMENT_TYPE : Holdable<P>, LabeledItem<LABEL_TYPE>
    {
        private P parent;

        public HoldingLabeledItemSet(P p)
        {
            parent = p;

            SetCanAddPredicate(HoldingContainerExtensions_Predicate.CanAdd<P, ELEMENT_TYPE>(this));
            SetCanRemovePredicate(HoldingContainerExtensions_Predicate.CanRemove<P, ELEMENT_TYPE>(this));
        }

        public bool TryAdd(Holdable<P> to_add)
        {
            ELEMENT_TYPE cast;

            if (to_add.Convert<ELEMENT_TYPE>(out cast))
                return base.TryAdd(cast);

            return false;
        }

        public bool Remove(Holdable<P> to_remove)
        {
            ELEMENT_TYPE cast;

            if (to_remove.Convert<ELEMENT_TYPE>(out cast))
                return base.Remove(cast);

            return false;
        }

        public P GetParent()
        {
            return parent;
        }
    }
}