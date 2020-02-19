using System;

namespace Crunchy.Sack
{
    using Dough;

    public interface CmlEntityInfo
    {
        CmlParameter CreateParameter(CmlContext context);

        void PushToRepresentation(CmlContext context, object representation);
    }

}
