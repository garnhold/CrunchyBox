using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public interface IndexedItemLookup<T> : LookupSet<int, T> where T : IndexedItem { }
    public class IndexedItemSet<T> : LabeledItemSet<int, T>, IndexedItemLookup<T> where T : IndexedItem
    {
        public IndexedItemSet() : base() { }
        public IndexedItemSet(IEnumerable<T> items) : base(items) { }
        public IndexedItemSet(params T[] items) : base((IEnumerable<T>)items) { }
    }
}