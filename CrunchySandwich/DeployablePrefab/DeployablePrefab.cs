using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class DeployablePrefab : MonoBehaviour
    {
    }

    public abstract class DeployablePrefab<T> : DeployablePrefab where T : DeployablePrefab<T>
    {
        static private T PREFAB;
        static public T DeployPrefabInstance()
        {
            if (PREFAB == null)
            {
                PREFAB = (T)DeployablePrefabManager.GetInstance<DeployablePrefabManager>()
                    .GetPrefabs()
                    .FindFirst(p => p.Is<T>());
            }

            return PREFAB;
        }
    }
}