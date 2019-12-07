using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationModifiers
    {
        static public RepresentationModifier General<REPRESENTATION_TYPE>(Process<REPRESENTATION_TYPE> p)
        {
            return new RepresentationModifier_General_Process<REPRESENTATION_TYPE>(p);
        }

        static public RepresentationModifier General<REPRESENTATION_TYPE>(Process<CmlExecution, REPRESENTATION_TYPE> p)
        {
            return new RepresentationModifier_General_Process<REPRESENTATION_TYPE>(p);
        }
    }
}