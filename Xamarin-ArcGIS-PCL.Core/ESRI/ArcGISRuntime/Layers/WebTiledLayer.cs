using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esri.ArcGISRuntime.Layers
{
    public interface WebTiledLayer : TiledMapServiceLayer
    {

#if __ANDROID__
        Com.Esri.Android.Map.TiledServiceLayer Native { get; set; }

        void SetWebTiledLayer(Com.Esri.Android.Map.TiledServiceLayer native);

#else
        TiledMapServiceLayer Native { get; set; }

        void SetWebTiledLayer(WebTiledLayer native);

#endif

        /// <summary>
        /// Gets or sets the template URI to the Web Tiled Layer.
        ///             The template uri contains a parameterized uri.
        ///             The template can contain the following templated parameters: {subDomain}, {level}, {row} and {col}.
        /// 
        /// <para>
        /// Example of OpenStreetMap template URI: http://{subDomain}.tile.opencyclemap.org/cycle/{level}/{col}/{row}.png
        /// </para>
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The template URI.
        /// 
        /// </value>
        string TemplateUri { get; set; }

        /// <summary>
        /// Gets or sets the sub domains.
        ///             The sub domain values are used to replace the {subDomain} parameter in the <see cref="P:Esri.ArcGISRuntime.Layers.WebTiledLayer.TemplateUri"/>.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The sub domains.
        /// 
        /// </value>
        string[] SubDomains { get; set; }

        /// <summary>
        /// Gets or sets the attribution to the Web Tiled Layer provider.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The copyright.
        /// 
        /// </value>
        string CopyrightText { get; set; }

        /// <summary>
        /// Gets or sets the level values to use when replacing the {level} parameter in the TemplateUrl.
        ///             This optional property is useful when the TemplateUrl is expecting non numeric level values.
        ///             This is mainly used for the WMTS layers that are converted to WebTiledLayers when added to a webmap. The WMTS layers may use non numeric level values.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The level values.
        /// 
        /// </value>
        string[] LevelValues { get; set; }

        
    }

    public class NativeWebTiledLayer : NativeTiledMapServiceLayer, WebTiledLayer
    {

#if __ANDROID__
        public Com.Esri.Android.Map.TiledServiceLayer Native { get; set; }

        public NativeWebTiledLayer(Com.Esri.Android.Map.TiledServiceLayer native)
            : base(native)
        {
            Native = native;
            var t = native.GetTileInfo();
        }

        public void SetWebTiledLayer(Com.Esri.Android.Map.TiledServiceLayer native)
        {
            Native = native;
            this.SetTiledMapServiceLayer(native);
        }
#else
        public TiledMapServiceLayer Native { get; set; }
        

        public NativeWebTiledLayer(TiledMapServiceLayer native)
            : base(native)
        {
            Native = native;
            //todo? var t = native.GetTileInfo();
        }

        public void SetWebTiledLayer(WebTiledLayer native)
        {
            Native = native;
            this.SetTiledMapServiceLayer(native);
        }


#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Layers.WebTiledLayer"/> class with a default tile scheme and a world full extent.
        /// 
        /// </summary>
        public NativeWebTiledLayer()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Layers.WebTiledLayer"/> class.
        /// 
        /// </summary>
        /// <param name="tiledLayerInitializationInfo">The tiled layer initialization info.</param>
        public NativeWebTiledLayer(TiledLayerInitializationInfo tiledLayerInitializationInfo)
            : base()
        {
            
        }

        /// <summary>
        /// Gets or sets the template URI to the Web Tiled Layer.
        ///             The template uri contains a parameterized uri.
        ///             The template can contain the following templated parameters: {subDomain}, {level}, {row} and {col}.
        /// 
        /// <para>
        /// Example of OpenStreetMap template URI: http://{subDomain}.tile.opencyclemap.org/cycle/{level}/{col}/{row}.png
        /// </para>
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The template URI.
        /// 
        /// </value>
        public string TemplateUri { get; set; }

        /// <summary>
        /// Gets or sets the sub domains.
        ///             The sub domain values are used to replace the {subDomain} parameter in the <see cref="P:Esri.ArcGISRuntime.Layers.WebTiledLayer.TemplateUri"/>.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The sub domains.
        /// 
        /// </value>
        public string[] SubDomains { get; set; }

        /// <summary>
        /// Gets or sets the attribution to the Web Tiled Layer provider.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The copyright.
        /// 
        /// </value>
        public string CopyrightText { get; set; }

        /// <summary>
        /// Gets or sets the level values to use when replacing the {level} parameter in the TemplateUrl.
        ///             This optional property is useful when the TemplateUrl is expecting non numeric level values.
        ///             This is mainly used for the WMTS layers that are converted to WebTiledLayers when added to a webmap. The WMTS layers may use non numeric level values.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The level values.
        /// 
        /// </value>
        public string[] LevelValues { get; set; }


        /// <summary>
        /// Override this method to initialize any properties and settings prior to using the map.
        /// 
        /// </summary>
        /// 
        /// <returns/>
        protected override sealed Task<TiledLayerInitializationInfo> OnInitializeTiledLayerRequestedAsync()
        {
            throw new NotImplementedException();
        }

        internal override Task<LayerInitializationInfo> OnInitializeRequestedAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the tile URI.
        /// 
        /// </summary>
        /// <param name="row">The row.</param><param name="column">The column.</param><param name="level">The level.</param><param name="token">The token.</param>
        /// <returns/>
        protected override Task<Uri> GetTileUriAsync(int level, int row, int column, CancellationToken token)
        {
            throw new NotImplementedException();
        }

    }
}
