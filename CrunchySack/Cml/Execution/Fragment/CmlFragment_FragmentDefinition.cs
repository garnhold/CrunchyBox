
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 16 2018 12:44:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlFragment_FragmentDefinition : CmlFragment
	{
        private string name;
        private CmlFragmentDefinition fragment_definition;

        protected override object InstanceInternal(CmlContext context)
        {
            return fragment_definition.Instance(context);
        }

        public CmlFragment_FragmentDefinition(string n, CmlFragmentDefinition f)
        {
            name = n;
            fragment_definition = f;
        }

        public override string GetName()
        {
            return name;
        }
	}
	
}
