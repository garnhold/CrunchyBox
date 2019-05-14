using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class RequireComponentExtensions_Types
    {
        static public IEnumerable<Type> GetRequiredComponentTypes(this RequireComponent item)
        {
            if (item.m_Type0 != null)
                yield return item.m_Type0;

            if (item.m_Type1 != null)
                yield return item.m_Type1;

            if (item.m_Type2 != null)
                yield return item.m_Type2;
        }
    }
}