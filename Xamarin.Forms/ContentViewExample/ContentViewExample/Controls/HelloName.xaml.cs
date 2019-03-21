using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContentViewExample.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloName : ContentView
    {
        public static readonly BindableProperty NameProperty =
     BindableProperty.Create(nameof(Name), typeof(string), typeof(HelloName));

        public HelloName()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
    }
}