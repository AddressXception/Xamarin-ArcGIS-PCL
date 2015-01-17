namespace Esri.ArcGISRuntime.Geometry
{
    public static class EnvelopeExtensions
    {
        public static Com.Esri.Core.Geometry.Envelope ToNative(this Envelope self)
        {
            return new Com.Esri.Core.Geometry.Envelope(self.XMin, self.YMin, self.XMax, self.YMax);
        }

        public static Envelope FromNative(this Com.Esri.Core.Geometry.Envelope self)
        {
            return new Envelope(self.XMin, self.YMin, self.XMax, self.YMax);
        }
    }
}