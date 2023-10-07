using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
 

            public class FragmentDefinitionVoid_SubSequence<P1> : FragmentDefinitionVoid
            {
    
                    private FragmentDefinition<P1> fragment1;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
                {
                    new_index = index;
                    
                    
                        if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                            return false;                        
                    
            
                    return true;
                }

                public FragmentDefinitionVoid_SubSequence()
                {
                }
                
                
                public FragmentDefinitionVoid_SubSequence(FragmentDefinition<P1> f1) : this()
                {
                    Initialize(f1);
                }
                
                public void Initialize(FragmentDefinition<P1> f1)
                {
                        fragment1 = f1;
            
                }
            }
            public class FragmentDefinitionVoid_Sequence<P1> : FragmentDefinitionVoid
            {
                private List<FragmentDefinitionVoid> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
                {
                    int best_index = -1;
                    

                    foreach (FragmentDefinitionVoid sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                        return true;
                    }

                    new_index = -1;
                    return false;
                }

                public FragmentDefinitionVoid_Sequence()
                {
                    sub_sequences = new List<FragmentDefinitionVoid>();
                }
                
                
                public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1) : this()
                {
                    Initialize(f1);
                }
                
                public void Initialize(FragmentDefinition<P1> f1)
                {
                    FragmentDefinitionVoid_SubSequence<P1> full = new FragmentDefinitionVoid_SubSequence<P1>(f1);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinitionVoid Sequence<P1>(FragmentDefinition<P1> f1)
                {
                    return new FragmentDefinitionVoid_Sequence<P1>(f1);
                }
            }

            public class FragmentDefinitionVoid_SubSequence<P1, P2> : FragmentDefinitionVoid
            {
    
                    private FragmentDefinition<P1> fragment1;
                    private FragmentDefinition<P2> fragment2;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
                {
                    new_index = index;
                    
                    
                        if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                            return false;                        
                        if(fragment2.Consume(tokens, new_index, out new_index, out Operation<P2> sub_producer2) == false)
                            return false;                        
                    
            
                    return true;
                }

                public FragmentDefinitionVoid_SubSequence()
                {
                }
                
                
                public FragmentDefinitionVoid_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2) : this()
                {
                    Initialize(f1, f2);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2)
                {
                        fragment1 = f1;
                        fragment2 = f2;
            
                }
            }
            public class FragmentDefinitionVoid_Sequence<P1, P2> : FragmentDefinitionVoid
            {
                private List<FragmentDefinitionVoid> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
                {
                    int best_index = -1;
                    

                    foreach (FragmentDefinitionVoid sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                        return true;
                    }

                    new_index = -1;
                    return false;
                }

                public FragmentDefinitionVoid_Sequence()
                {
                    sub_sequences = new List<FragmentDefinitionVoid>();
                }
                
                
                public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2) : this()
                {
                    Initialize(f1, f2);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2)
                {
                    FragmentDefinitionVoid_SubSequence<P1, P2> full = new FragmentDefinitionVoid_SubSequence<P1, P2>(f1, f2);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinitionVoid Sequence<P1, P2>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2)
                {
                    return new FragmentDefinitionVoid_Sequence<P1, P2>(f1, f2);
                }
            }

            public class FragmentDefinitionVoid_SubSequence<P1, P2, P3> : FragmentDefinitionVoid
            {
    
                    private FragmentDefinition<P1> fragment1;
                    private FragmentDefinition<P2> fragment2;
                    private FragmentDefinition<P3> fragment3;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
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

                public FragmentDefinitionVoid_SubSequence()
                {
                }
                
                
                public FragmentDefinitionVoid_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3) : this()
                {
                    Initialize(f1, f2, f3);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3)
                {
                        fragment1 = f1;
                        fragment2 = f2;
                        fragment3 = f3;
            
                }
            }
            public class FragmentDefinitionVoid_Sequence<P1, P2, P3> : FragmentDefinitionVoid
            {
                private List<FragmentDefinitionVoid> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index)
                {
                    int best_index = -1;
                    

                    foreach (FragmentDefinitionVoid sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                        return true;
                    }

                    new_index = -1;
                    return false;
                }

                public FragmentDefinitionVoid_Sequence()
                {
                    sub_sequences = new List<FragmentDefinitionVoid>();
                }
                
                
                public FragmentDefinitionVoid_Sequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3) : this()
                {
                    Initialize(f1, f2, f3);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3)
                {
                    FragmentDefinitionVoid_SubSequence<P1, P2, P3> full = new FragmentDefinitionVoid_SubSequence<P1, P2, P3>(f1, f2, f3);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinitionVoid Sequence<P1, P2, P3>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3)
                {
                    return new FragmentDefinitionVoid_Sequence<P1, P2, P3>(f1, f2, f3);
                }
            }
 

            public class FragmentDefinition_SubSequence<T, P1> : FragmentDefinition<T>
            {
                    private Operation<T, P1> producer_operation;            
    
                    private FragmentDefinition<P1> fragment1;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
                {
                    new_index = index;
                    producer = null;
                    
                        if(fragment1.Consume(tokens, new_index, out new_index, out Operation<P1> sub_producer1) == false)
                            return false;                        
                    
            
                        producer = () => producer_operation(sub_producer1());
            
                    return true;
                }

                public FragmentDefinition_SubSequence()
                {
                }
                
                    public FragmentDefinition_SubSequence(Operation<T, P1> o) : this()
                    {
                        producer_operation = o;
                    }
                
                public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, Operation<T, P1> o) : this()
                {
                    Initialize(f1, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, Operation<T, P1> o)
                {
                        fragment1 = f1;
            
                        producer_operation = o;
                }
            }
            public class FragmentDefinition_Sequence<T, P1> : FragmentDefinition<T>
            {
                private List<FragmentDefinition<T>> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
                {
                    int best_index = -1;
                    
                        Operation<T> best_producer = null;

                    foreach (FragmentDefinition<T> sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index, out producer))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                                    best_producer = producer;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                            producer = best_producer;
                        return true;
                    }

                    new_index = -1;
                        producer = null;
                    return false;
                }

                public FragmentDefinition_Sequence()
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
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
                    FragmentDefinition_SubSequence<T, P1> full = new FragmentDefinition_SubSequence<T, P1>(f1, o);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1>(FragmentDefinition<P1> f1, Operation<T, P1> o)
                {
                    return new FragmentDefinition_Sequence<T, P1>(f1, o);
                }
            }

            public class FragmentDefinition_SubSequence<T, P1, P2> : FragmentDefinition<T>
            {
                    private Operation<T, P1, P2> producer_operation;            
    
                    private FragmentDefinition<P1> fragment1;
                    private FragmentDefinition<P2> fragment2;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
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

                public FragmentDefinition_SubSequence()
                {
                }
                
                    public FragmentDefinition_SubSequence(Operation<T, P1, P2> o) : this()
                    {
                        producer_operation = o;
                    }
                
                public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o) : this()
                {
                    Initialize(f1, f2, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
                {
                        fragment1 = f1;
                        fragment2 = f2;
            
                        producer_operation = o;
                }
            }
            public class FragmentDefinition_Sequence<T, P1, P2> : FragmentDefinition<T>
            {
                private List<FragmentDefinition<T>> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
                {
                    int best_index = -1;
                    
                        Operation<T> best_producer = null;

                    foreach (FragmentDefinition<T> sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index, out producer))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                                    best_producer = producer;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                            producer = best_producer;
                        return true;
                    }

                    new_index = -1;
                        producer = null;
                    return false;
                }

                public FragmentDefinition_Sequence()
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
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
                    FragmentDefinition_SubSequence<T, P1, P2> full = new FragmentDefinition_SubSequence<T, P1, P2>(f1, f2, o);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2>(f1, f2, o);
                }
            }

            public class FragmentDefinition_SubSequence<T, P1, P2, P3> : FragmentDefinition<T>
            {
                    private Operation<T, P1, P2, P3> producer_operation;            
    
                    private FragmentDefinition<P1> fragment1;
                    private FragmentDefinition<P2> fragment2;
                    private FragmentDefinition<P3> fragment3;

                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
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

                public FragmentDefinition_SubSequence()
                {
                }
                
                    public FragmentDefinition_SubSequence(Operation<T, P1, P2, P3> o) : this()
                    {
                        producer_operation = o;
                    }
                
                public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o) : this()
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
            }
            public class FragmentDefinition_Sequence<T, P1, P2, P3> : FragmentDefinition<T>
            {
                private List<FragmentDefinition<T>> sub_sequences;
                
                protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
                {
                    int best_index = -1;
                    
                        Operation<T> best_producer = null;

                    foreach (FragmentDefinition<T> sub_sequence in sub_sequences)
                    {
                        if (sub_sequence.Consume(tokens, index, out new_index, out producer))
                        {
                            if (new_index >= best_index)
                            {
                                best_index = new_index;
                                    best_producer = producer;
                            }
                        }
                    }

                    if (best_index != -1)
                    {
                        new_index = best_index;
                            producer = best_producer;
                        return true;
                    }

                    new_index = -1;
                        producer = null;
                    return false;
                }

                public FragmentDefinition_Sequence()
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
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
                    FragmentDefinition_SubSequence<T, P1, P2, P3> full = new FragmentDefinition_SubSequence<T, P1, P2, P3>(f1, f2, f3, o);
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3>(f1, f2, f3, o);
                }
            }
}

