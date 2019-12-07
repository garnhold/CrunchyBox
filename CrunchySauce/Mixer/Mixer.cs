using System;

namespace Crunchy.Sauce
{
    public abstract class Mixer<T>
    {
        public abstract T Mix(T src, T dst, float weight);
    }
}