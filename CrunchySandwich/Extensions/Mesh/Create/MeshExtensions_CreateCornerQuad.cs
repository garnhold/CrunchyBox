using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateCornerQuad(float width, float height)
        {
            return CreateQuad(
                new Vector2(0.0f, 0.0f),
                new Vector2(0.0f, height),
                new Vector2(width, height),
                new Vector2(width, 0.0f)
            );
        }
        static public Mesh CreateCornerQuad(Vector2 size)
        {
            return CreateCornerQuad(size.x, size.y);
        }
        static public Mesh CreateCornerQuad()
        {
            return CreateCornerQuad(1.0f, 1.0f);
        }
    }
}