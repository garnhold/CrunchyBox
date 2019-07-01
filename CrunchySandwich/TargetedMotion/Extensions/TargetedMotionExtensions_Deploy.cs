using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TargetedMotionExtensions_Deploy
    {
        static public T Deploy<T>(this T item, GameObject target) where T : TargetedMotion
        {
            T instance = item.SpawnInstance<T>();

            instance.Initialize(target);
            return instance;
        }
    }
}