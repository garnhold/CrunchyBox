using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crunchy.Pantry_GoogleDrive
{
    using Dough;
    using Salt;
    
    namespace GoogleEX
    {
        namespace Storage
        {
            public abstract class ClauseType<T>
            {
                private string layout;
                private Operation<string, T> operation;

                public ClauseType(string l, Operation<string, T> o)
                {
                    layout = l;
                    operation = o;
                }

                public string CreateQueryString(string field, T value)
                {
                    return layout.RegexReplace("\\?([A-Za-z0-9_]+)", delegate(Match match) {
                        string label = match.Groups[1].Value;

                        switch (label)
                        {
                            case "FIELD":
                                return field.StyleAsEntity();
                                
                            case "VALUE":
                                return operation(value).StyleAsLiteral();
                        }

                        throw new UnaccountedBranchException("label", label);
                    });
                }
            }
        }
    }
}