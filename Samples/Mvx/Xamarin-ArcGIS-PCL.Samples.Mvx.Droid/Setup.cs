using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Xamarin_ArcGIS_PCL.Core;

namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Droid
{
    extern alias droid;

    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            Cirrious.CrossCore.Mvx.RegisterSingleton<IMapViewFactory>(new droid::Xamarin_ArcGIS_PCL.Droid.NativeMapViewFactory());
        }

    }
}