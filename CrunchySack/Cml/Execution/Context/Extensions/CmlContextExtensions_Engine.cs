using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    static public class CmlContextExtensions_Engine
	{
        static public RepresentationEngine GetEngine(this CmlContext item)
        {
            return item.GetTargetInfo().GetEngine();
        }
	}
	
}
