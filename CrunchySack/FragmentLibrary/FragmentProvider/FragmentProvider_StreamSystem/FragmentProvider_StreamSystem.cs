using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class FragmentProvider_StreamSystem  : FragmentProvider
    {
        private StreamSystem stream_system;

        protected abstract string CalculateId(string name);

        public FragmentProvider_StreamSystem(StreamSystem s)
        {
            stream_system = s;
        }

        public override CmlEntry_Fragment GetFragment(string name)
        {
            return stream_system.ReadCmlFragmentDefinition(CalculateId(name))
                .IfNotNull(c => new CmlEntry_Fragment_FragmentDefinition(name, c));
        }
    }
}