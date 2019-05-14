using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public partial class TypeHusker : Husker<Type>
    {
        private Type Resolve(Module module, int metadata_token)
        {
            return module.ResolveType(metadata_token);
        }
    }
}