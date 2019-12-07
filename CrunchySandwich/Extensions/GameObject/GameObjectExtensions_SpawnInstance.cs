using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class GameObjectExtensions_SpawnInstance
    {
        static public GameObject SpawnInstanceSpacarAt(this GameObject item, Vector3 position)
        {
            GameObject instance = item.SpawnInstance();

            instance.SetSpacarPosition(position);
            return instance;
        }

        static public GameObject SpawnInstancePlanarAt(this GameObject item, Vector2 position)
        {
            GameObject instance = item.SpawnInstance();

            instance.SetPlanarPosition(position);
            return instance;
        }
        static public GameObject SpawnInstancePlanarAt(this GameObject item, Vector2 position, float angle)
        {
            GameObject instance = item.SpawnInstance();

            instance.SetPlanarPosition(position);
            instance.SetPlanarRotation(angle);
            return instance;
        }
    }
}