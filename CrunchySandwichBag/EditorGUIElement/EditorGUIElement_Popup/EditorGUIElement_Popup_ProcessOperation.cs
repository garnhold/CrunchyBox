using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Popup_ProcessOperation<T> : EditorGUIElement_Popup<T>
    {
        private Process<T> set_process;
        private TryOperation<T> get_process;

        public EditorGUIElement_Popup_ProcessOperation(IEnumerable<T> es, Operation<string, T> op, Process<T> sp, TryOperation<T> go, float h) : base(es, op, h)
        {
            set_process = sp;
            get_process = go;
        }

        public EditorGUIElement_Popup_ProcessOperation(IEnumerable<T> es, Operation<string, T> op, Process<T> sp, TryOperation<T> go) : this(es, op, sp, go, DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_ProcessOperation(IEnumerable<T> es, Process<T> sp, TryOperation<T> go) : this(es, e => e.ToStringEX(), sp, go) { }

        public override void SetSelectedElement(T element)
        {
            set_process(element);
        }

        public override bool TryGetSelectedElement(out T element)
        {
            return get_process(out element);
        }
    }
}