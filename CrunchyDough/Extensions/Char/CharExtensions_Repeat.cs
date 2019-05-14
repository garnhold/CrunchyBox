using System;

namespace CrunchyDough
{
    static public class CharExtensions_Repeat
    {
        static public string Repeat(this char item, int times)
        {
            if(times > 0)
                return new string(item, times);

            return "";
        }
    }
}