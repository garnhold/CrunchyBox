using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectTableExtensions_Process
    {
        static public void ProcessValues<OBJECT_TYPE, VALUE_TYPE>(this ObjectTable<OBJECT_TYPE, VALUE_TYPE> item, Process<VALUE_TYPE> process) where OBJECT_TYPE : class
        {
            item.Process(p => process(p.Value));
        }
    }
}