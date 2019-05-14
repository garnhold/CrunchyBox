
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 16 2018 12:44:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlEntry_Fragment_FragmentDefinition : CmlEntry_Fragment
	{
        private string name;
        private CmlFragmentDefinition fragment_definition;

        protected override void SolidifyIntoInternalFragment(CmlExecution execution, CmlContainer container)
        {
            fragment_definition.SolidifyInto(execution, container);
        }

        public CmlEntry_Fragment_FragmentDefinition(string n, CmlFragmentDefinition f)
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
