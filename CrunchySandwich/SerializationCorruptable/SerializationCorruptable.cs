using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public interface SerializationCorruptable
    {
        bool IsSerializationCorrupt();
    }
}