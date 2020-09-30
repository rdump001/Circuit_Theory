using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class CIRCUITSViewModel : ViewModelBase<CIRCUITSSchema>
    {
        private RelayCommandEx<CIRCUITSSchema> itemClickCommand;
        public RelayCommandEx<CIRCUITSSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<CIRCUITSSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("CIRCUITSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<CIRCUITSSchema> CreateDataSource()
        {
            return new CIRCUITSDataSource(); // CollectionDataSource
        }


        override public Visibility TextToSpeechVisibility
        {
            get { return ViewType == ViewTypes.Detail ? Visibility.Visible : Visibility.Collapsed; }
        }

        override protected async void TextToSpeech()
        {
            await base.SpeakText("Description");
        }

        override public void NavigateToSectionList()
        {
            NavigationServices.NavigateToPage("CIRCUITSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("CIRCUITSDetail");
        }
    }
}
