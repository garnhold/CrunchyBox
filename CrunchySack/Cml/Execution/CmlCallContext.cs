
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlCallContext
	{
        private CmlEntry_Class @class;

        private CmlReturnSpace return_space;
        private CmlParameterSpace parameter_space;
        private CmlRepresentationSpace representation_space;

        public CmlCallContext(CmlEntry_Class c, CmlReturnSpace ret, CmlParameterSpace p, CmlRepresentationSpace rep)
        {
            @class = c;

            return_space = ret;
            parameter_space = p;
            representation_space = rep;
        }

        public CmlEntry_Class GetClass()
        {
            return @class;
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
