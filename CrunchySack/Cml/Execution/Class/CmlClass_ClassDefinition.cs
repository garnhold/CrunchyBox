
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlClass_ClassDefinition : CmlClass
	{
        private CmlClassDefinition class_definition;

        protected override object InstanceInternal(CmlContext context)
        {
            return class_definition.Instance(context);
        }

        public CmlClass_ClassDefinition(Type t, string l, CmlClassDefinition c) : base(t, l)
        {
            class_definition = c;
        }
	}
	
}
