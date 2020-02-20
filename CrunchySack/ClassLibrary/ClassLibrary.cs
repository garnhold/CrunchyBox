using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class ClassLibrary
    {
        private List<ClassProvider> class_providers;
        private Dictionary<Tuple<Type, string>, CmlClass> manual_classes;

        private OperationCache<CmlClass, Type, string> class_cache;

        public ClassLibrary()
        {
            class_providers = new List<ClassProvider>();
            manual_classes = new Dictionary<Tuple<Type, string>, CmlClass>();

            class_cache = new OperationCache<CmlClass, Type, string>("class_cache", delegate(Type type, string layout) {
                return manual_classes.GetValue(Tuple.New(type, layout)) ?? 
                    class_providers.Convert(p => p.GetClass(type, layout)).GetFirstNonNull();
            });
        }

        public void AddClass(CmlClass @class)
        {
            manual_classes[Tuple.New(@class.GetTargetType(), @class.GetLayout())] = @class;
            class_cache.Clear();
        }

        public void AddClassProvider(ClassProvider p)
        {
            class_providers.Add(p);
            class_cache.Clear();
        }

        public CmlClass GetClass(Type type, string layout)
        {
            return class_cache.Fetch(type, layout);
        }

        public CmlClass AssertGetClass(Type type, string layout)
        {
            return GetClass(type, layout)
                .AssertNotNull(() => new CmlRuntimeError_UnableToFindClassException(type, layout));
        }
    }
}