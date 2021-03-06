using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    static public class CmlContextExtensions_Add
	{
        static public void AddVariableLink(this CmlContext item, string group, VariableLink variable_link)
        {
            item.GetLinkManager().AddVariableLink(group, variable_link);
        }

        static public void AddEffigyLink(this CmlContext item, string group, EffigyLink effigy_link)
        {
            item.GetLinkManager().AddEffigyLink(group, effigy_link);
        }

        static public void AddFunctionSyncro(this CmlContext item, FunctionSyncro function_syncro)
        {
            function_syncro.SetManager(item.GetSyncroManager());
        }

        static public void AddDeferredProcess(this CmlContext item, Process process)
        {
            item.GetDeferredProcessList().Defer(process);
        }
	}
	
}
