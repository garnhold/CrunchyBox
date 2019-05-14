using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class RepresentationInstancers
    {
        static public RepresentationInstancer Simple(string t, Operation<object> o)
        {
            return new RepresentationInstancer_Operation(t, o);
        }
        static public RepresentationInstancer Simple<REQUESTER_TYPE>(string t, Operation<object, REQUESTER_TYPE> o)
        {
            return new RepresentationInstancer_Operation<REQUESTER_TYPE>(t, o);
        }

        static public RepresentationInstancer Variation<REPRESENTATION_TYPE>(string t, string b, Process<REPRESENTATION_TYPE> p)
        {
            return new RepresentationInstancer_Variation_Process<REPRESENTATION_TYPE>(t, b, p);
        }
    }
}