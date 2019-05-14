using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyLunch
{
    public abstract partial class CmdProgram
    {
        protected abstract void RunInternal();

        static public void Run<T>(IEnumerable<string> args) where T : CmdProgram, new()
        {
            new T().Run(args);
        }

        public void Run(IEnumerable<string> args)
        {
            new CmdSettingTable(args).LoadAsConfigurationInto(this, true);

            PrintHeader(GetType().Name);
            RunInternal();
        }
    }
}