using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Adjust
    {
		static public void AdjustSpacarPosition(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustSpacarPosition(amount);
        }
        static public void AdjustLocalSpacarPosition(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarPosition(amount);
        }

        static public void AdjustSpacarRotation(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustSpacarRotation(amount);
        }
        static public void AdjustLocalSpacarRotation(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarRotation(amount);
        }

        static public void AdjustSpacarScale(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustSpacarScale(amount);
        }
        static public void AdjustLocalSpacarScale(this GameObject item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarScale(amount);
        }

		static public void AdjustSpacarPosition(this Component item, Vector3 amount)
        {
            item.transform.AdjustSpacarPosition(amount);
        }
        static public void AdjustLocalSpacarPosition(this Component item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarPosition(amount);
        }

        static public void AdjustSpacarRotation(this Component item, Vector3 amount)
        {
            item.transform.AdjustSpacarRotation(amount);
        }
        static public void AdjustLocalSpacarRotation(this Component item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarRotation(amount);
        }

        static public void AdjustSpacarScale(this Component item, Vector3 amount)
        {
            item.transform.AdjustSpacarScale(amount);
        }
        static public void AdjustLocalSpacarScale(this Component item, Vector3 amount)
        {
            item.transform.AdjustLocalSpacarScale(amount);
        }

	}
}