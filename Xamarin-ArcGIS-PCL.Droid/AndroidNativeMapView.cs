using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using ArcGIS.CrossPlatform.Droid.Extensions;
using Com.Esri.Android.Map;
using Com.Esri.Android.Map.Event;
using Com.Esri.Core.Geometry;
using Com.Esri.Core.IO;
using Esri.ArcGISRuntime.Layers;

namespace Xamarin_ArcGIS_PCL.Droid
{
    public class NativeMapView : Com.Esri.Android.Map.MapView
    {
        protected NativeMapView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public NativeMapView(Context p0, string p1, UserCredentials p2, string p3, IOnMapEventListener p4) : base(p0, p1, p2, p3, p4)
        {
        }

        public NativeMapView(Context p0, IAttributeSet p1, int p2) : base(p0, p1, p2)
        {
        }

        public NativeMapView(Context p0, SpatialReference p1, Envelope p2) : base(p0, p1, p2)
        {
        }

        public NativeMapView(Context p0, MapOptions p1) : base(p0, p1)
        {
        }

        public NativeMapView(Context p0, string p1, string p2, string p3) : base(p0, p1, p2, p3)
        {
        }

        public NativeMapView(Context p0) : base(p0)
        {
        }

        public NativeMapView(Context p0, string p1, string p2, string p3, string p4, IOnMapEventListener p5) : base(p0, p1, p2, p3, p4, p5)
        {
        }

        public NativeMapView(Context p0, IAttributeSet p1) : base(p0, p1)
        {
        }

        public NativeMapView(Context p0, string p1, string p2, string p3, string p4)
            : base(p0, p1, p2, p3, p4)
        {
        }

        public int AddLayer(global::Esri.ArcGISRuntime.Layers.Layer p0)
        {
            return base.AddLayer(p0.ToNative());
        }

        public int AddLayer(global::Esri.ArcGISRuntime.Layers.Layer p0, int p1)
        {
            return base.AddLayer(p0.ToNative(), p1);
        }

        public int AddLayer(OpenStreetMapLayer p0, int p1)
        {
            return base.AddLayer(p0.ToNative(), p1);
        }
    }
}
