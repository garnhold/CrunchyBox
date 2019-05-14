using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyKitchen
{
    public abstract class ProjectItemCreator<ITEM_TYPE>
    {
        public abstract ITEM_TYPE Create(string name);
    }
}