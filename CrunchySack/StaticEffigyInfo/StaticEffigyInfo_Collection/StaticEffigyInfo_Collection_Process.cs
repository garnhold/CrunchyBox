using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class StaticEffigyInfo_Collection_Process : StaticEffigyInfo_Collection
    {
        private Process<object, object> process;

        public StaticEffigyInfo_Collection_Process(Type r, Type c, Process<object, object> p) : base(r, c)
        {
            process = p;
        }

        public override void AddChild(object representation, object child)
        {
            process(representation, child);
        }
    }

    public class StaticEffigyInfo_Collection_Process<REPRESENTATION_TYPE, CHILD_TYPE> : StaticEffigyInfo_Single_Process
    {
        public StaticEffigyInfo_Collection_Process(Process<REPRESENTATION_TYPE, CHILD_TYPE> p)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                  (r, c) => p((REPRESENTATION_TYPE)r, c.ConvertEX<CHILD_TYPE>())
            ) { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddStaticChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap)
        {
            item.AddStaticChildrenInfo(n,
                new StaticEffigyInfo_Collection_Process<REPRESENTATION_TYPE, CHILD_TYPE>(ap)
            );
        }
        static public void AddStaticChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap)
        {
            item.AddStaticChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, ap);
        }
    }
}