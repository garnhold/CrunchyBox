using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class EphemeralDrawer
    {
        private GameObject prefab;

        private int current_index;
        private int previous_index;
        private List<GameObject> ephemerals;

        private GameObject CreateEphemeral()
        {
            return prefab.SpawnInstance();
        }

        public EphemeralDrawer(GameObject p)
        {
            prefab = p;

            ephemerals = new List<GameObject>();
        }

        public void StartFrame()
        {
            for (int i = current_index; i < previous_index; i++)
                ephemerals[i].IfNotNull(e => e.DeactivateGameObject());

            previous_index = current_index;
            current_index = 0;
        }

        public GameObject NextEphemeral()
        {
            GameObject ephemeral;

            if (current_index < ephemerals.Count)
            {
                ephemeral = ephemerals[current_index];

                if (ephemeral.IsNull())
                    ephemeral = ephemerals[current_index] = CreateEphemeral();
            }
            else
            {
                ephemeral = ephemerals.AddAndGet(CreateEphemeral());
            }

            ephemeral.ActivateGameObject();
            current_index++;

            return ephemeral;
        }
    }
}