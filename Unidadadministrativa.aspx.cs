using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class Unidadadministrativa : System.Web.UI.Page
    {
        Modelo.Unidadadministrativa unidadadmin = new Modelo.Unidadadministrativa();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            unidadadmin.idunidadadministrativa = Txtiduni.Text;
            unidadadmin.nombreunidadadministrativa = Txtnomuni.Text;
            unidadadmin.telefonounidadadministrativa = Txtteluni.Text;
            unidadadmin.emailunidadadministrativa = Txtemailuni.Text;
            unidadadmin.domiciliounidadadministrativa = Txtdomiunni.Text;
            unidadadmin.idunidadpertenencia = ddlunipert.Text;
            unidadadmin.idnivel = ddlniveluadm.Text;
            int r= unidadadmin.Guardar();

            if (r == 1)
                ClientScript.RegisterStartupScript(GetType(), "mostrar", "GuardarDatos();", true);
            else if (r == 0)
                ClientScript.RegisterStartupScript(GetType(), "mostrar", "ErAgregar();", true);
            else
                ClientScript.RegisterStartupScript(GetType(), "mostrar", "ErAgregar();", true);

        }
    }
}