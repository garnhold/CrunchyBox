using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class PathResolver
    {
        private List<Variable> variables;

        private Type input_type;
        private Type output_type;

        public PathResolver(IEnumerable<Variable> v)
        {
            variables = v.ToList();

            input_type = variables.GetFirst().GetDeclaringType();
            output_type = variables.GetLast().GetVariableType();
        }

        public object ResolveTarget(object target)
        {
            variables.Process(v => target = v.GetContents(target));
            return target;
        }

        public IEnumerable<object> ResolveTargets(object target)
        {
            return variables.Convert(v => target = v.GetContents(target));
        }

        public Type GetInputType()
        {
            return input_type;
        }

        public Type GetOutputType()
        {
            return output_type;
        }

        public IEnumerable<Variable> GetVariables()
        {
            return variables;
        }

        public override string ToString()
        {
            return variables.Convert(v => v.ToString(false, false)).Join(".");
        }
    }
}