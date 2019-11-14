using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_RenderTexture
    {
        static public RenderTexture CreateAndAttachRenderTexture(this Camera item, int width, int height, int depth)
        {
            RenderTexture render_texture = new RenderTexture(width, height, depth);

            item.targetTexture = render_texture;
            return render_texture;
        }
        static public RenderTexture CreateAndAttachRenderTexture(this Camera item, Vector2 size, int depth)
        {
            return item.CreateAndAttachRenderTexture((int)size.x, (int)size.y, depth);
        }
        static public RenderTexture CreateAndAttachRenderTexture(this Camera item, int depth)
        {
            return item.CreateAndAttachRenderTexture(item.GetPixelSize(), depth);
        }

        static public RenderTexture CreateAndTemporarilyAttachRenderTexture(this Camera item, int depth, Process process)
        {
            RenderTexture old_target = item.targetTexture;
            RenderTexture temp_target = item.CreateAndAttachRenderTexture(depth);

            process();

            item.targetTexture = old_target;
            return temp_target;
        }

        static public bool HasRenderTexture(this Camera item)
        {
            if (item.targetTexture != null)
                return true;

            return false;
        }
    }
}