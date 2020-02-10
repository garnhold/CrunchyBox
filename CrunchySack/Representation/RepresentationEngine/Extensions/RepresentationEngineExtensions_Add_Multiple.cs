using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class RepresentationEngineExtensions_Add_Multiple
    {
        static public void AddInstancers(this RepresentationEngine item, IEnumerable<RepresentationInstancer> cs)
        {
            cs.Process(c => item.AddInstancer(c));
        }
        static public void AddInstancers(this RepresentationEngine item, params RepresentationInstancer[] cs)
        {
            item.AddInstancers((IEnumerable<RepresentationInstancer>)cs);
        }

        static public void AddConstructors(this RepresentationEngine item, IEnumerable<RepresentationConstructor> cs)
        {
            cs.Process(c => item.AddConstructor(c));
        }
        static public void AddConstructors(this RepresentationEngine item, params RepresentationConstructor[] cs)
        {
            item.AddConstructors((IEnumerable<RepresentationConstructor>)cs);
        }

        static public void AddAttributeInfos(this RepresentationEngine item, IEnumerable<RepresentationInfo_Attribute> cs)
        {
            cs.Process(c => item.AddAttributeInfo(c));
        }
        static public void AddAttributeInfos(this RepresentationEngine item, params RepresentationInfo_Attribute[] cs)
        {
            item.AddAttributeInfos((IEnumerable<RepresentationInfo_Attribute>)cs);
        }

        static public void AddChildrenInfos(this RepresentationEngine item, IEnumerable<RepresentationInfo_Children> cs)
        {
            cs.Process(c => item.AddChildrenInfo(c));
        }
        static public void AddChildrenInfos(this RepresentationEngine item, params RepresentationInfo_Children[] cs)
        {
            item.AddChildrenInfos((IEnumerable<RepresentationInfo_Children>)cs);
        }

        static public void AddGeneralModifiers(this RepresentationEngine item, IEnumerable<RepresentationModifier_General> cs)
        {
            cs.Process(c => item.AddGeneralModifier(c));
        }
        static public void AddGeneralModifiers(this RepresentationEngine item, params RepresentationModifier_General[] cs)
        {
            item.AddGeneralModifiers((IEnumerable<RepresentationModifier_General>)cs);
        }
    }
}