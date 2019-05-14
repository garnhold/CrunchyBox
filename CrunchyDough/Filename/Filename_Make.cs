using System;
using System.IO;

namespace CrunchyDough
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

        static public bool TryMakeNewFilename(string directory, string filename, int i, out string new_filename)
        {
            string base_filename = filename;

            if (i > 0)
                base_filename = AddFilenameSuffix(filename, CleanFilename(Strings.PseudoRandom(10)));

            new_filename = MakeFilename(directory, base_filename);

            if (File.Exists(new_filename) || Directory.Exists(new_filename))
                return false;

            return true;
        }

        static public bool TryMakeNewFilename(string directory, string filename, out string new_filename)
        {
            for (int i = 0; i < MAX_NUMBER_NEW_NAME_TRYS; i++)
            {
                if (TryMakeNewFilename(directory, filename, i, out new_filename))
                    return true;
            }

            new_filename = "";
            return false;
        }

        static public string MakeNewFilename(string directory, string filename, string extension)
        {
            string new_filename;

            TryMakeNewFilename(directory, SetExtension(filename, extension), out new_filename);
            return new_filename;
        }

        static public string MakeNewFilename(string directory, string extension)
        {
            return MakeNewFilename(directory, GetRandomFilename(), extension);
        }
    }
}