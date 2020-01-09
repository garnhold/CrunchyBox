using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
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