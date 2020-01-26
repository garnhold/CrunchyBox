
using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public class MonoBehaviourExtensions_RequireComponent
    {
        static public void EnforceRequiredComponents(this MonoBehaviour item)
        {
            item.GetType().GetAllCustomAttributesOfType<RequireComponent>(true)
                .Convert(a => a.GetRequiredComponentTypes())
                .Flatten()
                .Convert(t => item.FetchComponent(t))
                .Convert<Component, MonoBehaviour>()
                .Process(m => m.EnforceRequiredComponents());
        }

        [MenuItem("Edit/Enforce Required Components")]
        static public void EnfoceRequiredComponents()
        {
            throw new NotImplementedException("Not tested. Code Disabled.");
            /*
            List<Type> types = Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>(),
                Filterer_Type.HasCustomAttributeOfType<RequireComponent>(true)
            ).ToList();
             * 
             * also should use the UseScratch stuff

            foreach(MonoBehaviour mono_behaviour in AssetDatabaseExtensions
                .GetAllAssets("", "", Empty.IEnumerable<string>(), types)
                .Convert<UnityEngine.Object, MonoBehaviour>())
            {
                mono_behaviour.EnforceRequiredComponents();
            }
             */
        }
    }
}