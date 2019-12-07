using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Child_Get
    {
		static public GameObject GetChildByName(this GameObject item, string name)
        {
            return item.GetChildren().FindFirst(g => g.name == name);
        }

        static public GameObject GetChildByNameSequence(this GameObject item, IEnumerable<string> names)
        {
            GameObject game_object = item.gameObject;

            foreach (string name in names)
            {
                if (game_object == null)
                    return null;

                game_object = game_object.GetChildByName(name);
            }

            return game_object;
        }

        static public GameObject GetChildByPath(this GameObject item, string path)
        {
            return item.GetChildByNameSequence(path.SplitOn("->"));
        }

		static public GameObject GetChildByName(this Component item, string name)
        {
            return item.GetChildren().FindFirst(g => g.name == name);
        }

        static public GameObject GetChildByNameSequence(this Component item, IEnumerable<string> names)
        {
            GameObject game_object = item.gameObject;

            foreach (string name in names)
            {
                if (game_object == null)
                    return null;

                game_object = game_object.GetChildByName(name);
            }

            return game_object;
        }

        static public GameObject GetChildByPath(this Component item, string path)
        {
            return item.GetChildByNameSequence(path.SplitOn("->"));
        }

	}
}