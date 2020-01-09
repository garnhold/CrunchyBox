using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Angle
    {
			
			static public float GetPlanarAngleInDegreesBetween(this GameObject item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInDegrees();
			}
		
			static public float GetPlanarAngleInRadiansBetween(this GameObject item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInRadians();
			}
		
			static public float GetPlanarAngleInPercentBetween(this GameObject item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInPercent();
			}
					
			static public float GetPlanarAngleInDegreesBetween(this GameObject item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInDegrees();
			}
		
			static public float GetPlanarAngleInRadiansBetween(this GameObject item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInRadians();
			}
		
			static public float GetPlanarAngleInPercentBetween(this GameObject item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInPercent();
			}
						
			static public float GetPlanarAngleInDegreesBetween(this Component item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInDegrees();
			}
		
			static public float GetPlanarAngleInRadiansBetween(this Component item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInRadians();
			}
		
			static public float GetPlanarAngleInPercentBetween(this Component item, GameObject target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInPercent();
			}
					
			static public float GetPlanarAngleInDegreesBetween(this Component item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInDegrees();
			}
		
			static public float GetPlanarAngleInRadiansBetween(this Component item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInRadians();
			}
		
			static public float GetPlanarAngleInPercentBetween(this Component item, Component target)
			{
				return (target.GetPlanarPosition() - item.GetPlanarPosition()).GetAngleInPercent();
			}
				}
}