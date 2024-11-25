using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Pokedex_EESA.Conexion
{
    class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedex-eesa-default-rtdb.firebaseio.com/");
    }
}
