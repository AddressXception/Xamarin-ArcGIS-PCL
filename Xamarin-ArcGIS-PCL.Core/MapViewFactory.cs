using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_ArcGIS_PCL.Core
{
    public abstract class MapViewFactory : IMapViewFactory
    {
        public abstract object GetOpenStreetMapLayer();

    }
}
