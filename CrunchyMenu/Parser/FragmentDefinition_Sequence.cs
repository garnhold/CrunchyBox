using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
 
    
    public class FragmentDefinitionVoid_Sequence<P1> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1) : this()
        {
            Initialize(f1);
        }
        
        public void Initialize(FragmentDefinition<P1> f1)
        {
            fragment1 = f1;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2) : this()
        {
            Initialize(f1, f2);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2)
        {
            fragment1 = f1;
            fragment2 = f2;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3) : this()
        {
            Initialize(f1, f2, f3);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4) : this()
        {
            Initialize(f1, f2, f3, f4);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5) : this()
        {
            Initialize(f1, f2, f3, f4, f5);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5, P6> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5, P6, P7> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5, P6, P7, P8> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5, P6, P7, P8, P9> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;
        private FragmentDefinition<P9> fragment9;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
            fragment9 = f9;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            if(fragment9.Consume(tokens, new_index, out new_index, out Operation<P9> sub_producer9) == false)
                return false;                        
            
            
            return true;
        }
    }
    
    public class FragmentDefinitionVoid_Sequence<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : FragmentDefinitionVoid
    {
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;
        private FragmentDefinition<P9> fragment9;
        private FragmentDefinition<P10> fragment10;

        public FragmentDefinitionVoid_Sequence()
        {
        }
        
        
        public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
            fragment9 = f9;
            fragment10 = f10;
    
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            new_index = index;
            
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            if(fragment9.Consume(tokens, new_index, out new_index, out Operation<P9> sub_producer9) == false)
                return false;                        
            
            if(fragment10.Consume(tokens, new_index, out new_index, out Operation<P10> sub_producer10) == false)
                return false;                        
            
            
            return true;
        }
    }
 
    
    public class FragmentDefinition_Sequence<T, P1> : FragmentDefinition<T>
    {
        private Operation<T, P1> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, Operation<T, P1> o) : this()
        {
            Initialize(f1, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, Operation<T, P1> o)
        {
            fragment1 = f1;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o) : this()
        {
            Initialize(f1, f2, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
        {
            fragment1 = f1;
            fragment2 = f2;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o) : this()
        {
            Initialize(f1, f2, f3, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o) : this()
        {
            Initialize(f1, f2, f3, f4, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5, P6> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5, P6> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5, P6, P7> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6(), sub_producer7());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6(), sub_producer7(), sub_producer8());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;
        private FragmentDefinition<P9> fragment9;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
            fragment9 = f9;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            if(fragment9.Consume(tokens, new_index, out new_index, out Operation<P9> sub_producer9) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6(), sub_producer7(), sub_producer8(), sub_producer9());
            
            return true;
        }
    }
    
    public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : FragmentDefinition<T>
    {
        private Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> producer_operation;            
    
        private FragmentDefinition<P1> fragment1;
        private FragmentDefinition<P2> fragment2;
        private FragmentDefinition<P3> fragment3;
        private FragmentDefinition<P4> fragment4;
        private FragmentDefinition<P5> fragment5;
        private FragmentDefinition<P6> fragment6;
        private FragmentDefinition<P7> fragment7;
        private FragmentDefinition<P8> fragment8;
        private FragmentDefinition<P9> fragment9;
        private FragmentDefinition<P10> fragment10;

        public FragmentDefinition_Sequence()
        {
        }
        
        public FragmentDefinition_Sequence(Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : this()
        {
            producer_operation = o;
        }
        
        public FragmentDefinition_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : this()
        {
            Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, o);
        }
        
        public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
        {
            fragment1 = f1;
            fragment2 = f2;
            fragment3 = f3;
            fragment4 = f4;
            fragment5 = f5;
            fragment6 = f6;
            fragment7 = f7;
            fragment8 = f8;
            fragment9 = f9;
            fragment10 = f10;
    
            producer_operation = o;
        }

        public override bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            new_index = index;
            producer = null;
            
            
            if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                return false;                        
            
            if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                return false;                        
            
            if(fragment3.Consume(tokens, new_index, out new_index, out Operation<P3> sub_producer3) == false)
                return false;                        
            
            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                return false;                        
            
            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                return false;                        
            
            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                return false;                        
            
            if(fragment7.Consume(tokens, new_index, out new_index, out Operation<P7> sub_producer7) == false)
                return false;                        
            
            if(fragment8.Consume(tokens, new_index, out new_index, out Operation<P8> sub_producer8) == false)
                return false;                        
            
            if(fragment9.Consume(tokens, new_index, out new_index, out Operation<P9> sub_producer9) == false)
                return false;                        
            
            if(fragment10.Consume(tokens, new_index, out new_index, out Operation<P10> sub_producer10) == false)
                return false;                        
            
            
            producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6(), sub_producer7(), sub_producer8(), sub_producer9(), sub_producer10());
            
            return true;
        }
    }
}

