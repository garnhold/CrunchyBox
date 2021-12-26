using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class Assets
    {
        static public T ImportFile<T>(string filename) where T : UnityEngine.Object
        {
            AssetDatabase.ImportAsset(filename);
            AssetDatabase.SaveAssets();

            return AssetDatabase.LoadAssetAtPath<T>(filename);
        }

        static public T CreateTextFile<T>(string filename, string contents="") where T : UnityEngine.Object
        {
            File.WriteAllText(filename, contents);

            return ImportFile<T>(filename);
        }
        static public T CreateNewTextFile<T>(string base_name, string extension, string contents="") where T : UnityEngine.Object
        {
            return CreateTextFile<T>(Project.MakeUnusedCurrentDirectoryFilename(base_name, extension), contents);
        }
    }
}