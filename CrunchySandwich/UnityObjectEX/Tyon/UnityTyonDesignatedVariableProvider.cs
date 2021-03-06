using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class UnityTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Fields
    {
        static public readonly UnityTyonDesignatedVariableProvider INSTANCE = new UnityTyonDesignatedVariableProvider();

        private UnityTyonDesignatedVariableProvider() { }

        protected override Filterer<FieldInfo> GetFieldInfoFilterer(Type type)
        {
            if (type.CanBeTreatedAs<UnityEngine.Object>())
                return Filterer_FieldInfo.HasCustomAttributeOfType<SerializeFieldEX>();

            return Filterer_Utility.Any(
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeField>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeFieldEX>(),
                Filterer_FieldInfo.IsGetPublic()
            );
        }
    }
}