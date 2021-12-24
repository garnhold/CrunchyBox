using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class VariableExtensions_Elements_Modify
    {
        static public bool AddElementToVariable(this Variable item, object target, object value)
        {
            if (item.IsVariableArray())
                return item.SetContents(target, item.GetContents<Array>(target).CopyAppend(value));

            if (item.IsVariableTypicalIEnumerable())
                return item.GetContents<IEnumerable>(target).InspectAdd(value);

            return false;
        }
        static public bool AddElementToVariable(this Variable item, object target)
        {
            return item.AddElementToVariable(target, null);
        }

        static public bool InsertElementIntoVariableAt(this Variable item, object target, int index, object value)
        {
            if (item.IsVariableArray())
                return item.SetContents(target, item.GetContents<Array>(target).CopyInsert(index, value));

            if(item.IsVariableTypicalIEnumerable())
                return item.GetContents<IEnumerable>(target).InspectInsert(index, value);

            return false;
        }
        static public bool InsertElementIntoVariableAt(this Variable item, object target, int index)
        {
            return item.InsertElementIntoVariableAt(target, index, null);
        }

        static public bool RemoveElementInVariableAt(this Variable item, object target, int index)
        {
            if (item.IsVariableArray())
                return item.SetContents(target, item.GetContents<Array>(target).CopyRemove(index));

            if (item.IsVariableTypicalIEnumerable())
                return item.GetContents<IEnumerable>(target).InspectRemoveAt(index);

            return false;
        }

        static public bool MoveElementInVariable(this Variable item, object target, int src_index, int dst_index)
        {
            object element = item.GetVariableElement(src_index);

            if (item.RemoveElementInVariableAt(target, src_index))
            {
                if (item.InsertElementIntoVariableAt(target, dst_index, element))
                    return true;
            }

            return false;
        }
    }
}