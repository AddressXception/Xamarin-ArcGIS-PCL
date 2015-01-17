using Com.Esri.Core.Geometry;

namespace Esri.ArcGISRuntime.Geometry
{
    public static class PointExtensions
    {
        public static Point ToNative(this MapPoint self)
        {
          return new Point(self.X, self.Y, self.Z);  
        }

        public static MapPoint FromNative(this Point self)
        {
            return new MapPoint(self.GetX(), self.GetY(), self.GetZ());
        }

        
    }
}