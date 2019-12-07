using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Planar_Match
    {
	
		static public void MatchPlanarTransform(this GameObject item, GameObject target)
		{
			item.transform.MatchPlanarTransform(target.transform);
		}

	
		static public void MatchPlanarTransform(this GameObject item, Component target)
		{
			item.transform.MatchPlanarTransform(target.transform);
		}

		
		static public void MatchPlanarTransform(this Component item, GameObject target)
		{
			item.transform.MatchPlanarTransform(target.transform);
		}

	
		static public void MatchPlanarTransform(this Component item, Component target)
		{
			item.transform.MatchPlanarTransform(target.transform);
		}

		}
}