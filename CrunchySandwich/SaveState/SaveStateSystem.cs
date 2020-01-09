using System;
using System.IO;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Recipe;
    
    [SaveStateExplicitType]
    public abstract class SaveStateSystem<T> : Subsystem<T>, HasSaveStateSolidObject where T : SaveStateSystem<T>
    {
        private SaveStateSolidObject solid_object;

        public override void Start()
        {
            solid_object = new SaveStateSolidObject(this, GetType());
            solid_object.Load();
        }

        public SaveStateSolidObject GetSolidObject()
        {
            return solid_object;
        }
    }
}