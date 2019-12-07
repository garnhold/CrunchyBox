using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    static public class GameObjectComponentExtensions_Focus
    {
		static public void Focus(this GameObject item)
		{
			Selection.activeObject = item;
		}
		static public void Focus(this Component item)
		{
			Selection.activeObject = item;
		}
	}
}