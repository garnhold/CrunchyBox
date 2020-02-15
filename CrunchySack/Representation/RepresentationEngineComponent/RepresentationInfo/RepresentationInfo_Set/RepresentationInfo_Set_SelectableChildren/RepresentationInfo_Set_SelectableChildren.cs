using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Set_SelectableChildren : RepresentationInfo_Set
    {
        private EffigyInfo_Collection effigy_info;
        private List<RepresentationInfoSetChildrenSelector> selectors;

        public RepresentationInfo_Set_SelectableChildren(EffigyInfo_Collection e) : base(e.GetRepresentationType())
        {
            effigy_info = e;
            RegisterChildrenInfo();

            selectors = new List<RepresentationInfoSetChildrenSelector>();
        }

        public override void SolidifyInstance(CmlExecution execution, object representation, CmlSet set)
        {
            CmlSetChildren children = set.GetChildren();
            EffigyLink effigy_link = effigy_info.CreateLink(execution, representation, children.GetVariableInstance(), children.GetClass());

            selectors.Process(
                s => s.SolidifyInstance(
                    execution, 
                    representation, 
                    effigy_link, 
                    set.GetAttribute(s.GetName())
                )
            );

            execution.AddEffigyLink(
                children.GetGroup(),
                effigy_link
            );
        }

        public void AddSelector(RepresentationInfoSetChildrenSelector to_add)
        {
            selectors.Add(to_add);
            RegisterAttributeInfo(to_add.GetName());
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public RepresentationInfo_Set_SelectableChildren AddSelectableChildren(this RepresentationEngine item, EffigyInfo_Collection e)
        {
            return item.AddAndGetSetInfo(new RepresentationInfo_Set_SelectableChildren(e));
        }
    }
}