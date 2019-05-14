using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Member_VariablePath
    {
        static public List<Variable> CreateVariablePath(this Type item, string path)
        {
            List<Variable> variables = new List<Variable>();

            foreach (string component in path.SplitOn("."))
            {
                Variable variable = item.GetVariableByComponent(component);

                if (variable == null)
                    return null;

                variables.Add(variable);
                item = variable.GetVariableType();
            }

            return variables;
        }

        static public List<Variable> CreateWrapperVariablePath(this Type item, string path, Type wrapper_type, string fetch_component)
        {
            List<Variable> variables = new List<Variable>();

            foreach (string component in path.SplitOn("."))
            {
                Variable variable = item.GetVariableByComponent(component);
                if (variable == null)
                    return null;

                item = variable.GetVariableType();
                if (item.CanBeTreatedAs(wrapper_type) == false)
                    return null;

                variables.Add(variable);

                variable = item.GetVariableByPath(fetch_component);
                if(variable == null)
                    return null;

                item = variable.GetVariableType();
            }

            return variables;
        }
    }
}