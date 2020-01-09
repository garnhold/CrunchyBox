using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingEntityName_Detect_Evt
    {
        static public bool TryDetectEntityEvtMethodPair(this string item, out string add_method, out string remove_method, out string evt_name)
        {
            string first = item.ParseWords().GetFirst();
            string suffix = item.RemoveFirst(first);

            if (suffix.IsNotEmpty())
            {
                evt_name = (suffix[0] == '_').ConvertBool(suffix.Offset(1), suffix);

                if (first.AreWordInvariantsEqual("add"))
                {
                    add_method = item;
                    remove_method = "remove".ReplaceCaseToMatch(first) + suffix;

                    return true;
                }

                if (first.AreWordInvariantsEqual("remove"))
                {
                    remove_method = item;
                    add_method = "add".ReplaceCaseToMatch(first) + suffix;
                    return true;
                }
            }

            evt_name = item;
            add_method = item;
            remove_method = item;
            return false;
        }

        static public bool TryDetectEntityEvtMethodPair(this string item, out string add_method, out string remove_method)
        {
            string evt_name;

            return item.TryDetectEntityEvtMethodPair(out add_method, out remove_method, out evt_name);
        }

        static public string DetectEntityEvtName(this string item)
        {
            string add_method;
            string remove_method;
            string evt_name;

            item.TryDetectEntityEvtMethodPair(out add_method, out remove_method, out evt_name);
            return evt_name;
        }
    }
}