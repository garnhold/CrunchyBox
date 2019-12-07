using System;

namespace Crunchy.Dough
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