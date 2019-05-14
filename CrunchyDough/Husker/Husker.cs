using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class Husker<T>
    {
        public abstract void Dehydrate(HuskWriter writer, T to_dehydrate);
        public abstract T Hydrate(HuskReader reader);
    }
}