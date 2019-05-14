using System;
using System.IO;

namespace CrunchyDough
{
    public class StreamFile : StreamItem, StreamSystemStream
    {
        public StreamFile(string n, StreamDirectory d) : base(n, d)
        {
        }

        public override string GetPath()
        {
            return GetParentDirectory().GetChildPath(GetName());
        }
    }
}