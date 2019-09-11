using System;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    [Conversion]
    static public class GeneralConversionMethods_GameObject
    {
        [Conversion]
        static public object FromGameObject(GameObject game_object, Type type)
        {
            return game_object.GetComponent(type);
        }
    }
}