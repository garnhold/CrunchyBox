using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class VariableInstanceExtensions_Elements
    {
        static public int GetVariableInstanceNumberElements(this VariableInstance item)
        {
            return item.GetVariable().GetVariableNumberElements(item.GetTarget());
        }

        static public VariableInstance GetVariableInstanceElement(this VariableInstance item, int index)
        {
            return item.GetVariable().GetVariableElement(index)
                .IfNotNull(v => v.CreateInstance(item.GetTargetInstance()));
        }

        static public IEnumerable<VariableInstance> GetVariableInstanceElements(this VariableInstance item, int index, int count)
        {
            return item.GetVariable().GetVariableElements(index, count)
                .Convert(v => v.CreateInstance(item.GetTargetInstance()));
        }
        static public IEnumerable<VariableInstance> GetVariableInstanceElements(this VariableInstance item, int count)
        {
            return item.GetVariable().GetVariableElements(count)
                .Convert(v => v.CreateInstance(item.GetTargetInstance()));
        }

        static public IEnumerable<VariableInstance> GetAllVariableInstanceElements(this VariableInstance item)
        {
            return item.GetVariable().GetAllVariableElements(item.GetTarget())
                .Convert(v => v.CreateInstance(item.GetTargetInstance()));
        }
    }

}