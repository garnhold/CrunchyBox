using System;

namespace Crunchy.Dough
{
    static public class ValueChangeResultExtensions_Compare
    {
        static public bool IsFailure(this ValueChangeResult item)
        {
            if (item == ValueChangeResult.Failure)
                return true;

            return false;
        }

        static public bool IsSuccess(this ValueChangeResult item)
        {
            if (item.IsFailure() == false)
                return true;

            return false;
        }

        static public bool IsChange(this ValueChangeResult item)
        {
            if (item == ValueChangeResult.SuccessChanged)
                return true;

            return false;
        }
    }
}