using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    public class EditTarget
    {
        private Type target_type;
        private List<object> objects;

        private EditTarget parent;

        private void Touch(Process process)
        {
            if (target_type.CanBeTreatedAs<UnityEngine.Object>())
            {
                process();

                objects
                    .Convert<ISerializationCallbackReceiver>()
                    .Process(r => r.OnBeforeSerialize());

                objects
                    .Convert<ISerializationCallbackReceiver>()
                    .Process(r => r.OnAfterDeserialize());

                objects
                    .Convert<UnityEngine.Object>()
                    .Narrow(o => o.IsPrefabInstance())
                    .Process(o => PrefabUtility.RecordPrefabInstancePropertyModifications(o));

                objects
                    .Convert<UnityEngine.Object>()
                    .Skip(o => o.IsSceneObject())
                    .Process(o => EditorUtility.SetDirty(o));
            }
            else
            {
                if (parent != null)
                    parent.Touch(process);
                else
                    process();
            }
        }

        public EditTarget(IEnumerable<object> o, EditTarget p)
        {
            objects = o.ToList();
            target_type = objects.Convert(z => z.GetTypeEX()).GetCommonAncestor();

            parent = p;
        }

        public EditTarget(IEnumerable<object> o) : this(o, null) { }
        public EditTarget(params object[] o) : this((IEnumerable<object>)o) { }

        public EditTarget(SerializedObject o) : this(o.targetObjects) { }

        public void Touch()
        {
            Touch(() => { });
        }
        public void TouchWithUndo(string label, Process process)
        {
            Touch(delegate () {
                objects
                    .Convert<UnityEngine.Object>()
                    .Process(o => Undo.RecordObject(o, label));

                process();
            });
        }
        public void Touch(string label, bool create_undo_state, Operation<bool> process)
        {
            if (create_undo_state)
                TouchWithUndo(label, () => process());
            else
            {
                if (process())
                    Touch();
            }
        }

        public Type GetTargetType()
        {
            return target_type;
        }

        public IEnumerable<object> GetObjects()
        {
            return objects;
        }

        public bool IsValid()
        {
            if (objects.IsNotEmpty() && target_type != null)
                return true;

            return false;
        }

        public bool IsSerializationCorrupt()
        {
            if (objects.Convert<SerializationCorruptable>().Has(c => c.IsSerializationCorrupt()))
                return true;

            return false;
        }

        public EditFunction ForceFunction(string path, IEnumerable<Type> parameter_types)
        {
            return EditFunction.New(
                this,
                target_type.GetFunctionByPath(path, parameter_types)
                    .AssertNotNull(() => new MissingMethodException("No function exists for type " + GetTargetType() + " and path " + path))
            );
        }

        public EditAction ForceAction(string path)
        {
            return EditAction.New(
                this,
                target_type.GetActionByPath(path)
                    .AssertNotNull(() => new MissingMethodException("No action exists for type " + GetTargetType() + " and path " + path))
            );
        }

        public EditDisplay ForceDisplay(string path)
        {
            return EditDisplay.New(
                this,
                target_type.GetVariableByPath(path)
                    .AssertNotNull(() => new MissingMethodException("No method exists for type " + GetTargetType() + " and path " + path))
            );
        }

        public EditProperty ForceProperty(string path)
        {
            return EditProperty.New(
                this,
                target_type.GetVariableByPath(path)
                    .AssertNotNull(() => new MissingFieldException("No property exists for type " + GetTargetType() + " and path " + path))
            );
        }

        public IEnumerable<EditFunction> GetFunctions()
        {
            return target_type.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasCustomAttributeOfType<InspectorFunctionAttribute>()
            ).Convert(m => m.CreateFunction())
            .Convert(f => EditFunction.New(this, f));
        }

        public IEnumerable<EditAction> GetActions()
        {
            return target_type.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ContextMenu>() | Filterer_MethodInfo.HasCustomAttributeOfType<InspectorActionAttribute>()
            ).Convert(m => m.CreateAction())
            .Convert(a => EditAction.New(this, a));
        }

        public IEnumerable<EditAction> GetRecoveryActions()
        {
            return target_type.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<RecoveryFunctionAttribute>()
            ).Convert(m => m.CreateAction())
            .Convert(a => EditAction.New(this, a));
        }

        public IEnumerable<EditDisplay> GetDisplays()
        {
            return target_type.GetFilteredInstanceProps(
                Filterer_PropInfo.HasCustomAttributeOfType<InspectorDisplayAttribute>(),
                Filterer_PropInfo.CanGet()
            ).Convert(m => m.CreateVariable())
            .Convert(v => EditDisplay.New(this, v));
        }

        public IEnumerable<EditProperty> GetAllPropertys()
        {
            return target_type.GetFilteredInstanceFields(
                Filterer_Utility.Any(
                    Filterer_FieldInfo.HasCustomAttributeOfType<SerializeField>(),
                    Filterer_FieldInfo.HasCustomAttributeOfType<SerializeFieldEX>(),
                    Filterer_FieldInfo.IsPublicField()
                )
            ).Convert(f => f.CreateVariable())
            .Convert(v => EditProperty.New(this, v));
        }

        public IEnumerable<EditProperty> GetPropertys()
        {
            return GetAllPropertys()
                .Skip(p => p.HasCustomAttributeOfType<HideInInspector>(true))
                .Skip(p => p.HasCustomAttributeOfType<RecoveryFieldAttribute>(true))
                .Skip(p => p.GetPropertyType().HasCustomAttributeOfType<HideInInspector>(true));
        }

        public IEnumerable<EditProperty> GetRecoveryPropertys()
        {
            return GetAllPropertys()
                .Narrow(p => p.HasCustomAttributeOfType<RecoveryFieldAttribute>(true));
        }

        public IEnumerable<EditGadget> GetGadgets()
        {
            return target_type.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<AttachEditGadgetAttribute>()
            ).Convert(f => f.CreateVariable())
            .TryNarrow((Variable v, out AttachEditGadgetAttribute a) =>
                v.TryGetCustomAttributeOfType<AttachEditGadgetAttribute>(true, out a)
            ).Convert(p => EditGadget.New(this, p.item1, p.item2));
        }
    }
}