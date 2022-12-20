using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Bread;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static private Vector2 CURRENT_MOUSE_LOOK_POSITION;
        static private Vector2 LAST_MOUSE_LOOK_POSITION;
        static private Frame MOUSE_LOOK_FRAME;

        static public Vector2 GetMouseDelta()
        {
            if (MOUSE_LOOK_FRAME.IsNotCurrent())
            {
                if (MOUSE_LOOK_FRAME.IsNotRecent())
                    CURRENT_MOUSE_LOOK_POSITION = Input.mousePosition;

                LAST_MOUSE_LOOK_POSITION = CURRENT_MOUSE_LOOK_POSITION;
                CURRENT_MOUSE_LOOK_POSITION = Input.mousePosition;

                MOUSE_LOOK_FRAME = Frame.GetCurrentFrame();
            }

            return CURRENT_MOUSE_LOOK_POSITION - LAST_MOUSE_LOOK_POSITION;
        }

        static public Vector2 GetMouseLookDelta()
        {
            return InputExtensions.GetMouseDelta().GetComponentsSwapped();
        }
    }
}