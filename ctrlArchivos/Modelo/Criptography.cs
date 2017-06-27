using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ctrlArchivos.Modelo
{
    public class Criptography
    {

        public String encripta(String varcripto)
        {
            String resultado = "";
            byte[] inputbytes = System.Text.Encoding.Unicode.GetBytes(varcripto);
            resultado = Convert.ToBase64String(inputbytes);

            

            return resultado;
        }


        public String dencripta(String varcripto)
        {
            String resultado = "";
            byte[] decriptor = Convert.FromBase64String(varcripto);
            resultado = System.Text.Encoding.Unicode.GetString(decriptor);
            return resultado;            
        }


    }
}