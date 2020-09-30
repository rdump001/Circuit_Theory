using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class AUDIOVISUALSViewModel : ViewModelBase<YouTubeSchema>
    {
        private RelayCommandEx<YouTubeSchema> itemClickCommand;
        public RelayCommandEx<YouTubeSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<YouTubeSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("AUDIOVISUALSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<YouTubeSchema> CreateDataSource()
        {
            return new AUDIOVISUALSDataSource(); // YouTubeDataSource
        }


        override public Visibility TextToSpeechVisibility
        {
            get { return ViewType == ViewTypes.Detail ? Visibility.Visible : Visibility.Collapsed; }
        }

        override protected async void TextToSpeech()
        {
            await base.SpeakText("Summary");
        }

        override public Visibility GoToSourceVisibility
        {
            get { return ViewType == ViewTypes.Detail ? Visibility.Visible : Visibility.Collapsed; }
        }

        override protected void GoToSource()
        {
            base.GoToSource("{ExternalUrl}");
        }

        override public Visibility RefreshVisibility
        {
            get { return ViewType == ViewTypes.List ? Visibility.Visible : Visibility.Collapsed; }
        }

        override public void NavigateToSectionList()
        {
            NavigationServices.NavigateToPage("AUDIOVISUALSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("AUDIOVISUALSDetail");
        }
    }
}
