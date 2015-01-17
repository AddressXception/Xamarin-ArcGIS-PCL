using Cirrious.MvvmCross.ViewModels;

namespace Xamarin_ArcGIS_PCL.Samples.Mvx.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
