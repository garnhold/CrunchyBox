using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class InputExtensions
    {
        static public Vector2 GetWASD2()
        {
            Vector2 total = new Vector2();

            if (Input.GetKey(KeyCode.W))
                total += Vector2.up;

            if (Input.GetKey(KeyCode.A))
                total += Vector2.left;

            if (Input.GetKey(KeyCode.S))
                total += Vector2.down;

            if (Input.GetKey(KeyCode.D))
                total += Vector2.right;

            return total.BindMagnitudeBelow(1.0f);
        }

        static public Vector3 GetWASD3()
        {
            Vector3 total = new Vector3();

            if (Input.GetKey(KeyCode.W))
                total += Vector3.forward;

            if (Input.GetKey(KeyCode.A))
                total += Vector3.left;

            if (Input.GetKey(KeyCode.S))
                total += Vector3.back;

            if (Input.GetKey(KeyCode.D))
                total += Vector3.right;

            return total.BindMagnitudeBelow(1.0f);
        }
    }
}