using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{	
    public abstract partial class Problem
	{
        static public void Layer<P1>(Process process, Process<P1> process_p1) where P1 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
            }
        }
        static public R Layer<R, P1>(Operation<R> operation, Process<P1> process_p1) where P1 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
           }
            
           return result;
        }
        static public R Layer<R, P1>(Operation<R> operation, Operation<R, P1> operation_p1) where P1 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
            }
            
            return result;
        }

        static public void Layer<P1, P2>(Process process, Process<P1> process_p1, Process<P2> process_p2) where P1 : Problem where P2 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
            }
        }
        static public R Layer<R, P1, P2>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2) where P1 : Problem where P2 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2) where P1 : Problem where P2 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3) where P1 : Problem where P2 : Problem where P3 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
            }
        }
        static public R Layer<R, P1, P2, P3>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3) where P1 : Problem where P2 : Problem where P3 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3) where P1 : Problem where P2 : Problem where P3 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5, Operation<R, P6> operation_p6) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
				else if(problem6 != null){return operation_p6(problem6);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5, Operation<R, P6> operation_p6, Operation<R, P7> operation_p7) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
				else if(problem6 != null){return operation_p6(problem6);}
				else if(problem7 != null){return operation_p7(problem7);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5, Operation<R, P6> operation_p6, Operation<R, P7> operation_p7, Operation<R, P8> operation_p8) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
				else if(problem6 != null){return operation_p6(problem6);}
				else if(problem7 != null){return operation_p7(problem7);}
				else if(problem8 != null){return operation_p8(problem8);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8, P9>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
				else if(problem9 != null){process_p9(problem9);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
				else if(problem9 != null){process_p9(problem9);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5, Operation<R, P6> operation_p6, Operation<R, P7> operation_p7, Operation<R, P8> operation_p8, Operation<R, P9> operation_p9) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
				else if(problem6 != null){return operation_p6(problem6);}
				else if(problem7 != null){return operation_p7(problem7);}
				else if(problem8 != null){return operation_p8(problem8);}
				else if(problem9 != null){return operation_p9(problem9);}
            }
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9, Process<P10> process_p10) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem where P10 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;
			P10 problem10 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P10>()){ problem10 = creator() as P10; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
				else if(problem9 != null){process_p9(problem9);}
				else if(problem10 != null){process_p10(problem10);}
            }
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9, Process<P10> process_p10) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem where P10 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;
			P10 problem10 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P10>()){ problem10 = creator() as P10; has_problem = true; return true; }
                
                return false;
            });
            
           if(has_problem)
           {   
                if(problem1 != null){process_p1(problem1);}
				else if(problem2 != null){process_p2(problem2);}
				else if(problem3 != null){process_p3(problem3);}
				else if(problem4 != null){process_p4(problem4);}
				else if(problem5 != null){process_p5(problem5);}
				else if(problem6 != null){process_p6(problem6);}
				else if(problem7 != null){process_p7(problem7);}
				else if(problem8 != null){process_p8(problem8);}
				else if(problem9 != null){process_p9(problem9);}
				else if(problem10 != null){process_p10(problem10);}
           }
            
           return result;
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(Operation<R> operation, Operation<R, P1> operation_p1, Operation<R, P2> operation_p2, Operation<R, P3> operation_p3, Operation<R, P4> operation_p4, Operation<R, P5> operation_p5, Operation<R, P6> operation_p6, Operation<R, P7> operation_p7, Operation<R, P8> operation_p8, Operation<R, P9> operation_p9, Operation<R, P10> operation_p10) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem where P10 : Problem
        {
            bool has_problem = false;
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;
			P9 problem9 = null;
			P10 problem10 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>()){ problem1 = creator() as P1; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P2>()){ problem2 = creator() as P2; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P3>()){ problem3 = creator() as P3; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P4>()){ problem4 = creator() as P4; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P5>()){ problem5 = creator() as P5; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P6>()){ problem6 = creator() as P6; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P7>()){ problem7 = creator() as P7; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P8>()){ problem8 = creator() as P8; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P9>()){ problem9 = creator() as P9; has_problem = true; return true; }
				else if(type.CanBeTreatedAs<P10>()){ problem10 = creator() as P10; has_problem = true; return true; }
                
                return false;
            });
            
            if(has_problem)
            {
                if(problem1 != null){return operation_p1(problem1);}
				else if(problem2 != null){return operation_p2(problem2);}
				else if(problem3 != null){return operation_p3(problem3);}
				else if(problem4 != null){return operation_p4(problem4);}
				else if(problem5 != null){return operation_p5(problem5);}
				else if(problem6 != null){return operation_p6(problem6);}
				else if(problem7 != null){return operation_p7(problem7);}
				else if(problem8 != null){return operation_p8(problem8);}
				else if(problem9 != null){return operation_p9(problem9);}
				else if(problem10 != null){return operation_p10(problem10);}
            }
            
            return result;
        }

    }
}

