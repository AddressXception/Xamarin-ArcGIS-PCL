using System;
using System.Drawing;

namespace Esri.ArcGISRuntime.Geometry
{
    public static class PointExtensions
    {
        public static System.Drawing.Point ToSystem(this Esri.ArcGISRuntime.Geometry.MapPoint self)
        {
            return new Point((int)self.X, (int)self.Y);
        }

        public static Esri.ArcGISRuntime.Geometry.MapPoint ToSystem(this System.Drawing.Point self)
        {
            return new MapPoint(self.X, self.Y);
        }
    }
    public class MapPoint : Geometry
    {
        private bool? _hasM;
        private bool? _hasZ;

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.MapPoint class.
        /// </summary>
        public MapPoint()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.MapPoint class.
        /// </summary>
        /// <param name="spatialReference"></param>
        public MapPoint(SpatialReference spatialReference)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="coord">Coordinate</param><param name="sref">Spatial Reference</param>
        public MapPoint(Coordinate coord, SpatialReference sref)
        {
            this.Coordinate = coord;
            this.SpatialReference = sref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="x">x</param><param name="y">y</param>
        public MapPoint(double x, double y)
            : this(x, y, double.NaN, double.NaN, null)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="x">x</param><param name="y">y</param><param name="z">z</param>
        public MapPoint(double x, double y, double z)
            : this(x, y, z, double.NaN, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="x">x</param><param name="y">y</param><param name="spatialReference">Spatial Reference</param>
        public MapPoint(double x, double y, SpatialReference spatialReference)
            : this(x, y, double.NaN, double.NaN, spatialReference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="x">x</param><param name="y">y</param><param name="z">z</param><param name="spatialReference">Spatial Reference</param>
        public MapPoint(double x, double y, double z, SpatialReference spatialReference)
            : this(x, y, z, double.NaN, spatialReference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.MapPoint"/> class.
        /// 
        /// </summary>
        /// <param name="x">x</param><param name="y">y</param><param name="z">z</param><param name="m">measure</param><param name="spatialReference">Spatial Reference</param>
        public MapPoint(double x, double y, double z, double m, SpatialReference spatialReference)
        {
            this.Coordinate = new Coordinate(x,y,z,m);
            this.SpatialReference = spatialReference;
        }

        // Summary:
        //     Gets or sets the map coordinate.
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// Gets the minimum enclosing envelope of the instance
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Envelope
        /// </returns>
        public override Envelope Extent {
            get
            {
                if (this.IsEmpty)
                    return null;

                return new Envelope
                {
                    XMin = this.X,
                    XMax = this.X,
                    YMin = this.Y,
                    YMax = this.Y,
                    SpatialReference = this.SpatialReference
                };

            } 
        }


        /// <summary>
        /// Gets the geometry type.
        /// 
        /// </summary>
        public override GeometryType GeometryType { get {return GeometryType.Point;} }

        /// <summary>
        /// Gets a value indicating if the geometry has M
        /// 
        /// </summary>
        public override bool HasM
        {
            get
            {

                if (!this._hasM.HasValue)
                    this._hasM = this.Coordinate.HasM;
                return this._hasM.Value;
            }
        }

        /// <summary>
        /// Gets a value indicating if the geometry has Z.
        /// </summary>
        public override bool HasZ
        {
            get
            {
                if (!this._hasZ.HasValue)
                    this._hasZ = this.Coordinate.HasZ;
                return this._hasZ.Value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether or not the geometry is empty.
        /// 
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return double.IsNaN(this.X) || double.IsNaN(this.Y);
            }
        }

        /// <summary>
        /// Gets or sets the measure value.
        /// 
        /// </summary>
        public double M { get; set; }

        /// <summary>
        /// Gets or sets X.
        /// 
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// 
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets Z.
        /// 
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// Creates a deep clone of the current Object.
        /// </summary>
        /// <returns></returns>
        public MapPoint Clone()
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same
        /// type.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(MapPoint other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves a point to the specified location.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When moving a large amount of points, calling MoveTo can be more efficient than setting
        /// the <see cref="P:Esri.ArcGISRuntime.Geometry.MapPoint.X"/> and <see cref="P:Esri.ArcGISRuntime.Geometry.MapPoint.Y"/> properties individually.
        /// </para>
        /// <example>
        /// <para>
        /// Animates a graphic smoothly between two user defined locations by calling the MapPoint.MoveTo method
        ///             at regular intervals as defined by a DispatcherTimer. The distance the point is moved each time is
        ///             calculated by a quintic easing function.
        /// </para>
        /// <para>
        /// <img border="0" alt="Code example using the MapPoint.MoveTo method." src="../media/SmoothGraphicAnimation.png"/>
        /// </para>
        /// <code language="XAML" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\SmoothGraphicAnimation\CSharp\MainPage.xaml"/>
        /// 
        /// <code language="CSHARP" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\SmoothGraphicAnimation\CSharp\MainPage.xaml.cs"/>
        /// 
        /// <code language="VBNET" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\SmoothGraphicAnimation\VBNet\MainPage.xaml.vb"/>
        /// </example>
        /// </remarks>
        /// <param name="x">X value</param><param name="y">Y value</param>
        public void MoveTo(double x, double y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// 
        /// </summary>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
