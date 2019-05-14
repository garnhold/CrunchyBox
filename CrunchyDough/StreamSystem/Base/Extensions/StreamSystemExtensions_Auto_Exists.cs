using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Auto_Exists
    {
        static public bool DoesExist(this StreamSystem item, string path)
        {
            if (item.DoesStreamExist(path))
                return true;

            if (item.DoesDirectoryExist(path))
                return true;

            return false;
        }
    }
}