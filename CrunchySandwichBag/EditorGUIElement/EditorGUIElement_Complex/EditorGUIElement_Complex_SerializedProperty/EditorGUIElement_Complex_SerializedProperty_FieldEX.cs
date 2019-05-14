using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Complex_SerializedProperty_FieldEX : EditorGUIElement_Complex_SerializedProperty<Tuple<SerializedPropertyType, bool, Type>>
    {
        protected override Tuple<SerializedPropertyType, bool, Type> PullState()
        {
            SerializedProperty serialized_property = GetSerializedProperty();

            return Tuple.New(
                serialized_property.propertyType,
                serialized_property.isArray,
                serialized_property.GetVariableType()
            );
        }

        protected override EditorGUIElement PushState()
        {
            SerializedProperty serialized_property = GetSerializedProperty();

            if (serialized_property.propertyType == SerializedPropertyType.Generic || serialized_property.propertyType == SerializedPropertyType.ObjectReference)
            {
                if (serialized_property.isArray)
                    return new EditorGUIElement_Complex_SerializedProperty_List(serialized_property);
                else
                {
                    Type variable_type = serialized_property.GetVariableType();

                    if (variable_type != null)
                    {
                        PropertyDrawer property_drawer = CustomPropertyDrawers.GetPropertyDrawer(variable_type);

                        if (property_drawer != null)
                            return property_drawer.CreateEditorGUIElement(serialized_property);

                        if (variable_type.CanBeTreatedAs<UnityEngine.Object>() == false)
                            return new EditorGUIElement_Complex_SerializedProperty_Generic(serialized_property);
                    }
                }
            }
            
            return new EditorGUIElement_SerializedProperty_Field(serialized_property);
        }

        public EditorGUIElement_Complex_SerializedProperty_FieldEX(SerializedProperty s) : base(s)
        {
        }
    }
}