using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldInfoExtensions_Prop
    {
        static public PropInfoEX GetProp(this FieldInfo item)
        {
            return new PropInfoEX_Field(item.GetFieldInfoEX());
        }
    }
}