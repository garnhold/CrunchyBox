using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyClassInfo
    {
        public abstract CmlEntry_Class AssertGetClass(CmlExecution execution);
    }
}