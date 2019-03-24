using Prism.Ioc;
using Prism.Unity;
using PrismExample.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace PrismExample
{
    public partial class App : PrismApplication
    {
        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(nameof(HomeView));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeView>();
        }
    }
}