using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorSceneElement_Complex : EditorSceneElement
    {
        private EditorSceneElement element;

        protected abstract bool NeedRecreation();
        protected abstract EditorSceneElement Recreate();

        protected override void InitilizeInternal()
        {
            if (NeedRecreation())
            {
                element = Recreate();
                if(element != null)
                    element.SetParent(this);
            }

            if (element != null)
                element.Initilize();
        }

        protected override bool HandleAttachment(ref EditorSceneElementAttachment attachment)
        {
            if (element != null)
                element.AddAttachment(attachment);

            return false;
        }

        protected override void DrawInternal()
        {
            if (element != null)
                element.Draw();

            if (NeedRecreation())
                Initilize();
        }
    }

    public abstract class EditorSceneElement_Complex<T> : EditorSceneElement_Complex
    {
        private T current_state;
        private bool force_recreation;

        protected abstract T PullState();
        protected abstract EditorSceneElement PushState();

        protected override bool NeedRecreation()
        {
            if (force_recreation || current_state.NotEqualsEX(PullState()))
                return true;

            return false;
        }

        protected override EditorSceneElement Recreate()
        {
            current_state = PullState();
            force_recreation = false;

            return PushState();
        }

        public EditorSceneElement_Complex()
        {
            force_recreation = true;
        }

        public void ForceRecreation()
        {
            force_recreation = true;
        }
    }
}