using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estaticos
{
    class Sello
    {
        public static string Mensaje; // atributo es una variable en la clase, se llama atributo a una variable dentro de la clase

        public static string Imprimir() 
        {
            return Mensaje;
        }

        public static void Borrar() 
        {
            Sello.Mensaje = "";
        }
    }
}
