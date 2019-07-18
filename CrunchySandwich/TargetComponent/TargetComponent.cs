using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class TargetComponent
    {
        [SerializeField]private GameObject game_object;

        private Type component_type;
        [SerializeField]private string component_type_name;

        public TargetComponent(GameObject g, Type c)
        {
            game_object = g;

            component_type = c;
            component_type_name = component_type.IfNotNull(z => z.Name);
        }

        public TargetComponent() : this(null, null) { }

        public Component GetComponent()
        {
            return game_object.IfNotNull(g => g.GetComponent(GetComponentType()));
        }

        public Type GetComponentType()
        {
            if (component_type == null || component_type.Name != component_type_name)
            {
                component_type = CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.IsNamed(component_type_name)
                ).GetFirst();
            }

            return component_type;
        }

        public GameObject GetGameObject()
        {
            return game_object;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + game_object.GetHashCodeEX();
                hash = hash * 23 + component_type_name.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TargetComponent cast;

            if (obj.Convert<TargetComponent>(out cast))
            {
                if (cast.game_object == game_object)
                {
                    if(cast.component_type_name == component_type_name)
                        return true;
                }
            }

            return false;
        }
    }
}