using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public partial class MarkedMethods<T> where T : Attribute
	{      
		
			static public void InvokeFilteredMarkedStaticMethods()
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold()
                ).Process(m => m.Invoke(null, new object[] {  }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1>(P1 p1)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1>()
                ).Process(m => m.Invoke(null, new object[] { p1 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2>(P1 p1, P2 p2)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3>(P1 p1, P2 p2, P3 p3)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4, p5 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4, p5, p6 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4, p5, p6, p7 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4, p5, p6, p7, p8 }));
			}
		
			static public void InvokeFilteredMarkedStaticMethods<P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
                GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.CanEffectiveParametersHold<P1, P2, P3, P4, P5, P6, P7, P8, P9>()
                ).Process(m => m.Invoke(null, new object[] { p1, p2, p3, p4, p5, p6, p7, p8, p9 }));
			}
			}
}