using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class Subsystem : ScriptableObject
    {
        public virtual void Update() { }
        public virtual void UpdateInEditor() { }
    }

    public abstract class Subsystem<T> : Subsystem where T : Subsystem<T>
    {
        static private T INSTANCE;
        static public T GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = SubsystemManager.GetInstance().GetSubsystemInstance<T>();

            return INSTANCE;
        }
    }
}