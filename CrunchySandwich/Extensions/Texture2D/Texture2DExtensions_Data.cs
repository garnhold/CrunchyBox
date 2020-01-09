using System;
using System.IO;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Texture2DExtensions_Data
    {
        static public void SaveAsPNG(this Texture2D item, string filename)
        {
            File.WriteAllBytes(filename, item.EncodeToPNG());
        }

        static public void SaveAsJPG(this Texture2D item, string filename)
        {
            File.WriteAllBytes(filename, item.EncodeToJPG());
        }

        static public Texture2D Sideload(this Texture2D item)
        {
            return PlayEditDistinction<SideloadEditDistinctionAttribute>.Execute(t => t, item);
        }
    }

    public class SideloadEditDistinctionAttribute : EditDistinctionAttribute { }
}