﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorSceneElementAttachment
    {
        public virtual bool PrepareElementForAttachment(EditorSceneElement element) { return true; }

        public virtual void PreDrawInternal() { }
        public virtual void DrawInternal() { }
        public virtual void PostDrawInternal() { }

        public virtual void UnwindInternal() { }
    }
}