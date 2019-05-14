using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class FragmentProvider
    {
        public abstract CmlEntry_Fragment GetFragment(string name);
    }
}