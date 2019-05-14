using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class EffigyClassInfo
    {
        public abstract CmlEntry_Class AssertGetClass(CmlExecution execution);
    }
}