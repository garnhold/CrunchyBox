using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [ExecuteInEditMode]
    public abstract class InitBehaviour : MonoBehaviour
    {
        protected abstract void InitilizeInternal();
        protected virtual void UpdateInternal() { }

        private void Start()
        {
            InitilizeInternal();
        }

        private void Update()
        {
            if (Application.isPlaying == false)
                InitilizeInternal();
            else
                UpdateInternal();
        }
    }
}