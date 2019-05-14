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
    public class EditorGUIElement_Complex_SerializedProperty_CustomAsset : EditorGUIElement_Complex_SerializedProperty<Tuple<CustomAsset, AssetType>>
    {
        static private IEnumerable<Type> GetInternalCustomAssetTypes(Type field_type)
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs(field_type),
                Filterer_Type.CanBeTreatedAs<CustomAsset>(),
                Filterer_Type.IsConcreteClass()
            );
        }

        protected override Tuple<CustomAsset, AssetType> PullState()
        {
            SerializedProperty serialized_property = GetSerializedProperty();

            return Tuple.New(
                serialized_property.objectReferenceValue as CustomAsset,
                serialized_property.objectReferenceValue.GetAssetType()
            );
        }

        protected override EditorGUIElement PushState()
        {
            SerializedProperty serialized_property = GetSerializedProperty();

            Type variable_type = serialized_property.GetVariableType();
            CustomAsset asset = serialized_property.objectReferenceValue as CustomAsset;

            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();
            EditorGUIElement_Container_HorizontalStrip type_container = container.AddChild(new EditorGUIElement_Container_HorizontalStrip());

            switch (asset.GetAssetType())
            {
                case AssetType.None:
                case AssetType.External:
                    type_container.AddChild(1.0f,
                        new EditorGUIElement_Single_SerializedProperty_ObjectField(serialized_property)
                    );
                    break;

                case AssetType.Internal:
                    type_container.AddChild(1.0f,
                        new EditorGUIElement_Popup_SerializedProperty_ProcessOperation<Type>(
                            serialized_property,
                            GetInternalCustomAssetTypes(variable_type),
                            (p, t) => p.objectReferenceValue = CustomAssets.CreateInternalCustomAsset(t),
                            p => p.objectReferenceValue.IfNotNull(o => o.GetType())
                        )
                    );
                    break;
            }

            type_container.AddChild(new EditorGUIElementLength_Fixed(64.0f), new EditorGUIElement_Single_Process(delegate(Rect rect) {
                AssetType new_type = EditorGUIExtensions.EnumPopup(rect, asset.GetAssetType());

                if (asset.GetAssetType() != new_type)
                {
                    switch (new_type)
                    {
                        case AssetType.None:
                            serialized_property.objectReferenceValue = null;
                            break;

                        case AssetType.External:
                            serialized_property.objectReferenceValue = CustomAssets.GetExternalCustomAssetsOfType(variable_type).GetFirst();
                            break;

                        case AssetType.Internal:
                            serialized_property.objectReferenceValue = CustomAssets.CreateInternalCustomAsset(GetInternalCustomAssetTypes(variable_type).GetFirst());
                            break;
                    }
                }
            }));

            if (asset != null && asset.IsInternalAsset())
            {
                SerializedObject internal_serialized_object = new SerializedObject(asset);

                container.AddChild(new EditorGUIElement_Foldout_SerializedProperty_VerticalStrip(internal_serialized_object.FindProperty("is_show_inline"), "Properties")).GetContainer()
                    .AddChild(new EditorGUIElement_Complex_SerializedObject(internal_serialized_object));

                container.AddAttachment(new EditorGUIElementAttachment_SerializedObjectSection(internal_serialized_object));
            }

            return container;
        }

        public EditorGUIElement_Complex_SerializedProperty_CustomAsset(SerializedProperty s) : base(s)
        {
        }
    }
}