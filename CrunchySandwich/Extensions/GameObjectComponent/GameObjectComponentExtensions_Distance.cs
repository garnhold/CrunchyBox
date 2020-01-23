using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Distance
    {
			
			static public float GetPlanarDistanceBetween(this GameObject item, GameObject target)
			{
				return item.GetPlanarPosition().GetDistanceTo(target.GetPlanarPosition());
			}

			static public float GetPlanarSquaredDistanceBetween(this GameObject item, GameObject target)
			{
				return item.GetPlanarPosition().GetSquaredDistanceTo(target.GetPlanarPosition());
			}

			static public bool IsWithinPlanarDistance(this GameObject item, GameObject target, float distance)
			{
				return item.GetPlanarPosition().IsWithinDistance(target.GetPlanarPosition(), distance);
			}

			static public bool IsOutsidePlanarDistance(this GameObject item, GameObject target, float distance)
			{
				return item.GetPlanarPosition().IsOutsideDistance(target.GetPlanarPosition(), distance);
			}
		
			static public float GetPlanarDistanceBetween(this GameObject item, Component target)
			{
				return item.GetPlanarPosition().GetDistanceTo(target.GetPlanarPosition());
			}

			static public float GetPlanarSquaredDistanceBetween(this GameObject item, Component target)
			{
				return item.GetPlanarPosition().GetSquaredDistanceTo(target.GetPlanarPosition());
			}

			static public bool IsWithinPlanarDistance(this GameObject item, Component target, float distance)
			{
				return item.GetPlanarPosition().IsWithinDistance(target.GetPlanarPosition(), distance);
			}

			static public bool IsOutsidePlanarDistance(this GameObject item, Component target, float distance)
			{
				return item.GetPlanarPosition().IsOutsideDistance(target.GetPlanarPosition(), distance);
			}
		
		static public float GetPlanarDistanceBetween(this GameObject item, Vector2 target)
		{
			return item.GetPlanarPosition().GetDistanceTo(target);
		}

		static public float GetPlanarSquaredDistanceBetween(this GameObject item, Vector2 target)
		{
			return item.GetPlanarPosition().GetSquaredDistanceTo(target);
		}

		static public bool IsWithinPlanarDistance(this GameObject item, Vector2 target, float distance)
		{
			return item.GetPlanarPosition().IsWithinDistance(target, distance);
		}

		static public bool IsOutsidePlanarDistance(this GameObject item, Vector2 target, float distance)
		{
			return item.GetPlanarPosition().IsOutsideDistance(target, distance);
		}
			
			static public float GetSpacarDistanceBetween(this GameObject item, GameObject target)
			{
				return item.GetSpacarPosition().GetDistanceTo(target.GetSpacarPosition());
			}

			static public float GetSpacarSquaredDistanceBetween(this GameObject item, GameObject target)
			{
				return item.GetSpacarPosition().GetSquaredDistanceTo(target.GetSpacarPosition());
			}

			static public bool IsWithinSpacarDistance(this GameObject item, GameObject target, float distance)
			{
				return item.GetSpacarPosition().IsWithinDistance(target.GetSpacarPosition(), distance);
			}

			static public bool IsOutsideSpacarDistance(this GameObject item, GameObject target, float distance)
			{
				return item.GetSpacarPosition().IsOutsideDistance(target.GetSpacarPosition(), distance);
			}
		
			static public float GetSpacarDistanceBetween(this GameObject item, Component target)
			{
				return item.GetSpacarPosition().GetDistanceTo(target.GetSpacarPosition());
			}

			static public float GetSpacarSquaredDistanceBetween(this GameObject item, Component target)
			{
				return item.GetSpacarPosition().GetSquaredDistanceTo(target.GetSpacarPosition());
			}

			static public bool IsWithinSpacarDistance(this GameObject item, Component target, float distance)
			{
				return item.GetSpacarPosition().IsWithinDistance(target.GetSpacarPosition(), distance);
			}

			static public bool IsOutsideSpacarDistance(this GameObject item, Component target, float distance)
			{
				return item.GetSpacarPosition().IsOutsideDistance(target.GetSpacarPosition(), distance);
			}
		
		static public float GetSpacarDistanceBetween(this GameObject item, Vector3 target)
		{
			return item.GetSpacarPosition().GetDistanceTo(target);
		}

		static public float GetSpacarSquaredDistanceBetween(this GameObject item, Vector3 target)
		{
			return item.GetSpacarPosition().GetSquaredDistanceTo(target);
		}

		static public bool IsWithinSpacarDistance(this GameObject item, Vector3 target, float distance)
		{
			return item.GetSpacarPosition().IsWithinDistance(target, distance);
		}

		static public bool IsOutsideSpacarDistance(this GameObject item, Vector3 target, float distance)
		{
			return item.GetSpacarPosition().IsOutsideDistance(target, distance);
		}
				
			static public float GetPlanarDistanceBetween(this Component item, GameObject target)
			{
				return item.GetPlanarPosition().GetDistanceTo(target.GetPlanarPosition());
			}

			static public float GetPlanarSquaredDistanceBetween(this Component item, GameObject target)
			{
				return item.GetPlanarPosition().GetSquaredDistanceTo(target.GetPlanarPosition());
			}

			static public bool IsWithinPlanarDistance(this Component item, GameObject target, float distance)
			{
				return item.GetPlanarPosition().IsWithinDistance(target.GetPlanarPosition(), distance);
			}

			static public bool IsOutsidePlanarDistance(this Component item, GameObject target, float distance)
			{
				return item.GetPlanarPosition().IsOutsideDistance(target.GetPlanarPosition(), distance);
			}
		
			static public float GetPlanarDistanceBetween(this Component item, Component target)
			{
				return item.GetPlanarPosition().GetDistanceTo(target.GetPlanarPosition());
			}

			static public float GetPlanarSquaredDistanceBetween(this Component item, Component target)
			{
				return item.GetPlanarPosition().GetSquaredDistanceTo(target.GetPlanarPosition());
			}

			static public bool IsWithinPlanarDistance(this Component item, Component target, float distance)
			{
				return item.GetPlanarPosition().IsWithinDistance(target.GetPlanarPosition(), distance);
			}

			static public bool IsOutsidePlanarDistance(this Component item, Component target, float distance)
			{
				return item.GetPlanarPosition().IsOutsideDistance(target.GetPlanarPosition(), distance);
			}
		
		static public float GetPlanarDistanceBetween(this Component item, Vector2 target)
		{
			return item.GetPlanarPosition().GetDistanceTo(target);
		}

		static public float GetPlanarSquaredDistanceBetween(this Component item, Vector2 target)
		{
			return item.GetPlanarPosition().GetSquaredDistanceTo(target);
		}

		static public bool IsWithinPlanarDistance(this Component item, Vector2 target, float distance)
		{
			return item.GetPlanarPosition().IsWithinDistance(target, distance);
		}

		static public bool IsOutsidePlanarDistance(this Component item, Vector2 target, float distance)
		{
			return item.GetPlanarPosition().IsOutsideDistance(target, distance);
		}
			
			static public float GetSpacarDistanceBetween(this Component item, GameObject target)
			{
				return item.GetSpacarPosition().GetDistanceTo(target.GetSpacarPosition());
			}

			static public float GetSpacarSquaredDistanceBetween(this Component item, GameObject target)
			{
				return item.GetSpacarPosition().GetSquaredDistanceTo(target.GetSpacarPosition());
			}

			static public bool IsWithinSpacarDistance(this Component item, GameObject target, float distance)
			{
				return item.GetSpacarPosition().IsWithinDistance(target.GetSpacarPosition(), distance);
			}

			static public bool IsOutsideSpacarDistance(this Component item, GameObject target, float distance)
			{
				return item.GetSpacarPosition().IsOutsideDistance(target.GetSpacarPosition(), distance);
			}
		
			static public float GetSpacarDistanceBetween(this Component item, Component target)
			{
				return item.GetSpacarPosition().GetDistanceTo(target.GetSpacarPosition());
			}

			static public float GetSpacarSquaredDistanceBetween(this Component item, Component target)
			{
				return item.GetSpacarPosition().GetSquaredDistanceTo(target.GetSpacarPosition());
			}

			static public bool IsWithinSpacarDistance(this Component item, Component target, float distance)
			{
				return item.GetSpacarPosition().IsWithinDistance(target.GetSpacarPosition(), distance);
			}

			static public bool IsOutsideSpacarDistance(this Component item, Component target, float distance)
			{
				return item.GetSpacarPosition().IsOutsideDistance(target.GetSpacarPosition(), distance);
			}
		
		static public float GetSpacarDistanceBetween(this Component item, Vector3 target)
		{
			return item.GetSpacarPosition().GetDistanceTo(target);
		}

		static public float GetSpacarSquaredDistanceBetween(this Component item, Vector3 target)
		{
			return item.GetSpacarPosition().GetSquaredDistanceTo(target);
		}

		static public bool IsWithinSpacarDistance(this Component item, Vector3 target, float distance)
		{
			return item.GetSpacarPosition().IsWithinDistance(target, distance);
		}

		static public bool IsOutsideSpacarDistance(this Component item, Vector3 target, float distance)
		{
			return item.GetSpacarPosition().IsOutsideDistance(target, distance);
		}
		}
}
