using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Interpolate
    {
		static public void InterpolateSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            item.transform.InterpolateSpacarPosition(target, amount);
        }
        static public void InterpolateLocalSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            item.transform.InterpolateLocalSpacarPosition(target, amount);
        }

        static public void InterpolateSpacarScale(this GameObject item, Vector3 target, float amount)
        {
            item.transform.InterpolateSpacarScale(target, amount);
        }
        static public void InterpolateLocalSpacarScale(this GameObject item, Vector3 target, float amount)
        {
            item.transform.InterpolateLocalSpacarScale(target, amount);
        }

		static public void InterpolateSpacarScale(this GameObject item, float target, float amount)
        {
            item.transform.InterpolateSpacarScale(target, amount);
        }
        static public void InterpolateLocalSpacarScale(this GameObject item, float target, float amount)
        {
            item.transform.InterpolateLocalSpacarScale(target, amount);
        }

		static public void InterpolateSpacarPosition(this Component item, Vector3 target, float amount)
        {
            item.transform.InterpolateSpacarPosition(target, amount);
        }
        static public void InterpolateLocalSpacarPosition(this Component item, Vector3 target, float amount)
        {
            item.transform.InterpolateLocalSpacarPosition(target, amount);
        }

        static public void InterpolateSpacarScale(this Component item, Vector3 target, float amount)
        {
            item.transform.InterpolateSpacarScale(target, amount);
        }
        static public void InterpolateLocalSpacarScale(this Component item, Vector3 target, float amount)
        {
            item.transform.InterpolateLocalSpacarScale(target, amount);
        }

		static public void InterpolateSpacarScale(this Component item, float target, float amount)
        {
            item.transform.InterpolateSpacarScale(target, amount);
        }
        static public void InterpolateLocalSpacarScale(this Component item, float target, float amount)
        {
            item.transform.InterpolateLocalSpacarScale(target, amount);
        }

	}
}