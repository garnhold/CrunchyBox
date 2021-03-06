using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeReferenceExtensions_AreEquivolent
    {
        static public bool AreEquivolent(this TypeReference item, TypeReference type)
        {
            if (item.FullName == type.FullName)
            {
                if (item.Resolve().EqualsEX(type.Resolve()))
                    return true;
            }

            return false;
        }
    }
}