using System;
using System.Runtime.CompilerServices;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismUnityExample.Data;
using PrismUnityExample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismUnityExample
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

            containerRegistry.RegisterSingleton<IHomeRepository, TestHomeRepository>();
        }

        public App() : base(null)
        {
        }
    }
}