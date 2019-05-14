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
        static public RenderTexture CreateRenderTexture(this Camera item, int depth)
        {
            return new RenderTexture(item.GetPixelWidth(), item.GetPixelHeight(), depth);
        }

        static public RenderTexture CreateAndAttachRenderTexture(this Camera item, int depth)
        {
            RenderTexture render_texture = item.CreateRenderTexture(depth);

            item.targetTexture = render_texture;
            return render_texture;
        }

        static public RenderTexture CreateAndTemporarilyAttachRenderTexture(this Camera item, int depth, Process process)
        {
            RenderTexture old_target = item.targetTexture;
            RenderTexture temp_target = item.CreateAndAttachRenderTexture(depth);

            process();

            item.targetTexture = old_target;
            return temp_target;
        }
    }
}