using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class SceneEXExtensions_Load
    {
        static public void StartLoad(this SceneEX item)
        {
            SceneManager.LoadSceneAsync(item.GetName(), LoadSceneMode.Single);
        }

        static public bool IsLoaded(this SceneEX item)
        {
            return item.GetSceneInfo().isLoaded;
        }
    }
}