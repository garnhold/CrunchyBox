using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class AssemblyHusker : Husker<Assembly>
    {
        static public readonly AssemblyHusker INSTANCE = new AssemblyHusker();

        private AssemblyHusker() { }

        public override void Dehydrate(HuskWriter writer, Assembly to_dehydrate)
        {
            if (to_dehydrate != null)
                writer.WriteString(to_dehydrate.FullName);
            else
                writer.WriteString("");
        }

        public override Assembly Hydrate(HuskReader reader)
        {
            string full_name = reader.ReadString();

            if (full_name != "")
                return Assembly.Load(full_name);

            return null;
        }
    }
}