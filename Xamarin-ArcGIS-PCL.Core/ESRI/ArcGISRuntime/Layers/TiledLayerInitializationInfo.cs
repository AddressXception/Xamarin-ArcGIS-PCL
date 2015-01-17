using Esri.ArcGISRuntime.Geometry;

namespace Esri.ArcGISRuntime.Layers
{
    /// <summary>
    /// Contains information about the tiling scheme for a <see cref="T:Esri.ArcGISRuntime.Layers.TiledMapServiceLayer"/>.
    /// 
    /// </summary>
    /// <seealso cref="T:Esri.ArcGISRuntime.Layers.TiledMapServiceLayer"/>
    public abstract class TiledLayerInitializationInfo : LayerInitializationInfo
    {
        /// <summary>
        /// Gets or sets the dpi of the tiles
        /// 
        /// </summary>
        public float Dpi { get; set; }

        /// <summary>
        /// Gets or sets the height of each tile in pixels.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The height of each tile.
        /// </value>
        public int Height { get; protected set; }

        /// <summary>
        /// Gets or sets the width of each tile in pixels.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The width of each tile.
        /// </value>
        public int Width { get; protected set; }

        /// <summary>
        /// Gets or sets the tiling scheme origin..
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The tiling scheme origin.
        /// </value>
        public double OriginX { get; protected set; }

        /// <summary>
        /// Gets or sets the tiling scheme origin..
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The tiling scheme origin.
        /// </value>
        public double OriginY { get; protected set; }

        /// <summary>
        /// Gets or sets the Extent and spatial reference of the tiling scheme.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The extent of the tiling scheme. Spatial Reference of the extent defines the spatial reference of the schema.
        /// </value>
        public Envelope Extent { get; protected set; }

    }
}
