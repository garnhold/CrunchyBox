using System;

using UnityEngine;

using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class RandVector3Box
    {
        private RandVector3Source source;

        public abstract Vector3 Get();

        public RandVector3Box(RandVector3Source s)
        {
            source = s;
        }

        public RandVector3Box() : this(RandVector3.SOURCE) { }

        public RandVector3Source GetSource()
        {
            return source;
        }
    }
}