using System;
using System.Resources;
using System.Collections;
using System.Collections.Generic;

using System.Globalization;

namespace CrunchyDough
{
    static public class ResourceManagerExtensions_Keys
    {
        static public IEnumerable<string> GetKeys(this ResourceManager item)
        {
            try
            {
                return item.GetResourceSet(CultureInfo.CurrentUICulture, true, true)
                    .Bridge<DictionaryEntry>()
                    .Convert(e => e.Key.ToStringEX());
            }
            catch (Exception)
            {
            }

            return Empty.IEnumerable<string>();
        }
    }
}