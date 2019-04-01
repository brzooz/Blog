using System;
using Prism.Mvvm;
using Prism.Navigation;
using PrismUnityExample.Data;

namespace PrismUnityExample.ViewModels
{
    public class HomeViewModel : BindableBase, INavigationAware
    {
        private readonly IHomeRepository _homeRepository;

        private string _title;

        public string Title
        {
            get { return _title; }
            set 
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        public HomeViewModel(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Title = _homeRepository.GetTitle();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}

