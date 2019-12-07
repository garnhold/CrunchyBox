using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
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
    }
}