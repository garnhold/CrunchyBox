using System;
using System.Reflection;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySandwich
{
    static public class TypeExtensions_DesignatedVariables
    {
        static public IEnumerable<CrunchyNoodle.Action> GetDesignatedActions(this Type item)
        {
            return item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ContextMenu>()
            ).Convert(m => m.CreateAction());
        }

        static public IEnumerable<Variable> GetDesignatedVariablesForPropertys(this Type item)
        {
            return UnityTyonSerializationSettings.INSTANCE.GetDesignatedVariables(item)
                .Skip(v => v.HasCustomAttributeOfType<HideInInspector>(true));
        }

        static public IEnumerable<Variable> GetDesignatedVariablesForGadgets(this Type item)
        {
            return item.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<AttachEditGadgetAttribute>()
            ).Convert(f => f.CreateVariable());
        }
    }
}