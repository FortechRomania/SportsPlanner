using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SportsPlanner.Gateways;

namespace SportsPlanner.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IEventsGateway _eventsGateway;

        private string _pageTitle;

        public string PageTitle
        {
            get
            {
                return _pageTitle;
            }
            set
            {
                Set(ref _pageTitle, value);
            }
        }

        private RelayCommand _getEventsCommand;
        private IDialogService _dialogService;

        public RelayCommand GetEventsCommand
        {
            get
            {
                return _getEventsCommand
                    ?? (_getEventsCommand = new RelayCommand(() => GetEventsFromAPI()));
            }
        }

        public MainViewModel(IEventsGateway eventsGateway, IDialogService dialogService)
        {
            _eventsGateway = eventsGateway;
            _dialogService = dialogService;
        }

        private async void GetEventsFromAPI()
        {         
            var searchEventsResult = await _eventsGateway.GetEventsAsync();
            await _dialogService.ShowMessage($"Did receive the {searchEventsResult.Details.Total} events", "Alert Title");
        }
    }
}