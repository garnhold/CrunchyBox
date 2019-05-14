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
    public class SceneEX : ISerializationCallbackReceiver
    {
        [SerializeField]private UnityEngine.Object scene;
        [SerializeField][HideInInspector]private string name;

        public void OnAfterDeserialize() { }
        public void OnBeforeSerialize()
        {
            if (scene != null)
                name = scene.name;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(name);
        }

        public string GetName()
        {
            return name;
        }
    }
}