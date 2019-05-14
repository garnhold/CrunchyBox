using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public class RepresentationEngine
    {
        private GlobalLibrary global_library;
        private ClassLibrary class_library;
        private FragmentLibrary fragment_library;

        private Dictionary<string, RepresentationInstancer> instancers;
        private Dictionary<Tuple<string, int>, RepresentationConstructor> constructors;
        
        private Dictionary<string, TypeDictionary<RepresentationInfo_Attribute>> attribute_infos;
        private TypeDictionary<RepresentationInfo_Children> children_infos;

        private Dictionary<Type, List<RepresentationModifier_General>> general_modifiers;

        public RepresentationEngine()
        {
            global_library = new GlobalLibrary();
            class_library = new ClassLibrary();
            fragment_library = new FragmentLibrary();

            instancers = new Dictionary<string, RepresentationInstancer>();
            constructors = new Dictionary<Tuple<string, int>, RepresentationConstructor>();
            
            attribute_infos = new Dictionary<string, TypeDictionary<RepresentationInfo_Attribute>>();
            children_infos = new TypeDictionary<RepresentationInfo_Children>();

            general_modifiers = new Dictionary<Type, List<RepresentationModifier_General>>();
        }

        public void AddInstancer(RepresentationInstancer cs)
        {
            instancers[cs.GetTag()] = cs;
            cs.Initilize(this);
        }
        public void AddInstancers(IEnumerable<RepresentationInstancer> cs)
        {
            cs.Process(c => AddInstancer(c));
        }
        public void AddInstancers(params RepresentationInstancer[] cs)
        {
            AddInstancers((IEnumerable<RepresentationInstancer>)cs);
        }

        public void AddConstructor(RepresentationConstructor cs)
        {
            constructors[Tuple.New(cs.GetName(), cs.GetNumberParameters())] = cs;
            cs.Initilize(this);
        }
        public void AddConstructors(IEnumerable<RepresentationConstructor> cs)
        {
            cs.Process(c => AddConstructor(c));
        }
        public void AddConstructors(params RepresentationConstructor[] cs)
        {
            AddConstructors((IEnumerable<RepresentationConstructor>)cs);
        }

        public void AddAttributeInfo(RepresentationInfo_Attribute c)
        {
            attribute_infos.GetOrCreateDefaultValue(c.GetName())[c.GetRepresentationType()] = c;
            c.Initilize(this);
        }
        public void AddAttributeInfos(IEnumerable<RepresentationInfo_Attribute> cs)
        {
            cs.Process(c => AddAttributeInfo(c));
        }
        public void AddAttributeInfos(params RepresentationInfo_Attribute[] cs)
        {
            AddAttributeInfos((IEnumerable<RepresentationInfo_Attribute>)cs);
        }

        public void AddChildrenInfo(RepresentationInfo_Children c)
        {
            children_infos[c.GetRepresentationType()] = c;
            c.Initilize(this);
        }
        public void AddChildrenInfos(IEnumerable<RepresentationInfo_Children> cs)
        {
            cs.Process(c => AddChildrenInfo(c));
        }
        public void AddChildrenInfos(params RepresentationInfo_Children[] cs)
        {
            AddChildrenInfos((IEnumerable<RepresentationInfo_Children>)cs);
        }

        public void AddGeneralModifier(RepresentationModifier_General c)
        {
            general_modifiers.Add(c.GetRepresentationType(), c);
            c.Initilize(this);
        }
        public void AddGeneralModifiers(IEnumerable<RepresentationModifier_General> cs)
        {
            cs.Process(c => AddGeneralModifier(c));
        }
        public void AddGeneralModifiers(params RepresentationModifier_General[] cs)
        {
            AddGeneralModifiers((IEnumerable<RepresentationModifier_General>)cs);
        }

        public void Add(IEnumerable<RepresentationEngineComponent> cs)
        {
            AddInstancers(cs.Convert<RepresentationEngineComponent, RepresentationInstancer>());
            AddConstructors(cs.Convert<RepresentationEngineComponent, RepresentationConstructor>());
            
            AddAttributeInfos(cs.Convert<RepresentationEngineComponent, RepresentationInfo_Attribute>());
            AddChildrenInfos(cs.Convert<RepresentationEngineComponent, RepresentationInfo_Children>());

            AddGeneralModifiers(cs.Convert<RepresentationEngineComponent, RepresentationModifier_General>());
        }
        public void Add(params RepresentationEngineComponent[] cs)
        {
            Add((IEnumerable<RepresentationEngineComponent>)cs);
        }

        public CmlEntityInstance AssertEntityInstance(CmlExecution execution, CmlEntity entity, string tag)
        {
            return (
                (CmlEntityInstance)GetInstancer(tag).IfNotNull(i => new CmlEntityInstance_Normal(entity, i)) ??
                (CmlEntityInstance)GetFragmentLibrary().GetFragment(tag).IfNotNull(f => new CmlEntityInstance_Fragment(entity, f))
            ).AssertNotNull(() => new CmlRuntimeError_InvalidIdException("entity", tag));
        }
        public object AssertInstance(CmlExecution execution, string tag)
        {
            return GetInstancer(tag)
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("instancer", tag))
                .Instance(execution);
        }
        public RepresentationInstancer GetInstancer(string tag)
        {
            return instancers.GetValue(tag);
        }

        public void AssertConstructorInto(CmlExecution execution, string name, IEnumerable<object> system_values, CmlContainer container)
        {
            List<object> system_value_list = system_values.ToList();

            GetConstructor(name, system_value_list.Count)
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("constructor", name + "(" + system_value_list.Count + ")"))
                .InstanceInto(execution, system_value_list, container);
        }
        public RepresentationConstructor GetConstructor(string name, int number_parameters)
        {
            return constructors.GetValue(Tuple.New(name, number_parameters));
        }

        public CmlContainer_EndPoint_Attribute AssertCreateAttributeContainer(CmlExecution execution, object representation, string name)
        {
            return new CmlContainer_EndPoint_Attribute(
                representation,
                GetAttributeInfo(name, representation.GetTypeEX())
                    .AssertNotNull(() => new CmlRuntimeError_InvalidIdForTypeException("attribute", name, representation.GetTypeEX()))
            );
        }
        public RepresentationInfo_Attribute GetAttributeInfo(string name, Type type)
        {
            return attribute_infos
                .GetValue(name)
                .IfNotNull(d => d.GetValue(type));
        }

        public CmlContainer_EndPoint_Children AssertCreateChildrenContainer(CmlExecution execution, object representation)
        {
            return new CmlContainer_EndPoint_Children(
                representation,
                GetChildrenInfo(representation.GetTypeEX())
                    .AssertNotNull(() => new CmlRuntimeError_InvalidTypeException("children", representation.GetTypeEX()))
            );
        }
        public RepresentationInfo_Children GetChildrenInfo(Type type)
        {
            return children_infos.GetValue(type);
        }

        public void AssertApplyGeneralModifiers(CmlExecution execution, object representation)
        {
            GetGeneralModifiers(representation.GetTypeEX())
                .Process(m => m.Apply(execution, representation));
        }
        public IEnumerable<RepresentationModifier_General> GetGeneralModifiers(Type type)
        {
            return general_modifiers.GetAllAtKeys(
                type.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.BasicToSpecific)
            );
        }

        public GlobalLibrary GetGlobalLibrary()
        {
            return global_library;
        }

        public ClassLibrary GetClassLibrary()
        {
            return class_library;
        }

        public FragmentLibrary GetFragmentLibrary()
        {
            return fragment_library;
        }
    }
}