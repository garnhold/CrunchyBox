using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class ExternalRunnerProcessExtensions_Execute
    {
        static public bool TryExecuteToText(this ExternalRunner_Process item, string arguments, out string text, int max_milliseconds)
        {
            item.Start(arguments);

            bool to_return = item.WaitForExit();
            text = item.ReadText();

            return to_return;
        }
        static public bool TryExecuteToText(this ExternalRunner_Process item, out string text, int max_milliseconds)
        {
            return item.TryExecuteToText(item.GetDefaultArguments(), out text, max_milliseconds);
        }

        static public string ExecuteToText(this ExternalRunner_Process item, string arguments, int max_milliseconds)
        {
            string text;

            item.TryExecuteToText(arguments, out text, max_milliseconds);
            return text;
        }
        static public string ExecuteToText(this ExternalRunner_Process item, int max_milliseconds)
        {
            return item.ExecuteToText(item.GetDefaultArguments(), max_milliseconds);
        }

        static public string ExecuteToText(this ExternalRunner_Process item, string arguments)
        {
            return item.ExecuteToText(arguments, int.MaxValue);
        }
        static public string ExecuteToText(this ExternalRunner_Process item)
        {
            return item.ExecuteToText(item.GetDefaultArguments());
        }

        static public bool Execute(this ExternalRunner_Process item, string arguments, int max_milliseconds)
        {
            string text;

            return item.TryExecuteToText(arguments, out text, max_milliseconds);
        }
        static public bool Execute(this ExternalRunner_Process item, int max_milliseconds)
        {
            return item.Execute(item.GetDefaultArguments(), max_milliseconds);
        }

        static public bool Execute(this ExternalRunner_Process item, string arguments)
        {
            return item.Execute(arguments, int.MaxValue);
        }
        static public bool Execute(this ExternalRunner_Process item)
        {
            return item.Execute(item.GetDefaultArguments());
        }
    }
}