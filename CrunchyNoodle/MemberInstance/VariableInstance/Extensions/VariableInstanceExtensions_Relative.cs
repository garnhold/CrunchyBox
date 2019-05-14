using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class VariableInstanceExtensions_Relative
    {
        static public VariableInstance GetRelativeVariableInstanceByComponent(this VariableInstance item, string component)
        {
            return item.GetVariable().GetRelativeVariableByComponent(component)
                .IfNotNull(v => v.CreateInstance(item.GetTargetInstance()));
        }

        static public VariableInstance GetRelativeVariableInstanceByPathAndComponent(this VariableInstance item, string path, string component)
        {
            return item.GetVariable().GetRelativeVariableByPathAndComponent(path, component)
                .IfNotNull(v => v.CreateInstance(item.GetTargetInstance()));
        }

        static public VariableInstance GetRelativeVariableInstanceByPath(this VariableInstance item, string full_path)
        {
            return item.GetVariable().GetRelativeVariableByPath(full_path)
                .IfNotNull(v => v.CreateInstance(item.GetTargetInstance()));
        }
    }

}