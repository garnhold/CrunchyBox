using System;
using System.IO;
using System.Text;

namespace Crunchy.Ginger
{
    using Dough;
    
    public class CSHeader_SimpleDated : CSHeader
    {
        private string date_format;

        public CSHeader_SimpleDated(string f)
        {
            date_format = f;
        }

        public CSHeader_SimpleDated() : this("MMMM dd yyyy H:mm:ss zzz") { }

        public override string GenerateHeader()
        {
            return
@"//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: " + DateTime.Now.ToString(date_format);
        }
    }
}