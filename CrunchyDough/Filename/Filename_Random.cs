using System;
using System.IO;

namespace CrunchyDough
{
    static public partial class Filename
    {
        static private int NEXT_RANDOM_ID = 1;

        static public string GetRandomFilename()
        {
            return CleanFilename(Strings.PseudoRandom(32) + (NEXT_RANDOM_ID++));
        }
    }
}