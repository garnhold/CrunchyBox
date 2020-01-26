using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Child_Destroy
    {
		static public bool DestroyChildByName(this GameObject item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.Destroy();
				return true;
			}

			return false;
		}

		static public bool DestroyChildByName(this Component item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.Destroy();
				return true;
			}

			return false;
		}

		static public bool DestroyChildByNameImmediate(this GameObject item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.DestroyImmediate();
				return true;
			}

			return false;
		}

		static public bool DestroyChildByNameImmediate(this Component item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.DestroyImmediate();
				return true;
			}

			return false;
		}

		static public bool DestroyChildByNameAdvisory(this GameObject item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.DestroyAdvisory();
				return true;
			}

			return false;
		}

		static public bool DestroyChildByNameAdvisory(this Component item, string name)
		{
			GameObject child = item.GetChildByName(name);

			if(child != null)
			{
				child.DestroyAdvisory();
				return true;
			}

			return false;
		}

	}
}