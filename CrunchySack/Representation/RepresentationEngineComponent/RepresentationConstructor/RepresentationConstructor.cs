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
        private int number_parameters;

        public abstract void InstanceInto(CmlExecution execution, IEnumerable<object> arguments, CmlContainer container);

        public RepresentationConstructor(string n, int p)
        {
            name = n;
            number_parameters = p;
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumberParameters()
        {
            return number_parameters;
        }
    }
}