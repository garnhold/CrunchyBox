using System;

namespace CrunchyDough
{
    static public class BoolExtensions_Flip
    {
        static public bool GetFlipped(this bool item)
        {
            if (item == false)
                return true;

            return false;
        }
    }
}