using System;

namespace Crunchy.Sack
{
    using Dough;

    public interface CmlEntityInfo
    {
        string GetName();
        CmlValue GetValue(CmlContext context);
    }

}
