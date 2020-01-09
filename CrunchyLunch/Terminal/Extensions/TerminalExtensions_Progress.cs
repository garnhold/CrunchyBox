using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class TerminalExtensions_Progress
    {
        static public TerminalBlock_Progress WriteProgress(this Terminal item, int bar_width)
        {
            return item.AppendTerminalBlock(new TerminalBlock_Progress(bar_width));
        }
        static public TerminalBlock_Progress WriteProgressAndNewline(this Terminal item)
        {
            return item.AppendTerminalBlockNewline(new TerminalBlock_Progress());
        }
    }
}