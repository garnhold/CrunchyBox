using System;
using System.Reflection;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Salt;
    using Bun;
    using Sandwich;

    static public class AttachEditGadgetAttributeExtensions_Get
    {
        static public Type GetEditorSceneElementEditGadgetInstanceType(this AttachEditGadgetAttribute item)
        {
            return Types.GetFilteredTypes(
                Filterer_Type.IsConcreteClass(),
                Filterer_Type.CanBeTreatedAs<EditorSceneElement_EditGadgetInstance>(),
                Filterer_Type.IsNamed("EditorSceneElement_EditGadgetInstance_" + item.GetEditorSceneElementEditGadgetInstanceTypeName())
            ).GetFirst();
        }
    }
}