using System;
using System.Collections.Generic;
using System.Text;
using Pokedex_EESA.Modelo;
using Pokedex_EESA.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using Firebase.Database;

namespace Pokedex_EESA.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(new Mpokemon()
            {
                 ColorFondo = parametros.ColorFondo,
                 Colorpoder = parametros.Colorpoder,
                 Icono = parametros.Icono,
                 Nombre = parametros.Nombre,
                 Nroorden = parametros.Nroorden,
                 Poder = parametros.Poder,
            });
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            //var data = (await Cconexion.firebase.Child("Pokemon").OnceAsync<Mpokemon>()).Where(a=>a.Key!="Modelo").Select(item => new Mpokemon
            //{
            //    Idpokemon = item.Key,
            //    Nombre = item.Object.Nombre,
            //    ColorFondo = item.Object.ColorFondo,
            //    Colorpoder = item.Object.Colorpoder,
            //    Nroorden = item.Object.Nroorden,
            //    Poder = item.Object.Poder,
            //    Icono = item.Object.Icono
            //});
            var data = await Task.Run(()=> Cconexion.firebase.Child("Pokemon").AsObservable<Mpokemon>().AsObservableCollection());
            return data;
        }
    }
}
