using System;
using System.IO;
using System.Text;

namespace Crunchy.Ginger
{
    using Dough;

    public class CSHeader_SimpleStatement : CSHeader
    {
        public CSHeader_SimpleStatement()
        {
        }

        public override string GenerateHeader()
        {
            return
@"//-------------------------------
//--Generated Code File----------
//-------------------------------
";
        }
    }
}