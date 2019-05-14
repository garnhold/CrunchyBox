using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Identity
    {
        static public string GetElementsIdentity<T>(this IEnumerable<T> item) where T : Identifiable
        {
            return item.Convert(i => i.GetIdentityEX()).Join(", ");
        }
    }
}