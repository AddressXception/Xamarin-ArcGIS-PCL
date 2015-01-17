using Esri.ArcGISRuntime.Geometry;

namespace Esri.ArcGISRuntime.Layers
{
    /// <summary>
    /// Base class for layer initialization info
    /// </summary>
    public abstract class LayerInitializationInfo
    {
        /// <summary>
        /// Gets or sets the spatial reference this layer would prefer to use.
        /// </summary>
        public SpatialReference PreferredSpatialReference { get; set; }
    }
}
