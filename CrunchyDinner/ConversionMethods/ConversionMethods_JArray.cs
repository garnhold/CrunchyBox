using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Noodle;

namespace Crunchy.Dinner
{
    [Conversion]
    static public class ConversionMethods_JArray
    {
        [Conversion]
        static public IEnumerable<T> ToIEnumerable<T>(JArray item)
        {
            return item.Convert(t => t.ConvertEX<T>());
        }

        [Conversion]
        static public T[] ToArray<T>(JArray item)
        {
            return item.Convert(t => t.ConvertEX<T>())
                .ToArray();
        }
    }
}