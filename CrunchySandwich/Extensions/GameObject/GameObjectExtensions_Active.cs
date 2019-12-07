using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class GameObjectExtensions_Active
    {
        static public void ActivateGameObject(this GameObject item)
        {
            item.SetActive(true);
        }

        static public void DeactivateGameObject(this GameObject item)
        {
            item.SetActive(false);
        }
    }
}