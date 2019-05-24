using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public enum LocalAuthorityState
    {
        None,

        RetainedAuthority,
        MaintainedNoAuthority,

        GainedAuthority,
        LosedAuthority
    }
}