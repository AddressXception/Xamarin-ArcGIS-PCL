using Esri.ArcGISRuntime.Layers;
using Xamarin_ArcGIS_PCL.Core;

namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Core.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public object BaseLayer { get; set; }

        public MapViewModel(IMapViewFactory mapViewFactory)
        {

            var mapLayer = mapViewFactory.GetOpenStreetMapLayer();
            BaseLayer = mapLayer;

        }

        public MapViewModel()
        {
            BaseLayer = new NativeOpenStreetMapLayer();
        }
    }
}
