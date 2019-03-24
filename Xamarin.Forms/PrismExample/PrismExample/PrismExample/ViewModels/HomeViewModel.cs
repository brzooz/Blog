using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace PrismExample.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                RaisePropertyChanged();
            }
        }

        public ICommand IncrementCountCommand => new DelegateCommand(IncrementCount);

        private void IncrementCount()
        {
            Count++;
        }
    }
}