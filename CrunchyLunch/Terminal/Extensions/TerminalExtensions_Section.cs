using System;

using CrunchyDough;

namespace CrunchyLunch
{
    static public class TerminalExtensions_Section
    {
        static public void WriteIndentedSection(this Terminal item, Process process)
        {
            item.Indent();
                process();
            item.Dedent();
        }

        static public T WriteIndentedSection<T>(this Terminal item, Operation<T> operation)
        {
            T return_value = default(T);

            item.WriteIndentedSection(delegate() {
                return_value = operation();
            });

            return return_value;
        }
    }
}