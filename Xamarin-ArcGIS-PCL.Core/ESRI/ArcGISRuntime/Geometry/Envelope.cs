using System;

namespace Esri.ArcGISRuntime.Geometry
{
    /// <summary>
    /// Axis Aligned envelope
    /// 
    /// </summary>
    public class Envelope : Geometry, IEquatable<Envelope>
    {

        private bool? _hasM;
        private bool? _hasZ;

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.Envelope class.
        /// </summary>
        public Envelope()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.Envelope class.
        /// </summary>
        /// <param name="spatialReference"></param>
        public Envelope(SpatialReference spatialReference)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.Envelope"/> class.
        /// 
        /// </summary>
        /// <param name="p1">First corner</param><param name="p2">Second corner</param>
        public Envelope(MapPoint p1, MapPoint p2) : this(p1.X, p1.Y, p2.X, p2.Y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.Envelope"/> class.
        /// 
        /// </summary>
        /// <param name="x1">x min</param><param name="y1">y min</param><param name="x2">x max</param><param name="y2">y max</param>
        public Envelope(double x1, double y1, double x2, double y2)
        {
            this.XMin = Math.Min(x1, x2);
            this.YMin = Math.Min(y1, y2);
            this.XMax = Math.Max(x1, x2);
            this.YMax = Math.Max(y1, y2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.Envelope"/> class.
        /// 
        /// </summary>
        /// <param name="x1">x min</param><param name="y1">y min</param><param name="x2">x max</param><param name="y2">y max</param><param name="spatialReference">Spatial reference.</param>
        public Envelope(double x1, double y1, double x2, double y2, SpatialReference spatialReference) 
            : this (x1,y1,x2,y2)
        {
            this.SpatialReference = spatialReference;
        }

        /// <summary>
        /// Gets the minimum enclosing envelope of the instance
        /// </summary>
        public override Envelope Extent
        {
            get
            {
                if (this.IsEmpty) return null;
            
                return new Envelope(this.XMin, this.YMin, this.XMax, this.YMax)
                {
                    SpatialReference = this.SpatialReference != null ? this.SpatialReference.Clone() : null
                };

            }
        }

        /// <summary>
        /// The type geometry for this instance.
        /// </summary> 
        public override GeometryType GeometryType
        {
            get
            {
                return GeometryType.Envelope;
            }
        }
        /// <summary>
        /// Gets a value indicating if the geometry has M
        /// </summary>
        public override bool HasM
        {
            get
            {
                if (!this._hasM.HasValue)
                    this._hasM = !double.IsNaN(this.MMax) || !double.IsNaN(this.MMin);
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
                    this._hasZ = !double.IsNaN(this.ZMax) || !double.IsNaN(this.ZMin);
                return this._hasZ.Value;
            }
        }
        /// <summary>
        /// Gets the height of the instance.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the geometry is empty.
        /// 
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return !double.IsNaN(this.XMin) &&
                       !double.IsNaN(this.XMax) &&
                       !double.IsNaN(this.YMin) &&
                       !double.IsNaN(this.YMax);
            }
        }
        /// <summary>
        /// Gets or sets Mmax.
        /// </summary>
        public double MMax { get; set; }
        /// <summary>
        /// Gets or sets Mmin.
        /// </summary>
  
        public double MMin { get; set; }
        /// <summary>
        /// Gets the width of the instance.
        /// </summary>
 
        public double Width { get; set; }
        /// <summary>
        /// Gets or sets Xmax.
        /// </summary>
        public double XMax { get; set; }
        /// <summary>
        /// Gets or sets Xmin.
        /// </summary>
 
        public double XMin { get; set; }
        /// <summary>
        /// Gets or sets Ymax.
        /// </summary>
 
        public double YMax { get; set; }
        /// <summary>
        /// Gets or sets Ymin.
        /// </summary>
   
        public double YMin { get; set; }
        /// <summary>
        /// Gets or sets Zmax.
        /// </summary>
        public double ZMax { get; set; }

        /// <summary>
        /// Gets or sets Zmin.
        /// </summary>
        public double ZMin { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// 
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// 
        /// </returns>
        public bool Equals(Envelope other)
        {
           throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new envelope expanded by the amount specified.
        /// 
        /// </summary>
        /// <param name="factor">Expansion factor. Factor must be 0 or greater.
        ///             Values greater than 1 creates a larger envelope, and less then one shrinks it.</param>
        /// <returns>
        /// Expanded envelope
        /// </returns>
        /// 
        /// <example>
        /// Example: Expand the envelope by 10%:
        /// 
        /// <code lang="C#">
        /// Envelope expanded = myEnvelope.Expand(1.1);
        /// 
        /// </code>
        /// 
        /// </example>
        public Envelope Expand(double factor)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the center of the instance.
        /// 
        /// </summary>
        /// 
        /// <returns/>
        public MapPoint GetCenter()
        {
            if (this.IsEmpty) return new MapPoint(0,0);

            var point = new MapPoint
            {
                X = (this.XMin + this.XMax)/2.0,
                Y = (this.YMin + this.YMax)/2.0,
                SpatialReference = this.SpatialReference
            };

            return point;
        }

        /// <summary>
        /// Calculates the intersection between this instance and the specified envelope.
        /// 
        /// </summary>
        /// <param name="extent">Envelope to intersect with</param>
        /// <returns>
        /// The intersecting envelope or null if they don't intersect.
        /// </returns>
        public Envelope Intersection(Envelope extent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if this instance intersects an envelope.
        /// 
        /// </summary>
        /// <param name="other">Envelope to test against</param>
        /// <returns>
        /// True if they intersect
        /// </returns>
        public bool Intersects(Envelope other)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns a System.String that represents the current System.Object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the union of this instance and the specified envelope.
        /// 
        /// </summary>
        /// <param name="extent">The envelope to union with.</param>
        /// <returns>
        /// Envelope containing both envelope
        /// </returns>
        public Envelope Union(Envelope extent)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unions an envelope with a point
        /// 
        /// </summary>
        /// <param name="point">Point</param>
        /// <returns>
        /// An envelope that encompasses envelopes and the point.
        /// </returns>
        public Envelope Union(MapPoint point)
        {
            throw new NotImplementedException();
        }
    }
}
