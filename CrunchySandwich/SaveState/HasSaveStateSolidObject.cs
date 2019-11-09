using System;
using System.IO;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public interface HasSaveStateSolidObject
    {
        SaveStateSolidObject GetSolidObject();
    }
}