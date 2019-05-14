using System;
using System.Resources;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class Global_Indirect_ResourceManager : Global_Indirect
    {
        private ResourceManager resource_manager;

        public Global_Indirect_ResourceManager(string n, ResourceManager r) : base(n)
        {
            resource_manager = r;
        }

        public override CmlScriptValue GetIndirectValue(string id, CmlScriptValue_Argument_Host host)
        {
            return resource_manager.GetObjectEX(id)
                .IfNotNull(o => host.AddArgument(new CmlScriptValue_Argument_Single_Constant(o)));
        }
    }
}