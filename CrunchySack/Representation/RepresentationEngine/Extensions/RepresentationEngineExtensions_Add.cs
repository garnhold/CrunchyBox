using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class RepresentationEngineExtensions_Add
    {
        static public void AddPublicPropertyAttributeLinksForType(this RepresentationEngine item, Type type)
        {
            item.Add(
                type.GetFilteredInstancePropertys(Filterer_PropertyInfo.IsSetAndGetPublic())
                    .Convert(p => p.CreateVariable())
                    .Convert(v => (RepresentationEngineComponent)RepresentationInfos.AttributeLink(
                        v.GetVariableName().StyleAsVariableName(),
                        v
                    ))
            );
        }
        static public void AddPublicPropertyAttributeLinksForType<T>(this RepresentationEngine item)
        {
            item.AddPublicPropertyAttributeLinksForType(typeof(T));
        }
    }
}