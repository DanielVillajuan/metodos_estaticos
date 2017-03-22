using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.Write("Hola mundo");
            //Console.ReadLine();
            int numero;
            int max;
            int min;
            bool lol;
            string dato;

            //numero = 0;
            //numero = numero + 1;
            //numero = int.Parse("22");
            //numero = int.Parse("lalala"); //solo parsea string que sean numeros. ERROR!
            //Console.WriteLine(numero);//muestra el valor de la variable numero
            //Console.WriteLine("el numero de la loto de hoy es:" + numero);//para concatenar se usa el signo +

            for (int cont = 0; cont < 5; cont++)
            {

                Console.WriteLine("Ingrese numero:");
                dato = Console.ReadLine();
                //numero = int.Parse(dato);
                lol=int.TryParse(dato,out numero);

                while(lol==false)
                {
                    Console.WriteLine("error ,Ingrese numero:");
                    dato = Console.ReadLine();
                    lol = int.TryParse(dato, out numero);
                }


                if (cont == 0)
                {
                    min = numero;
                    max = numero;
                }

                if (numero < min )
                {
                    min = numero;
                    
                }
                if (numero > max ) 
                {

                    max = numero;
                    
                }

            }

            Console.WriteLine("el numero mas alto es:" + max);
            Console.WriteLine("el numero mas bajo es:" + min);
            Console.ReadLine();
        }
    }
}
