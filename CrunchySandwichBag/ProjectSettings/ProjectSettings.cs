using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;

namespace CrunchySandwichBag
{
    static public class ProjectSettings
    {
        static public string GetProjectSettingsDirectory()
        {
            return "ProjectSettings/";
        }

        static public void ModifySettings(string filename, Process<SerializedObject> process)
        {
            string path = Filename.MakeFilename(GetProjectSettingsDirectory(), filename);
            SerializedObject obj = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath(path).GetFirst());

            process(obj);

            obj.ApplyModifiedProperties();
        }
    }
}