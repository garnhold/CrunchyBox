using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract partial class StreamSystem
    {
        public virtual ByteSequence GetStreamHash(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return this.Read(path, delegate(Stream stream) {
                return HashTypes.SHA1.Calculate(stream);
            }, milliseconds);
        }
    }
}