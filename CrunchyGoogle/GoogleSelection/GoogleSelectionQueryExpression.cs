using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;
using Crunchy.Dinner;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    public partial class GoogleSelection<ID_ENUM>
    {
        public partial class Query
        {
            public abstract class Expression
            {
                public abstract string Render(HeaderInfo header_info);
            }

            public class Expression_Column : Expression
            {
                private ID_ENUM id;

                public Expression_Column(ID_ENUM i)
                {
                    id = i;
                }

                public override string Render(HeaderInfo header_info)
                {
                    return header_info
                        .GetA1IdForNativeId(id)
                        .Surround("`");
                }
            }

            public class Expression_Number : Expression
            {
                private decimal value;

                public Expression_Number(decimal v)
                {
                    value = v;
                }

                public override string Render(HeaderInfo header_info)
                {
                    return value.ToString();
                }
            }

            public abstract class Expression_BinaryOperator : Expression
            {
                private Expression left;
                private Expression right;

                private string operand;

                public Expression_BinaryOperator(Expression l, string o, Expression r)
                {
                    left = l;
                    right = r;

                    operand = o;
                }

                public override string Render(HeaderInfo header_info)
                {
                    return "({0} {1} {2})".Inject(
                        left.Render(header_info),
                        operand,
                        right.Render(header_info)
                    );
                }
            }

            public class Expression_IsEqualTo : Expression_BinaryOperator
            {
                public Expression_IsEqualTo(Expression l, Expression r) : base(l, "=", r) { }
            }
            public class Expression_IsNotEqualTo : Expression_BinaryOperator
            {
                public Expression_IsNotEqualTo(Expression l, Expression r) : base(l, "!=", r) { }
            }

            public class Expression_IsLessThan : Expression_BinaryOperator
            {
                public Expression_IsLessThan(Expression l, Expression r) : base(l, "<", r) { }
            }
            public class Expression_IsLessThanOrEqualTo : Expression_BinaryOperator
            {
                public Expression_IsLessThanOrEqualTo(Expression l, Expression r) : base(l, "<=", r) { }
            }

            public class Expression_IsGreaterThan : Expression_BinaryOperator
            {
                public Expression_IsGreaterThan(Expression l, Expression r) : base(l, ">", r) { }
            }
            public class Expression_IsGreaterThanOrEqualTo : Expression_BinaryOperator
            {
                public Expression_IsGreaterThanOrEqualTo(Expression l, Expression r) : base(l, ">=", r) { }
            }

            public class Expression_And : Expression_BinaryOperator
            {
                public Expression_And(Expression l, Expression r) : base(l, "AND", r) { }
            }
            public class Expression_Or : Expression_BinaryOperator
            {
                public Expression_Or(Expression l, Expression r) : base(l, "OR", r) { }
            }
        }
    }
}