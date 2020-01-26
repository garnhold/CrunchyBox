using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class ColorExtensions_MoveTowards
    {
        static public bool GetMoveTowards(this Color item, Color target, Color amount, out Color output)
        {
            float red_output;
            float green_output;
            float blue_output;
            float alpha_output;

            bool red_result = item.r.GetMoveTowards(target.r, amount.r, out red_output);
            bool green_result = item.g.GetMoveTowards(target.g, amount.g, out green_output);
            bool blue_result = item.b.GetMoveTowards(target.b, amount.b, out blue_output);
            bool alpha_result = item.a.GetMoveTowards(target.a, amount.a, out alpha_output);

            output = new Color(red_output, green_output, blue_output, alpha_output);
            return red_result && green_result && blue_result && alpha_result;
        }
    }
}