using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class ClassLibraryExtensions_AddText
    {
        static public void AddClass(this ClassLibrary item, Type type, string layout, string text)
        {
            item.AddClass(
                new CmlClass_ClassDefinition(
                    type,
                    layout,
                    CmlClassDefinition.DOMify(text)
                )
            );
        }
    }
}