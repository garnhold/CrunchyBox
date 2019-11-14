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
            MonoBehaviourEXLookup lookup = MonoBehaviourEXLookup.GetInstance();

            lookup.Clear();
            
            Project.GetAllPrefabs<MonoBehaviourEX>()
                .Process(delegate(MonoBehaviourEX item){
                    string id = item.GetAssetGUID();
                    
                    item.ModifyAsset(z => z.SetChildValue("reference_id", id));
                    lookup.Register(item);
                });
    
        }
    }
    [EditorInitializer]
    static public class ScriptableObjectEXInitializer
    {
        [EditorInitializer]
        static private void Initilize()
        {
            ScriptableObjectEXLookup lookup = ScriptableObjectEXLookup.GetInstance();

            lookup.Clear();
            
            Project.GetAllSofabs<ScriptableObjectEX>()
                .Process(delegate(ScriptableObjectEX item){
                    string id = item.GetAssetGUID();
                    
                    item.ModifyAsset(z => z.SetChildValue("reference_id", id));
                    lookup.Register(item);
                });
    
        }
    }
}
