﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_Render
    {
        static public Texture2D RenderToTexture2D(this Camera item, int depth)
        {
            return item.CreateAndTemporarilyAttachRenderTexture(depth, () => item.Render()).CreateTexture2D();
        }
    }
}