using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_TraverseEdges
    {
        static public IEnumerable<IEnumerable<GridCell<bool>>> TraverseEdges(this Grid<bool> item, int maximum_gap)
        {
            GridCell<bool> edge_cell;
            Grid<bool> edge_grid = item.DeriveStrictEdgeGrid();
            
            for (int y = 0; y < edge_grid.GetHeight(); y++)
            {
                for (int x = 0; x < edge_grid.GetWidth(); x++)
                {
                    edge_cell = edge_grid.GetCell(x, y);

                    if (edge_cell.GetData())
                    {
                        List<GridCell<bool>> edge_cells = new List<GridCell<bool>>();

                        while (edge_cell != null)
                        {
                            edge_cell.SetData(false);
                            edge_cells.Add(edge_cell);

                            edge_cell = edge_grid
                                .GetCardinalThenOrdinalNeighborCells(edge_cell.GetX(), edge_cell.GetY())
                                .Append(edge_grid.GetCellSpiral(edge_cell.GetX(), edge_cell.GetY(), maximum_gap))
                                .Narrow(c => c.GetData())
                                .GetFirst();
                        }

                        if (edge_cells.Count >= 3)
                            yield return edge_cells;
                    }
                }
            }
        }
    }
}