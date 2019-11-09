using System;
using System.IO;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    static public class HasSaveStateSolidObjectExtensions_SaveLoad
    {
        static public void Save(this HasSaveStateSolidObject item)
        {
            item.GetSolidObject().Save();
        }

        static public void ForceSave(this HasSaveStateSolidObject item)
        {
            item.GetSolidObject().ForceSave();
        }

        static public void Load(this HasSaveStateSolidObject item)
        {
            item.GetSolidObject().Load();
        }
    }
}