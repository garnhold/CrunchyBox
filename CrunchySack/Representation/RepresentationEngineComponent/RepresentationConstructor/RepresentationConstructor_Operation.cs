using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
	
    public class RepresentationConstructor_Simple_Operation<T> : RepresentationConstructor_Simple
	{
		private Operation<T> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
			
			
			return operation();
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T> o) : base(n, 0)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T>(string n, Operation<T> o)
		{
			return new RepresentationConstructor_Simple_Operation<T>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1> : RepresentationConstructor_Simple
	{
		private Operation<T, P1> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
			
							arguments.PartOut(out obj1);
			
			return operation(obj1.ConvertEX<P1>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1> o) : base(n, 1)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1>(string n, Operation<T, P1> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
			
							arguments.PartOut(out obj1, out obj2);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2> o) : base(n, 2)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2>(string n, Operation<T, P1, P2> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
			
							arguments.PartOut(out obj1, out obj2, out obj3);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3> o) : base(n, 3)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3>(string n, Operation<T, P1, P2, P3> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4> o) : base(n, 4)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4>(string n, Operation<T, P1, P2, P3, P4> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5> o) : base(n, 5)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5>(string n, Operation<T, P1, P2, P3, P4, P5> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5, P6> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>(), obj6.ConvertEX<P6>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6> o) : base(n, 6)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5, P6>(string n, Operation<T, P1, P2, P3, P4, P5, P6> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
        {
							object obj1;
							object obj2;
							object obj3;
							object obj4;
							object obj5;
							object obj6;
							object obj7;
			
							arguments.PartOut(out obj1, out obj2, out obj3, out obj4, out obj5, out obj6, out obj7);
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>(), obj6.ConvertEX<P6>(), obj7.ConvertEX<P7>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : base(n, 7)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5, P6, P7>(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
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
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>(), obj6.ConvertEX<P6>(), obj7.ConvertEX<P7>(), obj8.ConvertEX<P8>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : base(n, 8)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5, P6, P7, P8>(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
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
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>(), obj6.ConvertEX<P6>(), obj7.ConvertEX<P7>(), obj8.ConvertEX<P8>(), obj9.ConvertEX<P9>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : base(n, 9)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(n, o);
		}
	}
	
    public class RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : RepresentationConstructor_Simple
	{
		private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> operation;

		protected override object Instance(CmlExecution execution, IEnumerable<object> arguments)
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
			
			return operation(obj1.ConvertEX<P1>(), obj2.ConvertEX<P2>(), obj3.ConvertEX<P3>(), obj4.ConvertEX<P4>(), obj5.ConvertEX<P5>(), obj6.ConvertEX<P6>(), obj7.ConvertEX<P7>(), obj8.ConvertEX<P8>(), obj9.ConvertEX<P9>(), obj10.ConvertEX<P10>());
        }

        public RepresentationConstructor_Simple_Operation(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : base(n, 10)
		{
			operation = o;
		}
    }
	public partial class RepresentationConstructors
	{
		static public RepresentationConstructor Simple<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(string n, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
		{
			return new RepresentationConstructor_Simple_Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(n, o);
		}
	}
}