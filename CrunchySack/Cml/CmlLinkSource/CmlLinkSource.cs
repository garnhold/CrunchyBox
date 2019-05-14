
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 20:16:12 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public partial class CmlLinkSource : CmlElement
	{
        public const string DEFAULT_GROUP = "normal";
        public const string DEFAULT_LAYOUT = "normal";

        public abstract void SolidifyInto(CmlExecution execution, CmlContainer container);

        public CmlValue_Link SolidifyLink(CmlExecution execution)
        {
            CmlContainer_Value value = new CmlContainer_Value();

            SolidifyInto(execution, value);
            return value.GetValue<CmlValue_Link>();
        }
	}
	
}
