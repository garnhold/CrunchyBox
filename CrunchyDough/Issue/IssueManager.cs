using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IssueManager
    {
        private Stack<IssueLayer> issue_layer_stack;

        static private IssueManager INSTANCE;
        static public IssueManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new IssueManager();

            return INSTANCE;
        }

        private IssueManager()
        {
            issue_layer_stack = new Stack<IssueLayer>();
        }

        public void EnterLayer(IEnumerable<Type> types)
        {
            issue_layer_stack.Push(new IssueLayer(types));
        }
        public void ExitLayer()
        {
            issue_layer_stack.Pop();
        }

        public void Layer(Process process, params Type[] types)
        {
            EnterLayer(types);
                process();
            ExitLayer();
        }

        public void RaiseIssue(Type type, Operation<Issue> operation)
        {
            issue_layer_stack.PeekEX().IfNotNull(l => l.RaiseIssue(type, operation));
        }
        public void RaiseIssue<T>(Operation<T> operation) where T : Issue
        {
            issue_layer_stack.PeekEX().IfNotNull(l => l.RaiseIssue(operation));
        }
        public void RaiseIssue(Issue issue)
        {
            issue_layer_stack.PeekEX().IfNotNull(l => l.RaiseIssue(issue));
        }

        public IEnumerable<Issue> GetIssues(Type type)
        {
            return issue_layer_stack.PeekEX().IfNotNull(l => l.GetIssues(type));
        }
        public IEnumerable<T> GetIssues<T>() where T : Issue
        {
            return issue_layer_stack.PeekEX().IfNotNull(l => l.GetIssues<T>());
        }
    }
}