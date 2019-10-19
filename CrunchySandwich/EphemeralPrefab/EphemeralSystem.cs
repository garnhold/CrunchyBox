using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class EphemeralSystem : Subsystem<EphemeralSystem>
    {
        private Dictionary<GameObject, EphemeralDrawer> drawers;

        static public GameObject Next(GameObject prefab)
        {
            return GetInstance().NextEphemeral(prefab);
        }
        static public T Next<T>(T prefab) where T : Component
        {
            return GetInstance().NextEphemeral<T>(prefab);
        }

        public EphemeralSystem()
        {
            drawers = new Dictionary<GameObject, EphemeralDrawer>();
        }

        public override void Update()
        {
            drawers.Values.Process(d => d.StartFrame());
        }

        public GameObject NextEphemeral(GameObject prefab)
        {
            return drawers.GetOrCreateValue(prefab, g => new EphemeralDrawer(g))
                .NextEphemeral();
        }
        public T NextEphemeral<T>(T prefab) where T : Component
        {
            return NextEphemeral(prefab.gameObject).GetComponent<T>();
        }
    }
}