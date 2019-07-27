using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySandwich
{
	static public class PlayEditDistinction<ATTRIBUTE_TYPE> where ATTRIBUTE_TYPE : EditDistinctionAttribute
	{
			
		static public void ExecuteNoReturn(Process process)
		{
			if(Application.isPlaying)
				process();
			else
				ExecuteNoReturnEditDistinction();
		}
		static public void ExecuteNoReturnEditDistinction()
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.HasNoEffectiveParameters(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null);
		}

		static public T Execute<T>(Operation<T> operation)
		{
			if(Application.isPlaying)
				return operation();

			return ExecuteEditDistinction<T>();
		}
		static public T ExecuteEditDistinction<T>()
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.HasNoEffectiveParameters(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null);
		}

			
		static public void ExecuteNoReturn<P1>(Process<P1> process, P1 p1)
		{
			if(Application.isPlaying)
				process(p1);
			else
				ExecuteNoReturnEditDistinction<P1>(p1);
		}
		static public void ExecuteNoReturnEditDistinction<P1>(P1 p1)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1);
		}

		static public T Execute<T, P1>(Operation<T, P1> operation, P1 p1)
		{
			if(Application.isPlaying)
				return operation(p1);

			return ExecuteEditDistinction<T, P1>(p1);
		}
		static public T ExecuteEditDistinction<T, P1>(P1 p1)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1);
		}

			
		static public void ExecuteNoReturn<P1, P2>(Process<P1, P2> process, P1 p1, P2 p2)
		{
			if(Application.isPlaying)
				process(p1, p2);
			else
				ExecuteNoReturnEditDistinction<P1, P2>(p1, p2);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2>(P1 p1, P2 p2)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2);
		}

		static public T Execute<T, P1, P2>(Operation<T, P1, P2> operation, P1 p1, P2 p2)
		{
			if(Application.isPlaying)
				return operation(p1, p2);

			return ExecuteEditDistinction<T, P1, P2>(p1, p2);
		}
		static public T ExecuteEditDistinction<T, P1, P2>(P1 p1, P2 p2)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3>(Process<P1, P2, P3> process, P1 p1, P2 p2, P3 p3)
		{
			if(Application.isPlaying)
				process(p1, p2, p3);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3>(p1, p2, p3);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3>(P1 p1, P2 p2, P3 p3)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3);
		}

		static public T Execute<T, P1, P2, P3>(Operation<T, P1, P2, P3> operation, P1 p1, P2 p2, P3 p3)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3);

			return ExecuteEditDistinction<T, P1, P2, P3>(p1, p2, p3);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3>(P1 p1, P2 p2, P3 p3)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4>(Process<P1, P2, P3, P4> process, P1 p1, P2 p2, P3 p3, P4 p4)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4>(p1, p2, p3, p4);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4);
		}

		static public T Execute<T, P1, P2, P3, P4>(Operation<T, P1, P2, P3, P4> operation, P1 p1, P2 p2, P3 p3, P4 p4)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4);

			return ExecuteEditDistinction<T, P1, P2, P3, P4>(p1, p2, p3, p4);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4, P5>(Process<P1, P2, P3, P4, P5> process, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4, p5);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5>(p1, p2, p3, p4, p5);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5);
		}

		static public T Execute<T, P1, P2, P3, P4, P5>(Operation<T, P1, P2, P3, P4, P5> operation, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4, p5);

			return ExecuteEditDistinction<T, P1, P2, P3, P4, P5>(p1, p2, p3, p4, p5);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4, P5, P6>(Process<P1, P2, P3, P4, P5, P6> process, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4, p5, p6);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6>(p1, p2, p3, p4, p5, p6);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6);
		}

		static public T Execute<T, P1, P2, P3, P4, P5, P6>(Operation<T, P1, P2, P3, P4, P5, P6> operation, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4, p5, p6);

			return ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6>(p1, p2, p3, p4, p5, p6);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4, P5, P6, P7>(Process<P1, P2, P3, P4, P5, P6, P7> process, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4, p5, p6, p7);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7>(p1, p2, p3, p4, p5, p6, p7);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7);
		}

		static public T Execute<T, P1, P2, P3, P4, P5, P6, P7>(Operation<T, P1, P2, P3, P4, P5, P6, P7> operation, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4, p5, p6, p7);

			return ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7>(p1, p2, p3, p4, p5, p6, p7);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4, P5, P6, P7, P8>(Process<P1, P2, P3, P4, P5, P6, P7, P8> process, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4, p5, p6, p7, p8);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7, P8>(p1, p2, p3, p4, p5, p6, p7, p8);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7, p8);
		}

		static public T Execute<T, P1, P2, P3, P4, P5, P6, P7, P8>(Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> operation, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4, p5, p6, p7, p8);

			return ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7, P8>(p1, p2, p3, p4, p5, p6, p7, p8);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7, p8);
		}

			
		static public void ExecuteNoReturn<P1, P2, P3, P4, P5, P6, P7, P8, P9>(Process<P1, P2, P3, P4, P5, P6, P7, P8, P9> process, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
		{
			if(Application.isPlaying)
				process(p1, p2, p3, p4, p5, p6, p7, p8, p9);
			else
				ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7, P8, P9>(p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
		static public void ExecuteNoReturnEditDistinction<P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
		{
			MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8, P9>(),
				
				Filterer_MethodInfo.HasNoReturn()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}

		static public T Execute<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> operation, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
		{
			if(Application.isPlaying)
				return operation(p1, p2, p3, p4, p5, p6, p7, p8, p9);

			return ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
		static public T ExecuteEditDistinction<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
		{
			return (T)MarkedMethods<ATTRIBUTE_TYPE>.GetFilteredMarkedStaticMethods(
									Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8, P9>(),
				
				Filterer_MethodInfo.CanReturnInto<T>()
			).GetFirst().Invoke(null, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}

		}
}