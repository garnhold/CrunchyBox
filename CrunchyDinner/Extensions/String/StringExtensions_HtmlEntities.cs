using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Net;

using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class StringExtensions_HtmlEntities
    {
        static public string EncodeHtmlEntities(this string item)
        {
            return WebUtility.HtmlEncode(item);
        }
        static public string DecodeHtmlEntities(this string item)
        {
            return WebUtility.HtmlDecode(item);
        }
    }
}