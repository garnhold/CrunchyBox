using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_Relative
    {
        static private Variable CreateRelativeVariable(Variable item, Variable variable)
        {
            if (variable != null)
                return new Variable_Relative(item, variable);

            return null;
        }

        static public Variable GetRelativeVariableByComponent(this Variable item, string component)
        {
            return CreateRelativeVariable(item, item.GetVariableType().GetVariableByComponent(component));
        }

        static public Variable GetRelativeVariableByPathAndComponent(this Variable item, string path, string component)
        {
            return CreateRelativeVariable(item, item.GetVariableType().GetVariableByPathAndComponent(path, component));
        }

        static public Variable GetRelativeVariableByPath(this Variable item, string full_path)
        {
            return CreateRelativeVariable(item, item.GetVariableType().GetVariableByPath(full_path));
        }
    }
}