using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex_EESA.VistaModelo.VMPokemon;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_EESA.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPokemon : ContentPage
    {
        public RegistrarPokemon()
        {
            InitializeComponent();
            BindingContext = new VMregistropokemon(Navigation);
        }
    }
}