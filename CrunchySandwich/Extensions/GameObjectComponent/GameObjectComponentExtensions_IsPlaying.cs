using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_IsPlaying
    {

		static public bool IsPlaying(this GameObject item)
		{
			if(Application.IsPlaying(item))
				return true;

			return false;
		}

		static public bool IsEditing(this GameObject item)
		{
			if(item.IsPlaying() == false)
				return true;

			return false;
		}

		static public bool IsPlaying(this Component item)
		{
			if(Application.IsPlaying(item))
				return true;

			return false;
		}

		static public bool IsEditing(this Component item)
		{
			if(item.IsPlaying() == false)
				return true;

			return false;
		}
	}
}