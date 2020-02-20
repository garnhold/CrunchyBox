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
            RegisterSetMember(name, false, true, true, true);

            selectors = new List<RepresentationInfoSetChildrenSelector>();
        }

        public override void SolidifyInstance(CmlContext context, object representation, CmlSet set)
        {
            CmlValue children = set.GetValue(name);

            CmlValue_Link children_link;
            CmlValue_SystemValues children_values;

            if (children.Convert<CmlValue_Link>(out children_link))
            {
                EffigyLink effigy_link = effigy_info.CreateLink(context, representation, children_link.GetVariableInstance(), children_link.GetClass());

                selectors.Process(
                    s => set.GetValue(s.GetName()).IfNotNull(
                        v => s.SolidifyInstance(
                            context,
                            representation,
                            effigy_link,
                            v
                        ))
                );

                context.AddEffigyLink(
                    children_link.GetGroup(),
                    effigy_link
                );
            }
            else if (children.Convert<CmlValue_SystemValues>(out children_values))
            {
                effigy_info.SetChildren(representation, children_values.GetSystemValues());
            }
        }

        public void AddSelector(RepresentationInfoSetChildrenSelector to_add)
        {
            selectors.Add(to_add);
            to_add.Initialize(this);
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