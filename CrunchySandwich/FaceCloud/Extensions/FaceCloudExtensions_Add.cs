using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class FaceCloudExtensions_Add
    {
        static public void AddFaces(this FaceCloud item, IEnumerable<Face> faces)
        {
            faces.Process(f => item.AddFace(f));
        }
        static public void AddFaces(this FaceCloud item, params Face[] faces)
        {
            item.AddFaces((IEnumerable<Face>)faces);
        }
    }
}