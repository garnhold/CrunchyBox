using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class VariableInstanceExtensions_Elements_Modify
    {
        static public bool InsertElementIntoVariableInstanceAt(this VariableInstance item, int index, object value)
        {
            return item.GetVariable().InsertElementIntoVariableAt(item.GetTarget(), index, value);
        }
        static public bool InsertElementIntoVariableInstanceAt(this VariableInstance item, int index)
        {
            return item.GetVariable().InsertElementIntoVariableAt(item.GetTarget(), index);
        }

        static public bool RemoveElementInVariableInstanceAt(this VariableInstance item, int index)
        {
            return item.GetVariable().RemoveElementInVariableAt(item.GetTarget(), index);
        }

        static public bool MoveElementInVariableInstance(this VariableInstance item, int src_index, int dst_index)
        {
            return item.GetVariable().MoveElementInVariable(item.GetTarget(), src_index, dst_index);
        }
    }
}