using System;

namespace CrunchySauce
{
    public abstract class Mixer<T>
    {
        public abstract T Mix(T src, T dst, float weight);
    }
}