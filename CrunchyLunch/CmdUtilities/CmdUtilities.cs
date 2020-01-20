using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Lunch
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class CmdUtilities
    {
        static public bool LoadConfigurationInfo(object obj, IEnumerable<string> args, bool strict = false)
        {
            return new CmdSettingTable(args).LoadAsConfigurationInto(obj, strict);
        }

        static public T CreateConfiguration<T>(T obj, IEnumerable<string> args, bool strict = false)
        {
            LoadConfigurationInfo(obj, args, strict);

            return obj;
        }
        static public T CreateConfiguration<T>(IEnumerable<string> args, bool strict = false)
        {
            return CreateConfiguration<T>(typeof(T).CreateInstance<T>(), args, strict);
        }
    }
}