using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface NamedItemLookup<T> : LookupSet<string, T> where T : NamedItem { }
    public class NamedItemSet<T> : LabeledItemSet<string, T>, NamedItemLookup<T> where T : NamedItem
    {
        public NamedItemSet() : base() { }
        public NamedItemSet(IEnumerable<T> items) : base(items) { }
        public NamedItemSet(params T[] items) : base((IEnumerable<T>)items) { }
    }
}