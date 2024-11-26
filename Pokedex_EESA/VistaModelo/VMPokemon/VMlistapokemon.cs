using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex_EESA.Vista.Pokemon;
using Pokedex_EESA.Datos;
using Pokedex_EESA.Modelo;
using System.Collections.ObjectModel;
using System.Linq;
using Firebase.Database;
using Pokedex_EESA.Conexion;
using Pokedex_EESA.Vista;

namespace Pokedex_EESA.VistaModelo.VMPokemon
{
    public class VMlistapokemon:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion
        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region OBJETOS

        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnPropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }



        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        public async Task Iradetalle(Mpokemon parametros)
        {
            await Navigation.PushAsync(new Detallepokemon(parametros));
        }

        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Iradetallecommand => new Command<Mpokemon>(async (p) => await Iradetalle(p));

        #endregion

    }
}
