using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonSettings_Distributed<ATTRIBUTE_TYPE> : TyonSettings where ATTRIBUTE_TYPE : Attribute
    {
        static private IEnumerable<TyonSettingsComponent> CreateComponents()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<TyonSettingsComponent>(),
                Filterer_Type.IsConcreteClass(),
                Filterer_Type.HasCustomAttributeOfType<ATTRIBUTE_TYPE>(false)
            ).Convert(t => t.CreateInstance<TyonSettingsComponent>());
        }

        public TyonSettings_Distributed(IEnumerable<TyonSettingsComponent> c) : base(c.Prepend(CreateComponents())) { }
        public TyonSettings_Distributed(params TyonSettingsComponent[] c) : this((IEnumerable<TyonSettingsComponent>)c) { }
    }
}
