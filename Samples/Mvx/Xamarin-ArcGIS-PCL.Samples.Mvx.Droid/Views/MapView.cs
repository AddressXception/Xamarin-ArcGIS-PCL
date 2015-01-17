extern alias droid;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Xamarin_ArcGIS_PCL.Samples.Mvx.Core.ViewModels;
using NativeMapView = droid::Xamarin_ArcGIS_PCL.Droid.NativeMapView;
using NativeOpenStreetMapLayer = droid::Esri.ArcGISRuntime.Layers.NativeOpenStreetMapLayer;

namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Droid.Views
{
    [Activity(Label = "View for Map")]
    public class MapView : BaseView
    {
        public NativeMapView esriMap;

        public new MapViewModel ViewModel
        {
            get { return (MapViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MapView);            

            SetupMapIfNeeded();
            
        }

        private void SetupMapIfNeeded()
        {
            if (esriMap != null) return;

            LinearLayout contentV = (LinearLayout)FindViewById(Resource.Id.ContentView);
            esriMap = new NativeMapView(this);
            esriMap.EnableWrapAround(true);
            esriMap.SetEsriLogoVisible(true);
            esriMap.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            contentV.AddView(esriMap);

            //Load the base layer from the viewmodel as an OSM Layer
            var basemapLayer =
                (this.ViewModel.BaseLayer as NativeOpenStreetMapLayer).Native as
                    Com.Esri.Android.Map.Osm.OpenStreetMapLayer;
            basemapLayer.Name = "Basemap";
            esriMap.AddLayer(basemapLayer, 0);
        }


    }
}