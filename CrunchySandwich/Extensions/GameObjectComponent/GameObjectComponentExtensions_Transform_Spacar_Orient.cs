using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Orient
    {
		
		static public void OrientSpacarLocalToWorld(this GameObject item, Vector3 l1, Vector3 l2, Vector3 l3, Vector3 w1, Vector3 w2, Vector3 w3)
		{
			item.transform.OrientSpacarLocalToWorld(l1, l2, l3, w1, w2, w3);
		}
		
		static public void OrientSpacarLocalToWorld(this Component item, Vector3 l1, Vector3 l2, Vector3 l3, Vector3 w1, Vector3 w2, Vector3 w3)
		{
			item.transform.OrientSpacarLocalToWorld(l1, l2, l3, w1, w2, w3);
		}
	}
}