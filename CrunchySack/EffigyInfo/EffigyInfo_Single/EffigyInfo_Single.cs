using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Single : EffigyInfo
    {
        public abstract void SetChild(object representation, object child);

        public abstract EffigySingleDestination CreateSingleDestination(object representation);

        public EffigyInfo_Single(Type r, Type c) : base(r, c) { }

        public override void SetChildren(object representation, IEnumerable<object> children)
        {
            SetChild(representation, children.GetFirst());
        }

        public override EffigyLink CreateLink(CmlContext context, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return new EffigyLink_Single(
                context,
                variable_instance,
                CreateSingleDestination(representation),
                @class
            );
        }
    }
}