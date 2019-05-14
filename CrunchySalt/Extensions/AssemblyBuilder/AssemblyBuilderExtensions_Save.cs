using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class AssemblyBuilderExtensions_Save
    {
        static public void Save(this AssemblyBuilder item)
        {
            item.Save(item.GetDefaultFilename());
        }
    }
}