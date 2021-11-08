using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Lunch
{
    using Dough;
    
    public class ExternalRunner_Process : ExternalRunner
    {
        private string filename;

        private object output_lock;
        private List<string> output_buffer;

        public ExternalRunner_Process(string f, string da) : base(da)
        {
            filename = f;

            output_lock = new object();
            output_buffer = new List<string>();
        }

        public ExternalRunner_Process(string f) : this(f, "") { }

        public void Start(string arguments)
        {
            Stop();

            process = new System.Diagnostics.Process();

            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            ClearOutput();

            process.OutputDataReceived += delegate(object sender, System.Diagnostics.DataReceivedEventArgs e) {
                lock (output_lock)
                    output_buffer.Add(e.Data);
            };

            process.Start();
            process.BeginOutputReadLine();
        }
        public void Start(IEnumerable<string> arguments)
        {
            Start(arguments.MakeCommand());
        }
        public void Start()
        {
            Start(GetDefaultArguments());
        }

        public bool WaitForExit(int max_milliseconds)
        {
            if (IsRunning())
                return process.WaitForExit(max_milliseconds);

            return true;
        }
        public bool WaitForExit()
        {
            return WaitForExit(int.MaxValue);
        }

        public void ClearOutput()
        {
            lock (output_lock)
                output_buffer.Clear();
        }

        public void WriteLine(string input)
        {
            if (IsRunning())
                process.StandardInput.WriteLine(input);
        }

        public string ReadLine()
        {
            lock (output_lock)
                return output_buffer.PopFirst();
        }

        public IEnumerable<string> ReadLines()
        {
            string line;

            while ((line = ReadLine()) != null)
                yield return line;
        }

        public string ReadText()
        {
            return ReadLines().Join("\n");
        }
    }
}