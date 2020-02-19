using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo_Collection : EffigyInfo
    {
        public abstract void Update(EffigyLink link, object representation, IList<object> old_values, IList<object> new_values);

        public EffigyInfo_Collection(Type r, Type c) : base(r, c) { }

        public override EffigyLink CreateLink(CmlContext context, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return new EffigyLink_Collection(
                context,
                new EffigySource_Collection(variable_instance),
                new EffigyDestination_Collection(representation, this),
                @class
            );
        }
    }
}