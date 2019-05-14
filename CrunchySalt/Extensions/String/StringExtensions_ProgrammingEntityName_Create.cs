using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class StringExtensions_ProgrammingEntityName_Create
    {
        static public string CreateDerivedClass(this string item, string entity)
        {
            string base_class = item.CreateBaseClassDerivationContribution();

            base_class.ParseWordInvariants().Process(w => entity = entity.RemoveFirstCaseInsensitive(w));
            return base_class + "_" + entity.StyleAsClassName();
        }

        static public string CreateBaseClassDerivationContribution(this string item)
        {
            return item.TrimSuffix("_Intermediate");
        }
    }
}