using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class Subsystem : ScriptableObject
    {
        public virtual void Update() { }
        public virtual void UpdateInEditor() { }

        static public Subsystem GetInstance(Type type)
        {
            return SubsystemManager.GetInstance().GetSubsystemInstance(type);
        }
        static public T GetInstance<T>() where T : Subsystem
        {
            return SubsystemManager.GetInstance().GetSubsystemInstance<T>();
        }
    }
}