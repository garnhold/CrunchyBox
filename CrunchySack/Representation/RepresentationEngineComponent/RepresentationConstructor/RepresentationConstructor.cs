using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationConstructor : RepresentationEngineComponent
    {
        private string name;
        private List<Type> parameter_types;

        public abstract object Invoke(CmlContext context, IEnumerable<object> arguments);

        public RepresentationConstructor(string n, IEnumerable<Type> p)
        {
            name = n;
            parameter_types = p.ToList();
        }

        public RepresentationConstructor(string n, params Type[] p) : this(n, (IEnumerable<Type>)p) { }

        public string GetName()
        {
            return name;
        }

        public IEnumerable<Type> GetParameterTypes()
        {
            return parameter_types;
        }
    }
}