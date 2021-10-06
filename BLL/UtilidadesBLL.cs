using System;
using System.Collections.Generic;
using System.Text;

namespace P1_AP1_Kelvin_20180193.BLL
{
    public class UtilidadesBLL
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}
