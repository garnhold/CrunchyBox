using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class StreamExtensions_Text
    {
        static public string ReadTextRandomLine(this Stream item, RandIntSource source)
        {
            StreamReader reader = new StreamReader(item);

            if (item.CanSeek)
            {
                item.Position = source.GetIndex((int)item.Length);

                if (reader.ReadLine() != null)
                {
                    string line = reader.ReadLine();

                    if (line != null)
                        return line;
                }

                item.Position = 0;
                return reader.ReadLine();
            }

            return reader.ReadLines().ToList().GetRandom(source);
        }
        static public string ReadTextRandomLine(this Stream item)
        {
            return item.ReadTextRandomLine(RandInt.SOURCE);
        }
    }
}