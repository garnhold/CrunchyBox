using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class StreamSystem_PathModifier_Directory : StreamSystem_PathModifier
    {
        private string directory;

        protected override string CalculatePath(string path)
        {
            return Filename.ForwardCombine(directory, path);
        }

        public StreamSystem_PathModifier_Directory(string d, StreamSystem s) : base(s)
        {
            directory = d;
        }

        public override string GetSystemName()
        {
            return Filename.GetTopDirectoryName(directory);
        }

        public override string GetSystemFullName()
        {
            return GetInternalStreamSystem().GetSystemFullName() + " : " + directory;
        }
    }
}