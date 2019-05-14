using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class SignalingIndexedItemSet<T> : SignalingLabeledItemSet<int, T> where T : IndexedItem
    {
        public SignalingIndexedItemSet(Predicate<T> a, Predicate<T> r) : base(a, r) { }
        public SignalingIndexedItemSet() : base() { }
    }

    public class SignalingNamedItemSet<T> : SignalingLabeledItemSet<string, T> where T : NamedItem
    {
        public SignalingNamedItemSet(Predicate<T> a, Predicate<T> r) : base(a, r) { }
        public SignalingNamedItemSet() : base() { }
    }
}