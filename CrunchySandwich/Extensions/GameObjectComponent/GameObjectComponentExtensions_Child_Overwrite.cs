using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Child_Overwrite
    {
		static public void OverwriteChildByName(this GameObject item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByName(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByName(this GameObject item, string name, GameObject game_object)
		{
			item.OverwriteChildByName(name, () => game_object);
		}

		static public void OverwriteChild(this GameObject item, GameObject game_object)
		{
			item.OverwriteChildByName(game_object.name, game_object);
		}

		static public void OverwriteChildByName(this Component item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByName(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByName(this Component item, string name, GameObject game_object)
		{
			item.OverwriteChildByName(name, () => game_object);
		}

		static public void OverwriteChild(this Component item, GameObject game_object)
		{
			item.OverwriteChildByName(game_object.name, game_object);
		}

		static public void OverwriteChildByNameImmediate(this GameObject item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByNameImmediate(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByNameImmediate(this GameObject item, string name, GameObject game_object)
		{
			item.OverwriteChildByNameImmediate(name, () => game_object);
		}

		static public void OverwriteChildImmediate(this GameObject item, GameObject game_object)
		{
			item.OverwriteChildByNameImmediate(game_object.name, game_object);
		}

		static public void OverwriteChildByNameImmediate(this Component item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByNameImmediate(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByNameImmediate(this Component item, string name, GameObject game_object)
		{
			item.OverwriteChildByNameImmediate(name, () => game_object);
		}

		static public void OverwriteChildImmediate(this Component item, GameObject game_object)
		{
			item.OverwriteChildByNameImmediate(game_object.name, game_object);
		}

		static public void OverwriteChildByNameAdvisory(this GameObject item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByNameAdvisory(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByNameAdvisory(this GameObject item, string name, GameObject game_object)
		{
			item.OverwriteChildByNameAdvisory(name, () => game_object);
		}

		static public void OverwriteChildAdvisory(this GameObject item, GameObject game_object)
		{
			item.OverwriteChildByNameAdvisory(game_object.name, game_object);
		}

		static public void OverwriteChildByNameAdvisory(this Component item, string name, Operation<GameObject> operation)
		{
			item.DestroyChildByNameAdvisory(name);
			item.AddChild(operation()).IfNotNull(g => g.name = name);
		}

		static public void OverwriteChildByNameAdvisory(this Component item, string name, GameObject game_object)
		{
			item.OverwriteChildByNameAdvisory(name, () => game_object);
		}

		static public void OverwriteChildAdvisory(this Component item, GameObject game_object)
		{
			item.OverwriteChildByNameAdvisory(game_object.name, game_object);
		}

	}
}