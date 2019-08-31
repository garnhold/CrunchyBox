using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Type : TyonTypeHandler_Surrogate_ExplicitType<Type, string>
    {
        static public readonly TyonTypeHandler_Type INSTANCE = new TyonTypeHandler_Type();

        protected override string CreateSurrogateInternal(Type value, TyonDehydrater dehydrater)
        {
            return TyonType.CreateTyonType(value).Render();
        }

        protected override Type ResolveSurrogateInternal(string surrogate, TyonHydrater hydrater)
        {
            return TyonType.DOMify(surrogate).GetSystemType(hydrater);
        }

        private TyonTypeHandler_Type() { }
    }
}
