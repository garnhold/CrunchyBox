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

        public abstract object Invoke(CmlContext context, IEnumerable<object> arguments);

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