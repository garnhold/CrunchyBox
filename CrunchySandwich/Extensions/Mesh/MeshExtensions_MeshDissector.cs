using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshExtensions_MeshDissector
    {
        static public MeshDissector CreateMeshDissector(this Mesh item)
        {
            return new MeshDissector(item);
        }
    }
}