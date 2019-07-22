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
    [EditorGUIElementForType(typeof(CustomAsset), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_CustomAsset : EditorGUIElement_Complex_EditPropertySingleValue<CustomAsset>
    {
        static private IEnumerable<Type> GetInternalCustomAssetTypes(Type field_type)
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs(field_type),
                Filterer_Type.CanBeTreatedAs<CustomAsset>(),
                Filterer_Type.IsConcreteClass()
            );
        }

        protected override CustomAsset PullState()
        {
            CustomAsset value;

            GetProperty().TryGetContentValues<CustomAsset>(out value);
            return value;
        }

        protected override EditorGUIElement PushState()
        {
            CustomAsset asset;
            EditProperty_Single_Value property = GetProperty();

            Type field_type = property.GetPropertyType();

            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();
            EditorGUIElement_Container_HorizontalStrip type_container = container.AddChild(new EditorGUIElement_Container_HorizontalStrip());

            if (property.TryGetContentValues<CustomAsset>(out asset))
            {
                switch (asset.GetAssetType())
                {
                    case AssetType.None:
                    case AssetType.External:
                        type_container.AddChild(1.0f,
                            new EditorGUIElement_EditPropertySingleValuePopup_Asset(property, false)
                        );
                        break;

                    case AssetType.Internal:
                        type_container.AddChild(1.0f,
                            new EditorGUIElement_Popup_ProcessOperation<Type>(
                                GetInternalCustomAssetTypes(field_type),
                                t => property.SetContentValues(CustomAssets.CreateInternalCustomAsset(t)),
                                (out Type t) => property.TryGetContentsType(out t)
                            )
                        );
                        break;
                }

                type_container.AddChild(new EditorGUIElementLength_Fixed(64.0f), new EditorGUIElement_Process(delegate(Rect rect) {
                    AssetType new_type = EditorGUIExtensions.EnumPopup(rect, asset.GetAssetType());

                    if (asset.GetAssetType() != new_type)
                    {
                        switch (new_type)
                        {
                            case AssetType.None:
                                property.SetContentValues(null);
                                break;

                            case AssetType.External:
                                property.SetContentValues(
                                    CustomAssets.GetExternalCustomAssetsOfType(field_type)
                                        .GetFirst()
                                );
                                break;

                            case AssetType.Internal:
                                property.SetContentValues(
                                    CustomAssets.CreateInternalCustomAsset(
                                        GetInternalCustomAssetTypes(field_type)
                                           .GetFirst()
                                    )
                                );
                                break;
                        }
                    }
                }));

                if (asset != null && asset.IsInternalAsset())
                    container.AddChild(new EditorGUIElement_Complex_All(asset));
            }

            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_CustomAsset(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}