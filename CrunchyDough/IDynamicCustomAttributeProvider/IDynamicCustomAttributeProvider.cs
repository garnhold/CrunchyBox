using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public interface IDynamicCustomAttributeProvider
    {
        IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);
    }
}