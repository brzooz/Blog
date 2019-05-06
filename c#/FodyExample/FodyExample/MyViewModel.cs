using System;
using System.ComponentModel;

namespace FodyExample
{
    public class MyViewModel : INotifyPropertyChanged
    {
        public MyViewModel()
        {
            PropertyChanged += MyViewModel_PropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int Count { get; set; }
        public string Text { get; set; }

        private void MyViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"Property changed - {e.PropertyName}");
        }
    }
}