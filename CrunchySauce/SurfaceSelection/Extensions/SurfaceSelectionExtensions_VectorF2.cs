using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    static public class SurfaceSelectionExtensions_VectorF2
    {
        static public VectorF2 GetDimensions<T>(this SurfaceSelection<T> item)
        {
            return new VectorF2(item.GetWidth(), item.GetHeight());
        }
    }
}