using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyPantry
{
    public abstract class FileSnapshot
    {
        private string name;
        private string mime_type;
        private string hash;
        private DateTime last_write_time;

        public abstract string GetPath();

        public FileSnapshot(string n, string m, string h, DateTime w)
        {
            name = n;
            mime_type = m;
            hash = h;
            last_write_time = w;
        }

        public string GetName()
        {
            return name;
        }

        public string GetMIMEType()
        {
            return mime_type;
        }

        public string GetHash()
        {
            return hash;
        }

        public DateTime GetLastWriteTime()
        {
            return last_write_time;
        }
    }
}