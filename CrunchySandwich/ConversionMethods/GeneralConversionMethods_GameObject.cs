using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
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