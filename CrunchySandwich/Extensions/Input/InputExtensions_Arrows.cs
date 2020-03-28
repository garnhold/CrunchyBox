using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class InputExtensions
    {
        static public Vector2 GetArrows2()
        {
            Vector2 total = new Vector2();

            if (Input.GetKey(KeyCode.UpArrow))
                total += Vector2.up;

            if (Input.GetKey(KeyCode.LeftArrow))
                total += Vector2.left;

            if (Input.GetKey(KeyCode.DownArrow))
                total += Vector2.down;

            if (Input.GetKey(KeyCode.RightArrow))
                total += Vector2.right;

            return total.BindMagnitudeBelow(1.0f);
        }

        static public Vector3 GetArrows3()
        {
            Vector3 total = new Vector3();

            if (Input.GetKey(KeyCode.UpArrow))
                total += Vector3.forward;

            if (Input.GetKey(KeyCode.LeftArrow))
                total += Vector3.left;

            if (Input.GetKey(KeyCode.DownArrow))
                total += Vector3.back;

            if (Input.GetKey(KeyCode.RightArrow))
                total += Vector3.right;

            return total.BindMagnitudeBelow(1.0f);
        }
    }
}