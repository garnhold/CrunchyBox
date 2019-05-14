using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyLunch
{
    public abstract class ExternalRunner
    {
        protected string default_arguments;
        protected System.Diagnostics.Process process;

        public ExternalRunner(string da)
        {
            default_arguments = da;
        }

        public void SetDefaultArguments(string arguments)
        {
            default_arguments = arguments;
        }

        public void Stop()
        {
            if (IsRunning())
                process.Kill();
        }

        public void Abandon()
        {
            process = null;
        }

        public bool IsRunning()
        {
            if (process != null)
            {
                if (process.HasExited == false)
                    return true;
            }

            return false;
        }

        public bool IsExited()
        {
            if (process != null)
            {
                if (process.HasExited)
                    return true;
            }

            return false;
        }

        public string GetDefaultArguments()
        {
            return default_arguments;
        }
    }
}