using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IssueLayer
    {
        private Dictionary<Type, List<Issue>> issues;

        public IssueLayer(IEnumerable<Type> types)
        {
            issues = types.ToDictionaryKeys(t => new List<Issue>());
        }

        public void RaiseIssue(Type type, Operation<Issue> operation)
        {
            issues.GetValue(type)
                .IfNotNull(l => l.Add(operation()));
        }
        public void RaiseIssue<T>(Operation<T> operation) where T : Issue
        {
            RaiseIssue(typeof(T), () => operation());
        }
        public void RaiseIssue(Issue issue)
        {
            if(issue != null)
                RaiseIssue(issue.GetType(), () => issue);
        }

        public IEnumerable<Issue> GetIssues(Type type)
        {
            return issues.GetValue(type);
        }
        public IEnumerable<T> GetIssues<T>() where T : Issue
        {
            return GetIssues(typeof(T)).Convert<T>();
        }
    }
}