using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    
    static public class ProjectSettings
    {
        static public string GetProjectSettingsDirectory()
        {
            return "ProjectSettings/";
        }

        static public void ModifySettings(string filename, Process<SerializedObject> process)
        {
            AssetDatabase.LoadMainAssetAtPath(Filename.MakeFilename(GetProjectSettingsDirectory(), filename))
                .ModifyAsset(process);
        }
    }
}