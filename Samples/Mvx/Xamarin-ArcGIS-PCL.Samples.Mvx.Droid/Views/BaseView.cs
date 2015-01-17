using Cirrious.MvvmCross.Droid.Views;
using Xamarin_ArcGIS_PCL.Samples.Mvx.Core.ViewModels;

namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Droid.Views
{
    public abstract class BaseView
          : MvxActivity
    {
        public string Tag = string.Empty;
        private BaseViewModel _viewModel;

        public BaseViewModel TheViewModel
        {
            get { return _viewModel ?? (_viewModel = base.ViewModel as BaseViewModel); }
        }

    }
}