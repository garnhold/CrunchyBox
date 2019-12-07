using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    using Bun;
    
    static public partial class ContactFilter2DExtensions
    {
        static public readonly ContactFilter2D NONE = new ContactFilter2D().NoFilter();
    }
}