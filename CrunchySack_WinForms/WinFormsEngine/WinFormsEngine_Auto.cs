using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;
using System.ComponentModel;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WinFormsEngine : RepresentationEngine
    {
        public void AddInspectedComponentsForType(Type type)
        {
            Add(WinFormsInstancers.Simple(type.Name, () => type.CreateInstance()));

            AddAttributeInfosForPublicPropertys(type);
        }

        public void AddInspectedComponentsForTypes(IEnumerable<Type> types)
        {
            types.Process(t => AddInspectedComponentsForType(t));
        }
        public void AddInspectedComponentsForTypes(params Type[] types)
        {
            AddInspectedComponentsForTypes((IEnumerable<Type>)types);
        }

        public void AddAttributeInfosForPublicPropertys(Type type)
        {
            Add(
                type.GetFilteredInstancePropertys(Filterer_PropertyInfo.IsSetAndGetPublic())
                    .Convert(p => p.CreateVariable())
                    .Convert(v => (RepresentationEngineComponent)WinFormsInfos.AttributeLink(
                        v.GetVariableName().StyleAsVariableName(), 
                        v
                    ))
            );
        }
    }
}