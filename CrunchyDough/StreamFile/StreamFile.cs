using System;
using System.IO;

namespace Crunchy.Dough
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