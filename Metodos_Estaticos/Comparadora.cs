using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estaticos
{
    class Comparadora
    {
        /// <summary>
        /// Este metodo funciona para retornar el mayor de los parametros
        /// </summary>
        /// <param name="num1">Primero numero,entero</param>
        /// <param name="num2">Segundo numero,entero</param>
        /// <returns>Retorna el numero mayor</returns>
        public static int RetornarMayor(int num1, int num2)
        {
            int retorno=0;

            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;

            return retorno;
        }

        /// <summary>
        /// Esto retorna el valor del medio
        /// </summary>
        /// <param name="num1">Primer numero</param>
        /// <param name="num2">Segundo numero</param>
        /// <param name="num3">Tercer numero</param>
        /// <returns>Retorna el del medio</returns>
        public static void MostrarElDelMedio(int num1 ,int num2 , int num3)
        {
            Console.WriteLine(num2);   
        }


    }
}
