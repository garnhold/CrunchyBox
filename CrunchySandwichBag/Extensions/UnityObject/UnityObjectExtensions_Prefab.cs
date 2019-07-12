using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Prefab
    {
        static public bool IsPrefab(this UnityEngine.Object item)
        {
            PrefabType type = PrefabUtility.GetPrefabType(item);

            switch (type)
            {
                case PrefabType.DisconnectedModelPrefabInstance: return false;
                case PrefabType.DisconnectedPrefabInstance: return false;

                case PrefabType.MissingPrefabInstance: return false;

                case PrefabType.ModelPrefab: return true;
                case PrefabType.ModelPrefabInstance: return false;

                case PrefabType.None: return false;

                case PrefabType.Prefab: return true;
                case PrefabType.PrefabInstance: return false;
            }

            throw new UnaccountedBranchException("type", type);
        }

        static public bool IsPrefabInstance(this UnityEngine.Object item)
        {
            PrefabType type = PrefabUtility.GetPrefabType(item);

            switch (type)
            {
                case PrefabType.DisconnectedModelPrefabInstance: return true;
                case PrefabType.DisconnectedPrefabInstance: return true;

                case PrefabType.MissingPrefabInstance: return true;

                case PrefabType.ModelPrefab: return false;
                case PrefabType.ModelPrefabInstance: return true;

                case PrefabType.None: return false;

                case PrefabType.Prefab: return false;
                case PrefabType.PrefabInstance: return true;
            }

            throw new UnaccountedBranchException("type", type);
        }
    }
}