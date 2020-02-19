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

        public abstract void Update(EffigyLink link, object representation, object old_value, object new_value);

        public EffigyInfo_Single(Type r, Type c) : base(r, c) { }

        public override void AddChild(object representation, object child)
        {
            SetChild(representation, child);
        }

        public override EffigyLink CreateLink(CmlContext context, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return new EffigyLink_Single(
                context,
                new EffigySource_Single(variable_instance),
                new EffigyDestination_Single(representation, this),
                @class
            );
        }
    }
}