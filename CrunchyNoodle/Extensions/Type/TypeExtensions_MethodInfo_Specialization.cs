using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O>(this object item, string name, O other)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1>(this object item, string name, O other, P1 p1)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2>(this object item, string name, O other, P1 p1, P2 p2)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3>(this object item, string name, O other, P1 p1, P2 p2, P3 p3)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4, P5>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4, P5>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4, P5>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4, p5);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4, P5, P6>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4, p5, p6);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7, P8>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7, P8>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7, p8);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7, P8, P9>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethod(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Void
		{
			static public MethodInfo GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Void<O, P1, P2, P3, P4, P5, P6, P7, P8, P9>.GetSpecializationMethod(item, name, other);
			}

			static public void CallSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethod<O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
		}
				
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O>(this object item, string name, O other)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1>(this object item, string name, O other, P1 p1)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2>(this object item, string name, O other, P1 p1, P2 p2)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3>(this object item, string name, O other, P1 p1, P2 p2, P3 p3)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4, p5);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4, p5, p6);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7, P8>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7, P8>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7, p8);
			}
		}
			
		static public class TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7, P8, P9>
		{
			static private OperationCache<MethodInfoEX, Type, string, Type> GET_SPECIALIZATION_METHOD = ReflectionCache.Get().NewOperationCache("GET_SPECIALIZATION_METHOD", delegate(Type self, string name, Type other) {
				return self.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
					.Narrow(m => m.CanEffectiveParametersHold(other, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)))
					.FindLowestRated(m => m.GetEffectiveParameterType(0).GetTypeDistance(other));
			});
			static public MethodInfo GetSpecializationMethodWithReturn(Type self, string name, Type other)
			{
				return GET_SPECIALIZATION_METHOD.Fetch(self, name, other);
			}
		}
		static public partial class TypeExtensions_MethodInfo_Specialization_Generic_Return
		{
			static public MethodInfo GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name, Type other)
			{
				return TypeExtensions_MethodInfo_Specialization_Generic_Return<O, R, P1, P2, P3, P4, P5, P6, P7, P8, P9>.GetSpecializationMethodWithReturn(item, name, other);
			}

			static public R CallSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this object item, string name, O other, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				Type type = item.GetType();
				MethodInfo method = type.GetSpecializationMethodWithReturn<R, O, P1, P2, P3, P4, P5, P6, P7, P8, P9>(name, other.GetTypeEX());

				if(method == null)
					throw new NotImplementedException(type + " doesn't implement a version of " + name + " to handle " + other);

				return (R)method.Invoke(item, other, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
		}
	}