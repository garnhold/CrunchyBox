using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class FragmentProvider
    {
        public abstract CmlEntry_Fragment GetFragment(string name);
    }
}