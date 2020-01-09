using System;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class TypePass : Type, ForeignType
    {
        public abstract Type GetNativeType();

        //Type
        public override Assembly Assembly { get { return GetNativeType().Assembly; } }
        public override string AssemblyQualifiedName { get { return GetNativeType().AssemblyQualifiedName; } }
        public override Type BaseType { get { return GetNativeType().BaseType; } }
        public override bool ContainsGenericParameters { get { return GetNativeType().ContainsGenericParameters; } }
        public override MethodBase DeclaringMethod { get { return GetNativeType().DeclaringMethod; } }
        public override Type DeclaringType { get { return GetNativeType().DeclaringType; } }
        public override string FullName { get { return GetNativeType().FullName; } }
        public override GenericParameterAttributes GenericParameterAttributes { get { return GetNativeType().GenericParameterAttributes; } }
        public override int GenericParameterPosition { get { return GetNativeType().GenericParameterPosition; } }
        public override Guid GUID { get { return GetNativeType().GUID; } }
        public override bool IsGenericParameter { get { return GetNativeType().IsGenericParameter; } }
        public override bool IsGenericType { get { return GetNativeType().IsGenericType; } }
        public override bool IsGenericTypeDefinition { get { return GetNativeType().IsGenericTypeDefinition; } }
        public override MemberTypes MemberType { get { return GetNativeType().MemberType; } }
        public override Module Module { get { return GetNativeType().Module; } }
        public override string Namespace { get { return GetNativeType().Namespace; } }
        public override Type ReflectedType { get { return GetNativeType().ReflectedType; } }
        public override StructLayoutAttribute StructLayoutAttribute { get { return GetNativeType().StructLayoutAttribute; } }
        public override RuntimeTypeHandle TypeHandle { get { return GetNativeType().TypeHandle; } }
        public override Type UnderlyingSystemType { get { return GetNativeType().UnderlyingSystemType; } }
        public override Type[] FindInterfaces(TypeFilter filter, object filter_criteria) { return GetNativeType().FindInterfaces(filter, filter_criteria); }
        public override MemberInfo[] FindMembers(MemberTypes member_type, BindingFlags binding_flags, MemberFilter filter, object filter_criteria) { return GetNativeType().FindMembers(member_type, binding_flags, filter, filter_criteria); }
        public override int GetArrayRank() { return GetNativeType().GetArrayRank(); }
        protected override TypeAttributes GetAttributeFlagsImpl() { return GetNativeType().Attributes; }
        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { return GetNativeType().GetConstructor(bindingAttr, binder, callConvention, types, modifiers); }
        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { return GetNativeType().GetConstructors(bindingAttr); }
        public override MemberInfo[] GetDefaultMembers() { return GetNativeType().GetDefaultMembers(); }
        public override Type GetElementType() { return GetNativeType().GetElementType(); }
        public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { return GetNativeType().GetEvent(name, bindingAttr); }
        public override EventInfo[] GetEvents() { return GetNativeType().GetEvents(); }
        public override EventInfo[] GetEvents(BindingFlags bindingAttr) { return GetNativeType().GetEvents(bindingAttr); }
        public override FieldInfo GetField(string name, BindingFlags bindingAttr) { return GetNativeType().GetField(name, bindingAttr); }
        public override FieldInfo[] GetFields(BindingFlags bindingAttr) { return GetNativeType().GetFields(bindingAttr); }
        public override Type[] GetGenericArguments() { return GetNativeType().GetGenericArguments(); }
        public override Type[] GetGenericParameterConstraints() { return GetNativeType().GetGenericParameterConstraints(); }
        public override Type GetGenericTypeDefinition() { return GetNativeType().GetGenericTypeDefinition(); }
        public override Type GetInterface(string name, bool ignoreCase) { return GetNativeType().GetInterface(name, ignoreCase); }
        public override InterfaceMapping GetInterfaceMap(Type interfaceType) { return GetNativeType().GetInterfaceMap(interfaceType); }
        public override Type[] GetInterfaces() { return GetNativeType().GetInterfaces(); }
        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { return GetNativeType().GetMember(name, bindingAttr); }
        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { return GetNativeType().GetMember(name, type, bindingAttr); }
        public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { return GetNativeType().GetMembers(bindingAttr); }
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { return GetNativeType().GetMethod(name, bindingAttr, binder, callConvention, types, modifiers); }
        public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { return GetNativeType().GetMethods(bindingAttr); }
        public override Type GetNestedType(string name, BindingFlags bindingAttr) { return GetNativeType().GetNestedType(name, bindingAttr); }
        public override Type[] GetNestedTypes(BindingFlags bindingAttr) { return GetNativeType().GetNestedTypes(bindingAttr); }
        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { return GetNativeType().GetProperties(bindingAttr); }
        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { return GetNativeType().GetProperty(name, bindingAttr, binder, returnType, types, modifiers); }
        protected override bool HasElementTypeImpl() { return GetNativeType().HasElementType; }
        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { return GetNativeType().InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters); }
        protected override bool IsArrayImpl() { return GetNativeType().IsArray; }
        public override bool IsAssignableFrom(Type c) { return GetNativeType().IsAssignableFrom(c); }
        protected override bool IsByRefImpl() { return GetNativeType().IsByRef; }
        protected override bool IsCOMObjectImpl() { return GetNativeType().IsCOMObject; }
        protected override bool IsContextfulImpl() { return GetNativeType().IsContextful; }
        public override bool IsInstanceOfType(object o) { return GetNativeType().IsInstanceOfType(o); }
        protected override bool IsMarshalByRefImpl() { return GetNativeType().IsMarshalByRef; }
        protected override bool IsPointerImpl() { return GetNativeType().IsPointer; }
        protected override bool IsPrimitiveImpl() { return GetNativeType().IsPrimitive; }
        public override bool IsSubclassOf(Type c) { return GetNativeType().IsSubclassOf(c); }
        protected override bool IsValueTypeImpl() { return GetNativeType().IsValueType; }
        public override Type MakeArrayType() { return GetNativeType().MakeArrayType(); }
        public override Type MakeArrayType(int rank) { return GetNativeType().MakeArrayType(rank); }
        public override Type MakeByRefType() { return GetNativeType().MakeByRefType(); }
        public override Type MakeGenericType(params Type[] typeArguments) { return GetNativeType().MakeGenericType(typeArguments); }
        public override Type MakePointerType() { return GetNativeType().MakePointerType(); }
        public override string ToString() { return GetNativeType().ToString(); }

        //MemberInfo
        public override int MetadataToken { get { return GetNativeType().MetadataToken; } }
        public override string Name { get { return GetNativeType().Name; } }
        public override object[] GetCustomAttributes(bool inherit) { return GetNativeType().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativeType().GetCustomAttributes(attributeType, inherit); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativeType().IsDefined(attributeType, inherit); }
    }
}