using System;
using Xamarin_ArcGIS_PCL.Core.ESRI.ArcGISRuntime.Geometry;

namespace Esri.ArcGISRuntime.Geometry
{
    public abstract class Geometry
    {

        /// <summary>
        /// Gets the minimum enclosing Esri.ArcGISRuntime.Geometry.Envelope of the instance
        /// </summary>
        public abstract Envelope Extent { get; }

        /// <summary>
        /// Gets the geometry type.
        /// </summary>
        public abstract GeometryType GeometryType { get; }

        /// <summary>
        /// Gets a value indicating if the geometry has M
        /// </summary>
        public abstract bool HasM { get; }

        /// <summary>
        /// Gets a value indicating if the geometry has Z.
        /// </summary>
        public abstract bool HasZ { get; }

        /// <summary>
        /// Gets a value indicating whether or not the geometry is empty.
        /// </summary>
        public abstract bool IsEmpty { get; }

        /// <summary>
        /// Gets the dimension of the geometry.
        /// </summary>
        public int Dimension
        {
            get
            {
                switch (this.GeometryType)
                {
                    case GeometryType.Point:
                    case GeometryType.MultiPoint:
                        return 0;
                    case GeometryType.Polyline:
                        return 1;
                    case GeometryType.Polygon:
                    case GeometryType.Envelope:
                        return 2;
                    default:
                        return -1;
                }
            }
        }

        /// <summary>
        /// Gets the spatial reference of the instance.
        /// </summary>
        public SpatialReference SpatialReference { get; set; }

        /// <summary>
        /// Creates and returns a deep clone of the receiver.
        /// </summary>
        public Geometry Clone()
        {
            return Clone(this);
        }

        /// <summary>
        /// Creates a deep clone of 'toClone'
        /// </summary>
        /// <param name="toClone"></param>
        /// <returns>A Clone of the object</returns>
        public static Geometry Clone(Geometry toClone)
        {
            if (toClone == null)
                return null;

            if (toClone is MapPoint)
                return ((MapPoint)toClone).Clone();

            if (toClone is MultiPoint)
                return ((MultiPoint)toClone).Clone();

            if (toClone is Envelope)
                return ((Envelope)toClone).Clone();

            if (toClone is Polyline)
                return ((Polyline)toClone).Clone();

            if (toClone is Polygon)
                return ((Polygon)toClone).Clone();

            return null; 
        }

        /// <summary>
        /// Creates a geometry from an ArcGIS json geometry representation.
        /// </summary>
        /// <param name="json">JSON representation of geometry.</param>
        /// <returns>
        /// Geometry converted from a JSON String.
        /// </returns>
        public virtual Geometry FromJson(string json)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts a geometry into an ArcGIS json geometry representation.
        /// </summary>
        /// 
        /// <returns>
        /// Geometry represented as a JSON String.
        /// </returns>
        public virtual string ToJson()
        {
            throw new NotImplementedException();
        }
    }
}
