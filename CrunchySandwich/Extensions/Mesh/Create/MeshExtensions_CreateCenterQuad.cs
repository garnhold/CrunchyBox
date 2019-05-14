using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateCenterQuad(float width, float height)
        {
            float half_width = width * 0.5f;
            float half_height = height * 0.5f;

            return CreateQuad(
                new Vector2(-half_width, -half_height),
                new Vector2(-half_width, half_height),
                new Vector2(half_width, half_height),
                new Vector2(half_width, -half_height)
            );
        }
        static public Mesh CreateCenterQuad(Vector2 size)
        {
            return CreateCenterQuad(size.x, size.y);
        }
        static public Mesh CreateCenterQuad()
        {
            return CreateCenterQuad(1.0f, 1.0f);
        }
    }
}