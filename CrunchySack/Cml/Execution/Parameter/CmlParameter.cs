
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlParameter
	{
        private string name;
        private CmlDeferredValue deferred_value;

        private bool is_used;

        public CmlParameter(string n, CmlDeferredValue v)
        {
            name = n;
            deferred_value = v;
        }

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            is_used = true;

            deferred_value.SolidifyInto(execution, container);
        }

        public void ApplyAsAttribute(CmlExecution execution, object representation)
        {
            SolidifyInto(
                execution,
                execution.GetTargetInfo().GetEngine().AssertCreateInfoContainer(execution, representation, GetName())
            );
        }

        public string GetName()
        {
            return name;
        }

        public bool IsUsed()
        {
            return is_used;
        }

        public bool IsUnused()
        {
            if (IsUsed() == false)
                return true;

            return false;
        }
	}
	
}
