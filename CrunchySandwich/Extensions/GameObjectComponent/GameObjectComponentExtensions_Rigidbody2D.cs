using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Rigidbody2D
    {
		static public Vector2 GetPlanarVelocity(this GameObject item)
		{
			return item.GetComponentValueUpward<Rigidbody2D, Vector2>(r => r.velocity);
		}

		static public float GetPlanarSpeed(this GameObject item)
		{
			return item.GetPlanarVelocity().GetMagnitude();
		}

		static public Vector2 GetPlanarVelocity(this Component item)
		{
			return item.GetComponentValueUpward<Rigidbody2D, Vector2>(r => r.velocity);
		}

		static public float GetPlanarSpeed(this Component item)
		{
			return item.GetPlanarVelocity().GetMagnitude();
		}

	}
}