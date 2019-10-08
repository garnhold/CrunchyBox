using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SceneEXExtensions_Activate
    {
        static public bool Activate(this SceneEX item)
        {
            if (item.IsSceneLoaded() == false)
            {
                item.LoadScene();

                return true;
            }

            return false;
        }
    }
}