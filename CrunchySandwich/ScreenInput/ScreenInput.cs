using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class ScreenInput
    {
        static public IEnumerable<ScreenTouch> GetScreenTouchs()
        {
            int number_touches = Input.touchCount;

            for (int i = 0; i < number_touches; i++)
                yield return new ScreenTouch(Input.touches[i]);

            if (number_touches <= 0 || Input.simulateMouseWithTouches == false)
            {
                if (Input.GetMouseButton(0))
                    yield return new ScreenTouch(-1, Input.mousePosition);
            }
        }
    }
}