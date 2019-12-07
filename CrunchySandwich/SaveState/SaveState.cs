using System;
using System.IO;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Recipe;
    
    public abstract class SaveState : HasSaveStateSolidObject
    {
        private SaveStateSolidObject solid_object;

        public SaveState(string id)
        {
            solid_object = new SaveStateSolidObject(this, GetType(), id);
        }

        public SaveStateSolidObject GetSolidObject()
        {
            return solid_object;
        }
    }
}