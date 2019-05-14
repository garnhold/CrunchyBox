using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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