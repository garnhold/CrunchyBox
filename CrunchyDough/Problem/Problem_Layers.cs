using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{	
    public abstract partial class Problem
	{
        static public void Layer<P1>(Process process, Process<P1> process_p1) where P1 : Problem
        {
            P1 problem1 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
            });
               
            if(problem1 != null)
				process_p1(problem1);
        }
        static public R Layer<R, P1>(Operation<R> operation, Process<P1> process_p1) where P1 : Problem
        {
            P1 problem1 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
            });
               
            if(problem1 != null)
				process_p1(problem1);
            
            return result;
        }

        static public void Layer<P1, P2>(Process process, Process<P1> process_p1, Process<P2> process_p2) where P1 : Problem where P2 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
        }
        static public R Layer<R, P1, P2>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2) where P1 : Problem where P2 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
            
            return result;
        }

        static public void Layer<P1, P2, P3>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3) where P1 : Problem where P2 : Problem where P3 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
        }
        static public R Layer<R, P1, P2, P3>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3) where P1 : Problem where P2 : Problem where P3 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
        }
        static public R Layer<R, P1, P2, P3, P4>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
        }
        static public R Layer<R, P1, P2, P3, P4, P5>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;

            ProblemManager.GetInstance().Layer(process, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem
        {
            P1 problem1 = null;
			P2 problem2 = null;
			P3 problem3 = null;
			P4 problem4 = null;
			P5 problem5 = null;
			P6 problem6 = null;
			P7 problem7 = null;
			P8 problem8 = null;

            R result = ProblemManager.GetInstance().Layer(operation, (type, creator) => {
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8, P9>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem
        {
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
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
				else if(type.CanBeTreatedAs<P9>())
					problem9 = creator() as P9;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
			else if(problem9 != null)
				process_p9(problem9);
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem
        {
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
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
				else if(type.CanBeTreatedAs<P9>())
					problem9 = creator() as P9;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
			else if(problem9 != null)
				process_p9(problem9);
            
            return result;
        }

        static public void Layer<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(Process process, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9, Process<P10> process_p10) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem where P10 : Problem
        {
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
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
				else if(type.CanBeTreatedAs<P9>())
					problem9 = creator() as P9;
				else if(type.CanBeTreatedAs<P10>())
					problem10 = creator() as P10;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
			else if(problem9 != null)
				process_p9(problem9);
			else if(problem10 != null)
				process_p10(problem10);
        }
        static public R Layer<R, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(Operation<R> operation, Process<P1> process_p1, Process<P2> process_p2, Process<P3> process_p3, Process<P4> process_p4, Process<P5> process_p5, Process<P6> process_p6, Process<P7> process_p7, Process<P8> process_p8, Process<P9> process_p9, Process<P10> process_p10) where P1 : Problem where P2 : Problem where P3 : Problem where P4 : Problem where P5 : Problem where P6 : Problem where P7 : Problem where P8 : Problem where P9 : Problem where P10 : Problem
        {
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
                if(type.CanBeTreatedAs<P1>())
					problem1 = creator() as P1;
				else if(type.CanBeTreatedAs<P2>())
					problem2 = creator() as P2;
				else if(type.CanBeTreatedAs<P3>())
					problem3 = creator() as P3;
				else if(type.CanBeTreatedAs<P4>())
					problem4 = creator() as P4;
				else if(type.CanBeTreatedAs<P5>())
					problem5 = creator() as P5;
				else if(type.CanBeTreatedAs<P6>())
					problem6 = creator() as P6;
				else if(type.CanBeTreatedAs<P7>())
					problem7 = creator() as P7;
				else if(type.CanBeTreatedAs<P8>())
					problem8 = creator() as P8;
				else if(type.CanBeTreatedAs<P9>())
					problem9 = creator() as P9;
				else if(type.CanBeTreatedAs<P10>())
					problem10 = creator() as P10;
            });
               
            if(problem1 != null)
				process_p1(problem1);
			else if(problem2 != null)
				process_p2(problem2);
			else if(problem3 != null)
				process_p3(problem3);
			else if(problem4 != null)
				process_p4(problem4);
			else if(problem5 != null)
				process_p5(problem5);
			else if(problem6 != null)
				process_p6(problem6);
			else if(problem7 != null)
				process_p7(problem7);
			else if(problem8 != null)
				process_p8(problem8);
			else if(problem9 != null)
				process_p9(problem9);
			else if(problem10 != null)
				process_p10(problem10);
            
            return result;
        }

    }
}

