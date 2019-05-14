using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TargetInstanceExtensions_Variable
    {
        static public VariableInstance GetVariableInstanceByComponent(this TargetInstance item, string component)
        {
            return item.GetTargetType().GetVariableByComponent(component)
                .IfNotNull(v => v.CreateInstance(item));
        }

        static public VariableInstance GetVariableInstanceByPathAndComponent(this TargetInstance item, string path, string component)
        {
            return item.GetTargetType().GetVariableByPathAndComponent(path, component)
                .IfNotNull(v => v.CreateInstance(item));
        }

        static public VariableInstance GetVariableInstanceByPath(this TargetInstance item, string full_path)
        {
            return item.GetTargetType().GetVariableByPath(full_path)
                .IfNotNull(v => v.CreateInstance(item));
        }

        static public VariableInstance GetVariableInstanceByParentablePath(this TargetInstance item, TargetInstance parent, string full_path)
        {
            if (full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetVariableInstanceByPath(full_path);

            return item.GetVariableInstanceByPath(full_path);
        }
    }
}