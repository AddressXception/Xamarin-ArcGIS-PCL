using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Geometry;

namespace Xamarin_ArcGIS_PCL.Core.ESRI.ArcGISRuntime.Geometry
{
    public class Polygon : Esri.ArcGISRuntime.Geometry.Geometry
    {
        public override Envelope Extent
        {
            get { throw new NotImplementedException(); }
        }

        public override GeometryType GeometryType
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasM
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasZ
        {
            get { throw new NotImplementedException(); }
        }

        public override bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }
    }
}
