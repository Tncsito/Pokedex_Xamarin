using Pokedex_EESA.Vista.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_EESA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Detallepokemon();
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
