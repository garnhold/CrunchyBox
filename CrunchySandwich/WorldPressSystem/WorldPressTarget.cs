using System;

using UnityEngine;

namespace CrunchySandwich
{
    public interface IWorldPressTarget
    {
        void Touch(WorldPress world_press);
        void Untouch(WorldPress world_press);

        void Tap(WorldPress world_press, TapType type);

        void Grab(WorldPress world_press);
        void Drag(WorldPress world_press);
        void Drop(WorldPress world_press);

        GameObject gameObject { get; }
    }

    public class WorldPressTarget : MonoBehaviour, IWorldPressTarget
    {
        public virtual void Touch(WorldPress world_press) { }
        public virtual void Untouch(WorldPress world_press) { }

        public virtual void Tap(WorldPress world_press, TapType type) { }

        public virtual void Grab(WorldPress world_press) { }
        public virtual void Drag(WorldPress world_press) { }
        public virtual void Drop(WorldPress world_press) { }
    }
}