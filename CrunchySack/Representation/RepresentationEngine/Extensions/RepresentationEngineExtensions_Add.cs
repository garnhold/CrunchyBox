using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddPublicPropertyAttributeLinksForType(this RepresentationEngine item, Type type)
        {
            type.GetFilteredInstancePropertys(Filterer_PropertyInfo.IsSetAndGetPublic())
                .Convert(p => p.CreateVariable())
                .Process(v => item.AddAttributeLink(v.GetVariableName().StyleAsVariableName(), v));
        }
        static public void AddPublicPropertyAttributeLinksForType<T>(this RepresentationEngine item)
        {
            item.AddPublicPropertyAttributeLinksForType(typeof(T));
        }
    }
}