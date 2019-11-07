using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class SaveStateTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Fields
    {
        static public readonly SaveStateTyonDesignatedVariableProvider INSTANCE = new SaveStateTyonDesignatedVariableProvider();

        private SaveStateTyonDesignatedVariableProvider() { }

        protected override Filterer<FieldInfo> GetFieldInfoFilterer(Type type)
        {
            if (type.HasCustomAttributeOfType<SaveStateExplicitTypeAttribute>(true))
                return Filterer_FieldInfo.HasCustomAttributeOfType<SaveStateFieldAttribute>();

            return Filterer_Utility.Any(
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeField>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeFieldEX>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<SaveStateFieldAttribute>(),
                Filterer_FieldInfo.IsGetPublic()
            );
        }
    }
}