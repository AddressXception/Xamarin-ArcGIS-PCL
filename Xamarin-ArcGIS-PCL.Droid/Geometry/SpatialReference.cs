using System;

namespace Esri.ArcGISRuntime.Geometry
{
    public static class SpatialReferenceExtensions
    {
        public static SpatialReference FromNative(
            this Com.Esri.Core.Geometry.SpatialReference self)
        {
            return new SpatialReference(self);
        }
    }

    public class SpatialReference
    {


        public Com.Esri.Core.Geometry.SpatialReference Native { get; private set; }

        public SpatialReference(Com.Esri.Core.Geometry.SpatialReference native)
        {
            Native = native;
        }

        public SpatialReference BaseGeographic
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsGeographic
        {
            get
            {   
                throw new NotImplementedException();
            }
        }

        public bool IsPannable
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsProjected
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }

        public Unit Unit
        {
            get
            {
                throw new NotImplementedException();
                //return Native.Unit.FromNative();
            }
        }

        public bool AreEqual(SpatialReference sref1, SpatialReference sref2, bool ignoreNulls = false)
        {
            throw new NotImplementedException();
        }

        public SpatialReference Clone()
        {
            throw new NotImplementedException();
        }

        public SpatialReference Create(int wkid)
        {
            throw new NotImplementedException();
        }

        public SpatialReference Create(string wkt)
        {
            throw new NotImplementedException();
        }

        public SpatialReference Create(int wkid, int verticalWkid)
        {
            throw new NotImplementedException();
        }

        public SpatialReference FromJson(string json)
        {
            throw new NotImplementedException();
        }

        public string ToJson()
        {
            throw new NotImplementedException();
        }
    }
}