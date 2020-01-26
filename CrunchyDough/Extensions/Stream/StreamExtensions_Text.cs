using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_Text
    {
        static public void WriteText(this Stream item, string text)
        {
            StreamWriter writer = new StreamWriter(item);

            writer.Write(text);
            writer.Flush();
        }

        static public string ReadText(this Stream item)
        {
            StreamReader reader = new StreamReader(item);

            return reader.ReadToEnd();
        }

        static public void WriteTextLines(this Stream item, IEnumerable<string> lines)
        {
            StreamWriter writer = new StreamWriter(item);

            writer.WriteLines(lines);
            writer.Flush();
        }

        static public IEnumerable<string> ReadTextLines(this Stream item)
        {
            return new StreamReader(item).ReadLines();
        }

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