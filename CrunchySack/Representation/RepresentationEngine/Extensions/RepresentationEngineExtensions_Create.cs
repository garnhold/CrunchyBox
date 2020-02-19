using System;

namespace Crunchy.Sack
{
    using Dough;
    
    static public class RepresentationEngineExtensions_Create
    {
        static public RepresentationResult AssertCreateRepresentation(this RepresentationEngine item, object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            return item.GetClassLibrary().AssertGetClass(target.GetTypeEX(), layout)
                .IfNotNull(c => c.CreateRepresentationGetResult(new CmlContext_Base(new CmlTargetInfo(target, item))));
        }
        static public RepresentationResult CreateRepresentation(this RepresentationEngine item, object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            return item.GetClassLibrary().GetClass(target.GetTypeEX(), layout)
                .IfNotNull(c => c.CreateRepresentationGetResult(new CmlContext_Base(new CmlTargetInfo(target, item))));
        }
    }
}