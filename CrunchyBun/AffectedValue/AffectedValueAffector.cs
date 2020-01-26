using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public class AffectedValueAffector<T>
    {
        private T value;
        private int precedence;

        private bool is_enabled;

        private AffectedValue<T> parent;

        public AffectedValueAffector(T v, int p)
        {
            value = v;
            precedence = p;

            is_enabled = false;
        }

        public void Initialize(AffectedValue<T> p)
        {
            parent = p;
        }

        public void SetIsEnabled(bool e)
        {
            is_enabled = e;
            parent.IfNotNull(p => p.WakeUp());
        }

        public void Enable()
        {
            SetIsEnabled(true);
        }

        public void Disable()
        {
            SetIsEnabled(false);
        }

        public bool IsEnabled()
        {
            return is_enabled;
        }

        public T GetValue()
        {
            return value;
        }

        public int GetPrecedence()
        {
            return precedence;
        }
    }
}