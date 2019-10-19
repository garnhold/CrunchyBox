using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MountPoint<T> where T : Component
    {
        [SerializeField]private GameObject mount_point;

        private T mounted;

        public void Mount(T to_mount)
        {
            mounted = mount_point.SetChild(to_mount);
        }

        public void Unmount()
        {
            Mount(null);
        }

        public T GetMounted()
        {
            return mounted;
        }
    }
}