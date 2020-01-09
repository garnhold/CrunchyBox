using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingEntityName_Detect_Prop
    {
        static public bool TryDetectEntityPropMethodPair(this string item, out string set_method, out string get_method, out string prop_name)
        {
            string first = item.ParseWords().GetFirst();
            string suffix = item.RemoveFirst(first);

            if (suffix.IsNotEmpty())
            {
                prop_name = (suffix[0] == '_').ConvertBool(suffix.Offset(1), suffix);

                if (first.AreWordInvariantsEqual("get"))
                {
                    get_method = item;
                    set_method = "set".ReplaceCaseToMatch(first) + suffix;
                    return true;
                }

                if (first.AreWordInvariantsEqual("set"))
                {
                    set_method = item;
                    get_method = "get".ReplaceCaseToMatch(first) + suffix;

                    return true;
                }
            }

            prop_name = item;
            set_method = item;
            get_method = item;
            return false;
        }

        static public bool TryDetectEntityPropMethodPair(this string item, out string set_method, out string get_method)
        {
            string prop_name;

            return item.TryDetectEntityPropMethodPair(out set_method, out get_method, out prop_name);
        }

        static public string DetectEntityPropName(this string item)
        {
            string set_method;
            string get_method;
            string prop_name;

            item.TryDetectEntityPropMethodPair(out set_method, out get_method, out prop_name);
            return prop_name;
        }
    }
}