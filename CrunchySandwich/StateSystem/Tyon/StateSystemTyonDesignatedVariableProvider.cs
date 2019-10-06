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
    public class StateSystemTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Fields
    {
        static public readonly StateSystemTyonDesignatedVariableProvider INSTANCE = new StateSystemTyonDesignatedVariableProvider();

        private StateSystemTyonDesignatedVariableProvider() { }

        protected override Filterer<FieldInfo> GetFieldInfoFilterer(Type type)
        {
            if (type.HasCustomAttributeOfType<ExplicitStateSystemTypeAttribute>(true))
                return Filterer_FieldInfo.HasCustomAttributeOfType<StateSystemFieldAttribute>();

            return Filterer_Utility.Any(
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeField>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<SerializeFieldEX>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<StateSystemFieldAttribute>(),
                Filterer_FieldInfo.IsGetPublic()
            );
        }
    }
}