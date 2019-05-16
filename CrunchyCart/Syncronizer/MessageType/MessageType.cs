using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public enum MessageType
        {
            RequestConstant,
            UpdateConstant,
            FullUpdateConstant,

            InvokeEntityMethod,
            ChangeEntityAuthority,
            UpdateEntity,
            DestroyEntity,

            InvokeSystemMethod
        }
    }
}