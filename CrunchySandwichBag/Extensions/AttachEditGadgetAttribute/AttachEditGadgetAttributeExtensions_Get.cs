using System;
using System.Reflection;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class AttachEditGadgetAttributeExtensions_Get
    {
        static public Type GetEditorSceneElementEditGadgetInstanceType(this AttachEditGadgetAttribute item)
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.IsConcreteClass(),
                Filterer_Type.CanBeTreatedAs<EditorSceneElement_EditGadgetInstance>(),
                Filterer_Type.IsNamed("EditorSceneElement_EditGadgetInstance_" + item.GetEditorSceneElementEditGadgetInstanceTypeName())
            ).GetFirst();
        }
    }
}