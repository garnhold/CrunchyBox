using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        public const int MAX_NUMBER_NEW_NAME_TRYS = 32;

        static public string MakeFilename(string directory, string filename)
        {
            return Combine(GetDirectory(directory), CleanFilename(GetFilenameWithExtension(filename)));
        }

        static public string MakeFilename(string directory, string filename, string extension)
        {
            return MakeFilename(directory, SetExtension(filename, extension));
        }

        static public string MakeUnusedFilename(string directory, string filename, string extension)
        {
            return Files.GetUnusedFilename(MakeFilename(directory, filename, extension));
        }

        static public string MakeUnusedFilename(string directory, string extension)
        {
            return MakeUnusedFilename(directory, GetRandomFilename(), extension);
        }
    }
}