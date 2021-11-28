using Kaspersky.Core;

namespace Kaspersky.MVVM.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand SecurityViewCommand { get; set; }
        public RelayCommand MyNetworkViewCommand { get; set; }
        public RelayCommand ManagementViewCommand { get; set; }
        public RelayCommand CleaningOptimizationViewCommand { get; set; }

        public SecurityViewModel SecurityVM { get; set; }
        public MyNetworkViewModel MyNetworkVM { get; set; }
        public ManagementViewModel ManagementVM { get; set; }
        public CleaningOptimizationViewModel CleaningOptimizationVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            SecurityVM = new SecurityViewModel();
            MyNetworkVM = new MyNetworkViewModel();
            ManagementVM = new ManagementViewModel();
            CleaningOptimizationVM = new CleaningOptimizationViewModel();

            CurrentView = SecurityVM;

            SecurityViewCommand = new RelayCommand(o =>
            {
                CurrentView = SecurityVM;
            });

            MyNetworkViewCommand = new RelayCommand(o =>
            {
                CurrentView = MyNetworkVM;
            });

            ManagementViewCommand = new RelayCommand(o =>
            {
                CurrentView = ManagementVM;
            });

            CleaningOptimizationViewCommand = new RelayCommand(o =>
            {
                CurrentView = CleaningOptimizationVM;
            });
        }
    }
}
