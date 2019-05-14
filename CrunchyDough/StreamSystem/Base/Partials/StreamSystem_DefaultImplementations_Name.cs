using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract partial class StreamSystem
    {
        public virtual string GetSystemName()
        {
            return GetSystemFullName();
        }

        public virtual string GetSystemFullName()
        {
            return GetType().Name;
        }
    }
}