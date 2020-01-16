using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    static public class TextBoxExtensions_Select
    {
        static public void SelectAllText(this TextBox item)
        {
            item.SelectionStart = 0;
            item.SelectionEnd = item.Text.Length;
        }
    }
}