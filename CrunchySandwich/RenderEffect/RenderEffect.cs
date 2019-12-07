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
    
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    public class RenderEffect : MonoBehaviour
    {
        [SerializeField]private Material material;

        private void OnRenderImage(RenderTexture src, RenderTexture dst)
        {
            Graphics.Blit(src, dst, material);
        }
    }
}