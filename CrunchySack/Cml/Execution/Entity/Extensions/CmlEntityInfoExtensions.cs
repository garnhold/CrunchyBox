using System;

namespace Crunchy.Sack
{
    using Dough;

    static public class CmlEntityinfoExtensions
    {
        static public void PushToRepresentation(this CmlEntityInfo item, CmlContext context, object representation)
        {
            context.GetEngine().AssertGetInfo(representation.GetTypeEX(), item.GetName())
                .PushToRepresentation(context, representation, item.Solidify(context));
        }

        static public CmlParameter CreateParameter(this CmlEntityInfo item, CmlContext context)
        {
            return new CmlParameter(
                item.GetName(),
                item.Solidify(context)
            );
        }
    }
}
