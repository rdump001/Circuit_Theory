using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class CircuitsAndNetworksViewModel : ViewModelBase<CircuitsAndNetworksSchema>
    {
        private RelayCommandEx<CircuitsAndNetworksSchema> itemClickCommand;
        public RelayCommandEx<CircuitsAndNetworksSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<CircuitsAndNetworksSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("CircuitsAndNetworksDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<CircuitsAndNetworksSchema> CreateDataSource()
        {
            return new CircuitsAndNetworksDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("CircuitsAndNetworksList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("CircuitsAndNetworksDetail");
        }
    }
}
