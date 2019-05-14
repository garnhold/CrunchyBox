using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateCombined(CombineInstance[] combine_instances)
        {
            Mesh mesh = new Mesh();

            mesh.CombineMeshes(combine_instances);
            return mesh;
        }
        static public Mesh CreateCombined(IEnumerable<CombineInstance> combine_instances)
        {
            return CreateCombined(combine_instances.ToArray());
        }
    }
}