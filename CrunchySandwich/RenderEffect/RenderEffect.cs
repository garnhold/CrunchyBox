using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Crunchy.Sandwich
{
    using Dough;    
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    public class RenderEffect : MonoBehaviour
    {
        [SerializeField]private Material material;
        [SerializeField]private DepthTextureMode depth_texture_mode;

        private void TouchDepthTextureMode()
        {
            this.GetComponent<Camera>().depthTextureMode = depth_texture_mode;
        }

        private void Start()
        {
            TouchDepthTextureMode();
        }

        private void Update()
        {
            if (Application.isPlaying == false)
                TouchDepthTextureMode();
        }

        private void OnRenderImage(RenderTexture src, RenderTexture dst)
        {
            Graphics.Blit(src, dst, material);
        }
    }
}