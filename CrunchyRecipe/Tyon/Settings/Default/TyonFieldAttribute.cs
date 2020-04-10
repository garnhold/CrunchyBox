using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;

    [AttributeUsage(AttributeTargets.Field)]
    public class TyonFieldAttribute : Attribute
    {
    }
}
