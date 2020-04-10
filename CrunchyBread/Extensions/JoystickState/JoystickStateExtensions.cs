using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class JoystickStateExtensions
    {
        static public JoystickHatState GetHat(this JoystickState item, int hat_index)
        {
            switch (hat_index)
            {
                case 0: return item.GetHat(JoystickHat.Hat0);
                case 1: return item.GetHat(JoystickHat.Hat1);
                case 2: return item.GetHat(JoystickHat.Hat2);
                case 3: return item.GetHat(JoystickHat.Hat3);
            }

            throw new UnaccountedBranchException("hat_index", hat_index);
        }
    }
}