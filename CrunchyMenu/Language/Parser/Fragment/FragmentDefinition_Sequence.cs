using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{

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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, Operation<T, P1> o) : this(n)
                {
                    Initialize(f1, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, Operation<T, P1> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, o));

                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, Operation<T, P1> o) : base(null)
                    {
                            fragment1 = f1;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1>(string n, FragmentDefinition<P1> f1, Operation<T, P1> o)
                {
                    return new FragmentDefinition_Sequence<T, P1>(n, f1, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1>(FragmentDefinition<P1> f1, Operation<T, P1> o)
                {
                    return Sequence(null, f1, o);
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o) : this(n)
                {
                    Initialize(f1, f2, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, o));

                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o) : base(null)
                    {
                            fragment1 = f1;
                            fragment2 = f2;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2>(n, f1, f2, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, Operation<T, P1, P2> o)
                {
                    return Sequence(null, f1, f2, o);
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o) : this(n)
                {
                    Initialize(f1, f2, f3, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, o));

                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o) : base(null)
                    {
                            fragment1 = f1;
                            fragment2 = f2;
                            fragment3 = f3;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3>(n, f1, f2, f3, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, Operation<T, P1, P2, P3> o)
                {
                    return Sequence(null, f1, f2, f3, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, o));

                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
                {
                    private Operation<T, P1, P2, P3, P4> producer_operation;            
        
                        private FragmentDefinition<P1> fragment1;
                        private FragmentDefinition<P2> fragment2;
                        private FragmentDefinition<P3> fragment3;
                        private FragmentDefinition<P4> fragment4;

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
                            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                                return false;                        
                        
                        producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4());
                        return true;
                    }
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o) : base(null)
                    {
                            fragment1 = f1;
                            fragment2 = f2;
                            fragment3 = f3;
                            fragment4 = f4;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4>(n, f1, f2, f3, f4, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, Operation<T, P1, P2, P3, P4> o)
                {
                    return Sequence(null, f1, f2, f3, f4, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, o));

                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
                {
                    private Operation<T, P1, P2, P3, P4, P5> producer_operation;            
        
                        private FragmentDefinition<P1> fragment1;
                        private FragmentDefinition<P2> fragment2;
                        private FragmentDefinition<P3> fragment3;
                        private FragmentDefinition<P4> fragment4;
                        private FragmentDefinition<P5> fragment5;

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
                            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                                return false;                        
                            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                                return false;                        
                        
                        producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5());
                        return true;
                    }
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o) : base(null)
                    {
                            fragment1 = f1;
                            fragment2 = f2;
                            fragment3 = f3;
                            fragment4 = f4;
                            fragment5 = f5;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5>(n, f1, f2, f3, f4, f5, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, Operation<T, P1, P2, P3, P4, P5> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, f6, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P6> i6 in f6.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, i6, o));

                        }
                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
                {
                    private Operation<T, P1, P2, P3, P4, P5, P6> producer_operation;            
        
                        private FragmentDefinition<P1> fragment1;
                        private FragmentDefinition<P2> fragment2;
                        private FragmentDefinition<P3> fragment3;
                        private FragmentDefinition<P4> fragment4;
                        private FragmentDefinition<P5> fragment5;
                        private FragmentDefinition<P6> fragment6;

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
                            if(fragment4.Consume(tokens, new_index, out new_index, out Operation<P4> sub_producer4) == false)
                                return false;                        
                            if(fragment5.Consume(tokens, new_index, out new_index, out Operation<P5> sub_producer5) == false)
                                return false;                        
                            if(fragment6.Consume(tokens, new_index, out new_index, out Operation<P6> sub_producer6) == false)
                                return false;                        
                        
                        producer = () => producer_operation(sub_producer1(), sub_producer2(), sub_producer3(), sub_producer4(), sub_producer5(), sub_producer6());
                        return true;
                    }
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o) : base(null)
                    {
                            fragment1 = f1;
                            fragment2 = f2;
                            fragment3 = f3;
                            fragment4 = f4;
                            fragment5 = f5;
                            fragment6 = f6;
                
                        producer_operation = o;
                    }
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                            if(fragment6.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + fragment6.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6>(n, f1, f2, f3, f4, f5, f6, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, Operation<T, P1, P2, P3, P4, P5, P6> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, f6, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, f6, f7, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P6> i6 in f6.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P7> i7 in f7.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, i6, i7, o));

                        }
                        }
                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
                {
                    private Operation<T, P1, P2, P3, P4, P5, P6, P7> producer_operation;            
        
                        private FragmentDefinition<P1> fragment1;
                        private FragmentDefinition<P2> fragment2;
                        private FragmentDefinition<P3> fragment3;
                        private FragmentDefinition<P4> fragment4;
                        private FragmentDefinition<P5> fragment5;
                        private FragmentDefinition<P6> fragment6;
                        private FragmentDefinition<P7> fragment7;

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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o) : base(null)
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
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                            if(fragment6.CanConsumeNone())
                            if(fragment7.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + fragment6.GetPsuedoRegEx() + fragment7.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7>(n, f1, f2, f3, f4, f5, f6, f7, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, Operation<T, P1, P2, P3, P4, P5, P6, P7> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, f6, f7, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, f6, f7, f8, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P6> i6 in f6.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P7> i7 in f7.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P8> i8 in f8.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, i6, i7, i8, o));

                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o) : base(null)
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
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                            if(fragment6.CanConsumeNone())
                            if(fragment7.CanConsumeNone())
                            if(fragment8.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + fragment6.GetPsuedoRegEx() + fragment7.GetPsuedoRegEx() + fragment8.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8>(n, f1, f2, f3, f4, f5, f6, f7, f8, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, f6, f7, f8, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P6> i6 in f6.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P7> i7 in f7.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P8> i8 in f8.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P9> i9 in f9.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, i6, i7, i8, i9, o));

                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o) : base(null)
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
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                            if(fragment6.CanConsumeNone())
                            if(fragment7.CanConsumeNone())
                            if(fragment8.CanConsumeNone())
                            if(fragment9.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + fragment6.GetPsuedoRegEx() + fragment7.GetPsuedoRegEx() + fragment8.GetPsuedoRegEx() + fragment9.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(n, f1, f2, f3, f4, f5, f6, f7, f8, f9, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, f6, f7, f8, f9, o);
                }
            }

            public class FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> : FragmentDefinition<T>
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

                public FragmentDefinition_Sequence(string n) : base(n)
                {
                    sub_sequences = new List<FragmentDefinition<T>>();
                }
                
                public FragmentDefinition_Sequence(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : this(n)
                {
                    Initialize(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, o);
                }
                
                public void Initialize(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
                {
                    int count = 0;
                    sub_sequences.Clear();
                    
                        foreach(FragmentDefinition<P1> i1 in f1.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P2> i2 in f2.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P3> i3 in f3.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P4> i4 in f4.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P5> i5 in f5.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P6> i6 in f6.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P7> i7 in f7.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P8> i8 in f8.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P9> i9 in f9.GetSubAlternatives())
                        {
                        foreach(FragmentDefinition<P10> i10 in f10.GetSubAlternatives())
                        {

                            sub_sequences.Add(new FragmentDefinition_SubSequence(i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, o));

                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                        }
                }
                
                public override bool CanConsumeNone()
                {
                    if(sub_sequences.Has(s => s.CanConsumeNone()))
                        return true;
                        
                    return false;
                }
                
                public override string GetPsuedoRegEx()
                {
                    return sub_sequences.GetFirst().GetPsuedoRegEx();
                }
                
                private class FragmentDefinition_SubSequence : FragmentDefinition<T>
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
                    
                    public FragmentDefinition_SubSequence(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o) : base(null)
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
                    
                    public override bool CanConsumeNone()
                    {
                            if(fragment1.CanConsumeNone())
                            if(fragment2.CanConsumeNone())
                            if(fragment3.CanConsumeNone())
                            if(fragment4.CanConsumeNone())
                            if(fragment5.CanConsumeNone())
                            if(fragment6.CanConsumeNone())
                            if(fragment7.CanConsumeNone())
                            if(fragment8.CanConsumeNone())
                            if(fragment9.CanConsumeNone())
                            if(fragment10.CanConsumeNone())
                                return true;
                                
                        return false;
                    }
                    
                    public override string GetPsuedoRegEx()
                    {
                        return "(" + fragment1.GetPsuedoRegEx() + fragment2.GetPsuedoRegEx() + fragment3.GetPsuedoRegEx() + fragment4.GetPsuedoRegEx() + fragment5.GetPsuedoRegEx() + fragment6.GetPsuedoRegEx() + fragment7.GetPsuedoRegEx() + fragment8.GetPsuedoRegEx() + fragment9.GetPsuedoRegEx() + fragment10.GetPsuedoRegEx() + ")";
                    }
                }
            }
            static public partial class FragmentDefinitions
            {
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(string n, FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
                {
                    return new FragmentDefinition_Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(n, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, o);
                }
                static public FragmentDefinition<T> Sequence<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(FragmentDefinition<P1> f1, FragmentDefinition<P2> f2, FragmentDefinition<P3> f3, FragmentDefinition<P4> f4, FragmentDefinition<P5> f5, FragmentDefinition<P6> f6, FragmentDefinition<P7> f7, FragmentDefinition<P8> f8, FragmentDefinition<P9> f9, FragmentDefinition<P10> f10, Operation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> o)
                {
                    return Sequence(null, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, o);
                }
            }
}

