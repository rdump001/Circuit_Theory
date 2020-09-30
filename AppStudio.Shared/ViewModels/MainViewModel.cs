using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MainViewModel : BindableBase
    {
       private ELECTRONICSViewModel _eLECTRONICSModel;
       private CircuitsAndNetworksViewModel _circuitsAndNetworksModel;
       private CIRCUITSViewModel _cIRCUITSModel;
       private NETWORKSViewModel _nETWORKSModel;
       private EXTRAINFOViewModel _eXTRAINFOModel;
       private AUDIOVISUALSViewModel _aUDIOVISUALSModel;
        private PrivacyViewModel _privacyModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModel()
        {
            _selectedItem = ELECTRONICSModel;
            _privacyModel = new PrivacyViewModel();

        }
 
        public ELECTRONICSViewModel ELECTRONICSModel
        {
            get { return _eLECTRONICSModel ?? (_eLECTRONICSModel = new ELECTRONICSViewModel()); }
        }
 
        public CircuitsAndNetworksViewModel CircuitsAndNetworksModel
        {
            get { return _circuitsAndNetworksModel ?? (_circuitsAndNetworksModel = new CircuitsAndNetworksViewModel()); }
        }
 
        public CIRCUITSViewModel CIRCUITSModel
        {
            get { return _cIRCUITSModel ?? (_cIRCUITSModel = new CIRCUITSViewModel()); }
        }
 
        public NETWORKSViewModel NETWORKSModel
        {
            get { return _nETWORKSModel ?? (_nETWORKSModel = new NETWORKSViewModel()); }
        }
 
        public EXTRAINFOViewModel EXTRAINFOModel
        {
            get { return _eXTRAINFOModel ?? (_eXTRAINFOModel = new EXTRAINFOViewModel()); }
        }
 
        public AUDIOVISUALSViewModel AUDIOVISUALSModel
        {
            get { return _aUDIOVISUALSModel ?? (_aUDIOVISUALSModel = new AUDIOVISUALSViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            ELECTRONICSModel.ViewType = viewType;
            CircuitsAndNetworksModel.ViewType = viewType;
            CIRCUITSModel.ViewType = viewType;
            NETWORKSModel.ViewType = viewType;
            EXTRAINFOModel.ViewType = viewType;
            AUDIOVISUALSModel.ViewType = viewType;
        }

        public ViewModelBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                UpdateAppBar();
            }
        }

        public Visibility AppBarVisibility
        {
            get
            {
                return SelectedItem == null ? AboutVisibility : SelectedItem.AppBarVisibility;
            }
        }

        public Visibility AboutVisibility
        {

         get { return Visibility.Visible; }
        }

        public void UpdateAppBar()
        {
            OnPropertyChanged("AppBarVisibility");
            OnPropertyChanged("AboutVisibility");
        }

        /// <summary>
        /// Load ViewModel items asynchronous
        /// </summary>
        public async Task LoadDataAsync(bool forceRefresh = false)
        {
            var loadTasks = new Task[]
            { 
                ELECTRONICSModel.LoadItemsAsync(forceRefresh),
                CircuitsAndNetworksModel.LoadItemsAsync(forceRefresh),
                CIRCUITSModel.LoadItemsAsync(forceRefresh),
                NETWORKSModel.LoadItemsAsync(forceRefresh),
                EXTRAINFOModel.LoadItemsAsync(forceRefresh),
                AUDIOVISUALSModel.LoadItemsAsync(forceRefresh),
            };
            await Task.WhenAll(loadTasks);
        }

        //
        //  ViewModel command implementation
        //
        public ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await LoadDataAsync(true);
                });
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateToPage("AboutThisAppPage");
                });
            }
        }

        public ICommand PrivacyCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateTo(_privacyModel.Url);
                });
            }
        }
    }
}
