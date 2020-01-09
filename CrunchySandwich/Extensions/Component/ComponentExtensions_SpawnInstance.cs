using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class ComponentExtensions_SpawnInstance
    {
        static public T SpawnInstanceSpacarAt<T>(this T item, Vector3 position) where T : Component
        {
            T instance = item.SpawnInstance();

            instance.SetSpacarPosition(position);
            return instance;
        }

        static public T SpawnInstancePlanarAt<T>(this T item, Vector2 position) where T : Component
        {
            T instance = item.SpawnInstance();

            instance.SetPlanarPosition(position);
            return instance;
        }
        static public T SpawnInstancePlanarAt<T>(this T item, Vector2 position, float angle) where T : Component
        {
            T instance = item.SpawnInstance();

            instance.SetPlanarPosition(position);
            instance.SetPlanarRotation(angle);
            return instance;
        }
    }
}