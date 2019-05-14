using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [RequireComponent(typeof(SpriteRenderer))]
    [AddComponentMenu("CrunchySandwich/SpriteEdit")]
    public class SpriteEdit : InitBehaviour
    {
        [SerializeField]private int resolution_x;
        [SerializeField]private int resolution_y;

        [SerializeField]private int ansio_level;
        [SerializeField]private FilterMode filter_mode;
        [SerializeField]private TextureWrapMode wrap_mode;

        [SerializeField]private bool is_overlay_enabled;

        [AttachEditGadget("Paintable",
            new string[]{
                "MouseUp", "InitilizeInternal"
            },
            new string[]{
                "position", "GetSpacarPosition()",
                "rotation", "GetSpacarQuaternion()",
                "size", "GetSize()",
                "is_overlay_enabled", "IsOverlayEnabled()"
            }
        )]
        [SerializeField][HideInInspector]private Texture2D texture;

        protected override void InitilizeInternal()
        {
            if (texture != null)
            {
                texture.filterMode = filter_mode;
                texture.anisoLevel = ansio_level;
                texture.wrapMode = wrap_mode;

                GetComponent<SpriteRenderer>().SetCenterTexture(texture);
            }
        }

        [ContextMenu("New Texture")]
        public void NewTexture()
        {
            texture = Texture2DExtensions.CreateClear(resolution_x, resolution_y);
        }

        public Vector2 GetSize()
        {
            return GetComponent<SpriteRenderer>().GetPlanarSpriteSize();
        }

        public bool IsOverlayEnabled()
        {
            return is_overlay_enabled;
        }
    }
}