using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class JoystickHatStateExtensions
    {
        static public VectorF2 GetVectorF2(this JoystickHatState item)
        {
            return item.Position.GetVectorF2();
        }
    }
}