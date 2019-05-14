using System;

namespace CrunchyDough
{
    static public class BoolExtensions_Assert
    {
        static public void Assert(this bool item, Operation<Exception> o)
        {
            if (item != true)
                throw o();
        }

        static public void ThrowIfTrue(this bool item, Operation<Exception> o)
        {
            if (item == true)
                throw o();
        }
    }
}