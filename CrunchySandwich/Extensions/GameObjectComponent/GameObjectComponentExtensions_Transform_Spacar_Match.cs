using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Match
    {
	
		static public void MatchSpacarTransform(this GameObject item, GameObject target)
		{
			item.transform.MatchSpacarTransform(target.transform);
		}

	
		static public void MatchSpacarTransform(this GameObject item, Component target)
		{
			item.transform.MatchSpacarTransform(target.transform);
		}

		
		static public void MatchSpacarTransform(this Component item, GameObject target)
		{
			item.transform.MatchSpacarTransform(target.transform);
		}

	
		static public void MatchSpacarTransform(this Component item, Component target)
		{
			item.transform.MatchSpacarTransform(target.transform);
		}

		}
}