
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
        private CmlValue value;

        private bool is_used;

        private CmlContext context;

        public CmlParameter(CmlContext c, string n, CmlValue v)
        {
            name = n;
            value = v;

            context = c;
        }

        public void SolidifyInto(CmlContext context, CmlContainer container)
        {
            is_used = true;

            deferred_value.SolidifyInto(context, container);
        }

        public void ApplyAsAttribute(CmlContext context, object representation)
        {
            SolidifyInto(
                context,
                context.GetEngine().AssertCreateInfoContainer(context, representation, GetName())
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
