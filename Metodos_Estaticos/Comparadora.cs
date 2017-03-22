using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estaticos
{
    class Comparadora
    {

        public static int RetornarMayor(int num1, int num2)
        {
            int retorno=0;

            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;

            return retorno;
        }



    }
}
