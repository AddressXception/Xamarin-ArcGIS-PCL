using Esri.ArcGISRuntime.Layers;
using Xamarin_ArcGIS_PCL.Core;

namespace Xamarin_ArcGIS_PCL.Droid
{
    public class NativeMapViewFactory : MapViewFactory
    {
        public override object GetOpenStreetMapLayer()
        {
            return new NativeOpenStreetMapLayer();
        }


    }
}