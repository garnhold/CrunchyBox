using System;

namespace Crunchy.Sauce
{
    static public class SurfacePointExtensions_Neighbor
    {
        static public SurfacePoint GetNeighbor(this SurfacePoint item, int x_offset, int y_offset)
        {
            return new SurfacePoint(item.x + x_offset, item.y + y_offset);
        }

        static public SurfacePoint GetTopNeighbor(this SurfacePoint item)
        {
            return item.GetNeighbor(0, 1);
        }

        static public SurfacePoint GetBottomNeighbor(this SurfacePoint item)
        {
            return item.GetNeighbor(0, -1);
        }

        static public SurfacePoint GetLeftNeighbor(this SurfacePoint item)
        {
            return item.GetNeighbor(-1, 0);
        }

        static public SurfacePoint GetRightNeighbor(this SurfacePoint item)
        {
            return item.GetNeighbor(1, 0);
        }
    }
}