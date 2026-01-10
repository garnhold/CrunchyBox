using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public bool DoesDirectoryExist(string filename)
        {
            if (Directory.Exists(filename))
                return true;

            return false;
        }

        static public string GetTopExistingDirectory(string filename)
        {
            while (filename.IsVisible())
            {
                if (DoesDirectoryExist(filename))
                    return filename;

                filename = Filename.GetParentDirectory(filename);
            }

            return null;
        }
    }
}