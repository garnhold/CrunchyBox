
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlEntry_Class_ClassDefinition : CmlEntry_Class
	{
        private CmlClassDefinition class_definition;

        protected override void SolidifyIntoInternalClass(CmlExecution execution, CmlContainer container)
        {
            class_definition.SolidifyInto(execution, container);
        }

        public CmlEntry_Class_ClassDefinition(Type t, string l, CmlClassDefinition c) : base(t, l)
        {
            class_definition = c;
        }
	}
	
}
