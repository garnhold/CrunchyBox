using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Bun;
    
    public abstract class RandVector2Box
    {
        private RandVector2Source source;

        public abstract Vector2 Get();

        public RandVector2Box(RandVector2Source s)
        {
            source = s;
        }

        public RandVector2Box() : this(RandVector2.SOURCE) { }

        public RandVector2Source GetSource()
        {
            return source;
        }
    }
}