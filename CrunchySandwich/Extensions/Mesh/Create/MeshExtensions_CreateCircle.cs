using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;

    static public partial class MeshExtensions
    {
        static public Mesh CreateCircle(int number_vertexs)
        {
            return CreateDegreeSector(0.0f, 360.0f, number_vertexs);
        }
    }
}