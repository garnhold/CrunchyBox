using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    using Bun;
    
    static public class MouseStateExtensions_Position
    {
        static public VectorI2 GetPosition(this MouseState item)
        {
            return new VectorI2(item.X, item.Y);
        }
    }
}