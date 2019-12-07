using System;

namespace Crunchy.Dough
{
    public interface LabeledItem<LABEL_TYPE>
    {
        LABEL_TYPE GetItemLabel();
    }
}