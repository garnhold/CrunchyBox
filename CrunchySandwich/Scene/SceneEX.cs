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
    public class SceneEXOnValidateEditDistinctionAttribute : EditDistinctionAttribute { }

    public class SceneEX : CustomAsset
    {
        [SerializeFieldEX]private UnityEngine.Object scene_asset;
        [SerializeFieldEX][InspectorDisplay]private string path;

        protected override void OnValidateInternal()
        {
            PlayEditDistinction<SceneEXOnValidateEditDistinctionAttribute>
                .ExecuteNoReturn(t => { }, this);
        }

        public void Initialize(UnityEngine.Object s)
        {
            scene_asset = s;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(path);
        }

        public bool IsSceneLoaded()
        {
            return SceneManager.GetSceneByPath(path).IfNotNull(s => s.isLoaded);
        }
    }
}