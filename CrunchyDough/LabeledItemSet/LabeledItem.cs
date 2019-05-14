using System;

namespace CrunchyDough
{
    public interface LabeledItem<LABEL_TYPE>
    {
        LABEL_TYPE GetItemLabel();
    }
}