using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class NETWORKSViewModel : ViewModelBase<NETWORKSSchema>
    {
        private RelayCommandEx<NETWORKSSchema> itemClickCommand;
        public RelayCommandEx<NETWORKSSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<NETWORKSSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("NETWORKSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<NETWORKSSchema> CreateDataSource()
        {
            return new NETWORKSDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("NETWORKSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("NETWORKSDetail");
        }
    }
}
