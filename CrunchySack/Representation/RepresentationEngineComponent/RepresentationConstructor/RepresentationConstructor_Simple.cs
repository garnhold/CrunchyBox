using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class RepresentationConstructor_Simple : RepresentationConstructor
    {
        protected abstract object Instance(CmlExecution execution, IEnumerable<object> arguments);

        public RepresentationConstructor_Simple(string n, int p) : base(n, p) { }

        public override void InstanceInto(CmlExecution execution, IEnumerable<object> arguments, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_SystemValue(Instance(execution, arguments))
            );
        }
    }
}