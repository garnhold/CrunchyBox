using System;

using OpenTK;
using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    using Bun;
    
    static public class DisplayDeviceExtensions_Resolution
    {
        static public VectorI2 GetResolution(this DisplayDevice item)
        {
            return new VectorI2(item.Width, item.Height);
        }
    }
}