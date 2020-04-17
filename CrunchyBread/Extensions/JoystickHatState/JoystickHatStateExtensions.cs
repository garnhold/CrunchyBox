using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class JoystickHatStateExtensions
    {
        static public VectorI2 GetVectorI2(this JoystickHatState item)
        {
            return item.Position.GetVectorI2();
        }
    }
}