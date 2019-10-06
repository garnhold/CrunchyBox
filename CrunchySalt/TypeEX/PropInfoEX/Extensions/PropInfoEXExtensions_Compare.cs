using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class PropInfoEXExtensions_Compare
    {
        static public bool CanSetAndGet(this PropInfoEX item)
        {
            if (item.CanSet() && item.CanGet())
                return true;

            return false;
        }

        static public bool IsSetAndGetPublic(this PropInfoEX item)
        {
            if (item.IsSetPublic() && item.IsGetPublic())
                return true;

            return false;
        }

        static public bool IsFieldBacked(this PropInfoEX item)
        {
            if (item.GetPropInfoType() == PropInfoEXType.Field)
                return true;

            return false;
        }

        static public bool IsPropertyMethodsBacked(this PropInfoEX item)
        {
            if (item.GetPropInfoType() == PropInfoEXType.PropertyMethods)
                return true;

            return false;
        }

        static public bool IsUnassociatedMethodsBacked(this PropInfoEX item)
        {
            if (item.GetPropInfoType() == PropInfoEXType.UnassociatedMethods)
                return true;

            return false;
        }
    }
}