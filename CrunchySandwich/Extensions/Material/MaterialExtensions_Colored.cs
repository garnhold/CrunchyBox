using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MaterialExtensions
    {
        static public Material CreateColorMaterial(Color color, Shader shader)
        {
            Material material = new Material(shader);

            material.SetMainColor(color);
            return material;
        }

        static public Material CreateColorMaterial(Color color, string shader_name)
        {
            return CreateColorMaterial(color, Shader.Find(shader_name));
        }

        static public Material CreateUnlitColorMaterial(Color color)
        {
            return CreateColorMaterial(color, "Unlit/Color");
        }
    }
}