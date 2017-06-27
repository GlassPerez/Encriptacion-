using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace ctrlArchivos.Modelo
{
    public class Validacion
    {
        
        public void validateletter(TextBox valor)
        {

            String verifi = valor.Text;
            if (valor.Text != "")
            {
                char caracter = Convert.ToChar(verifi.Substring((verifi.Length - 1), 1));
                System.Windows.Forms.MessageBox.Show("ultima letra del textbox     " + caracter);
                try
                {
                    if (char.IsLetter(caracter))
                    {
                        System.Windows.Forms.MessageBox.Show("Es una letra ");
                    }
                    if (char.IsSeparator(caracter))
                    {
                        System.Windows.Forms.MessageBox.Show("Es una espacio ");
                    }
                    if (char.IsControl(caracter))
                    {
                        System.Windows.Forms.MessageBox.Show("Estas borrando ");
                    }
                }
                catch (Exception ex)
                { }
            }

        }
    }
}