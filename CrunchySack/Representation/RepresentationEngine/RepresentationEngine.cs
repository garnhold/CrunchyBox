using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class RepresentationEngine
    {
        private GlobalLibrary global_library;
        private ClassLibrary class_library;
        private FragmentLibrary fragment_library;

        private Dictionary<string, RepresentationInstancer> instancers;
        private Dictionary<string, List<RepresentationConstructor>> constructors;
        private OperationCache<RepresentationConstructor, string, ContentsEnumerable<Type>> constructor_cache;
        
        private Dictionary<string, TypeDictionary<RepresentationInfo>> infos;

        private Dictionary<Type, List<RepresentationInfoSet>> info_sets;
        private Dictionary<Type, List<RepresentationModifier_General>> general_modifiers;

        public RepresentationEngine()
        {
            global_library = new GlobalLibrary();
            class_library = new ClassLibrary();
            fragment_library = new FragmentLibrary();

            instancers = new Dictionary<string, RepresentationInstancer>();
            constructors = new Dictionary<string, List<RepresentationConstructor>>();

            constructor_cache = new OperationCache<RepresentationConstructor, string, ContentsEnumerable<Type>>("constructor_cache", delegate (string name, ContentsEnumerable<Type> parameter_types) {
                return constructors.GetValues(name)
                    .FindFirst(c => c.GetParameterTypes().AreElements(parameter_types, (p1, p2) => p1.CanHold(p2)));
            });

            infos = new Dictionary<string, TypeDictionary<RepresentationInfo>>();

            info_sets = new Dictionary<Type, List<RepresentationInfoSet>>();
            general_modifiers = new Dictionary<Type, List<RepresentationModifier_General>>();
        }

        public void AddInstancer(RepresentationInstancer cs)
        {
            instancers[cs.GetTag()] = cs;
            cs.Initilize(this);
        }

        public void AddConstructor(RepresentationConstructor cs)
        {
            constructors.Add(cs.GetName(), cs);
            cs.Initilize(this);

            constructor_cache.Clear();
        }

        public void AddInfo(RepresentationInfo i)
        {
            infos.GetOrCreateDefaultValue(i.GetName())[i.GetRepresentationType()] = i;
            i.Initilize(this);
        }

        public void AddInfoSet(RepresentationInfoSet s)
        {
            info_sets.Add(s.GetRepresentationType(), s);
            s.Initilize(this);
        }

        public void AddGeneralModifier(RepresentationModifier_General c)
        {
            general_modifiers.Add(c.GetRepresentationType(), c);
            c.Initilize(this);
        }

        public object AssertInstance(CmlContext context, string tag, CmlEntity entity)
        {
            return GetInstancer(tag).IfNotNull(i => i.Instance(context, entity))
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("entity", tag));
        }
        public CmlEntityInstancer GetInstancer(string tag)
        {
            return (CmlEntityInstancer)instancers.GetValue(tag) ??
                (CmlEntityInstancer)GetFragmentLibrary().GetFragment(tag);
        }

        public object AssertInstanceBase(CmlContext context, string tag)
        {
            return instancers.GetValue(tag)
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("instancer", tag))
                .Instance(context);
        }

        public object AssertInvokeConstructor(CmlContext context, string name, IEnumerable<object> system_values)
        {
            List<object> system_value_list = system_values.ToList();

            return GetConstructor(name, system_value_list.Convert(o => o.GetTypeEX()))
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdException("constructor", name + "(" + system_value_list.Convert(o => o.GetTypeEX()).ToString(", ") + ")"))
                .Invoke(context, system_value_list);
        }
        public RepresentationConstructor GetConstructor(string name, IEnumerable<Type> parameter_types)
        {
            return constructor_cache.Fetch(name, new ContentsEnumerable<Type>(parameter_types));
        }

        public RepresentationInfo AssertGetInfo(Type type, string name)
        {
            return GetInfo(name, type)
                .AssertNotNull(() => new CmlRuntimeError_InvalidIdForTypeException("info", name, type));
        }
        public RepresentationInfo GetInfo(string name, Type type)
        {
            return infos
                .GetValue(name)
                .IfNotNull(d => d.GetValue(type));
        }

        public void AssertApplyGeneralModifiers(CmlContext context, object representation)
        {
            GetGeneralModifiers(representation.GetTypeEX())
                .Process(m => m.Apply(context, representation));
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