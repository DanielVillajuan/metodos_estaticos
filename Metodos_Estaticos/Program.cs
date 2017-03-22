using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor;
            string dato;

            mayor=Comparadora.RetornarMayor(10 , 5);
            Console.WriteLine("el mayor es:" + mayor);
            Console.ReadLine();

            Sello.Mensaje = "Nuevo Mensaje";
            dato=Sello.Imprimir();
            Console.WriteLine(dato);

        }
    }
}
