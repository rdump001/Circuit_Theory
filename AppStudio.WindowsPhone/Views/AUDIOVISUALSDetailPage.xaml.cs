using System;
using System.Net.NetworkInformation;
using System.ComponentModel;

using Windows.ApplicationModel.DataTransfer;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using AppStudio.Services;
using AppStudio.ViewModels;

namespace AppStudio.Views
{
    public sealed partial class AUDIOVISUALSDetail : Page, INotifyPropertyChanged
    {
        private NavigationHelper _navigationHelper;

        public AUDIOVISUALSDetail()
        {
            this.InitializeComponent();
            _navigationHelper = new NavigationHelper(this);

            ytViewer.NavigationHelper = _navigationHelper;

            AUDIOVISUALSModel = new AUDIOVISUALSViewModel();

            DataContext = this;

            ApplicationView.GetForCurrentView().
                SetDesiredBoundsMode(ApplicationViewBoundsMode.UseVisible);
        }

        public AUDIOVISUALSViewModel AUDIOVISUALSModel { get; private set; }

        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);

            await AUDIOVISUALSModel.LoadItemsAsync();
            AUDIOVISUALSModel.SelectItem(e.Parameter);

            if (AUDIOVISUALSModel != null)
            {
                AUDIOVISUALSModel.ViewType = ViewTypes.Detail;
            }

            ytViewer.OnNavigatedTo();

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
            
            ytViewer.EmbedUrl = null;

            ytViewer.OnNavigatedFrom();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
