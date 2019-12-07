using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class SceneEXExtensions_Info
    {
        static public string GetName(this SceneEX item)
        {
            return item.GetSceneAsset().name;
        }

        static public Scene GetSceneInfo(this SceneEX item)
        {
            return SceneManager.GetSceneByName(item.GetName());
        }
    }
}