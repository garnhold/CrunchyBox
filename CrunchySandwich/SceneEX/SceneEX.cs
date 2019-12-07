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
    
    [Serializable]
    public class SceneEX
    {
        [SerializeField]private UnityEngine.Object scene_asset;

        public UnityEngine.Object GetSceneAsset()
        {
            return scene_asset;
        }
    }
}