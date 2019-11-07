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
    public class SaveStatePrefabReference
    {
        [SerializeFieldEX]private string prefab_id;

        static public implicit operator UnityEngine.Object(SaveStatePrefabReference p)
        {
            return p.ResolvePrefab();
        }

        static public implicit operator SaveStatePrefabReference(UnityEngine.Object o)
        {
            UnityObjectEX cast;

            if(o.Convert<UnityObjectEX>(out cast))
                return new SaveStatePrefabReference(cast.GetPrefabId());

            return null;
        }

        public SaveStatePrefabReference(string id)
        {
            prefab_id = id;
        }

        public SaveStatePrefabReference() : this("") { }

        public UnityEngine.Object ResolvePrefab()
        {
            return PrefabLookup.GetInstance().LookupPrefab(prefab_id);
        }
    }
}