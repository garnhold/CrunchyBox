using System;
using System.IO;
using System.Reflection;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static public string GetDataPath()
        {
            return Filename.ForwardCombine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                ProgramInfo.GetId() + "/"
            );
        }

        static public string MakeDataPath(string directory)
        {
            string path = Filename.ForwardCombine(GetDataPath(), directory + "/");

            Directory.CreateDirectory(path);
            return path;
        }

        static public string MakeDataFilename(string directory, string filename)
        {
            return Filename.MakeFilename(MakeDataPath(directory), filename);
        }
        static public string MakeObfuscatedDataFilename(string directory, string info)
        {
            return Filename.MakeDataFilename(directory, HashTypes.SHA1.CalculateAsUnicode(info).ToHexString());
        }

        static public string MakeDataFilename(string directory, string filename, string extension)
        {
            return Filename.MakeFilename(MakeDataPath(directory), filename, extension);
        }
        static public string MakeObfuscatedDataFilename(string directory, string info, string extension)
        {
            return Filename.MakeDataFilename(directory, HashTypes.SHA1.CalculateAsUnicode(info).ToHexString(), extension);
        }

        static public string MakeNewDataFilename(string directory, string extension)
        {
            return Filename.MakeNewFilename(MakeDataPath(directory), extension);
        }
    }
}