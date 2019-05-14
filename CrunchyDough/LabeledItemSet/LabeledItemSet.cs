using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class LabeledItemSet<LABEL_TYPE, ELEMENT_TYPE> : EnumerableLookupSet<LABEL_TYPE, ELEMENT_TYPE>, ICollection<ELEMENT_TYPE> where ELEMENT_TYPE : LabeledItem<LABEL_TYPE>
    {
        private Dictionary<LABEL_TYPE, ELEMENT_TYPE> items;

        public int Count { get { return items.Count; } }
        public bool IsReadOnly { get{ return false; } }

        public LabeledItemSet()
        {
            items = new Dictionary<LABEL_TYPE, ELEMENT_TYPE>();
        }

        public LabeledItemSet(IEnumerable<ELEMENT_TYPE> items) : this()
        {
            Add(items);
        }
        public LabeledItemSet(params ELEMENT_TYPE[] items) : this((IEnumerable<ELEMENT_TYPE>)items)
        {
        }

        public void Clear()
        {
            items.Clear();
        }

        public void Add(ELEMENT_TYPE item)
        {
            if (item != null)
                items[item.GetItemLabel()] = item;
        }

        public void Add(IEnumerable<ELEMENT_TYPE> items)
        {
            items.Process(i => Add(i));
        }

        public bool Remove(ELEMENT_TYPE item)
        {
            if (item != null)
                return Remove(item.GetItemLabel());

            return false;
        }

        public bool Contains(ELEMENT_TYPE item)
        {
            return items.ContainsValue(item);
        }

        public void CopyTo(ELEMENT_TYPE[] array, int array_index)
        {
            items.Values.CopyTo(array, array_index);
        }

        public void RemoveAll(Predicate<ELEMENT_TYPE> predicate)
        {
            items.Values.Narrow(predicate).ProcessCopy(i => Remove(i));
        }

        public bool Remove(LABEL_TYPE label)
        {
            return items.Remove(label);
        }

        public bool Has(LABEL_TYPE label)
        {
            if (items.ContainsKey(label))
                return true;

            return false;
        }

        public bool TryLookup(LABEL_TYPE label, out ELEMENT_TYPE output)
        {
            return items.TryGetValue(label, out output);
        }

        public IEnumerator<ELEMENT_TYPE> GetEnumerator()
        {
            return items.Values.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}