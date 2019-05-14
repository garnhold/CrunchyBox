using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class HoldingSingle<P, T> : SignalingSingle<T>, HoldingContainer<P> where T : Holdable<P>
    {
        private P parent;

        public HoldingSingle(P p)
        {
            parent = p;

            SetCanAddPredicate(HoldingContainerExtensions_Predicate.CanAdd<P, T>(this));
            SetCanRemovePredicate(HoldingContainerExtensions_Predicate.CanRemove<P, T>(this));
        }

        public bool TryAdd(Holdable<P> to_add)
        {
            T cast;

            if (to_add.Convert<T>(out cast))
                return base.Set(cast);

            return false;
        }

        public bool Remove(Holdable<P> to_remove)
        {
            T cast;

            if (to_remove.Convert<T>(out cast))
                return base.Remove(cast);

            return false;
        }

        public P GetParent()
        {
            return parent;
        }
    }
}