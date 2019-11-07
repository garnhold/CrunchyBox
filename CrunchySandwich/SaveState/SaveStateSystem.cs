using System;
using System.IO;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    [SaveStateExplicitType]
    public abstract class SaveStateSystem<T> : Subsystem<T> where T : SaveStateSystem<T>
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