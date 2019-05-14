using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public class CmlTargetInfo
    {
        private object requester;

        private object target;
        private List<object> parents;
        
        private RepresentationEngine engine;

        public CmlTargetInfo(object req, object t, IEnumerable<object> p, RepresentationEngine e)
        {
            requester = req;

            target = t;
            parents = p.ToList();

            engine = e;
        }

        public CmlTargetInfo(object req, object t, object p, RepresentationEngine e) : this(req, t, new object[] { p }, e) { }
        public CmlTargetInfo(object t, RepresentationEngine e) : this(t, t, Empty.IEnumerable<object>(), e) { }

        public CmlTargetInfo CreateChild(object child)
        {
            return new CmlTargetInfo(
                requester,
                child,
                parents.Append(target),
                engine
            );
        }

        public object GetRequester()
        {
            return requester;
        }

        public object GetTarget()
        {
            return target;
        }

        public Type GetTargetType()
        {
            return target.GetTypeEX();
        }

        public IEnumerable<object> GetParents()
        {
            return parents;
        }

        public object GetImmediateParent()
        {
            return GetParents().GetLast();
        }

        public object GetParentOfType(Type type)
        {
            return parents.GetReverse().FindFirst(p => p.CanObjectBeTreatedAs(type));
        }

        public RepresentationEngine GetEngine()
        {
            return engine;
        }
    }
}