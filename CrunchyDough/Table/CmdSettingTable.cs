using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class CmdSettingTable : SettingTable
    {
        static private KeyValuePair<string, string> ConvertToKeyValuePair(IEnumerable<string> input)
        {
            string value;

            if (input.TryGetOnly(out value))
                return KeyValuePair.New("PRIMARY", value);

            return KeyValuePair.New(
                input.GetFirst().TrimPrefix("-"),
                input.Offset(1).Join(" ").CoalesceBlank("true")
            );
        }

        public CmdSettingTable(IEnumerable<string> args) : base(
            args.Split(s => s.StartsWith("-"))
            .Convert(o => ConvertToKeyValuePair(o))) { }
    }
}