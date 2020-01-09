using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public enum VariableLinkState
    {
        Equal,

        DominateActive,
        SubmissiveActive
    }
}