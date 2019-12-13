using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public interface EditPropertySerialized
    {
        SerializedProperty GetSerializedProperty();
    }
}