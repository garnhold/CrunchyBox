using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ForTypeAttributeExtensions
    {
        static public int GetTypeDistance(this ForTypeAttribute item, Type type)
        {
            return item.GetTargetType().GetTypeDistance(type);
        }
    }
}