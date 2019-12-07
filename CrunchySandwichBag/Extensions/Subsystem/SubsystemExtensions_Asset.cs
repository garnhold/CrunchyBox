using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    static public class SubsystemExtensions_Asset
    {
        static public void CreateSubsystemAsset(Type type)
        {
            ScriptableObject.CreateInstance(type).Convert<Subsystem>().SaveSubsystemAsset();
        }

        static public void CreateSubsystemAssetIfMissing(Type type)
        {
            if (DoesSubsystemAssetExist(type) == false)
                CreateSubsystemAsset(type);
        }

        static public bool DoesSubsystemAssetExist(Type type)
        {
            if (AssetDatabaseExtensions.DoesAssetPathExist(GetSubsystemAssetPath(type)))
                return true;

            return false;
        }

        static public string GetSubsystemDirectoryAssetPath()
        {
            return Path.Combine(Project.GetResourcesDirectory(), SubsystemExtensions_Resource.GetSubsystemDirectoryResourcePath());
        }

        static public string GetSubsystemAssetPath(Type type)
        {
            return GetSubsystemAssetPath(type.Name);
        }
        static public string GetSubsystemAssetPath(string type_name)
        {
            return Path.Combine(Project.GetResourcesDirectory(), SubsystemExtensions_Resource.GetSubsystemResourcePath(type_name));
        }

        static public Subsystem GetSubsystemAsset(Type type)
        {
            return GetSubsystemAsset(type.Name);
        }
        static public Subsystem GetSubsystemAsset(string type_name)
        {
            return AssetDatabase.LoadAssetAtPath<Subsystem>(GetSubsystemAssetPath(type_name));
        }
    }
}