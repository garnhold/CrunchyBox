using System;
using System.IO;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Recipe;
    
    public interface HasSaveStateSolidObject
    {
        SaveStateSolidObject GetSolidObject();
    }
}