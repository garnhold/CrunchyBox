using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_Iterator
    {
        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, IEnumerable<PropInfoEX> iterator_targets)
        {
            return item.CreateDynamicMethodDelegate<IteratorGetter>("Iterator_" + item.Name + "<" + child_type.Name + ">", delegate(MethodBase method) {
                ILParameter this_parameter = method.GetTechnicalILParameter(0);

                return new ILReturn(
                    new ILIteratorSlew(iterator_targets.Convert(t => (ILValue)new ILProp(this_parameter, t)))
                );
            });
        }
        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, params PropInfoEX[] iterator_targets)
        {
            return item.CreateIteratorGetter(child_type, (IEnumerable<PropInfoEX>)iterator_targets);
        }

        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, IEnumerable<FieldInfoEX> field_infos)
        {
            return item.CreateIteratorGetter(child_type, field_infos.Convert(f => (PropInfoEX)new PropInfoEX_Field(f)));
        }
        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, params FieldInfoEX[] field_infos)
        {
            return item.CreateIteratorGetter(child_type, (IEnumerable<FieldInfoEX>)field_infos);
        }

        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, IEnumerable<MethodInfoEX> method_infos)
        {
            return item.CreateIteratorGetter(child_type, method_infos.Convert(m => (PropInfoEX)new PropInfoEX_MethodPair(null, m)));
        }
        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, params MethodInfoEX[] method_infos)
        {
            return item.CreateIteratorGetter(child_type, (IEnumerable<MethodInfoEX>)method_infos);
        }

        static public IteratorGetter CreateIteratorGetter(this Type item, Type child_type, IEnumerable<FieldInfoEX> field_infos, IEnumerable<MethodInfoEX> method_infos)
        {
            return item.CreateIteratorGetter(child_type, 
                field_infos.Convert(f => (PropInfoEX)new PropInfoEX_Field(f))
                    .Append(method_infos.Convert(m => (PropInfoEX)new PropInfoEX_MethodPair(null, m)))
            );
        }

        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, IEnumerable<PropInfoEX> iterator_getter_targets)
        {
            return item.CreateIteratorGetter(typeof(T), iterator_getter_targets).GetTypeSafe<T>();
        }
        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, params PropInfoEX[] iterator_getter_targets)
        {
            return item.CreateIteratorGetter<T>((IEnumerable<PropInfoEX>)iterator_getter_targets);
        }

        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, IEnumerable<FieldInfoEX> field_infos)
        {
            return item.CreateIteratorGetter(typeof(T), field_infos).GetTypeSafe<T>(); ;
        }
        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, params FieldInfoEX[] field_infos)
        {
            return item.CreateIteratorGetter<T>((IEnumerable<FieldInfoEX>)field_infos);
        }

        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, IEnumerable<MethodInfoEX> method_infos)
        {
            return item.CreateIteratorGetter(typeof(T), method_infos).GetTypeSafe<T>();
        }
        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, params MethodInfoEX[] method_infos)
        {
            return item.CreateIteratorGetter<T>((IEnumerable<MethodInfoEX>)method_infos);
        }

        static public IteratorGetter<T> CreateIteratorGetter<T>(this Type item, IEnumerable<FieldInfoEX> field_infos, IEnumerable<MethodInfoEX> method_infos)
        {
            return item.CreateIteratorGetter(typeof(T), field_infos, method_infos).GetTypeSafe<T>();
        }
    }
}