using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    	
    public class RepresentationConstructor_Operation<T> : RepresentationConstructor
	{
		private Operation<T> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
			
			
			return operation();
        }

        public RepresentationConstructor_Operation(string n, Operation<T> o) : base(n)
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T>(this RepresentationEngine item, string n, Operation<T> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T>(n, o));
		}
        static public void AddSimpleConstructor<T>(this RepresentationEngine item, Operation<T> o)
        {
            item.AddSimpleConstructor<T>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1> : RepresentationConstructor
	{
		private Operation<T, P1> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
			
							arguments.PartOut(out obj1);
			
			return operation(obj1.ConvertEX<P1 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1> o) : base(n, typeof(P1))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1>(this RepresentationEngine item, string n, Operation<T, P1> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1>(n, o));
		}
        static public void AddSimpleConstructor<T, P1>(this RepresentationEngine item, Operation<T, P1> o)
        {
            item.AddSimpleConstructor<T, P1>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2> : RepresentationConstructor
	{
		private Operation<T, P1, P2> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
			
							arguments.PartOut(out obj1, out obj2);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2> o) : base(n, typeof(P1), typeof(P2))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2>(this RepresentationEngine item, string n, Operation<T, P1, P2> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2>(this RepresentationEngine item, Operation<T, P1, P2> o)
        {
            item.AddSimpleConstructor<T, P1, P2>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
			
							arguments.PartOut(out obj1, out obj2, out obj3);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3> o) : base(n, typeof(P1), typeof(P2), typeof(P3))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3>(this RepresentationEngine item, Operation<T, P1, P2, P3> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5, P6> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >(), obj6.ConvertEX<P6 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5, P6> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5, P6> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
							object obj7;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6, out obj7);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >(), obj6.ConvertEX<P6 >(), obj7.ConvertEX<P7 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
							object obj7;
							object obj8;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6, out obj7, out obj8);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >(), obj6.ConvertEX<P6 >(), obj7.ConvertEX<P7 >(), obj8.ConvertEX<P8 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
							object obj7;
							object obj8;
							object obj9;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6, out obj7, out obj8, out obj9);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >(), obj6.ConvertEX<P6 >(), obj7.ConvertEX<P7 >(), obj8.ConvertEX<P8 >(), obj9.ConvertEX<P9 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(typeof(T).Name, o);
        }
	}
	
    public class RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : RepresentationConstructor
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> operation;

		public override object Invoke(CmlContext context, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
							object obj7;
							object obj8;
							object obj9;
							object obj10;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6, out obj7, out obj8, out obj9, out obj10);
			
			return operation(obj1.ConvertEX<P1 >(), obj2.ConvertEX<P2 >(), obj3.ConvertEX<P3 >(), obj4.ConvertEX<P4 >(), obj5.ConvertEX<P5 >(), obj6.ConvertEX<P6 >(), obj7.ConvertEX<P7 >(), obj8.ConvertEX<P8 >(), obj9.ConvertEX<P9 >(), obj10.ConvertEX<P10 >());
        }

        public RepresentationConstructor_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : base(n, typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9), typeof(P10))
		{
			operation = o;
		}
    }
	static public partial class RepresentationEngineExtensions_Add
	{
		static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(this RepresentationEngine item, string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
		{
            item.AddConstructor(new RepresentationConstructor_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(n, o));
		}
        static public void AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(this RepresentationEngine item, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
        {
            item.AddSimpleConstructor<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(typeof(T).Name, o);
        }
	}
}