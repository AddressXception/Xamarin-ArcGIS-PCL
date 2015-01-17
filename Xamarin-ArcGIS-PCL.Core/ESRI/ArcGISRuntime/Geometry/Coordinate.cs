using System;

namespace Esri.ArcGISRuntime.Geometry
{
    /// <summary>
    /// A coordinate that holds up to 4 values X, Y, Z and M (Measure). This is a lightweight struct.
    /// 
    /// </summary>
    public struct Coordinate
    {

    private bool _hasZ;
    private bool _hasM;

    /// <summary>
    /// X value, this is longitude when working with geographic coordinates.
    /// 
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Y value, this is latitude when working with geographic coordinates.
    /// 
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Z value,  representing a height. A value of double.NaN indicates its not present.
    /// 
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// M value, representing a Measure. A value of double.NaN indicates its not present.
    /// 
    /// </summary>
    public double M { get; set; }

    /// <summary>
    /// Indicates if the Z coordinate is present.
    /// 
    /// </summary>
    public bool HasZ
    {
      get
      {
        return this._hasZ;
      }
    }

    /// <summary>
    /// Indicates if the M coordinate is present.
    /// 
    /// </summary>
    public bool HasM
    {
      get
      {
        return this._hasM;
      }
    }

    /// <summary>
    /// Represents a cooridnate with and X and Y value
    /// 
    /// </summary>
    /// <param name="x">X value, this is longitude when working with geographic coordinates.</param><param name="y">Y value, this is latitude when working with geographic coordinates.</param>
    public Coordinate(double x, double y)
    {
      this = new Coordinate(x, y, double.NaN, double.NaN);
    }

    /// <summary>
    /// Represents a cooridnate with and X, Y and Z values
    /// 
    /// </summary>
    /// <param name="x">X value, this is longitude when working with geographic coordinates.</param><param name="y">Y value, this is latitude when working with geographic coordinates.</param><param name="z">Z value, representing a height.</param>
    public Coordinate(double x, double y, double z)
    {
      this = new Coordinate(x, y, z, double.NaN);
    }

    /// <summary>
    /// Represents a cooridnate with and X, Y, Z and M values
    /// 
    /// </summary>
    /// <param name="x">X value, this is longitude when working with geographic coordinates.</param><param name="y">Y value, this is latitude when working with geographic coordinates.</param><param name="z">Z value, representing a height.</param><param name="m">M value, representing a Measure, typically a distance along a line.</param>
    public Coordinate(double x, double y, double z, double m) : this()
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.M = m;
      this._hasZ = !double.IsNaN(this.Z);
      this._hasM = !double.IsNaN(this.M);
    }

    /// <summary>
    /// Compares two <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structures for equality.
    /// 
    /// </summary>
    /// <param name="coord1">The first <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to compare.</param><param name="coord2">The second <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to compare.</param>
    /// <returns>
    /// <c>true</c> if both <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.X"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Y"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Z"/> and
    ///             <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.M"/> values of coord1 and coord2 are equal; otherwise, <c>false</c>.
    /// </returns>
    public static bool operator ==(Coordinate coord1, Coordinate coord2)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Compares two <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structures for inequality.
    /// 
    /// </summary>
    /// <param name="coord1">The first <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to compare.</param><param name="coord2">The second <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to compare.</param>
    /// <returns>
    /// <c>false</c> if both <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.X"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Y"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Z"/> and
    ///             <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.M"/> values of coord1 and coord2 are equal; otherwise, <c>true</c>.
    /// </returns>
    public static bool operator !=(Coordinate coord1, Coordinate coord2)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Adds two <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structures as a vector operation.
    /// 
    /// </summary>
    /// <param name="coord1">The first <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to add.</param><param name="coord2">The second <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to add.</param>
    /// <returns>
    /// The vector add operation if both <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.X"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Y"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Z"/> and
    ///             <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.M"/> values of coord1 and coord2.
    /// </returns>
    /// 
    /// <remarks>
    /// If only one coordinate has Z and/or M values, it's assumed to be 0 in
    ///             the operation. If none of them has Z or M values, they are kept unset.
    /// 
    /// </remarks>
    public static Coordinate operator +(Coordinate coord1, Coordinate coord2)
    {
     throw new NotImplementedException();
    }

    /// <summary>
    /// Subtracts two <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structures as a vector operation.
    /// 
    /// </summary>
    /// <param name="coord1">The first <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to subtract from.</param><param name="coord2">The second <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to subtract.</param>
    /// <returns>
    /// The vector subtract operation if both <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.X"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Y"/>, <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.Z"/> and
    ///             <see cref="P:Esri.ArcGISRuntime.Geometry.Coordinate.M"/> values of coord1 and coord2.
    /// </returns>
    /// 
    /// <remarks>
    /// If only one coordinate has Z and/or M values, it's assumed to be 0 in
    ///             the operation. If none of them has Z or M values, they are kept unset.
    /// 
    /// </remarks>
    public static Coordinate operator -(Coordinate coord1, Coordinate coord2)
    {
     throw new NotImplementedException();
    }

    /// <summary>
    /// Scales a <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure as a vector operation.
    /// 
    /// </summary>
    /// <param name="coordinate">The <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/> structure to scale.</param><param name="factor">The scale factor.</param>
    /// <returns>
    /// The a scaled <see cref="T:Esri.ArcGISRuntime.Geometry.Coordinate"/>.
    /// </returns>
    public static Coordinate operator *(Coordinate coordinate, double factor)
    {
      throw new NotImplementedException();
    }

 

    internal string GetCoordsAsString()
    {
     throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents this instance.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.String"/> that represents this instance.
    /// 
    /// </returns>
    public override string ToString()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"/> is equal to this instance.
    /// 
    /// </summary>
    /// <param name="obj">The <see cref="T:System.Object"/> to compare with this instance.</param>
    /// <returns>
    /// <c>true</c> if the specified <see cref="T:System.Object"/> is equal to this instance; otherwise, <c>false</c>.
    /// 
    /// </returns>
    public override bool Equals(object obj)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// 
    /// </returns>
    public override int GetHashCode()
    {
      return this.X.GetHashCode() ^ this.Y.GetHashCode();
    }
  }
}
