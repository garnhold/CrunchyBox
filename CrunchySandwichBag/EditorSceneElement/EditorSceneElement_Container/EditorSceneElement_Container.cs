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
    public abstract class EditorSceneElement_Container : EditorSceneElement
    {
        public abstract void ClearChildren();
        public abstract bool RemoveChild(EditorSceneElement child);

        public abstract IEnumerable<EditorSceneElement> GetChildren();

        protected override void InitilizeInternal()
        {
            GetChildren().Process(c => c.Initilize());
        }

        protected override void DrawInternal()
        {
            GetChildren().Process(c => c.Draw());
        }
    }
}