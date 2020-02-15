using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfoSet_SelectableChildren : RepresentationInfoSet
    {
        private string name;

        private EffigyInfo_Collection effigy_info;
        private List<RepresentationInfoSetChildrenSelector> selectors;

        public RepresentationInfoSet_SelectableChildren(string n, EffigyInfo_Collection e) : base(e.GetRepresentationType())
        {
            name = n;

            effigy_info = e;
            RegisterSetMember(name);

            selectors = new List<RepresentationInfoSetChildrenSelector>();
        }

        public override void SolidifyInstance(CmlExecution execution, object representation, CmlSet set)
        {
            CmlSetMember children = set.GetMember(name);
            EffigyLink effigy_link = effigy_info.CreateLink(execution, representation, children.GetVariableInstance(), children.GetClass());

            selectors.Process(
                s => s.SolidifyInstance(
                    execution, 
                    representation, 
                    effigy_link, 
                    set.GetMember(s.GetName())
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
            RegisterSetMember(to_add.GetName());
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo(this RepresentationEngine item, string n, EffigyInfo_Collection e)
        {
            return item.AddAndGetInfoSet(new RepresentationInfoSet_SelectableChildren(n, e));
        }
        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo(this RepresentationEngine item, EffigyInfo_Collection e)
        {
            return item.AddSelectableChildrenInfo(RepresentationInfo.UnamedChildren, e);
        }
    }
}