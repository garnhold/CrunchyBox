using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshExtensions_MeshDissector
    {
        static public MeshDissector CreateMeshDissector(this Mesh item)
        {
            return new MeshDissector(item);
        }
    }
}