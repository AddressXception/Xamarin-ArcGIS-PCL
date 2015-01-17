using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Esri.Android.Map;
using Esri.ArcGISRuntime.Layers;

namespace ArcGIS.CrossPlatform.Droid.Extensions
{
    public static class LayerExtensions
    {

        public static Com.Esri.Android.Map.Osm.OpenStreetMapLayer ToNative(
            this OpenStreetMapLayer self)
        {
            return ((OpenStreetMapLayer)self).Native;
        }

        public static Com.Esri.Android.Map.TiledServiceLayer ToNative(
            this TiledMapServiceLayer self)
        {
            return ((TiledMapServiceLayer)self).Native;
        }

        //    public static ArcGISTiledMapServiceLayer ToNative(
        //        this TiledMapServiceLayer self)
        //    {
        //        return ((ArcGISTiledMapServiceLayer)self).Native;
        //    }

        public static Com.Esri.Android.Map.TiledLayer ToNative(
            this global::Esri.ArcGISRuntime.Layers.TiledLayer self)
        {
            return ((global::Esri.ArcGISRuntime.Layers.TiledLayer)self).Native;
        }

        public static Com.Esri.Android.Map.Layer ToNative(
            this global::Esri.ArcGISRuntime.Layers.Layer self)
        {
            return ((global::Esri.ArcGISRuntime.Layers.Layer)self).Native;
        }

    }
}