using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public class TargetComponent
    {
        [SerializeField]private GameObject game_object;
        [SerializeFieldEX]private Type component_type;

        public Component GetComponent()
        {
            return game_object.IfNotNull(g => g.GetComponent(GetComponentType()));
        }

        public Type GetComponentType()
        {
            return component_type;
        }

        public GameObject GetGameObject()
        {
            return game_object;
        }
    }
}