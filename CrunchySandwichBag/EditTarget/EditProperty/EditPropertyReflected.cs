using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public interface EditPropertyReflected
    {
        ReflectedProperty GetReflectedProperty();
    }
}