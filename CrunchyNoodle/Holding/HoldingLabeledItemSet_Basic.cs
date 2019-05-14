using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class HoldingIndexedItemSet<P, T> : HoldingLabeledItemSet<P, int, T> where T : Holdable<P>, IndexedItem
    {
        public HoldingIndexedItemSet(P p) : base(p) { }
    }

    public class HoldingNamedItemSet<P, T> : HoldingLabeledItemSet<P, string, T> where T : Holdable<P>, NamedItem
    {
        public HoldingNamedItemSet(P p) : base(p) { }
    }
}