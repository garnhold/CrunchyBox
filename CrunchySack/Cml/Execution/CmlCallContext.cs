
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlCallContext
	{
        private CmlEntry_Class @class;

        private CmlSetSpace set_space;
        private CmlReturnSpace return_space;
        private CmlParameterSpace parameter_space;
        private CmlRepresentationSpace representation_space;

        public CmlCallContext(CmlEntry_Class c, CmlSetSpace ss, CmlReturnSpace ret, CmlParameterSpace p, CmlRepresentationSpace rep)
        {
            @class = c;

            set_space = ss;
            return_space = ret;
            parameter_space = p;
            representation_space = rep;
        }

        public CmlEntry_Class GetClass()
        {
            return @class;
        }

        public CmlSetSpace GetSetSpace()
        {
            return set_space;
        }

        public CmlReturnSpace GetReturnSpace()
        {
            return return_space;
        }

        public CmlParameterSpace GetParameterSpace()
        {
            return parameter_space;
        }

        public CmlRepresentationSpace GetRepresentationSpace()
        {
            return representation_space;
        }
	}
	
}
