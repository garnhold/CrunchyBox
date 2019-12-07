using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorSceneElementAttachment
    {
        public virtual bool PrepareElementForAttachment(EditorSceneElement element) { return true; }

        public virtual void PreDrawInternal() { }
        public virtual void DrawInternal() { }
        public virtual void PostDrawInternal() { }

        public virtual void UnwindInternal() { }
    }
}