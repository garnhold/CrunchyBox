using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class UnityTyonSettings : TyonSettings_Distributed<UnityTyonSettingComponentAttribute>
    {
        private Dictionary<string, TyonObject> prefab_tyon_objects;
        private Dictionary<string, Process<object, TyonContext>> prefab_pushers;

        static public readonly UnityTyonSettings INSTANCE = new UnityTyonSettings();

        private UnityTyonSettings() : base(
            UnityTyonDesignatedVariableProvider.INSTANCE,

            TyonTypeHandler_Externalize_ExplicitType<UnityEngine.Object>.INSTANCE,
            TyonTypeHandler_MethodInfo.INSTANCE
        )
        {
            prefab_tyon_objects = new Dictionary<string, TyonObject>();
            prefab_pushers = new Dictionary<string, Process<object, TyonContext>>();
        }

        public TyonObject FetchPrefabTyonObject(string tyon_data)
        {
            return prefab_tyon_objects.GetOrCreateValue(tyon_data, () => TyonObject.DOMify(tyon_data));
        }
        public Process<object, TyonContext> FetchPrefabPusher(string tyon_data)
        {
            return prefab_pushers.GetOrCreateValue(tyon_data, () => this.CompilePushToSystemObject(tyon_data, TyonHydrationMode.Permissive));
        }
    }
}