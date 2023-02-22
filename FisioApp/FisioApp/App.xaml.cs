using FisioApp.Services;
using FisioApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FisioApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //MainPage = new AppShell();

            var pagina = new NavigationPage(
                new XamarinForms.Paginas.Modal.Conteudo01()                
            );
            MainPage = pagina;

            //MainPage = new XamarinForms.Paginas.Modal.Conteudo01();            
            
            /*
            var pagina = new NavigationPage(
                new XamarinForms.Paginas.PaginaDeMenuLateral.FlyoutPage1()
            );
            MainPage = pagina;
            */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
