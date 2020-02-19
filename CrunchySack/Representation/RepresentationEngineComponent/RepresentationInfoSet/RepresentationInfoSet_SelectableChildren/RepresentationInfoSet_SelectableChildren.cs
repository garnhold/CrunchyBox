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

        public override void SolidifyInstance(CmlContext context, object representation, CmlSet set)
        {
            CmlSetMember children = set.GetMember(name);

            CmlSetMember_Link children_link;
            CmlSetMember_Values children_values;

            if (children.Convert<CmlSetMember_Link>(out children_link))
            {
                EffigyLink effigy_link = effigy_info.CreateLink(context, representation, children_link.GetVariableInstance(), children_link.GetClass());

                selectors.Process(
                    s => set.GetMember(s.GetName()).IfNotNull(
                        m => s.SolidifyInstance(
                            context,
                            representation,
                            effigy_link,
                            m
                        ))
                );

                context.AddEffigyLink(
                    children_link.GetGroup(),
                    effigy_link
                );
            }
            else if (children.Convert<CmlSetMember_Values>(out children_values))
            {
                children_values.GetValues().Process(v => effigy_info.AddChild(representation, v));
            }
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