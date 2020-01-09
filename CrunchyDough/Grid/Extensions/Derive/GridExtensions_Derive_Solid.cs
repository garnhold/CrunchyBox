using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Derive_Solid
    {
        static public Grid<bool> DeriveEdgeGrid(this Grid<bool> item)
        {
            return item.Derive(delegate(GridCell<bool> cell) {
                if (cell.GetData())
                {
                    if (item.GetNeighborData(cell.GetX(), cell.GetY()).Has(false))
                        return true;
                }

                return false;
            });
        }

        static public Grid<bool> DeriveStrictEdgeGrid(this Grid<bool> item)
        {
            Grid<bool> edge_grid = item.DeriveEdgeGrid();

            return edge_grid.Derive(delegate(GridCell<bool> cell) {
                if (cell.GetData())
                {
                    if (edge_grid.GetNeighborData(cell.GetX(), cell.GetY()).Count(false) >= 4)
                        return true;
                }

                return false;
            });
        }
    }
}