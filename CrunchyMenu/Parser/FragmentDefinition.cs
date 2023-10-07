using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class FragmentDefinitionBase
    {
    }

    public abstract class FragmentDefinitionVoid : FragmentDefinitionBase
    {
        public abstract bool Consume(IList<TokenInstance> tokens, int index, out int new_index);
    }

    public abstract class FragmentDefinition<T> : FragmentDefinitionBase
    {
        public abstract bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> product);
    }
}