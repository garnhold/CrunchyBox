using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public bool TryGetAlphaNumberDown(out int number)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                number = 0;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                number = 1;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                number = 2;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                number = 3;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                number = 4;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                number = 5;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                number = 6;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                number = 7;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                number = 8;
                return true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                number = 9;
                return true;
            }

            number = 0;
            return false;
        }
        static public int GetAlphaNumberDown(int number)
        {
            int output;

            if (TryGetAlphaNumberDown(out output))
                return output;

            return number;
        }
    }
}