using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Planar_Orient
    {
		
		static public void OrientPlanarLocalToWorld(this GameObject item, Vector2 l1, Vector2 l2, Vector2 w1, Vector2 w2)
		{
			item.transform.OrientPlanarLocalToWorld(l1, l2, w1, w2);
		}
		
		static public void OrientPlanarLocalToWorld(this Component item, Vector2 l1, Vector2 l2, Vector2 w1, Vector2 w2)
		{
			item.transform.OrientPlanarLocalToWorld(l1, l2, w1, w2);
		}
	}
}