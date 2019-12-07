using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class SaveStateSolidObject : TyonSolidObject
    {
        public SaveStateSolidObject(object t, Type type, string id = "Singleton") : base(
            t,
            Files.GetStreamSystem().GetStreamSource(Filename.MakeDataFilename("SaveState", type.GetCleanName() + "_" + id)),
            SaveStateTyonSettings.INSTANCE,
            TyonHydrationMode.Permissive
        ) { }
    }
}