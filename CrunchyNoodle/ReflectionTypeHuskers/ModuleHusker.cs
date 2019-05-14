using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class ModuleHusker : Husker<Module>
    {
        static public readonly ModuleHusker INSTANCE = new ModuleHusker();

        private ModuleHusker() { }

        public override void Dehydrate(HuskWriter writer, Module to_dehydrate)
        {
            if (to_dehydrate != null)
            {
                writer.WriteString(to_dehydrate.ScopeName);
                writer.WriteRecurrant(to_dehydrate.Assembly, AssemblyHusker.INSTANCE);
            }
            else
            {
                writer.WriteString("");
            }
        }

        public override Module Hydrate(HuskReader reader)
        {
            string module_name = reader.ReadString();

            if(module_name != "")
                return reader.ReadRecurrant(AssemblyHusker.INSTANCE).GetModule(module_name);

            return null;
        }
    }
}