using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Parse_Bool
    {
        static private LookupSet<string, bool> BOOL_WORDS = new OptionTable<bool>(
            KeyValuePair.New("true", true),
            KeyValuePair.New("ok", true),
            KeyValuePair.New("okay", true),
            KeyValuePair.New("yes", true),
            KeyValuePair.New("on", true),
            KeyValuePair.New("hi", true),
            KeyValuePair.New("high", true),
            KeyValuePair.New("live", true),
            KeyValuePair.New("accept", true),
            KeyValuePair.New("confirm", true),
            KeyValuePair.New("affirmative", true),
            KeyValuePair.New("t", true),
            KeyValuePair.New("y", true),
            KeyValuePair.New("1", true),

            KeyValuePair.New("false", false),
            KeyValuePair.New("no", false),
            KeyValuePair.New("off", false),
            KeyValuePair.New("lo", false),
            KeyValuePair.New("low", false),
            KeyValuePair.New("dead", false),
            KeyValuePair.New("deny", false),
            KeyValuePair.New("refuse", false),
            KeyValuePair.New("negative", false),
            KeyValuePair.New("f", false),
            KeyValuePair.New("n", false),
            KeyValuePair.New("0", false)
        );

        static public bool TryParseBool(this string item, out bool value)
        {
            return BOOL_WORDS.TryLookup(item, out value);
        }

        static public bool ParseBool(this string item, bool default_value)
        {
            bool value;

            if (item.TryParseBool(out value))
                return value;

            return default_value;
        }
        static public bool ParseBool(this string item)
        {
            return item.ParseBool(false);
        }
    }
}