using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class FaceCloudFace
    {
        private Face face;
        private bool is_used;

        public FaceCloudFace(Face f)
        {
            face = f;
            is_used = false;
        }

        public void Use()
        {
            is_used = true;
        }

        public void Reset()
        {
            is_used = false;
        }

        public Face GetFace()
        {
            return face;
        }

        public bool IsUsed()
        {
            return is_used;
        }
    }
}