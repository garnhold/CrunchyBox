using System;

namespace Crunchy.Dough
{
    static public class CompareResultExtensions
    {
        static public CompareResult CreateFromInt(int result)
        {
            if (result < 0)
                return CompareResult.LessThan;

            if (result > 0)
                return CompareResult.GreaterThan;

            return CompareResult.EqualTo;
        }
    }
}