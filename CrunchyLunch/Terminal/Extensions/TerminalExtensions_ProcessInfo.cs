using System;

using CrunchyDough;

namespace CrunchyLunch
{
    static public class TerminalExtensions_ProcessInfo
    {
        static public TerminalBlock_ProcessInfo WriteProcessInfo(this Terminal item, string process_name)
        {
            return item.AppendTerminalBlockNewline(new TerminalBlock_ProcessInfo(process_name));
        }
        static public TerminalBlock_ProcessInfo WriteProcessInfo(this Terminal item, string process_name, Process process)
        {
            TerminalBlock_ProcessInfo terminal_block = item.WriteProcessInfo(process_name);

            terminal_block.DoProcess(process);
            return terminal_block;
        }
    }
}