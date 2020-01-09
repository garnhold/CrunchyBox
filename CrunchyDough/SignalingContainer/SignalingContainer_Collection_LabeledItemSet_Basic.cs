using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class SignalingContainer_Collection_IndexedItemSet<T> : SignalingContainer_Collection_LabeledItemSet<int, T> where T : IndexedItem
    {
    }

    public abstract class SignalingContainer_Collection_NamedItemSet<T> : SignalingContainer_Collection_LabeledItemSet<string, T> where T : NamedItem
    {
    }
}