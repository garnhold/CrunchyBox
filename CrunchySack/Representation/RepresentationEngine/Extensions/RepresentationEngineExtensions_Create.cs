using System;

using CrunchyDough;

namespace CrunchySack
{
    static public class RepresentationEngineExtensions_Create
    {
        static public RepresentationResult CreateRepresentation(this RepresentationEngine item, object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            return item.GetClassLibrary().GetClass(target.GetTypeEX(), layout)
                .IfNotNull(c => c.CreateRepresentationGetResult(new CmlExecution(new CmlTargetInfo(target, item))));
        }
    }
}