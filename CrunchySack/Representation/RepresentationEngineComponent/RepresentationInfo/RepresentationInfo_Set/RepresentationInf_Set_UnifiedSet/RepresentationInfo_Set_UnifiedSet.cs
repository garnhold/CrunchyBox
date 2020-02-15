using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public class RepresentationInfo_Set_UnifiedSet<REPRESENTATION_TYPE> : RepresentationInfo_Set
    {
        private Process<REPRESENTATION_TYPE, CmlSet> process;

        public RepresentationInfo_Set_UnifiedSet(Delegate s) : base(typeof(REPRESENTATION_TYPE))
        {
            process = GetType().CreateDynamicMethodDelegate<Process<REPRESENTATION_TYPE, CmlSet>>(delegate (ILValue representation, ILValue set) {
                return s.Method.GetStaticILMethodInvokation(
                    s.Method.GetTechnicalParameters()
                        .Convert(p => {
                            if (p.Name == "representation")
                                return representation;

                            RegisterAttributeInfo(p.Name);
                            return set.GetILInvoke("GetAttribute", p.Name);
                        })
                );
            });
        }

        public override void SolidifyInstance(CmlExecution execution, object representation, CmlSet set)
        {
            process((REPRESENTATION_TYPE)representation, set);
        }
    }
}