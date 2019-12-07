using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    static public class GameObjectExtensions_Destroy
    {
        static public void Destroy(this GameObject item)
        {
            GameObject.Destroy(item);
        }

        static public void DestroyImmediate(this GameObject item, bool is_asset = false)
        {
            GameObject.DestroyImmediate(item, is_asset);
        }

        static public void DestroyAdvisory(this GameObject item, bool is_asset = false)
        {
            if (Application.isPlaying)
                item.Destroy();
            else
            {
                item.DeactivateGameObject();

                ApplicationEX.GetInstance().RegisterDeferredProcess(delegate() {
                    item.DestroyImmediate(is_asset);
                });
            }
        }
    }
}