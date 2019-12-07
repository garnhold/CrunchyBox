using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class ExternalRunnerCommandExtensions_Execute
    {
        static public Stream ExecuteToStream(this ExternalRunner_Command item, string arguments)
        {
            return item.ExecuteToReader(arguments).BaseStream;
        }
        static public Stream ExecuteToStream(this ExternalRunner_Command item)
        {
            return item.ExecuteToStream(item.GetDefaultArguments());
        }

        static public string ExecuteToText(this ExternalRunner_Command item, string arguments)
        {
            return item.ExecuteToReader(arguments).ReadToEnd();
        }
        static public string ExecuteToText(this ExternalRunner_Command item)
        {
            return item.ExecuteToText(item.GetDefaultArguments());
        }

        static public void Execute(this ExternalRunner_Command item, string arguments)
        {
            item.ExecuteToReader(arguments);
        }
        static public void Execute(this ExternalRunner_Command item)
        {
            item.Execute(item.GetDefaultArguments());
        }
    }
}