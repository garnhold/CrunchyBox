using System;

using CrunchyDough;

namespace CrunchyLunch
{
    public class TerminalBlock_ProcessInfo : TerminalBlock_Text
    {
        private string process_name;

        private Timer timer;
        private bool is_processed;

        public TerminalBlock_ProcessInfo(string n, int nw) : base(nw)
        {
            process_name = n;

            timer = new Timer();
        }

        public TerminalBlock_ProcessInfo(int nw) : this("", nw) { }
        public TerminalBlock_ProcessInfo(string n) : this(n.Length + 20) { }

        public void StartProcess()
        {
            timer.Restart();
            is_processed = false;

            SetText(process_name + "...");
        }

        public void FinishProcess()
        {
            timer.Pause();
            is_processed = true;

            SetText(process_name + " Done " + timer.GetElapsedTimeInMilliseconds() + "ms");
        }

        public void DoProcess(Process process)
        {
            StartProcess();
                process();
            FinishProcess();
        }

        public void SetProcessName(string name)
        {
            process_name = name;
        }

        public string GetProcessName()
        {
            return process_name;
        }

        public bool IsProcessed()
        {
            return is_processed;
        }
    }
}