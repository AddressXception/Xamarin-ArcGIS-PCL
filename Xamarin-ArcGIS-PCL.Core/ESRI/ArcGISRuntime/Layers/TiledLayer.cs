using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Geometry;

namespace Esri.ArcGISRuntime.Layers
{
    public interface TiledLayer : Layer
    {

#if __ANDROID__
        Com.Esri.Android.Map.TiledLayer Native { get; set; }
        void SetTiledLayer(Com.Esri.Android.Map.TiledLayer native);
#else
        TiledLayer Native { get; set; }

        void SetTiledLayer(TiledLayer native);
#endif

        /// <summary>
        /// Gets the tiling scheme.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// This property is set by a subclass during <see cref="M:Esri.ArcGISRuntime.Layers.TiledLayer.OnInitializeRequestedAsync"/> and is not available until the layer has successfully initialized.
        /// </remarks>
        /// 
        /// <value>
        /// The tilingscheme.
        /// </value>
        TiledLayerInitializationInfo TileInfo { get; }

        /// <summary>
        /// Gets or sets layer brightness level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The brightness level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        double Brightness { get; set; }

        /// <summary>
        /// Gets or sets layer contrast level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The contrast level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        double Contrast { get; set; }

        /// <summary>
        /// Gets or sets layer gamma level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The gamma level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        double Gamma { get; set; }
      
    }

    /// <summary>
    /// Abstract tiled/cached map service layer class
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// 
    /// <para>
    /// Implement this class if you want to create a custom tiled layer where
    ///             the cached images cannot be referenced by a simple URL.
    /// 
    /// </para>
    /// 
    /// <para>
    /// As a minimum this layer must implement <see cref="M:Esri.ArcGISRuntime.Layers.TiledMapServiceLayer.GetTileDataAsync(System.Int32,System.Int32,System.Int32,System.Threading.CancellationToken)"/>
    ///             and <see cref="M:Esri.ArcGISRuntime.Layers.TiledLayer.OnInitializeTiledLayerRequestedAsync"/>.
    /// 
    /// </para>
    /// 
    /// <para>
    /// If your images can be referenced by a simple <see cref="T:System.Uri"/>, you
    ///             should instead implement <see cref="T:Esri.ArcGISRuntime.Layers.TiledMapServiceLayer"/>.
    /// 
    /// </para>
    /// 
    /// </remarks>
    /// <seealso cref="T:Esri.ArcGISRuntime.Layers.TiledMapServiceLayer"/><seealso cref="T:Esri.ArcGISRuntime.Layers.DynamicLayer"/><seealso cref="T:Esri.ArcGISRuntime.Layers.DynamicMapServiceLayer"/>
    public abstract class NativeTiledLayer : NativeLayer, TiledLayer
    {
#if __ANDROID__
        public Com.Esri.Android.Map.TiledLayer Native { get; set; }

        public NativeTiledLayer(Com.Esri.Android.Map.TiledLayer native)
            : base(native)
        {
            Native = native;
        }

        public void SetTiledLayer(Com.Esri.Android.Map.TiledLayer native)
        {
            Native = native;
            this.SetLayer(native);
        }
#else
        public new TiledLayer Native { get; set; }

        public NativeTiledLayer(TiledLayer native)
            : base(native)
        {
            Native = native;
        }

        public void SetTiledLayer(TiledLayer native)
        {
            Native = native;
            this.SetLayer(native);
        }


#endif


        public NativeTiledLayer(string url, bool initLayer)
            : base(initLayer)
        {

        }

        public NativeTiledLayer(bool initLayer)
            : base(initLayer)
        {

        }

        public NativeTiledLayer()
        {
            
        }

        /// <summary>
        /// Gets the tiling scheme.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// This property is set by a subclass during <see cref="M:Esri.ArcGISRuntime.Layers.TiledLayer.OnInitializeRequestedAsync"/> and is not available until the layer has successfully initialized.
        /// </remarks>
        /// 
        /// <value>
        /// The tilingscheme.
        /// </value>
        public TiledLayerInitializationInfo TileInfo { get; protected set; }

        /// <summary>
        /// Gets or sets layer brightness level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The brightness level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        public double Brightness { get; set; }

        /// <summary>
        /// Gets or sets layer contrast level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The contrast level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        public double Contrast
        {
            get; set; }

        /// <summary>
        /// Gets or sets layer gamma level.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// The gamma level is a value between -100 and 100 with a default of 0.
        /// 
        /// </remarks>
        public double Gamma
        {
            get; set; }

        /// <summary>
        /// Override this method to initialize any properties and settings prior to using the map.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Service Tile Info
        /// </returns>
        protected abstract Task<TiledLayerInitializationInfo> OnInitializeTiledLayerRequestedAsync();

        /// <summary>
        /// Causes tiled layer to clear tiles.
        /// 
        /// </summary>
        protected virtual void Invalidate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tile information returned by the <see cref="M:Esri.ArcGISRuntime.Layers.TiledLayer.GetTileDataAsync(System.Int32,System.Int32,System.Int32,System.Threading.CancellationToken)"/> call.
        /// 
        /// </summary>
        /// <seealso cref="M:Esri.ArcGISRuntime.Layers.TiledLayer.GetTileDataAsync(System.Int32,System.Int32,System.Int32,System.Threading.CancellationToken)"/>
        public class ImageTileData
        {
            /// <summary>
            /// Gets or sets the tile row.
            /// 
            /// </summary>
            public int Row { get; set; }

            /// <summary>
            /// Gets or sets the tile level.
            /// 
            /// </summary>
            public int Level { get; set; }

            /// <summary>
            /// Gets or sets the tile column.
            /// 
            /// </summary>
            public int Column { get; set; }

            /// <summary>
            /// Gets or sets the image data.
            /// 
            /// </summary>
            /// 
            /// <remarks>
            /// The image data encoded into an image data array.
            /// </remarks>
            public byte[] ImageData { get; set; }

            /// <summary>
            /// Gets or sets the type of content the <see cref="P:Esri.ArcGISRuntime.Layers.TiledLayer.ImageTileData.ImageData"/> property holds.
            /// 
            /// </summary>
            public string ContentType { get; set; }
        }
    }
}
