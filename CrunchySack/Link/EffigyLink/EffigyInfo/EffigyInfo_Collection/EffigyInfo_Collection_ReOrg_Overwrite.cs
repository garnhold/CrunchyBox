using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection_ReOrg_Overwrite : EffigyInfo_Collection_ReOrg
    {
        private AttachedObjectField<object, IList<object>> field;

        protected abstract void SetChildrenInternal(object representation, IEnumerable<object> children);

        public EffigyInfo_Collection_ReOrg_Overwrite(Type r, Type c) : base(r, c)
        {
            field = new AttachedObjectField<object, IList<object>>(o => new List<object>());
        }

        public override void ClearChildren(object representation)
        {
            IList<object> list = field.GetValue(representation);

            list.Clear();
            SetChildrenInternal(representation, list);
        }

        public override void AddChild(object representation, object child)
        {
            IList<object> list = field.GetValue(representation);

            list.Add(child);
            SetChildrenInternal(representation, list);
        }
    }
}