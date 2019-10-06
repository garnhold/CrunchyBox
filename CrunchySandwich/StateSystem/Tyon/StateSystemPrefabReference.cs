using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class StateSystemPrefabReference
    {
        [SerializeFieldEX]private string prefab_id;

        static public implicit operator UnityEngine.Object(StateSystemPrefabReference p)
        {
            return p.ResolvePrefab();
        }

        static public implicit operator StateSystemPrefabReference(UnityEngine.Object o)
        {
            UnityObjectEX cast;

            if(o.Convert<UnityObjectEX>(out cast))
                return new StateSystemPrefabReference(cast.GetPrefabId());

            return null;
        }

        public StateSystemPrefabReference(string id)
        {
            prefab_id = id;
        }

        public StateSystemPrefabReference() : this("") { }

        public UnityEngine.Object ResolvePrefab()
        {
            return PrefabLookup.GetInstance().LookupPrefab(prefab_id);
        }
    }
}