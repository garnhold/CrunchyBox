using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Planar_Scale
    {

		static public void ScalePlanarScale(this GameObject item, float scale)
        {
            item.transform.ScalePlanarScale(scale);
        }
        static public void ScaleLocalPlanarScale(this GameObject item, float scale)
        {
            item.transform.ScaleLocalPlanarScale(scale);
        }

		static public void ScalePlanarScale(this Component item, float scale)
        {
            item.transform.ScalePlanarScale(scale);
        }
        static public void ScaleLocalPlanarScale(this Component item, float scale)
        {
            item.transform.ScaleLocalPlanarScale(scale);
        }
	}
}