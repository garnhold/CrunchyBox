using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeReferenceExtensions_Compare
    {
        static public bool IsVoidType(this TypeReference item)
        {
            if (item.AreEquivolent(item.Module.TypeSystem.Void))
                return true;

            return false;
        }
    }
}