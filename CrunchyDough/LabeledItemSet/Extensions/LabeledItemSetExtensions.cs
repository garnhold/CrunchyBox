using System;

namespace Crunchy.Dough
{
    static public class LabeledItemSetExtensions
    {
        static public ITEM_TYPE AddAndGet<LABEL_TYPE, ITEM_TYPE>(this LabeledItemSet<LABEL_TYPE, ITEM_TYPE> item, ITEM_TYPE to_add) where ITEM_TYPE : LabeledItem<LABEL_TYPE>
        {
            item.Add(to_add);
            return to_add;
        }
    }
}