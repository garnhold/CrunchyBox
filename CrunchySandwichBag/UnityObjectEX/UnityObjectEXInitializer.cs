using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorInitializer]
    static public class MonoBehaviourEXInitializer
    {
        [EditorInitializer]
        static private void Initilize()
        {
            MonoBehaviourEXPrefabLookup lookup = MonoBehaviourEXPrefabLookup.GetInstance();

            lookup.Clear();
            
            Project.GetAllPrefabs<MonoBehaviourEX>()
                .ProcessSandboxed(delegate(MonoBehaviourEX item){
                    string id = item.GetAssetGUID();
                    
                    item.ModifyAsset(z => z.SetChildValue("reference_id", id));
                    lookup.Register(item);
                }, e => Debug.LogException(e));
    
        }
    }
    [EditorInitializer]
    static public class ScriptableObjectEXInitializer
    {
        [EditorInitializer]
        static private void Initilize()
        {
            ScriptableObjectEXSofabLookup lookup = ScriptableObjectEXSofabLookup.GetInstance();

            lookup.Clear();
            
            Project.GetAllSofabs<ScriptableObjectEX>()
                .ProcessSandboxed(delegate(ScriptableObjectEX item){
                    string id = item.GetAssetGUID();
                    
                    item.ModifyAsset(z => z.SetChildValue("reference_id", id));
                    lookup.Register(item);
                }, e => Debug.LogException(e));
    
        }
    }
}
