
namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Core
{
    using Cirrious.CrossCore.IoC;
    using Cirrious.CrossCore;
    using Xamarin_ArcGIS_PCL.Core;

    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.LazyConstructAndRegisterSingleton<IMapViewFactory, MapViewFactory>();

            RegisterAppStart<ViewModels.MapViewModel>();
        }
    }
}