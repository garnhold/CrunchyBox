using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public partial class FieldInfoEXHusker : Husker<FieldInfoEX>
    {
        private FieldInfoEX Resolve(Module module, int metadata_token)
        {
            return module.ResolveField(metadata_token)
                .GetFieldInfoEX();
        }
    }
}