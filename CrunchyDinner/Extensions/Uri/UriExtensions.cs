using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class UriExtensions
    {
        static public string GetOrigin(this Uri item)
        {
            return item.Scheme + "://" + item.Host + ":" + item.Port;
        }
    }
}