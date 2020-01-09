using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class ComponentExtensions_GameObject
    {
        static public void DestroyGameObject(this Component item)
        {
            item.gameObject.Destroy();
        }

        static public void DestroyGameObjectImmediate(this Component item, bool is_asset = false)
        {
            item.gameObject.DestroyImmediate(is_asset);
        }

        static public void DestroyGameObjectAdvisory(this Component item, bool is_asset = false)
        {
            item.gameObject.DestroyAdvisory(is_asset);
        }

        static public void ActivateGameObject(this Component item)
        {
            item.gameObject.ActivateGameObject();
        }

        static public void DeactivateGameObject(this Component item)
        {
            item.gameObject.DeactivateGameObject();
        }
    }
}