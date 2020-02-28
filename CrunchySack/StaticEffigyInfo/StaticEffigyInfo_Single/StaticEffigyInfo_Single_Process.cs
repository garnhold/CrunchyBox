using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class StaticEffigyInfo_Single_Process : StaticEffigyInfo_Single
    {
        private Process<object, object> process;

        public StaticEffigyInfo_Single_Process(Type r, Type c, Process<object, object> p) : base(r, c)
        {
            process = p;
        }

        public override void SetChild(object representation, object child)
        {
            process(representation, child);
        }
    }

    public class StaticEffigyInfo_Single_Process<REPRESENTATION_TYPE, CHILD_TYPE> : StaticEffigyInfo_Single_Process
    {
        public StaticEffigyInfo_Single_Process(Process<REPRESENTATION_TYPE, CHILD_TYPE> p)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                  (r, c) => p((REPRESENTATION_TYPE)r, c.ConvertEX<CHILD_TYPE>())
            ) { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddSingleStaticChildInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, CHILD_TYPE> s)
        {
            item.AddStaticChildrenInfo(n,
                new StaticEffigyInfo_Single_Process<REPRESENTATION_TYPE, CHILD_TYPE>(s)
            );
        }
        static public void AddSingleStaticChildInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, CHILD_TYPE> s)
        {
            item.AddSingleStaticChildInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, s);
        }
    }
}