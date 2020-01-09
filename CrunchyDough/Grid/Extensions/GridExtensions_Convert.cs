using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Convert
    {
        static public Grid<OUTPUT_TYPE> ConvertGrid<INPUT_TYPE, OUTPUT_TYPE>(this Grid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            return item.Derive(delegate(GridCell<INPUT_TYPE> cell) {
                return operation.Execute(cell.GetData());
            });
        }
    }
}