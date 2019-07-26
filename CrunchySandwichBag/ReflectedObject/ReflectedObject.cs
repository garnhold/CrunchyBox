using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class ReflectedObject
    {
        private Type object_type;
        private List<object> objects;

        private ReflectedObject parent;

        public void Touch(string label, Process process)
        {
            if (object_type.CanBeTreatedAs<UnityEngine.Object>())
            {
                objects
                    .Convert<UnityEngine.Object>()
                    .Process(o => Undo.RecordObject(o, label));

                process();

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
                    parent.Touch(label, process);
            }
        }

        public ReflectedObject(IEnumerable<object> o, ReflectedObject p)
        {
            objects = o.ToList();
            object_type = objects.Convert(z => z.GetTypeEX()).GetCommonAncestor();

            parent = p;
        }

        public ReflectedObject(IEnumerable<object> o) : this(o, null) { }

        public bool IsValid()
        {
            if (objects.IsNotEmpty() && object_type != null)
                return true;

            return false;
        }

        public bool IsSerializationCorrupt()
        {
            if (objects.Convert<SerializationCorruptable>().Has(c => c.IsSerializationCorrupt()))
                return true;

            return false;
        }

        public Type GetObjectType()
        {
            return object_type;
        }

        public IEnumerable<object> GetObjects()
        {
            return objects;
        }

        public ReflectedAction ForceAction(string path)
        {
            return ReflectedAction.New(
                this,
                object_type.GetActionByPath(path)
                    .AssertNotNull(() => new MissingMethodException("No action exists for type " + GetObjectType() + " and path " + path))
            );
        }

        public ReflectedProperty ForceProperty(string path)
        {
            return ReflectedProperty.New(
                this,
                object_type.GetVariableByPath(path)
                    .AssertNotNull(() => new MissingFieldException("No property exists for type " + GetObjectType() + " and path " + path))
            );
        }

        public IEnumerable<ReflectedAction> GetActions()
        {
            return object_type.GetFilteredInstanceMethods(
                Filterer_MethodInfo.HasNoEffectiveParameters(),
                Filterer_MethodInfo.HasCustomAttributeOfType<ContextMenu>()
            ).Convert(m => m.CreateAction())
            .Convert(a => ReflectedAction.New(this, a));
        }

        public IEnumerable<ReflectedProperty> GetPropertys()
        {
            return UnityTyonSettings.INSTANCE.GetDesignatedVariables(object_type)
                .Skip(v => v.HasCustomAttributeOfType<HideInInspector>(true))
                .Skip(v => v.HasCustomAttributeOfType<RecoveryFieldAttribute>(true))
                .Convert(v => ReflectedProperty.New(this, v));
        }

        public IEnumerable<ReflectedProperty> GetRecoveryPropertys()
        {
            return UnityTyonSettings.INSTANCE.GetDesignatedVariables(object_type)
                .Narrow(v => v.HasCustomAttributeOfType<RecoveryFieldAttribute>(true))
                .Convert(v => ReflectedProperty.New(this, v));
        }

        public IEnumerable<ReflectedGadget> GetGadgets()
        {
            return object_type.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<AttachEditGadgetAttribute>()
            ).Convert(f => f.CreateVariable())
            .TryNarrow((Variable v, out AttachEditGadgetAttribute a) => 
                v.TryGetCustomAttributeOfType<AttachEditGadgetAttribute>(true, out a)
            ).Convert(p => ReflectedGadget.New(this, p.item1, p.item2));
        }

        public int GetNumberActions()
        {
            return GetActions().Count();
        }

        public int GetNumberPropertys()
        {
            return GetPropertys().Count();
        }

        public int GetNumberRecoveryPropertys()
        {
            return GetRecoveryPropertys().Count();
        }

        public int GetNumberGadgets()
        {
            return GetGadgets().Count();
        }
    }
}