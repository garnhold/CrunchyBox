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
    [Serializable]
    public class SceneEX
    {
        [SerializeField]private UnityEngine.Object scene_asset;

        public void LoadScene()
        {
            SceneManager.LoadScene(GetName());
        }

        public bool IsSceneLoaded()
        {
            return SceneManager.GetSceneByName(GetName()).IfNotNull(s => s.isLoaded);
        }

        public string GetName()
        {
            return scene_asset.name;
        }
    }
}