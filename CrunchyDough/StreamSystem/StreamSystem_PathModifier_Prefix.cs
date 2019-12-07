using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StreamSystem_PathModifier_Prefix : StreamSystem_PathModifier
    {
        private string prefix;

        protected override string CalculatePath(string path)
        {
            return prefix + path;
        }

        public StreamSystem_PathModifier_Prefix(string p, StreamSystem s) : base(s)
        {
            prefix = p;
        }

        public override string GetSystemName()
        {
            return prefix;
        }

        public override string GetSystemFullName()
        {
            return GetInternalStreamSystem().GetSystemFullName() + " : " + prefix;
        }
    }
}