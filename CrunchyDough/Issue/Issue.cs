using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class Issue
    {
        static public void Layer<T1>(Process process) where T1 : Issue
        {
            IssueManager.GetInstance().Layer(process, typeof(T1));
        }
        static public void Layer<T1, T2>(Process process) where T1 : Issue where T2 : Issue
        {
            IssueManager.GetInstance().Layer(process, typeof(T1), typeof(T2));
        }
        static public void Layer<T1, T2, T3>(Process process) where T1 : Issue where T2 : Issue where T3 : Issue
        {
            IssueManager.GetInstance().Layer(process, typeof(T1), typeof(T2), typeof(T3));
        }

        static public void Raise<T>(Operation<T> operation) where T : Issue
        {
            IssueManager.GetInstance().RaiseIssue<T>(operation);
        }

        static public IEnumerable<T> GetIssues<T>() where T : Issue
        {
            return IssueManager.GetInstance().GetIssues<T>();
        }

        public abstract string GetMessage();

        public Issue()
        {
        }
    }
}