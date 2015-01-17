using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esri.ArcGISRuntime.Geometry
{
    /// <summary>
    /// Instances of this class represent a spatial reference.
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// 
    /// <para>
    /// Each spatial reference can be represented by either a
    ///             well-known ID (wkid), or a well-known text (wkt). Spatial References define the spatial properties of a geometry,
    ///             for instance the coordinate system it uses. There are 2 broad classes of coordinate systems - Geographic &amp; Projected.
    ///             A Geographic Coordinate system uses a 3-dimensional spherical surface to define locations on the earth. A Projected
    ///             Coordinate system on the other hand uses a flat, 2-dimensional surface. More information about spatial references
    ///             and coordinate systems is available
    ///             <a href="http://help.arcgis.com/en/arcgisdesktop/10.0/help/index.html#/What_are_map_projections/003r00000001000000/">here</a>.
    /// 
    /// </para>
    /// 
    /// <para>
    /// It is very important to associate spatial data, such as geometry objects, with corresponding spatial references.
    /// </para>
    /// 
    /// <para>
    /// A spatial reference class is not intended to change once the wkid or wkt properties are validated, calling the <see cref="P:Esri.ArcGISRuntime.Geometry.SpatialReference.IsValid"/> will check is the properties are correct.
    /// </para>
    /// 
    /// </remarks>
    public class SpatialReference
    {
        /// <summary>
        ///Instances of this class represent a spatial reference.
        /// </summary>
        /// <remarks>
        /// Each spatial reference can be represented by either a well-known ID (wkid),
        ///     or a well-known text (wkt). Spatial References define the spatial properties
        ///     of a geometry, for instance the coordinate system it uses. There are 2 broad
        ///     classes of coordinate systems - Geographic & Projected.  A Geographic Coordinate
        ///     system uses a 3-dimensional spherical surface to define locations on the
        ///     earth. A Projected Coordinate system on the other hand uses a flat, 2-dimensional
        ///     surface. More information about spatial references and coordinate systems
        ///     is available here.
        ///     It is very important to associate spatial data, such as geometry objects,
        ///    with corresponding spatial references.
        /// </remarks>
        public SpatialReference()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.SpatialReference
        ///     class.
        /// </summary>
        /// <param name="wkid">The Well-known ID that represents the Spatial Reference.</param>  
        public SpatialReference(int wkid)
        {

        }

        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.SpatialReference
        /// class.
        /// </summary>
        /// <param name="wktext">The Well known text that represents the Spatial Reference.</param>
        public SpatialReference(string wktext)
        {

        }
 
        /// <summary>
        /// Initializes a new instance of the Esri.ArcGISRuntime.Geometry.SpatialReference
        /// </summary>
        /// <param name="wkid">The Well-known ID that represents the Spatial Reference.</param>
        /// <param name="verticalWkid">The Vertical Coordinate System Well-known ID.</param>
        public SpatialReference(int wkid, int verticalWkid)
        {

        }

        /// <summary>
        /// Gets the base geographic coordinate system if this is a projected coordinate system
        /// </summary>
        public SpatialReference BaseGeographic { get; set; }

        /// <summary>
        /// Returns true if this is a geographic coordinate system.
        /// </summary>  
        public bool IsGeographic { get; set; }
        //
        // Summary:
        //     Returns true if this coordinate system supports wrap around.
        public bool IsPannable { get; set; }
        
        /// <summary>
        /// Returns true if this is a projected coordinate system.
        /// </summary>
        public  bool IsProjected { get; set; }
        
        /// <summary>
        /// Indicates if the spatial refererence has valid properties, either the Wkid
        ///    or Wkt is set. Once a spatial reference is valid it cannot be changed.
        /// </summary>
        public bool IsValid { get; set; }
        
        /// <summary>
        /// The units that the spatial reference coordinates are in.
        /// </summary>
        public Unit Unit { get; set; }
        
        /// <summary>
        /// Gets or sets the vertical coordinate system Well-known ID.
        /// </summary>
        public int VcsWkid { get; set; }
        
        /// <summary>
        /// Gets the Well-known ID for this instance.
        /// </summary>
        public int Wkid { get; set; }
        
        /// <summary>
        /// Gets the Well-known Text for this instance.
        /// </summary>
        public string Wkt { get; set; }

        /// <summary>
        /// Returns true of the Spatial references are the same.
        /// </summary>
        /// <param name="sref1">The first spatial reference.</param>
        /// <param name="sref2">The spatial reference to compare to.</param>
        /// <param name="ignoreNulls">if set to true if one Esri.ArcGISRuntime.Geometry.SpatialReference is null
        ///     and the other is not, the two will be considered the same.</param>
        /// <returns></returns>
        public bool AreEqual(SpatialReference sref1, SpatialReference sref2, bool ignoreNulls = false)
        {
           throw new NotImplementedException(); 
        }

        /// <summary>
        /// Returns an instance that can be reused, if the spatial reference is valid and so cannot be changes, it will return this instance.
        ///             Otherwise a copy is returned.
        /// 
        /// </summary>
        public SpatialReference Clone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.SpatialReference"/> class.
        /// </summary>
        /// <param name="wkid">The Well-known ID that represents the Spatial Reference.</param>
        /// <remarks>
        /// This method can reuse instance that are already in use.
        /// </remarks>
        public SpatialReference Create(int wkid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.SpatialReference"/> class.
        /// </summary>
        /// <param name="wkt">The Well known text that represents the Spatial Reference.</param>
        /// <remarks>
        /// This method can reuse instance that are already in use.
        /// </remarks>
        public SpatialReference Create(string wkt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Geometry.SpatialReference"/> class.
        /// </summary>
        /// <param name="wkid">The Well-known ID that represents the Spatial Reference.</param><param name="verticalWkid">The Vertical Coordinate System Well-known ID.</param>
        /// <remarks>
        /// This method can reuse instance that are already in use.
        /// </remarks>
        public SpatialReference Create(int wkid, int verticalWkid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an instance of a spatial reference from a JSON string.
        /// </summary>
        /// <returns>
        /// A spatial reference.
        /// </returns>
        public SpatialReference FromJson(string json)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an ArcGIS JSON representation of the spatial reference. The spatial reference must be valid <see cref="P:Esri.ArcGISRuntime.Geometry.SpatialReference.IsValid"/>
        /// </summary>
        /// <returns>
        /// A string containing json.
        /// </returns>
        public string ToJson()
        {
            throw new NotImplementedException();
        }
    }
}
