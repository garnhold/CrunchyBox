using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	
	public class InvoketoidInvoker : InvoketoidInvokerBase
    {
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
							});
		}
	}
	
	public class InvoketoidInvoker<P1> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5, P6> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
			[SerializeFieldEX]private P6 p6;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
									p6,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5, P6, P7> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
			[SerializeFieldEX]private P6 p6;
			[SerializeFieldEX]private P7 p7;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
									p6,
									p7,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5, P6, P7, P8> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
			[SerializeFieldEX]private P6 p6;
			[SerializeFieldEX]private P7 p7;
			[SerializeFieldEX]private P8 p8;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
									p6,
									p7,
									p8,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5, P6, P7, P8, P9> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
			[SerializeFieldEX]private P6 p6;
			[SerializeFieldEX]private P7 p7;
			[SerializeFieldEX]private P8 p8;
			[SerializeFieldEX]private P9 p9;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
									p6,
									p7,
									p8,
									p9,
							});
		}
	}
	
	public class InvoketoidInvoker<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : InvoketoidInvokerBase
    {
			[SerializeFieldEX]private P1 p1;
			[SerializeFieldEX]private P2 p2;
			[SerializeFieldEX]private P3 p3;
			[SerializeFieldEX]private P4 p4;
			[SerializeFieldEX]private P5 p5;
			[SerializeFieldEX]private P6 p6;
			[SerializeFieldEX]private P7 p7;
			[SerializeFieldEX]private P8 p8;
			[SerializeFieldEX]private P9 p9;
			[SerializeFieldEX]private P10 p10;
	
		public override object Invoke(object obj, MethodInfo method)
		{
			return method.Invoke(obj, new object[] {
									p1,
									p2,
									p3,
									p4,
									p5,
									p6,
									p7,
									p8,
									p9,
									p10,
							});
		}
	}
}
