using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MaterialExtensions
    {
        static public Material CreateTextureMaterial(Texture texture, Shader shader)
        {
            Material material = new Material(shader);

            material.SetMainTexture(texture);
            return material;
        }

        static public Material CreateTextureMaterial(Texture texture, string shader_name)
        {
            return CreateTextureMaterial(texture, Shader.Find(shader_name));
        }

        static public Material CreateUnlitTransparentTextureMaterial(Texture texture)
        {
            return CreateTextureMaterial(texture, "Unlit/Transparent");
        }
    }
}