using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using System.Net;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class StringExtensions_UrlEntities
    {
        static public string EncodeUrlEntities(this string item)
        {
            return WebUtility.UrlEncode(item);
        }
        static public string DecodeUrlEntities(this string item)
        {
            return WebUtility.UrlDecode(item);
        }

        static public IEnumerable<KeyValuePair<string, string>> DecodeUrlPairs(this string item)
        {
            return item.SplitOn("&")
                .Convert(p => p.SplitToTupleAtIndexOf("="))
                .Convert(t => KeyValuePair.New(t.item1.DecodeUrlEntities(), t.item2.DecodeUrlEntities()));
        }
        static public IDictionary<string, string> DecodeUrlDictionary(this string item)
        {
            return item.DecodeUrlPairs().ToDictionary();
        }
    }
}