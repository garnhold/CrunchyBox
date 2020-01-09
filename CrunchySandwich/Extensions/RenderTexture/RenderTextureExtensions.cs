using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RenderTextureExtensions
    {
        static public void Use(this RenderTexture item, Process process)
        {
            RenderTexture old = RenderTexture.active;

            RenderTexture.active = item;
                process();
            RenderTexture.active = old;
        }
    }
}