using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public interface TyonTypeResolver
    {
        bool IsResolver(Type type);

        object ResolveSurrogate(Type type, object surrogate, TyonHydrater hydrater);
    }
}
