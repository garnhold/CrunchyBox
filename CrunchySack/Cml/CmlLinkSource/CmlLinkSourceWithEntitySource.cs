
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 17 2018 23:01:00 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlLinkSourceWithEntitySource : CmlElement
	{
        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            container.Insert(
                execution,
                new CmlValue_LinkWithEntity(
                    GetLinkSource().SolidifyLink(execution),
                    GetEntity()
                )
            );
        }

        public CmlValue_LinkWithEntity SolidifyIntoLinkWithEntity(CmlExecution execution)
        {
            CmlContainer_Value value = new CmlContainer_Value();

            SolidifyInto(execution, value);
            return value.GetValue<CmlValue_LinkWithEntity>();
        }
	}
	
}
