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
                    .Narrow(o => o.IsPrefab())
                    .Process(o => PrefabUtility.RecordPrefabInstancePropertyModifications(o));
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
            return ReflectedAction.New(this, object_type.GetActionByPath(path));
        }

        public ReflectedProperty ForceProperty(string path)
        {
            return ReflectedProperty.New(this, object_type.GetVariableByPath(path));
        }

        public IEnumerable<ReflectedAction> GetActions()
        {
            return object_type.GetDesignatedActions()
                .Convert(a => ReflectedAction.New(this, a));
        }

        public IEnumerable<ReflectedProperty> GetPropertys()
        {
            return object_type.GetDesignatedVariablesForPropertys()
                .Convert(v => ReflectedProperty.New(this, v));
        }

        public IEnumerable<ReflectedGadget> GetGadgets()
        {
            return object_type.GetDesignatedVariablesForGadgets()
                .TryNarrow((Variable v, out AttachEditGadgetAttribute a) => 
                    v.TryGetCustomAttributeOfType<AttachEditGadgetAttribute>(true, out a)
                ).Convert(p => ReflectedGadget.New(this, p.item1, p.item2));
        }
    }
}