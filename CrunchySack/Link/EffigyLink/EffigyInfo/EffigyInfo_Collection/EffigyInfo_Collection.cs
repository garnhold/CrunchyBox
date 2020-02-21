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
        protected abstract EffigyCollectionDestination CreateCollectionDestination(object representation);

        public EffigyInfo_Collection(Type r, Type c) : base(r, c) { }

        public override EffigyLink CreateLink(CmlContext context, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return new EffigyLink_Collection(
                context,
                variable_instance,
                CreateCollectionDestination(representation),
                @class
            );
        }
    }
}