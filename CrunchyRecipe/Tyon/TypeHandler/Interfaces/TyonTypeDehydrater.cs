using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public interface TyonTypeDehydrater
    {
        bool IsDehydrater(Type type);

        TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater);
    }
}
