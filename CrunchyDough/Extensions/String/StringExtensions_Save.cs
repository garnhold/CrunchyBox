using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StringExtensions_Save
    {
        static public bool Save(this string item, string filename, bool overwrite)
        {
            if (overwrite || File.Exists(filename) == false)
            {
                File.WriteAllText(filename, item);
                return true;
            }

            return false;
        }
        static public bool SaveVisible(this string item, string filename, bool overwrite)
        {
            if (item.IsVisible())
                return item.Save(filename, overwrite);

            return false;
        }

        static public bool Save(this string item, string directory, string filename, bool overwrite)
        {
            return item.Save(Filename.MakeFilename(directory, filename), overwrite);
        }
        static public bool SaveVisible(this string item, string directory, string filename, bool overwrite)
        {
            if (item.IsVisible())
                return item.Save(directory, filename, overwrite);

            return false;
        }

        static public bool SaveChanges(this string item, string filename, bool overwrite)
        {
            if (File.Exists(filename))
            {
                if (File.ReadAllText(filename) != item)
                    return item.Save(filename, overwrite);

                return false;
            }

            return item.Save(filename, overwrite);
        }

        static public bool SaveChanges(this string item, string directory, string filename, bool overwrite)
        {
            return item.SaveChanges(Filename.MakeFilename(directory, filename), overwrite);
        }
    }
}