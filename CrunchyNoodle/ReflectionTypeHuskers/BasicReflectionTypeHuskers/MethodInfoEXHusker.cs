using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public partial class MethodInfoEXHusker : Husker<MethodInfoEX>
    {
        private MethodInfoEX Resolve(Module module, int metadata_token)
        {
            return module.ResolveMethod(metadata_token)
                .Convert<MethodInfo>()
                .GetMethodInfoEX();
        }
    }
}