using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class SignalingContainer_Collection_LabeledItemSet<LABEL_TYPE, ELEMENT_TYPE> : SignalingContainer_Collection<ELEMENT_TYPE>, EnumerableLookupSet<LABEL_TYPE, ELEMENT_TYPE> where ELEMENT_TYPE : LabeledItem<LABEL_TYPE>
    {
        private LabeledItemSet<LABEL_TYPE, ELEMENT_TYPE> labeled_item_set;

        public override int Count { get { return labeled_item_set.Count; } }

        public SignalingContainer_Collection_LabeledItemSet()
        {
            labeled_item_set = new LabeledItemSet<LABEL_TYPE, ELEMENT_TYPE>();
        }

        public override void Clear()
        {
            labeled_item_set.RemoveAll(them => CanRemove(them));
        }

        public override bool TryAdd(ELEMENT_TYPE to_add)
        {
            if (CanAdd(to_add))
            {
                labeled_item_set.Add(to_add);

                return true;
            }

            return false;
        }

        public override bool Remove(ELEMENT_TYPE to_remove)
        {
            if (CanRemove(to_remove))
                return labeled_item_set.Remove(to_remove);

            return false;
        }

        public override bool Contains(ELEMENT_TYPE item)
        {
            return labeled_item_set.Contains(item);
        }

        public override void CopyTo(ELEMENT_TYPE[] array, int array_index)
        {
            labeled_item_set.CopyTo(array, array_index);
        }

        public bool Has(LABEL_TYPE label)
        {
            return labeled_item_set.Has(label);
        }

        public bool TryLookup(LABEL_TYPE label, out ELEMENT_TYPE item)
        {
            return labeled_item_set.TryLookup(label, out item);
        }

        public override IEnumerator<ELEMENT_TYPE> GetEnumerator()
        {
            return labeled_item_set.GetEnumerator();
        }
    }
}