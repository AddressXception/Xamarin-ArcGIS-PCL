using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Geometry;

namespace Esri.ArcGISRuntime.Layers
{
    public interface TiledMapServiceLayer : TiledLayer
    {

#if __ANDROID__
        Com.Esri.Android.Map.TiledServiceLayer Native { get; set; }

        void SetTiledMapServiceLayer(Com.Esri.Android.Map.TiledServiceLayer native);
#else
        TiledMapServiceLayer Native { get; set; }

        void SetTiledMapServiceLayer(TiledMapServiceLayer native);

#endif

       
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
    ///             the cached images can be referenced by a URL.
    /// 
    /// </para>
    /// 
    /// </remarks>
    public abstract class NativeTiledMapServiceLayer : NativeTiledLayer, TiledMapServiceLayer
    {

#if __ANDROID__
        public new Com.Esri.Android.Map.TiledServiceLayer Native { get; set; }

        public NativeTiledMapServiceLayer(Com.Esri.Android.Map.TiledServiceLayer native)
            : base(native)
        {
            Native = native;
            var t = native.GetTileInfo();
            this.SetTileInfo(t);
        }

        //todo: do we really want to hide this field?  or do we create another conversion to the pcl type?
        //after all tileinitializationinfo is basically the same  thing
        public new TiledInfo TileInfo { get; set; }

        protected void SetTileInfo(Com.Esri.Android.Map.TiledServiceLayer.TileInfo tiledInfo)
        {
            var point = tiledInfo.Origin.FromNative();
            System.Drawing.Point pointP = new Point((int)point.X, (int)point.Y);

            this.TileInfo = new TiledInfo(
                pointP,
                tiledInfo.GetScales(),
                tiledInfo.GetResolutions(),
                tiledInfo.Levels,
                tiledInfo.DPI,
                tiledInfo.TileWidth,
                tiledInfo.TileHeight);
        }

        public void SetTiledMapServiceLayer(Com.Esri.Android.Map.TiledServiceLayer native)
        {
            Native = native;
            this.SetTiledLayer(native);
        }
#else
        protected NativeTiledMapServiceLayer(TiledMapServiceLayer native)
            : base(native)
        {
            Native = native;
            var t = native.TileInfo;
            this.SetTileInfo(t);
        }

        protected void SetTileInfo(TiledLayerInitializationInfo tiledInfo)
        {
            //todo var point = tiledInfo.Origin.FromNative();
            //System.Drawing.Point pointP = new Point((int)point.X, (int)point.Y);

            //this.TileInfo = new TiledInfo(
            //    pointP,
            //    tiledInfo.GetScales(),
            //    tiledInfo.GetResolutions(),
            //    tiledInfo.Levels,
            //    tiledInfo.DPI,
            //    tiledInfo.TileWidth,
            //    tiledInfo.TileHeight);
        }


        public TiledMapServiceLayer Native { get; set; }
        

        public void SetTiledMapServiceLayer(TiledMapServiceLayer native)
        {
            Native = native;
            this.SetTiledLayer(native);
        }

#endif

        public NativeTiledMapServiceLayer()
        {
            
        }
        
        public NativeTiledMapServiceLayer(string url)
            : base(false) //todo? maybe not false?
        {

        }

        public NativeTiledMapServiceLayer(bool initLayer)
            : base(initLayer)
        {

        }

        /// <summary>
        /// Returns the Uri for a tile at a given row, column and level.
        /// 
        /// </summary>
        /// <param name="level">Tile level</param><param name="row">Tile row</param><param name="column">Tile column</param><param name="token">Cancellation Token for cancelling long-running tile requests</param>
        /// <returns>
        /// Uri task to Tile Uri
        /// </returns>
        /// 
        /// <remarks>
        /// This method must be implemented in a thread-safe manner.
        /// </remarks>
        protected abstract Task<Uri> GetTileUriAsync(int level, int row, int column, CancellationToken token);


      //  public new TiledInfo TileInfo { get; protected set; }

        public class TiledInfo
        {
            public int DPI { get; protected set; }
            public int Levels { get; protected set; }
            public Point Origin { get; protected set; }

            public double[] Resolutions { get; protected set; }

            public double[] Scales { get; protected set; }

            public int Height { get; protected set; }

            public int TileWidth { get; protected set; }

            public TiledInfo(Point origin, double[] scale, double[] res, int levels, int dpi, int tileWidth, int tileHeight)
            {

                Origin = origin;
                Scales = scale;
                Resolutions = res;
                Levels = levels;
                DPI = dpi;
                TileWidth = tileWidth;
                Height = tileHeight;
            }
        }

    }

    
}
