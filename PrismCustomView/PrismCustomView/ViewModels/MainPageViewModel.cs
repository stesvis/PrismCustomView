using Prism.Navigation;

namespace PrismCustomView.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _myLabelProperty;
        public string MyLabelProperty
        {
            get { return _myLabelProperty; }
            set { SetProperty(ref _myLabelProperty, value); }
        }

        private string _myTextProperty;
        public string MyTextProperty
        {
            get { return _myTextProperty; }
            set { SetProperty(ref _myTextProperty, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            MyLabelProperty = "Label 1";
            MyTextProperty = "Hello world 1";
        }
    }
}