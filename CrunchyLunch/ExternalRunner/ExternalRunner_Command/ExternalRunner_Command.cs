using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyLunch
{
    public class ExternalRunner_Command : ExternalRunner
    {
        private string filename;

        public ExternalRunner_Command(string f, string da) : base(da)
        {
            filename = Filename.GetAbsolutePath(f);
        }

        public ExternalRunner_Command(string f) : this(f, "") { }

        public StreamReader ExecuteToReader(string arguments)
        {
            Stop();

            process = new System.Diagnostics.Process();

            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            return process.StandardOutput;
        }
        public StreamReader ExecuteToReader()
        {
            return ExecuteToReader(GetDefaultArguments());
        }
    }
}