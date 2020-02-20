using System;

namespace Crunchy.Sack
{
    using Dough;

    public interface CmlEntityInstancer
    {
        object Instance(CmlContext context, CmlEntity entity);
    }

}
