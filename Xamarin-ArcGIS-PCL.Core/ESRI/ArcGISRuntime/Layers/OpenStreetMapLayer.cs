using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esri.ArcGISRuntime.Layers
{
    public interface OpenStreetMapLayer : WebTiledLayer
    {
 #if __ANDROID__
        Com.Esri.Android.Map.Osm.OpenStreetMapLayer Native { get; set; }
        void SetOpenStreetMapLayer(Com.Esri.Android.Map.Osm.OpenStreetMapLayer native);

#else

        OpenStreetMapLayer Native { get; set; }
        void SetOpenStreetMapLayer(OpenStreetMapLayer native);

#endif

    }

    public class NativeOpenStreetMapLayer : NativeWebTiledLayer, OpenStreetMapLayer
    {

#if __ANDROID__
        public Com.Esri.Android.Map.Osm.OpenStreetMapLayer Native { get; set; }
        public void SetOpenStreetMapLayer(Com.Esri.Android.Map.Osm.OpenStreetMapLayer native)
        {
            Native = native;
            this.SetWebTiledLayer(native);
        }
#else
        public OpenStreetMapLayer Native { get; set; }
        public void SetOpenStreetMapLayer(OpenStreetMapLayer native)
        {
            Native = native;
            this.SetWebTiledLayer(native);
        }

#endif


        /// <summary>
        /// Initializes a new instance of the <see cref="T:Esri.ArcGISRuntime.Layers.OpenStreetMapLayer"/> class.
        /// 
        /// </summary>
        public NativeOpenStreetMapLayer()
        {

#if __ANDROID__
            var native = new Com.Esri.Android.Map.Osm.OpenStreetMapLayer();
            this.SetOpenStreetMapLayer(native);
#else
            //var native = new OpenStreetMapLayer();
            this.SetOpenStreetMapLayer(this);
#endif

            this.TemplateUri = "http://{subDomain}.tile.openstreetmap.org/{level}/{col}/{row}.png";
            this.CopyrightText = "Map data © OpenStreetMap contributors, CC-BY-SA";
            this.SubDomains = new string[3]
            {
                "a",
                "b",
                "c"
            };
        }


    }
}
