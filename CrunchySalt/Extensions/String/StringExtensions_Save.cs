using System;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_Save
    {
        static public string GetFilenameFromClassName(this string item)
        {
            return item + ".cs";
        }

        static public bool SaveClass(this string item, string directory, string class_name, bool overwrite)
        {
            return item.Save(directory, class_name.GetFilenameFromClassName(), overwrite);
        }

        static public bool SaveVisibleClass(this string item, string directory, string class_name, bool overwrite)
        {
            return item.SaveVisible(directory, class_name.GetFilenameFromClassName(), overwrite);
        }

        static public bool SaveChangesToClass(this string item, string directory, string class_name, bool overwrite)
        {
            return item.SaveChanges(directory, class_name.GetFilenameFromClassName(), overwrite);
        }
    }
}